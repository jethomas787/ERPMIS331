using ERPMIS331.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPMIS331
{
    public partial class Purchasing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                QueryData();
            }
        }

        protected void TimeBasedDataLoad(object sender, EventArgs e)
        {
            QueryData();
        }

        protected void UploadPurchaseFile(object sender, EventArgs e)
        {
            if (filePurchase.HasFile)
            {
                var purchase = new ErpPurchase();

            }


        }

        private void QueryData()
        {
           using (MIS331_ERPContext ctx = new MIS331_ERPContext()) 
            {
                var data = from inventory in ctx.ErpInventory
                           join components in ctx.ErpComponents on inventory.ErpComponentId equals components.ErpComponentId
                           join supplier in ctx.ErpSupplier on components.ErpSupplierId equals supplier.SupplierId
                           where inventory.ErpInventoryQty == components.ErpComponentReorderLvl
                           select new
                           {
                               Item = components.ErpComponentName,
                               Quantity = inventory.ErpInventoryQty,
                               Price = components.ErpComponentCpu,
                               Supplier = supplier.SupplierName,
                           };
                purchaseGridView.DataSource = data.ToList();
                purchaseGridView.DataBind();
            }
         
        }

        protected void LogOutBtn(object sender, EventArgs e)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }


    }
}