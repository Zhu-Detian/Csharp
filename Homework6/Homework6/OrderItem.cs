
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Homework6
{
    [Serializable]
    public class OrderItem
    {
        public Commodity Goods { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get { return Goods.Price * Quantity; } }

        public OrderItem()
        {
            Goods = null;
            Quantity = 0;
        }
        public OrderItem(Commodity goods, int quantity)
        {
            Goods = goods;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null && item.Goods.Name == Goods.Name;
        }
        public override string ToString()
        {
            return Goods.ToString() + " 数量: " + Quantity + " 总价: " + TotalPrice;
        }
    }
}