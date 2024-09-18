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
                    Session["username"] = usr.UserName;
                    Session["roleId"] = usr.RoleId;

                   FormsAuthentication.SetAuthCookie(usr.UserName, false);

                    switch (usr.RoleId)
                    {
                        case 1:
                            Response.Redirect("Supplier.aspx");
                            break;
                            
                        case 2:
                            Response.Redirect("Default.aspx");
                            break;

                        case 3:
                            Response.Redirect("Default.aspx");
                            break;

                        case 4:
                            Response.Redirect("Default.aspx");
                            break;

                        case 5:
                            Response.Redirect("Default.aspx");
                            break;
                    }

                }else
                {
                    Response.Redirect("login.aspx");
                }

            }
        }
    }
           
}

