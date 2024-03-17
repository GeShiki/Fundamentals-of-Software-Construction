using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Rectangle:IShape
    {
        private double side1 = 0;
        private double side2 = 0;
        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
            }
        }
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
            }
        }
        public bool NotRectangle()
        {
            return !((side1 > 0) && (side2 > 0));
        }
        public Rectangle()
        {
            bool isR = NotRectangle();
            while (isR)
            {
                Console.WriteLine("请输入第一条边:");
                side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二条边:");
                side2 = double.Parse(Console.ReadLine());
                isR = NotRectangle();
                if (isR == false)
                {
                    break;
                }
                Console.WriteLine("输入错误，请再次输入！");
            }
        }
        public double calArea()
        {
            return side1 * side2;
        }
    }
}
