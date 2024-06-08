using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Customer()
        {

        }
        public override string ToString()
        {
            return ($"客户ID:{Id},客户姓名:{Name}。");
        }
        public override bool Equals(object? obj)
        {
            Customer c = obj as Customer;
            return (c != null && c.Id == Id);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Id.GetHashCode();
        }
    }
}
