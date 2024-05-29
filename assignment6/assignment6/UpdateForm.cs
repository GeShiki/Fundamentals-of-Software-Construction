using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace assignment6
{
    public partial class UpdateForm : Form
    {
        OrderService orderService;
        Order order;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(OrderService orderService, Order order)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.order = order;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer(1, "张三");
            Customer customer2 = new Customer(2, "李四");
            Goods phone = new Goods(1, "手机", 1000);
            Goods computer = new Goods(2, "电脑", 2000);
            Goods server = new Goods(3, "服务器", 3000);
            if (cbGoods.Text == "手机")
            {
                OrderDetails orderDetails = new OrderDetails(phone, int.Parse(tbNumber.Text));
                order.AddDetails(orderDetails);
            }
            else if (cbGoods.Text == "电脑")
            {
                OrderDetails orderDetails = new OrderDetails(computer, int.Parse(tbNumber.Text));
                order.AddDetails(orderDetails);
            }
            else
            {
                OrderDetails orderDetails = new OrderDetails(server, int.Parse(tbNumber.Text));
                order.AddDetails(orderDetails);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            orderService.UpdateOrder(order);
            MainForm mainForm = new MainForm(orderService);
            mainForm.Show();
            this.Hide();
        }
    }
}
