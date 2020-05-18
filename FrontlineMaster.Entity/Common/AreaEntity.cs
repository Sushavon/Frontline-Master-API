using System;
using System.Collections.Generic;
using System.Text;

namespace FrontlineMaster.Entity.Common
{
    public class AreaEntity
    {
        public int AreaId { get; set; }
        public int RegionId { get; set; }
        public string AreaCode { get; set; }
        public string AreaDesc { get; set; }
        public string ZdAreaCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
