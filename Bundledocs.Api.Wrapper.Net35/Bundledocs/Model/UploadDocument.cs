using System;
using System.IO;

namespace Bundledocs.Model
{
    public class UploadDocument
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string ForeignKey { get; set; }

        public DateTime Created { get; set; }
    }

    public class UploadFile
    {
        public string DocumentDate { get; set; }
        public string FileLocation { get; set; }
        public string FileUploadKey { get; set; }
        public string FileUploadDate { get; set; }
        public string FileUploadName { get; set; }

        public string FileName { get; set; }                
        public Stream Stream { get; set; }
        public string ContentType { get; set; }

        public int Order { get; set; }
    }

    public class AuthenticateResponse
    {
        public string SessionKey { get; set; }
    }

    public class BriefHeaderDocument : UploadDocument
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string DisplayOrder { get; set; }
    }

    public class BriefHeader : UploadDocument
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string DisplayOrder { get; set; }
    }

    public class ContentResponse
    {
        public string Scope { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
    }
}
