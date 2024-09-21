using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace ERPMIS331
{
    public partial class ERPManagerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Any initialization logic can go here
        }

        private void BindDataGrid(string tableName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbcxnstrng"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT TOP (1000) * FROM [MIS331_ERP].[dbo].[{tableName}]", con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                GridViewData.DataSource = dt;
                                GridViewData.DataBind();
                            }
                            else
                            {
                                GridViewData.DataSource = null; // Clear previous data
                                GridViewData.DataBind();
                                System.Diagnostics.Debug.WriteLine("No data available in the table: " + tableName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the error
                        System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }

        protected void ButtonViewComponents_Click(object sender, EventArgs e)
        {
            BindDataGrid("ERP_Components");
        }

        protected void ButtonViewInventory_Click(object sender, EventArgs e)
        {
            BindDataGrid("ERP_Inventory");
        }

        protected void ButtonViewProducts_Click(object sender, EventArgs e)
        {
            BindDataGrid("ERP_Product");
        }

        protected void ButtonViewPurchases_Click(object sender, EventArgs e)
        {
            BindDataGrid("ERP_Purchase");
        }

        protected void ButtonViewUsers_Click(object sender, EventArgs e)
        {
            BindDataGrid("ERP_User");
        }
    }
}