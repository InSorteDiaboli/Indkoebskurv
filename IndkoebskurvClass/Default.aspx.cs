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
            cart = GrabCart(cart);
            AddToCart(cart);
            ShowCart(cart);

            //cart = (List<CartProduct>)Session["Cart"]; <-- anden metode
            //Her putter vi produkter i kurv klassen
        }

        private void ShowCart(List<CartProduct> cart)
        {
            gv_cart.DataSource = cart;
            gv_cart.DataBind();
        }

        private void AddToCart(List<CartProduct> cart)
        {
            bool newProduct = true;

            foreach (CartProduct product in cart)
            {
                if(product.Id == Convert.ToInt32(tb_id.Text))
                {
                    newProduct = false;
                    product.Amount += Convert.ToInt32(tb_amount.Text);
                    //update
                }
            }

            if (newProduct)
            {
                cart.Add(new CartProduct
                    (Convert.ToInt32(tb_id.Text),
                    tb_name.Text,
                    Convert.ToDecimal(tb_price.Text),
                    Convert.ToInt32(tb_amount.Text)
                    ));
            }
        }

        private List<CartProduct> GrabCart(List<CartProduct> cart)
        {
            if (Session["Cart"] == null)
            {
                Session.Add("Cart", cart);
            }

            cart = Session["Cart"] as List<CartProduct>;
            return cart;
        }

        protected void Btn_empty_Click(object sender, EventArgs e)
        {
            if(Session["Cart"] != null)
            {
                Session.Remove("Cart");
                
                
            }

        }
    }
}