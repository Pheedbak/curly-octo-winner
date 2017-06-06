using System;
using System.Collections.Generic;

namespace CheckMe
{
    public class Checkout
    {

        private Dictionary<int, Item> shoppingCart = new Dictionary<int, Item>();

        private List<Item> stock = new List<Item> { new Item { Sku = 123 } };
        public void AddToCart(Item item)
        {
            throw new NotImplementedException();
        }

        public decimal Total()
        {
            return 121;
        }

        public void AddToCart(int sku, int quantity)
        {
            if (shoppingCart.ContainsKey(sku))
            {
                shoppingCart[sku].Quantity += quantity;
            }
            shoppingCart.Add(sku,GetItem(sku));

        }

        private Item GetItem(int sku)
        {
            throw new NotImplementedException();
        }
    }
}