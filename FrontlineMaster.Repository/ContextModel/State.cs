using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class State
    {
        public State()
        {
            City = new HashSet<City>();
            DoctorAddr = new HashSet<DoctorAddr>();
            DrAddrDraft = new HashSet<DrAddrDraft>();
            RepMst = new HashSet<RepMst>();
        }

        public int StateId { get; set; }
        public int CompanyId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string WeeklyOff { get; set; }
        public string SapStateCode { get; set; }
        public string TrinityActiveFlag { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<DoctorAddr> DoctorAddr { get; set; }
        public virtual ICollection<DrAddrDraft> DrAddrDraft { get; set; }
        public virtual ICollection<RepMst> RepMst { get; set; }
    }
}
