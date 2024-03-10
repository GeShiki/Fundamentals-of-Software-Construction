namespace assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度:");
            int length = Convert.ToInt32(Console.ReadLine());
            double[] arry = new double[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"请输入第{i + 1}个数:");
                arry[i] = Convert.ToDouble(Console.ReadLine());
            }
            Max(arry);
            Min(arry);
            Avg(arry);
            Total(arry);
        }
        static void Max(double[] arry)
        {
            double max = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                max = arry[i] > max ? arry[i] : max;
            }
            Console.WriteLine($"最大值是:{max}");
        }

        static void Min(double[] arry)
        {
            double min = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                min = arry[i] < min ? arry[i] : min;
            }
            Console.WriteLine($"最小值是:{min}");
        }

        static void Avg(double[] arry)
        {
            double avg = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                avg += arry[i];
            }
            avg = avg / arry.Length;
            Console.WriteLine($"平均值是:{avg}");
        }

        static void Total(double[] arry)
        {
            double total = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                total += arry[i];
            }
            Console.WriteLine($"总值是:{total}");
        }
    }
}