namespace FrontlineMaster.Entity.Common
{
    public class StateEntity
    {
        public int StateId { get; set; }
        public int CompanyId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string WeeklyOff { get; set; }
        public string SapStateCode { get; set; }
        public string TrinityActiveFlag { get; set; }
        public bool? IsActive { get; set; }
    }
}
