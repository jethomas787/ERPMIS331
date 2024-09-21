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
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductsGrid();
            }
        }

        private void BindProductsGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ERP_ProductID, ERP_ProductName, ERP_ProductPrice, ERP_ProductQtyLvl FROM [MIS331_ERP].[dbo].[ERP_Product]", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        GridViewProducts.DataSource = dt;
                        GridViewProducts.DataBind();
                    }
                }
            }
        }

        protected void GridViewProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "OrderProduct")
            {
                int productId = Convert.ToInt32(e.CommandArgument);
                OrderProductById(productId);
            }
        }

        private void OrderProductById(int productId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Get current quantity
                        SqlCommand cmdGetQty = new SqlCommand("SELECT ERP_ProductQtyLvl FROM [MIS331_ERP].[dbo].[ERP_Product] WHERE ERP_ProductID = @ProductID", con, transaction);
                        cmdGetQty.Parameters.AddWithValue("@ProductID", productId);
                        int currentQty = Convert.ToInt32(cmdGetQty.ExecuteScalar());

                        if (currentQty > 0)
                        {
                            // Decrease quantity by 1
                            SqlCommand cmdUpdateQty = new SqlCommand("UPDATE [MIS331_ERP].[dbo].[ERP_Product] SET ERP_ProductQtyLvl = ERP_ProductQtyLvl - 1 WHERE ERP_ProductID = @ProductID", con, transaction);
                            cmdUpdateQty.Parameters.AddWithValue("@ProductID", productId);
                            cmdUpdateQty.ExecuteNonQuery();

                            transaction.Commit();
                        }
                        else
                        {
                            // Handle out-of-stock situation (optional)
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        // Handle error (optional)
                    }
                }
            }

            // Refresh the product list
            BindProductsGrid();
        }
    }
}