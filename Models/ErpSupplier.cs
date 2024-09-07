using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpSupplier
    {
        public ErpSupplier()
        {
            ErpComponents = new HashSet<ErpComponents>();
            ErpPurchaseOrders = new HashSet<ErpPurchaseOrders>();
        }

        public short SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPhoneNumber { get; set; }

        public virtual ICollection<ErpComponents> ErpComponents { get; set; }
        public virtual ICollection<ErpPurchaseOrders> ErpPurchaseOrders { get; set; }
    }
}
