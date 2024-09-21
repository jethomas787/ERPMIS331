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
    public partial class Login : System.Web.UI.Page
    {
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            string selectedRole = Session["SelectedRole"] as string;

            // Validate username and password logic here
            if (selectedRole == "1" && password == "SupplyManager@MIS331") // Supply Manager
            {
                Session["UserRole"] = "SupplyManager";
                System.Diagnostics.Debug.WriteLine("Redirecting to SupplierManagerDashboard.aspx");
                Response.Redirect("SupplierManagerDashboard.aspx");
            }
            else if (selectedRole == "2" && password == "ERPManager@MIS331") // ERP Manager
            {
                Session["UserRole"] = "ERPManager";
                System.Diagnostics.Debug.WriteLine("Redirecting to ERPManagerDashboard.aspx");
                Response.Redirect("ERPManagerDashboard.aspx");
            }
            else if (selectedRole == "3" && password == "PurchasingManager@MIS331") // Purchasing Manager
            {
                Session["UserRole"] = "PurchasingManager";
                System.Diagnostics.Debug.WriteLine("Redirecting to PurchasingManagerDashboard.aspx");
                Response.Redirect("PurchasingManager.aspx");
            }
            else
            {
                LabelError.Text = "Invalid username or password.";
                LabelError.Visible = true;
            }
        }
    }
}