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
        private Cart cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            cart = new Cart();
        }

        protected void Btn_submit_Click(object sender, EventArgs e)
        {
            cart.AddToCart(
                Convert.ToInt32(tb_id.Text), 
                tb_name.Text, 
                Convert.ToDecimal(tb_price.Text), 
                Convert.ToInt32(tb_amount.Text),
                "~/img/logo.png"
                );

            CartView_Design.Refresh();

            //ShowCart(cart.Items);

            //cart = (List<CartProduct>)Session["Cart"]; <-- anden metode
            //Her putter vi produkter i kurv klassen
        }

        protected void Btn_empty_Click(object sender, EventArgs e)
        {
            cart.RemoveCart();
            CartView_Design.Refresh();
        }
    }
}