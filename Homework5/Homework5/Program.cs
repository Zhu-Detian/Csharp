
using System;
using System.Collections.Generic;

namespace Homework5
{
    class Program
    {
        static Order InputOrder()
        {
            Console.Write("请输入订单号：");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入顾客姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入顾客地址：");
            string address = Console.ReadLine();
            Customer customer = new Customer(name, address);
            Console.Write("请输入不同商品的数量：");
            int totalCommodity = Convert.ToInt32(Console.ReadLine());
            List<OrderItem> orderItems = new List<OrderItem>();
            for (int i = 1; i <= totalCommodity; i++)
            {
                Console.Write("请输入商品名：");
                string commodityName = Console.ReadLine();
                Console.Write("请输入商品单价：");
                double commodityPrice = Convert.ToDouble(Console.ReadLine());
                Commodity commodity = new Commodity(commodityName, commodityPrice);
                Console.Write("请输入该商品的数量：");
                int quantity = Convert.ToInt32(Console.ReadLine());
                OrderItem orderItem = new OrderItem(commodity, quantity);
                orderItems.Add(orderItem);
            }
            Order order = new Order(id, customer, DateTime.Now, orderItems);
            return order;
        }
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService(new List<Order>());
            Console.Write("请输入订单数量：");
            int totalOrder = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= totalOrder; i++)
            {
                Order order = InputOrder();
                try
                {
                    orderService.AppendOrder(order);
                    Console.WriteLine("\n已添加订单:");
                    Console.WriteLine(order);
                }
                catch (OrderException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            int op = 0;
            while (op < 8)
            {
                Console.WriteLine("请选择要执行的操作：\n1.添加订单 2.删除订单 3.打印订单 4.按订单号排序 5.按订单号查询 6.按商品查询 7.按顾客姓名查询 8.退出\n");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Order order = InputOrder();
                            try
                            {
                                orderService.AppendOrder(order);
                                Console.WriteLine("\n已添加订单:");
                                Console.WriteLine(order);
                            }
                            catch (OrderException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("请输入订单号：");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                orderService.Delete(id);
                                Console.WriteLine($"成功删除 {id} 号订单");
                            }
                            catch (OrderException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(orderService);
                            break;
                        }
                    case 4:
                        {
                            orderService.Sort();
                            break;
                        }
                    case 5:
                        {
                            Console.Write("请输入订单号：");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Order order = orderService.InquireByID(id);
                            if (order != null)
                            {
                                Console.WriteLine("\n查询结果:");
                                Console.WriteLine(order);
                            }
                            else Console.WriteLine("没有查找到订单");
                            break;
                        }
                    case 6:
                        {
                            Console.Write("请输入商品名：");
                            string name = Console.ReadLine();
                            List<Order> result = orderService.InquireByCommodity(name);
                            if (result != null)
                            {
                                result.Sort((a, b) => Convert.ToInt32(a.TotalPrice - b.TotalPrice));
                                OrderService temp = new OrderService(result);
                                Console.WriteLine("\n查询结果:");
                                Console.WriteLine(temp);
                            }
                            else Console.WriteLine("没有查找到订单");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("请输入顾客姓名：");
                            string name = Console.ReadLine();
                            List<Order> result = orderService.InquireByCustomer(name);
                            if (result != null)
                            {
                                result.Sort((a, b) => Convert.ToInt32(a.TotalPrice - b.TotalPrice));
                                OrderService temp = new OrderService(result);
                                Console.WriteLine("\n查询结果:");
                                Console.WriteLine(temp);
                            }
                            else Console.WriteLine("没有查找到订单");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("退出程序");
                            break;
                        }
                }
            }
        }
    }
}