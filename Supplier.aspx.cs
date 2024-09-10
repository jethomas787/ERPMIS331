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

           // IQueryable<ERPMIS331.Models.ErpSupplier> test = data.AsQueryable();
            //return test;

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            SupplierGrid_GetData();
        }
        
        protected void RowCancelingEdit(object sender, GridViewCancelEditEventArgs e) {  
            GridView1.EditIndex = -1;  
            SupplierGrid_GetData();  
        } 
        
        protected void RowUpdating(object sender, GridViewUpdateEventArgs e) {  
            
            Int SupplierID = (int)e.Keys["SupplierID"];
            String SupplierName = e.Keys["SupplierName"].ToString();
            String SupplierAddress = e.Keys["SupplierAddress"].ToString();
            String SupplierEmail= e.Keys["SupplierEmail"].ToString();
            String SupplierPhoneNumber = e.Keys["SupplierPhoneNumber"].ToString();
            
            MIS331_ERPContext context = new MIS331_ERPContext();
            context.ErpSupplier.FromSqlRaw("Update ")
            
            short supplierID = (short)Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());  
            GridViewRow row = (GridViewRow) GridView1.Rows[e.RowIndex];  
            //TextBox txtname=(TextBox)gr.cell[].control[];  
            TextBox textName = (TextBox) row.Cells[0].Controls[0];  
            TextBox textadd = (TextBox) row.Cells[1].Controls[0];  
            TextBox textc = (TextBox) row.Cells[2].Controls[0];  
            //TextBox textadd = (TextBox)row.FindControl("txtadd");  
            //TextBox textc = (TextBox)row.FindControl("txtc");  
            GridView1.EditIndex = -1;  
            conn.Open();  
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
            SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);  
            cmd.ExecuteNonQuery();  
            conn.Close();  
            gvbind();  
            //GridView1.DataBind(); 


    }
}