namespace Bundledocs
{
    using Bundledocs.Api;
    using Bundledocs.Model;
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public class BundledocsApi
    {
        public BundledocsApiUsers Users;
        public BundledocsApiBundles Bundles;
        public BundledocsApiSections Sections;
        public BundledocsApiDocuments Documents;
        public BundledocsApiEvents Events;
        public BundledocsApiReceipts Receipts;

        private BundledocsApi(string accessToken)
        {
            Users = BundledocsApiUsers.New(accessToken);
            Bundles = BundledocsApiBundles.New(accessToken);
            Sections = BundledocsApiSections.New(accessToken);
            Documents = BundledocsApiDocuments.New(accessToken);
            Events = BundledocsApiEvents.New(accessToken);
            Receipts = BundledocsApiReceipts.New(accessToken);
        }

        public static BundledocsApi New(string authorization) => new BundledocsApi(authorization);
    }

    public abstract class BundledocsApiBase
    {
        protected string _authorizationHeader;
        protected BundledocsApiBase(string accessToken)
        {
            _authorizationHeader = $"Bearer {accessToken}";
        }
    }

    public class BundledocsApiReceipts : BundledocsApiBase
    {
        private ReceiptsApi _receipts = new ReceiptsApi();
        private BundledocsApiReceipts(string accessToken) : base(accessToken) { }
        public static BundledocsApiReceipts New(string accessToken) => new BundledocsApiReceipts(accessToken);

        public Stream Download(string PartitionKey, string Rowkey)
        {
            return _receipts.ReceiptsDownloadBundleReceipt(_authorizationHeader, PartitionKey, Rowkey);
        }
    }

    public class BundledocsApiUsers : BundledocsApiBase
    {
        private UsersApi _users = new UsersApi();
        private BundledocsApiUsers(string accessToken) : base(accessToken) { }
        public static BundledocsApiUsers New(string accessToken) => new BundledocsApiUsers(accessToken);

        public UserBean Me() => _users.UsersLoadUser(_authorizationHeader)?.Data.FirstOrDefault();
    }

    public class BundledocsApiBundles : BundledocsApiBase
    {
        private BundlesApi _bundles = new BundlesApi();
        private BundledocsApiBundles(string accessToken) : base(accessToken) { }
        public static BundledocsApiBundles New(string accessToken) => new BundledocsApiBundles(accessToken);

        public BriefBean Get(string PartitionKey, string Rowkey)
        {
            return _bundles.BundlesLoadBundle(_authorizationHeader, PartitionKey, Rowkey)?.Data.FirstOrDefault();
        }

        public BriefBean Create(string code, string title, bool isVisibleToGroups = true)
        {
            return Create(new BriefBean() { AccessType = 0, IsVisibleToGroups = isVisibleToGroups, Code = code, Title = title });
        }

        public BriefBean Create(BriefBean createBriefBean)
        {
            return _bundles.BundlesCreateBundle(_authorizationHeader, createBriefBean)?.Data.FirstOrDefault();
        }

        public BriefBean Delete(string partitionKey, string rowKey)
        {
            return _bundles.BundlesDeleteBundle(_authorizationHeader, partitionKey, rowKey)?.Data.FirstOrDefault();
        }

        public OAuthApiMessage Generate(string partitionKey, string rowKey, Brief generateBriefBean)
        {
            return _bundles.BundlesGenerateBundle(_authorizationHeader, partitionKey, rowKey, BriefBean.FromBrief(generateBriefBean))?.Messages.FirstOrDefault();
        }

        public OAuthApiMessage Generate(string partitionKey, string rowKey, BriefBean generateBriefBean)
        {
            return _bundles.BundlesGenerateBundle(_authorizationHeader, partitionKey, rowKey, generateBriefBean)?.Messages.FirstOrDefault();
        }

        public Stream Download(string partitionKey, string rowKey)
        {
            Stream downloadedBundle = _bundles.BundlesDownloadBundle(_authorizationHeader, partitionKey, rowKey);
            return downloadedBundle;            
        }

