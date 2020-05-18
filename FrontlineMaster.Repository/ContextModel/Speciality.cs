using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class Speciality
    {
        public Speciality()
        {
            Doctor = new HashSet<Doctor>();
            DoctorDraftOriginalSpec = new HashSet<DoctorDraft>();
            DoctorDraftSpec = new HashSet<DoctorDraft>();
            Qualification = new HashSet<Qualification>();
        }

        public int SpecialityId { get; set; }
        public int CompanyId { get; set; }
        public string SpecCode { get; set; }
        public string SpecDesc { get; set; }
        public string SpecStatus { get; set; }
        public string DedupliStatus { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Doctor> Doctor { get; set; }
        public virtual ICollection<DoctorDraft> DoctorDraftOriginalSpec { get; set; }
        public virtual ICollection<DoctorDraft> DoctorDraftSpec { get; set; }
        public virtual ICollection<Qualification> Qualification { get; set; }
    }
}
