using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class EntityApproval
    {
        public int ApprovalId { get; set; }
        public string EntityName { get; set; }
        public int EntityId { get; set; }
        public string ApprLevel { get; set; }
        public string Status { get; set; }
        public int? ApprovalById { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string ApprovalRemark { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
