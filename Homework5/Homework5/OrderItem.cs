using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class OrderItem
    {
        public Commodity Goods { get; }
        public int Quantity { get; }
        public double TotalPrice { get { return Goods.Price * Quantity; } }

        public OrderItem(Commodity goods, int quantity)
        {
            Goods = goods;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Goods.ToString() + " 数量: " + Quantity + " 总价: " + TotalPrice;
        }
    }
}