        public List<BriefReceipt> Receipts(string partitionKey, string rowKey)
        {
            return _bundles.BundlesGetAllBriefReceipts(_authorizationHeader, partitionKey, rowKey).Data.FirstOrDefault();
        }

        public IList<BriefDocument> Tree(string partitionKey, string rowKey)
        {
            return _bundles.BundlesGetBriefDocumentIndexDataTree(_authorizationHeader, partitionKey, rowKey)?.Data.FirstOrDefault();
        }
    }

    public class BundledocsApiSections : BundledocsApiBase
    {
        private SectionsApi _sections = new SectionsApi();
        private BundledocsApiSections(string accessToken) : base(accessToken) { }
        public static BundledocsApiSections New(string accessToken) => new BundledocsApiSections(accessToken);

        public BriefDocument Create(string briefPartitionKey, string briefRowKey, string description, string borderColor = "#ffffff")
        {
            return _sections.SectionsCreate(_authorizationHeader, new BriefDocument { Description = description, BorderColor = borderColor, PartitionKey = briefPartitionKey, ForeignKey = briefRowKey, DisplayOrder = "", ParentRowKey = "" })?.Data.FirstOrDefault();
        }

        public BriefDocument Delete(string partitionKey, string rowKey)
        {
            return _sections.SectionsDelete(_authorizationHeader, partitionKey, rowKey)?.Data.FirstOrDefault();
        }

        public BriefDocument Rename(string sectionPartitionKey, string sectionRowKey, string newName)
        {
            return _sections.SectionsUpdate(_authorizationHeader, sectionPartitionKey, sectionRowKey, new BriefDocumentBean(Description: newName))?.Data.FirstOrDefault();
        }
    }

    public class BundledocsApiDocuments : BundledocsApiBase
    {
        DocumentsApi _documents = new DocumentsApi();
        private BundledocsApiDocuments(string accessToken) : base(accessToken) { }
        public static BundledocsApiDocuments New(string accessToken) => new BundledocsApiDocuments(accessToken);

        public bool Create(BriefDocument briefDocument, string fileLocation, string fileName = "", bool isTitlePage = false)
        {
            return Create(briefDocument, File.OpenRead(fileLocation), String.IsNullOrEmpty(fileName?.Trim()) ? Path.GetFileName(fileLocation) : fileName?.Trim(), isTitlePage);
        }

        public bool Create(BriefDocument parentSection, Stream fileStream, string fileName, bool isTitlePage = false)
        {
            bool isSuccess = false;
            try
            {
                //prepare the upload parameters
                UploadFile uploadFile = new UploadFile();
                uploadFile.FileName = fileName;
                uploadFile.Stream = fileStream;
                uploadFile.ContentType = "application/octet-stream";

                //prepare the upload parameters
                NameValueCollection uploadFileParameters = new NameValueCollection();
                uploadFileParameters.Add("PartitionKey", parentSection.PartitionKey);
                uploadFileParameters.Add("ForeignKey", parentSection.ForeignKey);
                uploadFileParameters.Add("ParentRowKey", parentSection.RowKey);
                uploadFileParameters.Add("FileUploadKey", Guid.NewGuid().ToString());
                uploadFileParameters.Add("FileUploadDate", DateTime.Now.ToLongDateString());

                //upload the document
                if (isTitlePage)
                {
                    isSuccess = _documents.UploadTitlePageDocument(_authorizationHeader, uploadFileParameters, uploadFile);
                }
                else
                {
                    isSuccess = _documents.UploadDocument(_authorizationHeader, uploadFileParameters, uploadFile);
                }
            }
            catch
            {
                throw;
            }

            return isSuccess;
        }

        public BriefDocument Delete(string partitionKey, string rowKey)
        {
            return _documents.DocumentsDelete(_authorizationHeader, partitionKey, rowKey)?.Data.FirstOrDefault();
        }

