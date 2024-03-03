namespace assignment1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void answer_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(number1.Text);
            double n2 = double.Parse(number2.Text);
            double ans = 0;
            string op = operation.Text;
            bool flag = true;
            switch (op)
            {
                case "+":
                    ans = n1 + n2;
                    break;
                case "-":
                    ans = n1 - n2;
                    break;
                case "*":
                    ans = n1 * n2;
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        flag = false;
                        MessageBox.Show("第二个数字输入错误！");
                    }
                    else
                        ans = n1 / n2;
                    break;
                case "%":
                    ans = n1 % n2;
                    break;
                default:
                    MessageBox.Show("运算符输入错误！");
                    flag = false;
                    break;
            }
            if (flag)
                MessageBox.Show(ans.ToString());
        }

        private void number2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}