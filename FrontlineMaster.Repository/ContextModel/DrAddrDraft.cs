using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DrAddrDraft
    {
        public DrAddrDraft()
        {
            DrAddrVisitHrDraft = new HashSet<DrAddrVisitHrDraft>();
        }

        public int DrAddrId { get; set; }
        public int? DoctorId { get; set; }
        public int? FinalDoctorId { get; set; }
        public string AddrCode { get; set; }
        public string ClinicName { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Area { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string PinCode { get; set; }
        public string PhoneC { get; set; }
        public string PhoneR { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string RegisterCode { get; set; }
        public int? AddrTypeId { get; set; }
        public string Remark { get; set; }
        public string FinalDrCode { get; set; }
        public int? RepId { get; set; }
        public short? McrNo { get; set; }
        public string EntryCategory { get; set; }
        public int SeqNo { get; set; }
        public string ImageUrl { get; set; }
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

        public virtual CodeValue AddrType { get; set; }
        public virtual City City { get; set; }
        public virtual DoctorDraft Doctor { get; set; }
        public virtual Doctor FinalDoctor { get; set; }
        public virtual RepMst LastApprovalBy { get; set; }
        public virtual RepMst Rep { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<DrAddrVisitHrDraft> DrAddrVisitHrDraft { get; set; }
    }
}
