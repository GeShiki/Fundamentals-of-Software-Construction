using System.Xml.Schema;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "张三");
            Customer customer2 = new Customer(2, "李四");
            Goods phone = new Goods(1, "手机", 1000);
            Goods computer = new Goods(2, "电脑", 2000);
            Goods server = new Goods(3, "服务器", 3000);
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
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);
            Console.WriteLine("初始订单:");
            Console.Write(service.ToString());
            List<Order> zhangSanOrders = new List<Order>();
            zhangSanOrders = service.QCustomer("张三");
            Console.WriteLine("张三订单:");
            zhangSanOrders.ForEach(o => Console.WriteLine(o.ToString()));
            Order order4 = new Order(1, customer1);
            order4.AddDetails(details3);
            service.UpdateOrder(order4);
            Console.WriteLine("张三修改:");
            Console.Write(service);
            service.DeleteOrder(1);
            Console.WriteLine("张三删除:");
            Console.Write(service);
        }
    }
}