namespace FrontlineMaster.Entity.Hierarchy
{
    public class TownTypeEntity
    {
        public int TownTypeId { get; set; }
        public int CompanyId { get; set; }
        public string TownTypeCode { get; set; }
        public string TownTypeDesc { get; set; }
        public bool IsActive { get; set; }
    }
}
