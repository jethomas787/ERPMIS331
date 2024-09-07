using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpComponents
    {
        public ErpComponents()
        {
            ErpBillOfMaterials = new HashSet<ErpBillOfMaterials>();
        }

        public short ErpComponentId { get; set; }
        public string ErpComponentName { get; set; }
        public decimal ErpComponentCpu { get; set; }
        public decimal ErpComponentQty { get; set; }
        public decimal ErpComponentReorderLvl { get; set; }
        public short ErpSupplierId { get; set; }

        public virtual ErpSupplier ErpSupplier { get; set; }
        public virtual ICollection<ErpBillOfMaterials> ErpBillOfMaterials { get; set; }
    }
}
