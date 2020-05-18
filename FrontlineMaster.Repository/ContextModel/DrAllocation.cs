using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DrAllocation
    {
        public int DrAllocationId { get; set; }
        public int CompanyId { get; set; }
        public int SbuId { get; set; }
        public int RepId { get; set; }
        public int DoctorId { get; set; }
        public short SerNo { get; set; }
        public short? McrNo { get; set; }
        public string DrCategory { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? DrAddrId { get; set; }
        public string TransferFlag { get; set; }

        public virtual Company Company { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual DoctorAddr DrAddr { get; set; }
        public virtual RepMst Rep { get; set; }
        public virtual Sbu Sbu { get; set; }
    }
}
