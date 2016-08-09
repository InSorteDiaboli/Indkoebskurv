using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Indkoebskurv;

namespace Indkoebskurv
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_submit_Click(object sender, EventArgs e)
        {
            List<CartProduct> cart = new List<CartProduct>();
            //Her putter vi produkter i kurv klassen
        }
    }
}