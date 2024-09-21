using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class SystemInformation : System.Web.UI.Page
    {
        protected void ButtonComponents_Click(object sender, EventArgs e)
        {
            Response.Redirect("ErpComponent.aspx"); // Redirect to the components page
        }

        protected void ButtonInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inventory.aspx"); // Redirect to the inventory page
        }

        protected void ButtonProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx"); // Redirect to the products page
        }
    }
}