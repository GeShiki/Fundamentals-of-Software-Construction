using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Order:IComparable<Order>
    {
        private List<OrderDetails> details = new List<OrderDetails>();
        public int Id { get; set; }
        public Customer customer { get; set; }
        public double SumPrice
        {
            get { return details.Sum(d => d.TotalPrice); }
        }
        public Order(int id, Customer customer)
        {
            Id = id;
            this.customer = customer;
        }
        public Order()
        {

        }
        public void AddDetails(OrderDetails orderDetails)
        {
            if (details.Contains(orderDetails))
            {
                throw new ArgumentException("明细重复!");
            }
            details.Add(orderDetails);
        }
        public int CompareTo(Order other)
        {
            return (other == null) ? 1 : this.Id.CompareTo(other.Id);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"订单ID:{Id},");
            stringBuilder.Append(customer);
            stringBuilder.Append($"订单总价:{SumPrice},");
            details.ForEach(d => stringBuilder.Append(d.ToString()));
            return stringBuilder.ToString();
        }
        public override bool Equals(object? obj)
        {
            var o = obj as Order;
            return (o != null) && (o.Id == Id);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
