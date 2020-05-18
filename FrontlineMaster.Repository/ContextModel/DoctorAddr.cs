using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DoctorAddr
    {
        public DoctorAddr()
        {
            DrAddrVisitHr = new HashSet<DrAddrVisitHr>();
            DrAllocation = new HashSet<DrAllocation>();
            DrAllocationDraft = new HashSet<DrAllocationDraft>();
        }

        public int DrAddrId { get; set; }
        public int? DoctorId { get; set; }
        public string AddrCode { get; set; }
        public string ClinicName { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Area { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public string PinCode { get; set; }
        public string PhoneC { get; set; }
        public string PhoneR { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string RegisterCode { get; set; }
        public int? AddrTypId { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual CodeValue AddrTyp { get; set; }
        public virtual City City { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<DrAddrVisitHr> DrAddrVisitHr { get; set; }
        public virtual ICollection<DrAllocation> DrAllocation { get; set; }
        public virtual ICollection<DrAllocationDraft> DrAllocationDraft { get; set; }
    }
}
