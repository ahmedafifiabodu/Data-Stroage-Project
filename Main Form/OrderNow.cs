using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Assignment_4
{
    [Serializable]
    public class OrderNow
    {
        public XmlSerializer xml = new XmlSerializer(typeof(List<OrderNow>));

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