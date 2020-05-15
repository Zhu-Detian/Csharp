using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Homework8
{
    [Serializable]
    public class Commodity
    {
        public int CommodityID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Commodity()
        {
            Name = "null";
            Price = 0;
        }
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
