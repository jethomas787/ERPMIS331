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
using System.Runtime.InteropServices.ComTypes;


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

        public void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            short id = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            using(var context = new MIS331_ERPContext())
            {
                var entity = context.ErpSupplier.Find(id);
                if(entity != null)
                {
                   context.ErpSupplier.Remove(entity);
                   context.SaveChanges();
                }

            }
           
            SupplierGrid_GetData();
        }

        public void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddNewRow")
            {
                GridViewRow footerRow = GridView1.FooterRow;
                TextBox txtNewSupplierName = (TextBox)footerRow.FindControl("txtNewSupplierName");
                TextBox txtNewSupplierAddress = (TextBox)footerRow.FindControl("txtNewSupplierAddress");
                TextBox txtNewSupplierEmail = (TextBox)footerRow.FindControl("txtNewSupplierEmail");
                TextBox txtNewSupplierPhone = (TextBox)footerRow.FindControl("txtNewSupplierPhone");


                if (!string.IsNullOrEmpty(txtNewSupplierName.Text) && !string.IsNullOrEmpty(txtNewSupplierAddress.Text)
                    && !string.IsNullOrEmpty(txtNewSupplierEmail.Text) && !string.IsNullOrEmpty(txtNewSupplierPhone.Text))
                    using (MIS331_ERPContext ctx = new MIS331_ERPContext())
                    {
                        ErpSupplier supplier = new ErpSupplier()
                        {
                            SupplierName = txtNewSupplierName.Text,
                            SupplierEmail = txtNewSupplierEmail.Text,
                            SupplierAddress = txtNewSupplierAddress.Text,
                            SupplierPhoneNumber = txtNewSupplierPhone.Text
                        };
                        ctx.ErpSupplier.Add(supplier);
                        ctx.SaveChanges();
                    }
                SupplierGrid_GetData();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
              /*  if (e.Row.DataItem == null)
                {
                    e.Row.Visible = false;
                }*/
            }
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