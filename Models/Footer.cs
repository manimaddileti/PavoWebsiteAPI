using System;

namespace PavoWebsiteDatabase.Models
{
    public class Footer
    {
        public int Id { get; set; }
        public string ?CopyRights { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
        public User ?CreatedByUser { get; set; }
        public User ?ModifiedByUser { get; set; }
        public User ?DeletedByUser { get; set; }
    }
}

