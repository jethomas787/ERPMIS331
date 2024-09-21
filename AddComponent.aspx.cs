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
    public partial class AddComponent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [MIS331_ERP].[dbo].[ERP_Components] (ERP_ComponentName, ERP_ComponentCPU, ERP_ComponentQty, ERP_ComponentReorderLvl, ERP_SupplierID) VALUES (@Name, @CPU, @Qty, @ReorderLevel, @SupplierID)", con))
                {
                    cmd.Parameters.AddWithValue("@Name", TextBoxName.Text);
                    cmd.Parameters.AddWithValue("@CPU", TextBoxCPU.Text);
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(TextBoxQty.Text));
                    cmd.Parameters.AddWithValue("@ReorderLevel", Convert.ToInt32(TextBoxReorderLevel.Text));
                    cmd.Parameters.AddWithValue("@SupplierID", TextBoxSupplierID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            LabelMessage.Text = "Component added successfully!";
            LabelMessage.Visible = true;
        }
    }
}