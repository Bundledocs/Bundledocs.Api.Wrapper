namespace Bundledocs.Test.BundledocsAssembly_Facts
{
    using Bundledocs;
    using Bundledocs.Extensions;
    using Bundledocs.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    public class BundledocsApi_Tests
    {
        protected BundledocsApi _bundledocsApi = BundledocsApi.New(App.Default.authorization);

        [TestClass]
        public class UsersApi_Tests : BundledocsApi_Tests
        {
            [TestMethod]
            public void Me_Test()
            {
                //Arrange                                            
                //Act                
                UserBean user = _bundledocsApi.Users.Me();

                //Assert
                Assert.IsNotNull(user);
            }
        }

        [TestClass]
        public class Bundles_Tests : BundledocsApi_Tests
        {
            [TestMethod]
            public void Create_Test()
            {
                //Arrange
                string expectedCode = Guid.NewGuid().ToString("n");
                string expectedTitle = Guid.NewGuid().ToString("n");

                //Act                
                BriefBean briefBean = _bundledocsApi.Bundles.Create(expectedCode, expectedTitle);

                //Assert                
                Assert.AreEqual(expectedCode, briefBean.Code);
                Assert.IsNotNull(expectedTitle, briefBean.Title);
            }

            [TestMethod]
            public void Delete_Test()
            {
                //Arrange                   
                BriefBean briefBean = _bundledocsApi.Bundles.Create("TEMP CODE", "TEMP TITLE");

                //Act                
                BriefBean deletedBrief = _bundledocsApi.Bundles.Delete(briefBean.PartitionKey, briefBean.RowKey);

                //Assert
                Assert.AreEqual(briefBean.RowKey, deletedBrief.RowKey);
            }

            [TestMethod]
            public void Generate_Test()
            {
                //Arrange
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //find a brief to load
                Brief briefToLoad = user.Briefs.Where(k => k.PartitionKey == user.RowKey && !String.IsNullOrEmpty(k.PdfFilePath)).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(briefToLoad.PartitionKey, briefToLoad.RowKey);

                //Act
                //generate the bundle
                OAuthApiMessage generateMessage = _bundledocsApi.Bundles.Generate(loadedBrief.PartitionKey, loadedBrief.RowKey, loadedBrief);

                //listen to the events back from the server to verify the brief is processed and generated successfully
                bool generateComplete = _bundledocsApi.Events.WaitForGenerateToComplete(briefToLoad.RowKey);

                //Assert
                Assert.IsTrue(generateComplete);
            }

            [TestMethod]
            public void Download_Test()
            {
                //Arange
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //find a brief to load
                Brief briefToLoad = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(briefToLoad.PartitionKey, briefToLoad.RowKey);

                //Act
                //Download the bundle      
                Stream myStream = _bundledocsApi.Bundles.Download(loadedBrief.PartitionKey, loadedBrief.RowKey);

                //write the downloaded bundle to disk
                byte[] myFile = myStream.ReadToEnd();
                string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";
                File.WriteAllBytes(newFilePath, myFile);

                //Assert                
                Assert.IsTrue(File.Exists(newFilePath));

                //open the downloaded bundle
                Process.Start(newFilePath);
            }

            [TestMethod]
            public void Receipts_Test()
            {
                //Arange
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //find a brief to load
                Brief briefToLoad = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(briefToLoad.PartitionKey, briefToLoad.RowKey);

                //Act
                //load the brief receipts     
                List<BriefReceipt> briefReceipts = _bundledocsApi.Bundles.Receipts(loadedBrief.PartitionKey, loadedBrief.RowKey);

                //Assert                
                Assert.IsTrue(briefReceipts.Count >= 0);
            }
        }

        [TestClass]
        public class Sections_Tests : BundledocsApi_Tests
        {            
            [TestMethod]
            public void Create_Test()
            {
                //Arrange                                                   
                string expected = Guid.NewGuid().ToString("n");
                string actual = String.Empty;

                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //choose a brief
                Brief brief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(brief.PartitionKey, brief.RowKey);

                //Act                
                BriefDocument newSection = _bundledocsApi.Sections.Create(loadedBrief.PartitionKey, loadedBrief.RowKey, expected);

                actual = newSection.Description;

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Rename_Test()
            {
                //Arrange   
                string expected = Guid.NewGuid().ToString("n");
                string actual = String.Empty;

                //Arrange
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //choose a brief
                Brief brief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(brief.PartitionKey, brief.RowKey);

                //load the brief documents
                BriefDocument sectionToRename = _bundledocsApi.Bundles.Tree(loadedBrief.PartitionKey, loadedBrief.RowKey).Where(k => k.Type == "HEADER").FirstOrDefault();

                //Act
                //rename the section
                BriefDocument renamedSection = _bundledocsApi.Sections.Rename(sectionToRename.PartitionKey, sectionToRename.RowKey, expected);

                actual = renamedSection.Description;

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Delete_Test()
            {
                //Arrange                                                   
                string expected = Guid.NewGuid().ToString("n");
                string actual = String.Empty;

                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //choose a brief
                Brief brief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(brief.PartitionKey, brief.RowKey);

                //create a test section
                BriefDocument newSection = _bundledocsApi.Sections.Create(loadedBrief.PartitionKey, loadedBrief.RowKey, "new section");

                //Act                
                BriefDocument deletedSection = _bundledocsApi.Sections.Delete(newSection.PartitionKey, newSection.RowKey);

                //Assert
                Assert.AreEqual(newSection.RowKey, deletedSection.RowKey);
            }
        }

        [TestClass]
        public class Document_Tests : BundledocsApi_Tests
        {
            [TestMethod]
            public void Create_Test()
            {
                //Arrange 
                bool expected = true;
                bool actual = false;
                                
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //find a brief to load
                Brief briefToLoad = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(briefToLoad.PartitionKey, briefToLoad.RowKey);

                //load the brief documents
                IList<BriefDocument> briefDocuments = _bundledocsApi.Bundles.Tree(loadedBrief.PartitionKey, loadedBrief.RowKey);

                //find a section to upload a document into
                BriefDocument uploadLocation = briefDocuments.Where(k => k.Type == "HEADER").FirstOrDefault();
                
                //Act
                bool isSuccess = _bundledocsApi.Documents.Create(uploadLocation, App.Default.UploadFileLocation);

                //listen to the events back from the server to verify the document is uploaded and processed successfully
                actual = _bundledocsApi.Events.WaitForUploadToComplete(uploadLocation.ForeignKey);

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Download_Test()
            {
                //Arrange                                                 
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //find a brief to load
                Brief parentBrief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(parentBrief.PartitionKey, parentBrief.RowKey);
                
                //load the brief documents
                BriefDocument documentToDownload = _bundledocsApi.Bundles.Tree(loadedBrief.PartitionKey, loadedBrief.RowKey).Where(k => k.Type == "HEADER").FirstOrDefault().Children.Where(k => k.Type == "DOCUMENT").FirstOrDefault();

                //Act
                //download the document
                Stream myStream = _bundledocsApi.Documents.Download(documentToDownload.PartitionKey, documentToDownload.RowKey);

                //write the downloaded bundle to disk
                byte[] myFile = myStream.ReadToEnd();
                string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";
                File.WriteAllBytes(newFilePath, myFile);

                //Assert                
                Assert.IsTrue(File.Exists(newFilePath));

                //open the downloaded bundle
                Process.Start(newFilePath);
            }

            [TestMethod]
            public void Rename_Test()
            {
                //Arrange   
                string expected = Guid.NewGuid().ToString("n");                

                //Arrange
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //choose a brief
                Brief brief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(brief.PartitionKey, brief.RowKey);

                //load the brief documents
                BriefDocument documentToRename = _bundledocsApi.Bundles.Tree(loadedBrief.PartitionKey, loadedBrief.RowKey).Where(k => k.Type == "HEADER").FirstOrDefault().Children.Where(k => k.Type == "DOCUMENT").FirstOrDefault();

                //Act
                //rename the section
                BriefDocument renamedDocument = _bundledocsApi.Documents.Rename(documentToRename.PartitionKey, documentToRename.RowKey, expected);
                
                //Assert
                Assert.AreEqual(expected, renamedDocument.Description);
            }

            [TestMethod]
            public void Delete_Test()
            {                
                //Arrange
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //choose a brief
                Brief brief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(brief.PartitionKey, brief.RowKey);

                //load the brief documents
                BriefDocument documentToDelete = _bundledocsApi.Bundles.Tree(loadedBrief.PartitionKey, loadedBrief.RowKey).Where(k => k.Type == "HEADER").FirstOrDefault().Children.Where(k => k.Type == "DOCUMENT").FirstOrDefault();

                //Act
                //delete the document
                BriefDocument deletedDocument = _bundledocsApi.Documents.Delete(documentToDelete.PartitionKey, documentToDelete.RowKey);
                                
                //Assert
                Assert.AreEqual(documentToDelete.RowKey, deletedDocument.RowKey);
            }
        }


        [TestClass]
        public class Receipt_Tests : BundledocsApi_Tests
        {
            [TestMethod]
            public void Download_Test()
            {
                //Arrange                
                //load the user
                UserBean user = _bundledocsApi.Users.Me();

                //find a brief to load
                Brief parentBrief = user.Briefs.Where(k => k.PartitionKey == user.RowKey).FirstOrDefault();

                //load the brief
                BriefBean loadedBrief = _bundledocsApi.Bundles.Get(parentBrief.PartitionKey, parentBrief.RowKey);

                //load the brief receipts
                IList<BriefReceipt> briefReceipts = _bundledocsApi.Bundles.Receipts(loadedBrief.PartitionKey, loadedBrief.RowKey);

                //load the latest brief receipt
                BriefReceipt briefReceiptToDownload = briefReceipts.FirstOrDefault();

                //download the brief receipt
                Stream briefReceiptStream = _bundledocsApi.Receipts.Download(briefReceiptToDownload.PartitionKey, briefReceiptToDownload.RowKey);

                //write the downloaded stream to disk
                byte[] myFile = briefReceiptStream.ReadToEnd();
                string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";
                File.WriteAllBytes(newFilePath, myFile);

                //Assert                
                Assert.IsTrue(File.Exists(newFilePath));

                //open the downloaded bundle
                Process.Start(newFilePath);
            }
        }
    }
}
