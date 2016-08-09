using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indkoebskurv
{
    public class CartProduct
    {
        #region Fields
        private int id;
        private string name;
        private decimal price;
        private int amount;
        #endregion

        #region Properties
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public int Amount { get { return this.amount; } set { this.amount = value; } }
        public decimal TotalPrice { get { return this.price * this.amount; } }

        #endregion

        #region Constructors

        public CartProduct(int id, string name, decimal price, int amount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        #endregion

        #region Methods

        #endregion
    }
}