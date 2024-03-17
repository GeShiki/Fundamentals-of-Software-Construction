namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalArea = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("请输入形状:");
                string shapeName = Console.ReadLine();
                IShape S = Shapes.ShapeIs(shapeName);
                while (S == null)
                {
                    Console.WriteLine("再次输入:");
                    shapeName = Console.ReadLine();
                    S = Shapes.ShapeIs(shapeName);
                }
                totalArea += S.calArea();
            }
            Console.WriteLine($"总面积是:{totalArea}。");
        }
    }
}