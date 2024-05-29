using System.ComponentModel;

namespace assignment6
{
    public partial class MainForm : Form
    {
        OrderService service = new OrderService();
        public MainForm()
        {
            InitializeComponent();
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
            service.AddOrder(order1);
            service.AddOrder(order2);
            service.AddOrder(order3);
            bsO.DataSource = service.QALL();
        }

        public MainForm(OrderService service)
        {
            InitializeComponent();
            this.service = service;
           bsO.DataSource = service.QALL();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbService.Text == "添加")
            {
                EditForm editForm = new EditForm(service);
                editForm.Show();
                this.Hide();
            }
            else if (cbService.Text == "删除")
            {
                Order order = bsO.Current as Order;
                service.DeleteOrder(order.Id);
                bsO.DataSource = service.QALL();
                bsO.ResetBindings(false);
            }
            else if (cbService.Text == "修改")
            {
                Order order = bsO.Current as Order;
                UpdateForm updateForm = new UpdateForm(service,order);
                updateForm.Show();
                this.Hide();
            }
            else
            {
                if (cbQtype.Text == "全部")
                {
                    bsO.DataSource = service.QALL();
                    bsO.ResetBindings(false);
                }
                else
                {
                    bsO.DataSource = service.QCustomer(tbName.Text);
                    bsO.ResetBindings(false);
                }
            }
        }
    }
}