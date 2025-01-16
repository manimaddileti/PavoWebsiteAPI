namespace PavoWebsiteDatabase.Models
{
    public class SubscriptionDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubscriptionPlan { get; set; }
        public string PriceTimeline { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
