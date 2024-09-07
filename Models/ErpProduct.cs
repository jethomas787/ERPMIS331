using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERPMIS331.Models
{
    public partial class ErpProduct
    {
        public ErpProduct()
        {
            ErpBillOfMaterials = new HashSet<ErpBillOfMaterials>();
        }

        public short ErpProductId { get; set; }
        public string ErpProductName { get; set; }
        public string ErpProductDesc { get; set; }
        public decimal ErpProductPrice { get; set; }
        public string ErpProoductUoM { get; set; }
        public decimal ErpProductQtyLvl { get; set; }

        public virtual ICollection<ErpBillOfMaterials> ErpBillOfMaterials { get; set; }
    }
}
