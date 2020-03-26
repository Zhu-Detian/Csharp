
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class OrderException : Exception
    {
        public OrderException(string message) : base(message) { }

    }
}
