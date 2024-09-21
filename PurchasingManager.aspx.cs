using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class PurchasingManager : System.Web.UI.Page
    {
        protected void ButtonOrderBurger_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderBurger.aspx");
        }
    }
}