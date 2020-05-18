using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class Doctor
    {
        public Doctor()
        {
            DoctorAddr = new HashSet<DoctorAddr>();
            DrAddrDraft = new HashSet<DrAddrDraft>();
            DrAllocation = new HashSet<DrAllocation>();
            DrAllocationDraft = new HashSet<DrAllocationDraft>();
        }

        public int DoctorId { get; set; }
        public int CompanyId { get; set; }
        public string DrCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? QualificationId { get; set; }
        public int SpecId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? AnnDate { get; set; }
        public int? DrAddrId { get; set; }
        public string RegisterCode { get; set; }
        public string OriginalSpec { get; set; }
        public string UnduplicatedFlag { get; set; }
        public string CardQuali { get; set; }
        public string OriginalDrCode { get; set; }
        public int? GenderId { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual CodeValue Gender { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual Speciality Spec { get; set; }
        public virtual ICollection<DoctorAddr> DoctorAddr { get; set; }
        public virtual ICollection<DrAddrDraft> DrAddrDraft { get; set; }
        public virtual ICollection<DrAllocation> DrAllocation { get; set; }
        public virtual ICollection<DrAllocationDraft> DrAllocationDraft { get; set; }
    }
}
