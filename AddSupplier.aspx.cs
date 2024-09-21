using ERPMIS331.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPMIS331
{
    public partial class AddSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SupplierFormView_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            // Retrieve the input values from the FormView
            string supplierName = e.Values["SupplierName"].ToString();
            string supplierAddress = e.Values["SupplierAddress"].ToString();
            string supplierEmail = e.Values["SupplierEmail"].ToString();
            string supplierPhoneNumber = e.Values["SupplierPhoneNumber"].ToString();

            // Insert the new product using Entity Framework
            using (var ctx = new MIS331_ERPContext())
            {
                var supplier = new ErpSupplier
                {
                    SupplierName = supplierName,
                    SupplierAddress = supplierAddress,
                    SupplierEmail = supplierEmail,
                    SupplierPhoneNumber = supplierPhoneNumber
                };

                ctx.ErpSupplier.Add(supplier);
                ctx.SaveChanges();
                lblMessage.Text = "Supplier added successfully!";

            }

            // Cancel the default FormView insert behavior
            e.Cancel = true;
        }
    }
}