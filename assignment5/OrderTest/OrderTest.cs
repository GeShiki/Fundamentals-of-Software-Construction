using assignment5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace OrderTest
{
    [TestClass]
    public class OrderTest
    {
        Customer customer1 = new Customer(1, "张三");
        Customer customer2 = new Customer(2, "李四");
        Goods phone = new Goods(1, "手机", 1000);
        Goods computer = new Goods(2, "电脑", 2000);
        Goods server = new Goods(3, "服务器", 3000);
        OrderService service = new OrderService();
        [TestInitialize]
        public void Init()
        {
            OrderDetails details1 = new OrderDetails(phone, 10);
            OrderDetails details2 = new OrderDetails(computer, 2);
            OrderDetails details3 = new OrderDetails(server, 1);
            OrderDetails details4 = new OrderDetails(phone, 3);
            Order order1 = new Order(1, customer1);
            order1.AddDetails(details3);
            order1.AddDetails(details1);
            Order order2 = new Order(2, customer2);
            order2.AddDetails(details1);
            order2.AddDetails(details2);
            order2.AddDetails(details3);
            Order order3 = new Order(3, customer1);
            order3.AddDetails(details2);
            order3.AddDetails(details4);
            service.AddOrder(order1);
        }
        [TestMethod]
        public void AddOrderTest()
        {
            OrderDetails details = new OrderDetails(phone, 1000);
            Order order = new Order(4, customer1);
            order.AddDetails(details);
            service.AddOrder(order);
            List<Order> orders = new List<Order>();
            orders = service.QALL();
            Assert.IsNotNull(orders);
            Assert.AreEqual(2, orders.Count);
            CollectionAssert.Contains(orders, order);
        }
        [TestMethod]
        public void DeleteOrderTest()
        {
            service.DeleteOrder(1);
            List<Order> orders = new List<Order>();
            orders = service.QALL();
            Assert.AreEqual(0, orders.Count);
        }

        [TestMethod]
        public void UpdateOrderTest()
        {
            Order order = new Order(1, customer1);
            OrderDetails details = new OrderDetails(phone, 1000);
            service.UpdateOrder(order);
            List<Order> orders = new List<Order>();
            orders = service.QALL();
            Assert.IsNotNull(orders);
            Assert.AreEqual(1, orders.Count);
            Assert.AreEqual(order, orders[0]);
        }
        [TestMethod]
        public void QCustomerTest()
        {
            OrderDetails details = new OrderDetails(phone, 1000);
            Order order = new Order(4, customer2);
            order.AddDetails(details);
            service.AddOrder(order);
            Assert.AreEqual(1, service.QCustomer("张三").Count);
        }
    }
}