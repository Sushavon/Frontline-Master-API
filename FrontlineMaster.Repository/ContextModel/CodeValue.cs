using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class CodeValue
    {
        public CodeValue()
        {
            Doctor = new HashSet<Doctor>();
            DoctorAddr = new HashSet<DoctorAddr>();
            DrAddrDraft = new HashSet<DrAddrDraft>();
            DrAddrVisitHr = new HashSet<DrAddrVisitHr>();
            DrAddrVisitHrDraft = new HashSet<DrAddrVisitHrDraft>();
            FamilyDetailGender = new HashSet<FamilyDetail>();
            FamilyDetailMaritalStatus = new HashSet<FamilyDetail>();
            RepMst = new HashSet<RepMst>();
        }

        public int CodeValId { get; set; }
        public string ValCode { get; set; }
        public string ValDesc { get; set; }
        public string TypeCode { get; set; }
        public int SeqNo { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Doctor> Doctor { get; set; }
        public virtual ICollection<DoctorAddr> DoctorAddr { get; set; }
        public virtual ICollection<DrAddrDraft> DrAddrDraft { get; set; }
        public virtual ICollection<DrAddrVisitHr> DrAddrVisitHr { get; set; }
        public virtual ICollection<DrAddrVisitHrDraft> DrAddrVisitHrDraft { get; set; }
        public virtual ICollection<FamilyDetail> FamilyDetailGender { get; set; }
        public virtual ICollection<FamilyDetail> FamilyDetailMaritalStatus { get; set; }
        public virtual ICollection<RepMst> RepMst { get; set; }
    }
}
