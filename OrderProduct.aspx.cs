using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ERPProject;

namespace ERPProject
{
    public partial class OrderProduct : System.Web.UI.Page
    {
        private decimal totalCost = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindComponents();
            }
        }

        private void BindComponents()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ERP_ComponentID, ERP_ComponentName, ERP_ComponentCPU FROM [MIS331_ERP].[dbo].[ERP_Components]", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DropDownComponents.DataSource = dt;
                        DropDownComponents.DataTextField = "ERP_ComponentName";
                        DropDownComponents.DataValueField = "ERP_ComponentID";
                        DropDownComponents.DataBind();
                    }
                }
            }
        }

        protected void ButtonSubmitOrder_Click(object sender, EventArgs e)
        {
            int componentId = Convert.ToInt32(DropDownComponents.SelectedValue);
            int quantity = Convert.ToInt32(TextBoxQuantity.Text);

            if (quantity > 0)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ComponentConn"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Get the unit price of the selected component
                    decimal unitPrice = GetComponentPrice(con, componentId);
                    totalCost += unitPrice * quantity;

                    // Insert into Purchase Order Details table
                    InsertPurchaseOrder(con, componentId, quantity, unitPrice);

                    LabelTotalCost.Text = totalCost.ToString("0.00");
                    LabelError.Text = ""; // Clear any previous errors
                }
            }
            else
            {
                LabelError.Text = "Please enter a valid quantity.";
            }
        }

        private decimal GetComponentPrice(SqlConnection con, int componentId)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT ERP_ComponentCPU FROM [MIS331_ERP].[dbo].[ERP_Components] WHERE ERP_ComponentID = @ComponentID", con))
            {
                cmd.Parameters.AddWithValue("@ComponentID", componentId);
                return (decimal)cmd.ExecuteScalar();
            }
        }

        private void InsertPurchaseOrder(SqlConnection con, int componentId, int quantity, decimal unitPrice)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [MIS331_ERP].[dbo].[ERP_PurchaseOrderDetails] (ERP_ComponentID, ERP_PO_Qty, ERP_UnitPrice) VALUES (@ComponentID, @Quantity, @UnitPrice)", con))
            {
                cmd.Parameters.AddWithValue("@ComponentID", componentId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
