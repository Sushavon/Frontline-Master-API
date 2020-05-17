namespace FrontlineMaster.Entity.Common
{
    public class CityEntity
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public int SerNoDr { get; set; }
        public int SerNoChemist { get; set; }
        public string FinalCityCode { get; set; }
        public string FinDelFlag { get; set; }
        public bool? IsActive { get; set; }
    }
}