        public BriefDocument Rename(string partitionKey, string rowKey, string newName)
        {
            return _documents.DocumentsUpdate(_authorizationHeader, partitionKey, rowKey, new BriefDocumentBean(Description: newName))?.Data.FirstOrDefault();
        }

        public Stream Download(string partitionKey, string rowKey)
        {
            return _documents.DocumentsDownload(_authorizationHeader, partitionKey, rowKey);
        }
    }

    public class BundledocsApiEvents : BundledocsApiBase
    {
        private EventsApi _events = new EventsApi();
        private BundledocsApiEvents(string accessToken) : base(accessToken) { }
        public static BundledocsApiEvents New(string accessToken) => new BundledocsApiEvents(accessToken);

        public bool WaitForUploadToComplete(string context, int uploadedFilesCount = 1)
        {
            bool uploadStatus = false;
            int converted = 0;
            int timeout = 10;
            int timeoutWait = 3000;
            do
            {
                List<OAuth2ApiEvent> responseEvents = Get(context);

                if (responseEvents == null)
                {
                    if (--timeout <= 0) { uploadStatus = false; break; } else { Thread.Sleep(timeoutWait); continue; }
                }
                timeout = 10;

                foreach (OAuth2ApiEvent response in responseEvents)
                {
                    string actionName = response.Name;

                    if (actionName == "UAC_BriefDocumentUpload_Progress_End" || actionName == "UAC_BriefDocumentProcessing_End")
                    {
                        converted++;
                        uploadStatus = true;
                    }

                    if (actionName == "UAC_BriefDocumentUpload_Progress_Fail")
                    {
                        converted += 2;
                        uploadStatus = false;
                    }

                    if (actionName == "UAC_BriefDocumentUpload_Decrement_FileCount")
                    {
                        converted += 2;
                    }

                    if (actionName == "UAC_BriefDocumentProcessing_Fail")
                    {
                        converted += 1;
                        uploadStatus = false;
                    }

                    if (converted >= uploadedFilesCount * 2)
                    {
                        break;
                    }
                }

                if (OAuth2ApiEventUpload != null)
                {
                    responseEvents.ForEach(k => OAuth2ApiEventUpload(k));
                }

            } while (converted < uploadedFilesCount * 2);

            return uploadStatus;
        }

        public bool WaitForGenerateToComplete(string context)
        {
            bool generateStatus = false;
            bool stopListening = false;
            int timeout = 10;
            int timeoutWait = 3000;
            do
            {
                List<OAuth2ApiEvent> responseEvents = Get(context);

                if (responseEvents?.Count <= 0)
                {
                    if (--timeout <= 0) { generateStatus = false; break; } else { Thread.Sleep(timeoutWait); continue; }
                }
                timeout = 10;

                foreach (OAuth2ApiEvent response in responseEvents)
                {
                    string actionName = response.Name;
                    
                    if(actionName== "UAC_BriefProcessing_Progress")
                    {                        
                        if(response.Data.ToString().Contains("STAGE SIX OF SIX COMPLETE"))
                        {
                            generateStatus = true;
                        }
                    }

                    if (actionName == "UAC_BriefProcessing_End")
                    {
                        stopListening = true;
                        break;
                    }
                }

                if (OAuth2ApiEventGenerate != null)
                {
                    responseEvents.ForEach(k => OAuth2ApiEventGenerate(k));
                }

            } while (!stopListening);

            return generateStatus;
        }

        public List<OAuth2ApiEvent> Get(string context)
        {
            return _events.EventsGet(_authorizationHeader, context).Data ?? new List<OAuth2ApiEvent>();
        }
                
        public event OAuth2ApiEventHandler OAuth2ApiEventGenerate;
        public event OAuth2ApiEventHandler OAuth2ApiEventUpload;

        public delegate void OAuth2ApiEventHandler(OAuth2ApiEvent OAuth2ApiEvent);
    }
}
