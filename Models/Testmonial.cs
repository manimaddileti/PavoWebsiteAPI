namespace PavoWebsiteDatabase.Models
{
    public class Testmonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
