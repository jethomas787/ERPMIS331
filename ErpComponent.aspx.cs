using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class ErpComponent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [MIS331_ERP].[dbo].[ERP_Components]", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        GridViewComponents.DataSource = dt;
                        GridViewComponents.DataBind();

                        // Calculate total quantity
                        int totalQty = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            totalQty += Convert.ToInt32(row["ERP_ComponentQty"]);
                        }
                        LabelTotalQty.Text = totalQty.ToString();
                    }
                }
            }
        }

        protected void ButtonAddComponent_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [MIS331_ERP].[dbo].[ERP_Components] (ERP_ComponentName, ERP_ComponentCPU, ERP_ComponentQty, ERP_ComponentReorderLvl, ERP_SupplierID) VALUES (@Name, @CPU, @Qty, @ReorderLevel, @SupplierID)", con))
                {
                    cmd.Parameters.AddWithValue("@Name", TextBoxComponentName.Text);
                    cmd.Parameters.AddWithValue("@CPU", TextBoxCPU.Text);
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(TextBoxQty.Text));
                    cmd.Parameters.AddWithValue("@ReorderLevel", Convert.ToInt32(TextBoxReorderLevel.Text));
                    cmd.Parameters.AddWithValue("@SupplierID", TextBoxSupplierID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            LabelAddMessage.Text = "Component added successfully!";
            LabelAddMessage.Visible = true;

            // Clear the input fields
            TextBoxComponentName.Text = "";
            TextBoxCPU.Text = "";
            TextBoxQty.Text = "";
            TextBoxReorderLevel.Text = "";
            TextBoxSupplierID.Text = "";

            // Rebind the grid to refresh the component list
            BindGrid();
        }
    }
}