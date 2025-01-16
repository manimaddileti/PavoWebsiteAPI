namespace PavoWebsiteDatabase.Models
{
    public class PageContentDetail
    {
        public int Id { get; set; }
        public string Description_1 { get; set; }
        public string Description_2 { get; set; }
        public string Description_3 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
