namespace assignment2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("素数因子是:");
            int testNum = 2;
            int primeFactor = 0;
            bool isPrime = true;
            while (testNum * testNum <= num)
            {
                if (num % testNum == 0 && primeFactor != testNum)
                {
                    Console.WriteLine(testNum);
                    primeFactor = testNum;
                    num = num / testNum;
                    isPrime = false;
                }
                else
                {
                    testNum++;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(num);
            }
        }
    }
}