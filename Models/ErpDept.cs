﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpDept
    {
        public ErpDept()
        {
            ErpUser = new HashSet<ErpUser>();
        }

        public short DeptId { get; set; }
        public string Department { get; set; }

        public virtual ICollection<ErpUser> ErpUser { get; set; }
    }
}
