namespace PavoWebsiteDatabase.Models
{
    public class ActivityMetrics
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int EndUsers { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
