using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public Goods Good { get; set; }
        private int quantity;
        public int Quantity
        { 
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("数量必须大于0!");
                }
                quantity = value;
            }
        }
        public double TotalPrice { get; }
        public OrderDetails(int id, Goods good, int quantity)
        {
            Id = id;    
            Good = good;
            Quantity = quantity;
            TotalPrice = Quantity * Good.Price;
        }
        public OrderDetails()
        {

        }
        public override string ToString()
        {
            return ($"订单货物:{Good.Name},数量:{Quantity},总价:{TotalPrice}。");
        }
        public override bool Equals(object? obj)
        {
            var od = obj as OrderDetails;
            return od != null && od.Good.Equals(Good) && od.Quantity == Quantity;
        }
        public override int GetHashCode()
        {
            return 2 * Good.GetHashCode();
        }
    }
}
