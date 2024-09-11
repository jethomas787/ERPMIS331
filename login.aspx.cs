using ERPMIS331.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ERPMIS331
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LoginBtn(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (var ctx = new MIS331_ERPContext())
            {
                var usr = ctx.ErpUser.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();
                if (usr != null)
                {
                    FormsAuthentication.SetAuthCookie(usr.UserName, false);
                    string role = ctx.ErpRole.Find(usr.RoleId).Role;

                    if (role == "Admin")
                    {
                        Response.Redirect("~/Default.aspx");
                    }
                    else if (role == "Inventory")
                    {
                        Response.Redirect("~/Inventory.aspx");
                    }
                    else if (role == "Supplier")
                    {
                        Response.Redirect("~/Supplier");
                    }
                    else if (role == "Purchase")
                    {
                        Response.Redirect("~/Purchase");
                    }
                    else if (role == "Sales")
                    {
                        Response.Redirect("~/Sales");
                    }
                }

            }
        }
    }
           
}

