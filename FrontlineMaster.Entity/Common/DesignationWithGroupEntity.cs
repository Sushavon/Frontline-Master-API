namespace FrontlineMaster.Entity.Hierarchy
{
    public class DesignationWithGroupEntity
    {
        public int DesigId { get; set; }
        public int SbuId { get; set; }
        public string SbuCode { get; set; }
        public string DesigCode { get; set; }
        public string DesigDesc { get; set; }
        public string LeaveFlag { get; set; }
        public short? DesigHierarchy { get; set; }
        public string DesigCategory { get; set; }
        public string ConfirmationFlag { get; set; }
        public bool? IsActive { get; set; }
        public int DesigGrpId { get; set; }
        public string GroupCode { get; set; }
    }
}
