using System.Collections.Generic;

namespace Kanc.MVP.Domain
{
    public class Customer
    {
        public static readonly List<Customer> AllCustomers = new List<Customer>();
        public readonly List<Order> Orders = new List<Order>();

        public Customer(string name)
        {
            Id = 0;
            Name = name;
            Orders = new List<Order>();
        }
        
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        //public bool IsValid()
        //{
            
        //}
    }
}
