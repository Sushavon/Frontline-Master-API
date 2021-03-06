﻿using System;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class DrDropReason
    {
        public string ReasonCode { get; set; }
        public string ReasonDesc { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
