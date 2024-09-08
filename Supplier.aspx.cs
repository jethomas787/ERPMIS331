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


        }


    }
}