using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    public class OrderException : Exception
    {
        public OrderException(string message) : base(message) { }

    }
}
