using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpPurchaseOrderDetails
    {
        public short ErpPurchaseOrderId { get; set; }
        public short ErpComponentId { get; set; }
        public decimal ErpPoQty { get; set; }
        public decimal ErpUnitPrice { get; set; }

        public virtual ErpComponents ErpComponent { get; set; }
        public virtual ErpPurchaseOrders ErpPurchaseOrder { get; set; }
    }
}
