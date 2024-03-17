using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Triangle : IShape
    {
        private double side1 = 0;
        private double side2 = 0;
        private double side3 = 0;
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
        public double Side3
        {
            get 
            { 
                return side3;
            }
            set
            {
                side3 = value;
            }
        }
        public bool NotTriangle()
        {
            return !((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2) && (side1 > 0) && (side2 > 0) && (side3 > 0));
        }
        public Triangle()
        {
            bool isT = NotTriangle();
            while (isT)
            {
                Console.WriteLine("请输入第一条边:");
                side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二条边:");
                side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第三条边:");
                side3 = double.Parse(Console.ReadLine());
                isT = NotTriangle();
                if (isT == false)
                {
                    break;
                }
                Console.WriteLine("输入错误，请再次输入！");
            }
        }
        public double calArea()
        {
            double area = 0;
            double p = (side1 + side2 + side3) / 2;
            area = System.Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return area;
        }
    }
}
