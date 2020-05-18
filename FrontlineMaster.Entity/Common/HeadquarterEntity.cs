using System;
using System.Collections.Generic;
using System.Text;

namespace FrontlineMaster.Entity.Common
{
    public class HeadquarterEntity
    {
        public int HeadquarterId { get; set; }
        public int AreaId { get; set; }
        public string HqCode { get; set; }
        public string HqDesc { get; set; }
        public string ZdHqCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
