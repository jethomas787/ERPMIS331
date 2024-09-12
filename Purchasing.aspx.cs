using ERPMIS331.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPMIS331
{
    public partial class Purchasing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadPurchaseFile(object sender, EventArgs e)
        {
            if (filePurchase.HasFile)
            {
                var purchase = new ErpPurchase();

            }


        }
    }
}