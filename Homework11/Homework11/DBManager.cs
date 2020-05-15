using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class DBManager
    {
        static int newOrderID = 0;
        static int newItemID = 0;
        static public List<Order> LoadData()
        {
            List<Order> orders = new List<Order>() { };
            using (var context = new OrderServiceContext())
            {
                orders = Decoder(context.Orders);
            }
            return orders;
        }
        static List<Order> Decoder(IQueryable<DB_Order> query)
        {
            List<Order> orders = new List<Order>() { };
            foreach (var db_order in query)
            {
                Order order = new Order();
                order.ID = db_order.Order_ID;
                order.User.Name = db_order.Name;
                order.User.Address = db_order.Address;
                order.OrderTime = db_order.OrderTime;
                order.orderItems = GetItems(order.ID);
                orders.Add(order);
            }
            return orders;
        }
        static List<OrderItem> GetItems(int orderID)
        {
            List<OrderItem> items = new List<OrderItem>() { };
            using (var context = new OrderServiceContext())
            {
                var query = context.Items
                    .Where(i => i.OrderID == orderID);
                foreach (var db_item in query)
                {
                    OrderItem item = new OrderItem();
                    item.Goods.Name = db_item.Name;
                    item.Goods.Price = db_item.Price;
                    item.Quantity = db_item.Quantity;
                    items.Add(item);
                }
            }
            return items;
        }
        static public void AddOrder(Order newOrder)
        {
            using (var context = new OrderServiceContext())
            {
                var db_order = new DB_Order()
                {
                    Name = newOrder.Name,
                    Address = newOrder.Address,
                    OrderTime = newOrder.OrderTime,
                    OrderItems = new List<DB_OrderItem>() { }
                };
                context.Entry(db_order).State = EntityState.Added;
                context.SaveChanges();
                newOrderID = db_order.Order_ID;
            }
            //List<DB_OrderItem> DB_items = new List<DB_OrderItem>() { };
            foreach (OrderItem item in newOrder.orderItems)
            {
                AddItem(item, newOrderID);
            }
        }

        static void AddItem(OrderItem item, int orderID)
        {
            var db_item = new DB_OrderItem()
            {
                Name = item.Name,
                Price = item.Price,
                Quantity = item.Quantity,
                OrderID = orderID
            };
            using (var context = new OrderServiceContext())
            {
                context.Entry(db_item).State = EntityState.Added;
                context.SaveChanges();
                newItemID = db_item.ItemID;
            }
        }

        static public void DeleteOrder(int orderID)
        {
            using (var context = new OrderServiceContext())
            {
                var order = context.Orders.Include(o => o.OrderItems).FirstOrDefault(o => o.Order_ID == orderID);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        static public void ModifyOrder(Order newOrder)
        {
            using (var context = new OrderServiceContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.Order_ID == newOrder.ID);
                if (order != null)
                {
                    order.Name = newOrder.Name;
                    order.Address = newOrder.Address;
                    order.OrderTime = newOrder.OrderTime;
                    var query = context.Items
                        .Where(i => i.OrderID == newOrder.ID);
                    List<DB_OrderItem> items = query.ToList();
                    foreach (OrderItem item in newOrder.orderItems)
                    {
                        var db_item = new DB_OrderItem()
                        {
                            Name = item.Name,
                            Price = item.Price,
                            Quantity = item.Quantity,
                            OrderID = newOrder.ID
                        };
                        if (items.Contains(db_item)) continue;
                        AddItem(item, newOrder.ID);
                    }
                }
            }
        }

        static public Order InquireByID(int orderID)
        {
            List<Order> result;
            using (var context = new OrderServiceContext())
            {
                var query = context.Orders
                    .Where(o => o.Order_ID == orderID);
                result = Decoder(query);
            }
            if (result.Count == 0) return null;
            return result[0];
        }

        static public List<Order> InquireByCommodity(string commodityName)
        {
            List<Order> result;
            using (var context = new OrderServiceContext())
            {
                var query = from order in context.Orders
                            join item in context.Items on order.Order_ID equals item.ItemID
                            where item.Name.Contains(commodityName)
                            select order;
                result = Decoder(query);
            }
            if (result.Count == 0) return null;
            return result;
        }

        static public List<Order> InquireByCustomer(string customerName)
        {
            List<Order> result;
            using (var context = new OrderServiceContext())
            {
                var query = context.Orders
                    .Where(o => o.Name == customerName);
                result = Decoder(query);
            }
            if (result.Count == 0) return null;
            return result;
        }
    }
}
