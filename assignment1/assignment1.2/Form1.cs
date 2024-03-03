namespace assignment1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(textBox1.Text);
            double number2 = double.Parse(textBox2.Text);
            double ans = 0;
            string op = comboBox1.Text;
            bool flag = true;
            switch (op)
            {
                case "+":
                    ans = number1 + number2;
                    break;
                case "-":
                    ans = number1 - number2;
                    break;
                case "*":
                    ans = number1 * number2;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        flag = false;
                        MessageBox.Show("第二个数字输入错误！");
                    }
                    else
                        ans = number1 / number2;
                    break;
                case "%":
                    ans = number1 % number2;
                    break;
                default:
                    MessageBox.Show("运算符输入错误！");
                    flag = false;  
                    break;
            }
            if (flag)
                MessageBox.Show(ans.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}