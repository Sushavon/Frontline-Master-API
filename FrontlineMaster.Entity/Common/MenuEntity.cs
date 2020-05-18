namespace FrontlineMaster.Entity.Common
{
    public class MenuEntity
    {
        public int MenuId { get; set; }
       // public string MenuCode { get; set; }
        public string Status { get; set; }
        public string MenuDesc { get; set; }
        public int? ParentMenuId { get; set; }
        public string PageReference { get; set; }
       // public string IconReference { get; set; }
       // public int MenuGroupRightsId { get; set; }
        public int CompanyId { get; set; }
        public int SbuId { get; set; }
        public string MenuGroupId { get; set; }
     //   public string SfaActiveFlag { get; set; }
      //  public string RepDeptCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
