namespace FrontlineMaster.Entity.Common
{
    public class RegionEntity
    {
        public int RegionId { get; set; }
        public int ZoneId { get; set; }
        public string RegionCode { get; set; }
        public string RegionDesc { get; set; }
        public string ZdRegionCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
