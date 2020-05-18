using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DrAddrVisitHr
    {
        public int VisitHourId { get; set; }
        public int DrAddrId { get; set; }
        public int? Day { get; set; }
        public decimal? FromTime { get; set; }
        public decimal? ToTime { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual CodeValue DayNavigation { get; set; }
        public virtual DoctorAddr DrAddr { get; set; }
    }
}
