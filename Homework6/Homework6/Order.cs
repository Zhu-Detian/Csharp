using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Homework6
{
    [Serializable]
    public class Order : IComparable
    {
        public int ID { get; set; }
        public Customer User { get; set; }
        public DateTime OrderTime { get; set; }
        public List<OrderItem> orderItems;
        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (OrderItem item in orderItems)
                {
                    totalPrice += item.TotalPrice;
                }
                return totalPrice;
            }
        }

        public Order()
        {
            ID = 0;
            User = null;
            OrderTime = DateTime.Now;
            orderItems = null;
        }
        public Order(int id, Customer user, DateTime orderTime, List<OrderItem> orderItems)
        {
            ID = id;
            User = user;
            OrderTime = orderTime;
            this.orderItems = orderItems;
        }

        public override string ToString()
        {
            string span = "------------------------------------------------------------\n";
            string info = $"订单明细:\n订单号: {ID}\n下单时间: {OrderTime}\n顾客信息: {User}\n商品列表:\n";
            foreach (OrderItem item in orderItems)
            {
                info += item.ToString() + '\n';
            }
            info += $"订单总金额: {TotalPrice}\n";
            return span + info + span;
        }

        public override bool Equals(object obj)
        {
            Order objOrder = obj as Order;
            return objOrder != null && objOrder.ID == this.ID;
        }

        public int CompareTo(object obj)
        {
            Order objOrder = obj as Order;
            if (objOrder == null)
                throw new System.ArgumentException();
            return this.ID - objOrder.ID;
        }
    }
}