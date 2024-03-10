namespace assignment2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入行数:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入列数:");
            int line = int.Parse(Console.ReadLine());
            int[,] arry = new int[row, line];
            InitArry(ref arry, row, line);
            if (IsT(ref arry, row, line))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static void InitArry(ref int[,] arry, int row, int line)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    Console.WriteLine($"请输入第{i + 1}行，第{j + 1}列的数:");
                    arry[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static bool IsT(ref int[,] arry, int row, int line)
        {
            for (int i = 0; i < row; i++)
            {
                int rowI = i;
                int lineI = 0;
                while (rowI < row && lineI < line)
                {
                    if (arry[rowI,lineI] != arry[i,0])
                    {
                        return false;
                    }
                    rowI++;
                    lineI++;
                }
            }
            for (int i = 0; i < line; i++)
            {
                int rowI = 0;
                int lineI = i;
                while (rowI < row && lineI < line)
                {
                    if (arry[rowI, lineI] != arry[0, i])
                    {
                        return false;
                    }
                    rowI++;
                    lineI++;
                }
            }
            return true;
        }
    }
}