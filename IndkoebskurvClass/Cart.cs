using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indkoebskurv
{
    [Serializable]
    public class Cart
    {
        private List<CartProduct> items;

        public Cart()
        {

            this.items = GrabCart();

        }

        public List<CartProduct> Items { get { return this.items; } }

        private List<CartProduct> GrabCart()
        {
            List<CartProduct> cart = new List<CartProduct>();

            if (HttpContext.Current.Session["Cart"] == null)
            {
                HttpContext.Current.Session.Add("Cart", cart);
            }

            cart = HttpContext.Current.Session["Cart"] as List<CartProduct>;
            return cart;
        }

        public void AddToCart(int id, string name, decimal price, int amount, string image)
        {


            CartProduct product = findProduct(id);
            if (product.Id != 0)
            {
                product.Amount += amount;
            }

            else
            {
                this.items.Add(new CartProduct
                    (id, name, price, amount, image));
            }
        }


        public void removeProduct(int id)
        {
            CartProduct item = findProduct(id);

            if (item.Id != 0)
            {
                this.items.Remove(item);
            }
        }

        public void RemoveCart()
        {
            if (HttpContext.Current.Session["Cart"] != null)
            {
                HttpContext.Current.Session.Remove("Cart");

            } this.items = new List<CartProduct>();
        }

        public void SetAmountOnProduct(int id, int newAmount)
        {
            CartProduct item = findProduct(id);
            item.Amount = newAmount;

        }

        public void addAmountOnProduct(int id, int amountToAdd)
        {
            CartProduct item = findProduct(id);
            item.Amount += amountToAdd;
        }

        public void reduceAmountOnProduct(int id, int amountToReduce)
        {
            CartProduct item = findProduct(id);
            if (item.Amount <= 1)
            {
                removeProduct(id);
            }
            else
            {
                item.Amount -= amountToReduce;
            }
        }

        public CartProduct findProduct(int id)
        {
            foreach (CartProduct product in this.items)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return new CartProduct();
        }

        public decimal vatOnAllProducts
        {
            get { 
                decimal totalVat = 0;
                foreach (CartProduct product in this.items)
                {
                    totalVat += product.Vat;
                }
                return totalVat;
            }
        }

        public decimal priceOnAllProducts
        {
            get
            {
                decimal totalPrice = 0;
                foreach (CartProduct product in this.items)
                {
                    totalPrice += product.TotalPrice;
                }
                return totalPrice;
            }
        }

    }
}