using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Homework8
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            Name = "";
            Address = "";
        }
        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return "姓名: " + Name + " 地址: " + Address;
        }
    }
}
