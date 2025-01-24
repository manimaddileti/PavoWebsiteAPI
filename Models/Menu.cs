namespace PavoWebsiteDatabase.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int OrderBy { get; set; }
        public int? ParentId { get; set; }
        public string Icons { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public int IsDeleted { get; set; }
    }
}

