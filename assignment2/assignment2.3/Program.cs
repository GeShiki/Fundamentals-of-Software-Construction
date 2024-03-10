namespace assignment2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arry = new int[99];
            InitArry(ref arry);
            Solution(ref arry);
        }
        static void InitArry (ref int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = i + 2;
            }
        }
        static void DelPrime(ref int[] arry, int prime, int start)
        {
            for (int i = start + 1; i < arry.Length; i++)
            {
                if (arry[i] % prime == 0)
                {
                    arry[i] = 0;
                }
            }
        }
        static void Solution(ref int[] arry)
        {
            for (int i = 0; i < 10; i++)
            {
                int prime = arry[i];
                if (prime != 0)
                {
                    DelPrime(ref arry, prime, i);
                }
            }
            Console.WriteLine("素数有:");
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] != 0)
                {
                    Console.WriteLine(arry[i]);
                }
            }
        }
    }
}