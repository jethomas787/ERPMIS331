﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpCustomer
    {
        public ErpCustomer()
        {
            ErpSalesOrder = new HashSet<ErpSalesOrder>();
        }

        public short ErpCustomerId { get; set; }
        public string ErpName { get; set; }

        public virtual ICollection<ErpSalesOrder> ErpSalesOrder { get; set; }
    }
}
