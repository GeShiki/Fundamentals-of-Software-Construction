using System.Collections.Specialized;

namespace assignment4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Action<List<int>> Solution = (list => 
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                int max = list.Max();
                Console.WriteLine($"最大值:{max}");
                int min = list.Min();
                Console.WriteLine($"最小值:{min}");
                int sum = list.Sum();
                Console.WriteLine($"和:{sum}");
            });
            Solution(list);
        }
    }
}