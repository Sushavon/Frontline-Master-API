using System.ComponentModel.DataAnnotations;

namespace FrontlineMaster.Entity.Common
{
    public class SBUEntity
    {
        [Key]
        public int SbuId { get; set; }
        public int CompanyId { get; set; }
        public string SbuCode { get; set; }
        public string SbuName { get; set; }
        public string RepDeptCode { get; set; }
        public string ExpenseDeptCode { get; set; }
        public string ShortName { get; set; }
        public short? DisplayOrder { get; set; }
        public string OldSbuCode { get; set; }
        public string LeaveProcessFlag { get; set; }
        public string RspFlag { get; set; }
        public string SapDept { get; set; }
        public string Samg2Comp { get; set; }
        public short? PeriodDay { get; set; }
        public string SecSalesFlag { get; set; }
        public long? CostCenter { get; set; }
        public long? FundCenter { get; set; }
        public string SfaActiveFlag { get; set; }
        public string SalesCompanyCode { get; set; }
        public string TrinityActiveFlag { get; set; }
        public string ZydusCompany { get; set; }
        public string Isexpenselive { get; set; }
        public bool? IsActive { get; set; }
    }
}
