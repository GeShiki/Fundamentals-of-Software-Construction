using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal static class Shapes
    {
        public static IShape ShapeIs(string whichShape)
        {
            IShape shape = null;
            switch(whichShape)
            {
                case "三角形":
                    shape = new Triangle();
                    break;
                case "长方形":
                    shape = new Rectangle();
                    break;
                case "正方形":
                    shape= new Square();
                    break;
                default:
                    Console.WriteLine("输入错误！");
                    break;
            }
            return shape;
        }
    }
}
