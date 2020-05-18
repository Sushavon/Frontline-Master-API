using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class EntApprConfig
    {
        public int ApprLevelId { get; set; }
        public string EntityName { get; set; }
        public string ApprLevel { get; set; }
        public int SeqNo { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
