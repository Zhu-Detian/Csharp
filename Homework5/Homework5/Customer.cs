using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Customer
    {
        public string Name { get; }
        public string Address { get; }
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