﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FrontlineMaster.Entity.Common
{
    public class DropReasonEntity
    {
        public string ReasonCode { get; set; }
        public string ReasonDesc { get; set; }
        public bool? IsActive { get; set; }
    }
}