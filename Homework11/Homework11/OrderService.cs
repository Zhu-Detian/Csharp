using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace Homework8
{
    public class OrderService
    {
        public List<Order> orders = new List<Order> { } ;
        
        public OrderService()
        {
            this.orders = new List<Order> { };
        }
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
            DBManager.AddOrder(newOrder);
        }

        public void Sort()
        {
            orders.Sort();
        }
        public void Sort(Func <Order, Order, int> func)
        {
            orders.Sort((o1, o2) => func(o1, o2));
        }

        public void Delete(int orderID)
        {
            foreach (Order order in orders)
            {
                if (order.ID == orderID)
                {
                    orders.Remove(order);
                    DBManager.DeleteOrder(orderID);
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
                    DBManager.ModifyOrder(newOrder);
                    return;
                }
            }
            throw new OrderException(message: "修改失败，找不到对应订单");
        }

        /*public List<Order> InquireByCommodity(string commodityName)
        {
            var result = from order in orders
                         where order.orderItems.Exists(commodity => commodity.Goods.Name.Contains(commodityName))
                         orderby order.TotalPrice
                         select order;
            var resultList = result.ToList();
            if (resultList.Count == 0) return null;
            return resultList;
        }

        public List<Order> InquireByCustomer(string customerName)
        {
            var result = from order in orders
                         where order.User.Name == customerName
                         orderby order.TotalPrice
                         select order;
            var resultList = result.ToList();
            if (resultList.Count == 0) return null;
            return resultList;
        }*/

        public void Export(string name)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(name, FileMode.Create))
            {
                xmlserializer.Serialize(fs, this.orders);
            }
        }
        public void Import(string name)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(name, FileMode.Open))
            {
                this.orders = (List<Order>)xmlserializer.Deserialize(fs);
            }
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
