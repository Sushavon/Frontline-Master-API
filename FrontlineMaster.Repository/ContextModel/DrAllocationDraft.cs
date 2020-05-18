using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DrAllocationDraft
    {
        public int DrAllocationId { get; set; }
        public int CompanyId { get; set; }
        public int SbuId { get; set; }
        public int RepId { get; set; }
        public short McrNo { get; set; }
        public int DoctorId { get; set; }
        public int DrAddrId { get; set; }
        public int SeqNo { get; set; }
        public short? PreMcrNo { get; set; }
        public string EntryCategory { get; set; }
        public string Remark { get; set; }
        public string NextApprLevel { get; set; }
        public string LastApprLevel { get; set; }
        public string LastApprovalStatus { get; set; }
        public int? LastApprovalById { get; set; }
        public DateTime? LastApprovalDate { get; set; }
        public string LastApprovalRemark { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual DoctorAddr DrAddr { get; set; }
        public virtual RepMst LastApprovalBy { get; set; }
        public virtual RepMst Rep { get; set; }
        public virtual Sbu Sbu { get; set; }
    }
}
