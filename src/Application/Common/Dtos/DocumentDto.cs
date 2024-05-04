using Application.Common.Mappings;
using FirstFreightAPI.Entities.Shared;

namespace Application.Common.Dtos
{
    public class DocumentDto : IMapFrom<Document>
    {
        public int SubscriberId { get; set; }
        public int DocumentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string DocumentUrl { get; set; }
        public int DocumentTypeId { get; set; }
        public int DocumentFolderId { get; set; }
        public string DocumentGroup { get; set; }
        public int DealId { get; set; }
        public int GlobalContactId { get; set; }
        public int UserId { get; set; }
        public int UserIdGlobal { get; set; }
        public int LocationId { get; set; }
        public int CompanyId { get; set; }
        public int CompanyIdGlobal { get; set; }
        public int QuoteIdGlobal { get; set; }
        public int ActivityId { get; set; }
        public int EmailId { get; set; }
        public string DocumentBlobReference { get; set; }
        public string DocumentContainerReference { get; set; }
        public DateTime UploadedDate { get; set; }
        public int UploadedBy { get; set; }
        public int UploadedByGlobal { get; set; }
        public string UploadedByName { get; set; }
        public int FileCount { get; set; }
        public int MessageId { get; set; }
        public string TargetContainerReference { get; set; }
    }
}
