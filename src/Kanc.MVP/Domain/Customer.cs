using System.Collections.Generic;

namespace Kanc.MVP.Domain
{
    public class Customer
    {
        public static readonly List<Customer> AllCustomers = new List<Customer>();
        public readonly List<Order> Orders = new List<Order>();

        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Age { get; set; }
    }
}
