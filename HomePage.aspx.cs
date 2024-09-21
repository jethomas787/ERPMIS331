using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Any initialization code can go here
            }
        }

        protected void ButtonPurchase_Click(object sender, EventArgs e)
        {
            Response.Redirect("Purchase.aspx");
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            // Logout logic here (e.g., clearing session data)
            Session.Clear();
            Response.Redirect("Login.aspx"); // Redirect to the login page after logout
        }
    }
}