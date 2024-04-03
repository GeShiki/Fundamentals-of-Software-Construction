using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new ApplicationException("订单重复!");
            }
            orders.Add(order);
        }
        public void DeleteOrder(int id)
        {
            int index;
            try
            {
                index = orders.FindIndex(o => o.Id == id);
            }
            catch
            {
                throw new ApplicationException("ID错误!");
            }
            orders.RemoveAt(index);
        }
        public void UpdateOrder(Order order)
        {
            DeleteOrder(order.Id);
            AddOrder(order);
            Sort();
        }
        public void Sort()
        {
            orders.Sort();
        }
        public List<Order> QALL()
        {
            var query = orders.OrderBy(o => o.SumPrice);
            return query.ToList();
        }
        public List<Order>  QCustomer(string name)
        {
            var query = orders.Where(o => o.customer.Name == name)
                .OrderBy(o => o.SumPrice);
            return query.ToList();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            orders.ForEach(o => sb.Append(o.ToString() + "\n"));
            return sb.ToString();
        }
    }
}
