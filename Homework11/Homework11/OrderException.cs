using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    public class OrderException: Exception
    {
        public OrderException(string message) : base(message) { }

    }
}
