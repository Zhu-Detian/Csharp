using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class OrderService
    {
        private List<Order> orders;

        public OrderService(List<Order> orders)
        {
            this.orders = orders;
        }

        public void AppendOrder(Order newOrder)
        {
            foreach (Order order in orders)
            {
                if (order.Equals(newOrder))
                {
                    throw new OrderException(message: "添加失败，无法重复添加订单");
                }
            }
            orders.Add(newOrder);
        }

        public void Sort()
        {
            orders.Sort();
        }
        public void Sort(IComparer<Order> compare)
        {
            orders.Sort(compare);
        }

        public void Delete(int orderID)
        {
            foreach (Order order in orders)
            {
                if (order.ID == orderID)
                {
                    orders.Remove(order);
                    return;
                }
            }
            throw new OrderException(message: "删除失败，找不到对应订单");
        }

        public void Modify(Order newOrder)
        {
            foreach (Order order in orders)
            {
                if (order.Equals(newOrder))
                {
                    int index = orders.IndexOf(order);
                    orders[index] = newOrder;
                    return;
                }
            }
            throw new OrderException(message: "修改失败，找不到对应订单");
        }

        public Order InquireByID(int orderID)
        {
            var result = from order in orders
                         where order.ID == orderID
                         select order;
            if (result != null)
                return result.ToList()[0];
            return null;
        }

        public List<Order> InquireByCommodity(string commodityName)
        {
            var result = from order in orders
                         where order.orderItems.Exists(commodity => commodity.Goods.Name.Contains(commodityName))
                         select order;
            if (result == null) return null;
            return result.ToList();
        }

        public List<Order> InquireByCustomer(string customerName)
        {
            var result = from order in orders
                         where order.User.Name == customerName
                         select order;
            if (result == null) return null;
            return result.ToList();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\n所有订单：\n");
            foreach (Order order in orders)
            {
                builder.Append(order);
            }
            return builder.ToString();
        }
    }
}
