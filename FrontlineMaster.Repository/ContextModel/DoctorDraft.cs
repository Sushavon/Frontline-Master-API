using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DoctorDraft
    {
        public DoctorDraft()
        {
            DrAddrDraft = new HashSet<DrAddrDraft>();
        }

        public int DoctorId { get; set; }
        public int CompanyId { get; set; }
        public string DrCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int QualificationId { get; set; }
        public int SpecId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? AnnDate { get; set; }
        public string RegisterCode { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string FinalDrCode { get; set; }
        public string CardQuali { get; set; }
        public int? RepId { get; set; }
        public short? McrNo { get; set; }
        public int? OriginalSpecId { get; set; }
        public string OriginalDrCode { get; set; }
        public string EntryCategory { get; set; }
        public int SeqNo { get; set; }
        public string ImageUrl { get; set; }
        public string NextApprLevel { get; set; }
        public string LastApprLevel { get; set; }
        public string LastApprovalStatus { get; set; }
        public int? LastApprovalById { get; set; }
        public DateTime? LastApprovalDate { get; set; }
        public int? LastApprovalMcrno { get; set; }
        public string LastApprovalRemark { get; set; }
        public string ApproveOnlyAddr { get; set; }
        public string OnlyAddrDrCode { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual RepMst LastApprovalBy { get; set; }
        public virtual Speciality OriginalSpec { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual RepMst Rep { get; set; }
        public virtual Speciality Spec { get; set; }
        public virtual ICollection<DrAddrDraft> DrAddrDraft { get; set; }
    }
}
