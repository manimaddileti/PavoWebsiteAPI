namespace PavoWebsiteDatabase.Models
{
    public class SubscriptionDescriptionList
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}

