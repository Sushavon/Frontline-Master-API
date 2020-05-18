using System;
using System.Collections.Generic;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class ChemistAllocation
    {
        public int ChemistAllotId { get; set; }
        public int CompanyId { get; set; }
        public int SbuId { get; set; }
        public int RepId { get; set; }
        public string ChemistCode { get; set; }
        public short SerNo { get; set; }
        public short McrNo { get; set; }
        public string ChemistCategory { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
