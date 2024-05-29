using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    public class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("价格必须大于0!");
                }
                price = value;
            }
        }
        public Goods(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public Goods()
        {

        }
        public override string ToString()
        {
            return ($"货物ID:{Id},货物名称:{Name},货物单价:{Price}。");
        }
        public override bool Equals(object? obj)
        {
            var g = obj as Goods;
            return (g != null && g.Id == Id);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode() + Price.GetHashCode();
        }
    }
}
