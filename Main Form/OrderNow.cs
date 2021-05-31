using System;

namespace Assignment_4
{
    [Serializable]
    public class OrderNow
    {
        public string name;
        public string price;
        public decimal quantity;

        public OrderNow()
        {
        }

        public OrderNow(string name, string price, decimal quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}