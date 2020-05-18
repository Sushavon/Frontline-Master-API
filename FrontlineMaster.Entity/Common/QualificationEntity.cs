using System;
using System.Collections.Generic;
using System.Text;

namespace FrontlineMaster.Entity.Common
{
    public class QualificationEntity
    {
        public int QualificationId { get; set; }
        public string QualiCode { get; set; }
        public string QualiDesc { get; set; }
        public int SpecId { get; set; }
        public string OldQuali { get; set; }
        public bool? IsActive { get; set; }
    }
}
