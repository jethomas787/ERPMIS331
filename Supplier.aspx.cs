using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ERPMIS331.Models;
using System.Data.Entity;


namespace ERPMIS331
{
    public partial class Supplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SupplierGrid_GetData();
            }
        }

        public void SupplierGrid_GetData()
        {
            MIS331_ERPContext context = new MIS331_ERPContext();
            var data = context.ErpSupplier.ToList();
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            SupplierGrid_GetData();
        }

        public void SupplierGrid_UpdateData(int supplierID)
        {
            using (MIS331_ERPContext db = new MIS331_ERPContext())
            {
                ErpSupplier supplier = null;
                supplier = db.ErpSupplier.Find(supplierID);
                if (supplier == null)
                {
                    ModelState.AddModelError("",
                      String.Format("Supplier with id {0} was not found", supplier));
                    return;
                }

                TryUpdateModel(supplier);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }


    }
}