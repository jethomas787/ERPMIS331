using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPProject
{
    public partial class OrderBurger : System.Web.UI.Page
    {
        protected void ButtonOrder_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(TextBoxQuantity.Text, out quantity) && quantity > 0)
            {
                decimal pricePerBurger = 5.00m; // Price of one burger
                decimal totalCost = pricePerBurger * quantity;

                LabelTotal.Text = "Total Cost: $" + totalCost.ToString("F2");
            }
            else
            {
                LabelTotal.Text = "Please enter a valid quantity.";
            }
        }
    }
}