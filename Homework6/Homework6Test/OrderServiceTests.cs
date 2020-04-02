
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        static Customer customer1 = new Customer("czz", "Zhongshan");
        static Customer customer2 = new Customer("xjt", "Wuhan");
        static OrderItem orderitem1 = new OrderItem(new Commodity("apple", 5.5), 10);
        static OrderItem orderitem2 = new OrderItem(new Commodity("banana", 7), 15);
        static OrderItem orderitem3 = new OrderItem(new Commodity("pear", 10), 17);
        static Order order1 = new Order(1, customer1, new DateTime(2020, 3, 31), new List<OrderItem> { orderitem1, orderitem2 });
        static Order order2 = new Order(2, customer2, new DateTime(2020, 3, 31), new List<OrderItem> { orderitem3, orderitem2 });
        static Order order3 = new Order(3, customer1, new DateTime(2020, 3, 31), new List<OrderItem> { orderitem1, orderitem3 });
        OrderService service = new OrderService();

        [TestInitialize()]
        public void initial()
        {
            service = new OrderService(new List<Order> { order1, order2, order3 });
        }

        [TestMethod()]
        public void AppendOrderTest()
        {
            //OrderService service = new OrderService();
            Order order4 = new Order(4, customer1, DateTime.Now, new List<OrderItem> { orderitem1, orderitem3 });
            service.AppendOrder(order4);
            CollectionAssert.Contains(service.orders, order4);
        }
        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void AppendOrderTestException()
        {
            Order order5 = new Order(2, customer1, DateTime.Now, new List<OrderItem> { orderitem1, orderitem3 });
            service.AppendOrder(order5);
        }

        [TestMethod()]
        public void SortTest()
        {
            service.Sort();
            CollectionAssert.AreEqual(service.orders, new List<Order> { order1, order2, order3 });
        }

        [TestMethod()]
        public void SortTest1()
        {
            service.Sort((o1, o2) => o2.ID - o1.ID);
            CollectionAssert.AreEqual(service.orders, new List<Order> { order3, order2, order1 });
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void DeleteTestException()
        {
            service.Delete(4);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            service.Delete(3);
            Assert.AreEqual(2, service.orders.Count);
        }

        [TestMethod()]
        public void ModifyTest()
        {
            order2 = new Order(2, customer2, DateTime.Now, new List<OrderItem> { orderitem1, orderitem3 });
            service.Modify(order2);
            CollectionAssert.Contains(service.orders, order2);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void ModifyTestException()
        {
            Order order6 = new Order(4, customer1, DateTime.Now, new List<OrderItem> { orderitem1, orderitem3 });
            service.Modify(order6);
        }

        [TestMethod()]
        public void InquireByIDTest()
        {
            Order result = service.InquireByID(2);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, order2);
            result = service.InquireByID(4);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void InquireByCommodityTest()
        {
            List<Order> result = service.InquireByCommodity("apple");
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(result, new List<Order> { order1, order3 });
            result = service.InquireByCommodity("pineapple");
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void InquireByCustomerTest()
        {
            List<Order> result = service.InquireByCustomer("czz");
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(result, new List<Order> { order1, order3 });
            result = service.InquireByCustomer("test");
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void ExportTest()
        {
            service.Export("orders.xml");
            Assert.IsTrue(File.Exists("orders.xml"));
            List<string> expect = File.ReadLines("expectedOrders.xml").ToList();
            List<string> output = File.ReadLines("orders.xml").ToList();
            Assert.AreEqual(expect.Count, output.Count);
            for (int i = 0; i < expect.Count; i++)
            {
                Assert.AreEqual(expect[i].Trim(), output[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService os = new OrderService();
            os.Import("expectedOrders.xml");
            Assert.AreEqual(3, os.orders.Count);
        }
    }
}