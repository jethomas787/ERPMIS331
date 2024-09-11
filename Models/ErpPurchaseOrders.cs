using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpPurchaseOrders
    {
        public short ErpPurchaseOrderId { get; set; }
        public short ErpSupplierId { get; set; }
        public DateTime ErpPurchaseOrderDate { get; set; }
        public decimal ErpPurchaseTotalAmt { get; set; }
        public string ErpPurchaseStatus { get; set; }

        public virtual ErpSupplier ErpSupplier { get; set; }
        public virtual ErpPurchaseOrderDetails ErpPurchaseOrderDetails { get; set; }
    }
}
