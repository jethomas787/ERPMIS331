using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class SupplierManagerDashboard : System.Web.UI.Page
    {
               protected void ButtonViewComponents_Click(object sender, EventArgs e)
        {
            Response.Redirect("ErpComponent.aspx"); // Redirect to the components page
        }
    }
}
