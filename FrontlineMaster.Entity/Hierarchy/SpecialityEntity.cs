namespace FrontlineMaster.Entity.Hierarchy
{
    public class SpecialityEntity
    {
        public int SpecialityId { get; set; }
        public int CompanyId { get; set; }
        public string SpecCode { get; set; }
        public string SpecDesc { get; set; }
        public string SpecStatus { get; set; }
        public string DedupliStatus { get; set; }
        public bool? IsActive { get; set; }
    }
}
