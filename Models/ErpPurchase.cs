using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpPurchase
    {
        public short ErpPurchaseId { get; set; }
        public short ErpSupplierId { get; set; }
        public DateTime ErpPurchaseDate { get; set; }
        public decimal ErpPurchaseQty { get; set; }
        public decimal ErpPurchaseUnitPrice { get; set; }

        public virtual ErpSupplier ErpSupplier { get; set; }
    }
}
