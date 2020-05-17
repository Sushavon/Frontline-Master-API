using System.ComponentModel.DataAnnotations;

namespace FrontlineMaster.Entity.Hierarchy
{
    public class CompanyEntity
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string OldCompCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
