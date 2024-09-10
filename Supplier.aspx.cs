using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ERPMIS331.Models;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;


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
        public void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            SupplierGrid_GetData();
        }

        public void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            SupplierGrid_GetData();
        }

        public void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
      
            short id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];

            TextBox txtSupplierName = (TextBox)row.Cells[2].Controls[0];
            TextBox txtSupplierAddress = (TextBox)row.Cells[3].Controls[0];
            TextBox txtSupplierEmail = (TextBox)row.Cells[4].Controls[0];
            TextBox txtSupplierPhone = (TextBox)row.Cells[5].Controls[0];

            string newSupplierName = txtSupplierName.Text;
            string newSupplierAddress = txtSupplierAddress.Text;
            string newSupplierEmail = txtSupplierEmail.Text;
            string newSupplierPhoneNumber = txtSupplierPhone.Text; 

            using (var context = new MIS331_ERPContext())
            {
                var entity = context.ErpSupplier.Find(id);

                if (entity != null)
                {
                    entity.SupplierName = newSupplierName;
                    entity.SupplierAddress = newSupplierAddress;
                    entity.SupplierEmail = newSupplierEmail;
                    entity.SupplierPhoneNumber = newSupplierPhoneNumber;
                    context.SaveChanges();
                }
            }

            GridView1.EditIndex = -1;
            SupplierGrid_GetData();
        }
    }
}