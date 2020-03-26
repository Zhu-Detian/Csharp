using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Commodity
    {
        public string Name { get; }
        public double Price { get; }
        public Commodity(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "商品名: " + Name + " 单价: " + Price;
        }
    }
}