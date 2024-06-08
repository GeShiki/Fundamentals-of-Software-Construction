using System.Windows.Forms;
using System;
using Microsoft.EntityFrameworkCore;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Customer customer1 = new Customer(1, "张三");
            Customer customer2 = new Customer(2, "李四");
            Goods phone = new Goods(1, "手机", 1000);
            Goods computer = new Goods(2, "电脑", 2000);
            Goods server = new Goods(3, "服务器", 3000);
            OrderDetails details1 = new OrderDetails(1, phone, 10);
            OrderDetails details2 = new OrderDetails(2, computer, 2);
            OrderDetails details3 = new OrderDetails(3, server, 1);
            OrderDetails details4 = new OrderDetails(4, phone, 3);
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
            using (var context = new OrderDbContext())
            {
                context.Database.EnsureCreated();
                context.orders.Add(order1);
                context.orders.Add(order2);
                context.orders.Add(order3);
                context.SaveChanges();
                context.orders.Load();
                bsO.DataSource = context.orders.Local.ToBindingList();
                bsO.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new OrderDbContext())
            {
                context.Database.EnsureCreated();
                var user = context.orders.FirstOrDefault(o => o.Id == int.Parse(textBox1.Text));
                if (user != null)
                {
                    MessageBox.Show("User queried.");
                    bsO.DataSource = context.orders.Local.ToBindingList();
                    bsO.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Order not found.");
                }
            }
        }
    }
}