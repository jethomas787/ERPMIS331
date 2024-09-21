using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class RoleSelection : System.Web.UI.Page
    {
        protected void RoleButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedRole = clickedButton.CommandArgument;

            // Store the selected role in session
            Session["SelectedRole"] = selectedRole;

            // Redirect to the dashboard or main page
            Response.Redirect("login.aspx"); // Change this to the appropriate page for the role
        }
    }
}