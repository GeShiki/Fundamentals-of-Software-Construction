using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Square:IShape
    {
        private double side = 0;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public bool NotSquare()
        {
            return !(side > 0);
        }
        public Square()
        {
            bool isS = NotSquare();
            while (isS)
            {
                Console.WriteLine("请输入边:");
                side = double.Parse(Console.ReadLine());
                isS = NotSquare();
                if (isS == false)
                {
                    break;
                }
                Console.WriteLine("输入错误，请再次输入！");
            }
        }
        public double calArea()
        {
            return side * side;
        }
    }
}
