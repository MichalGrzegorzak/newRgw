using System.Collections.Generic;

namespace Kanc.MVP.Domain
{
    public class Customer
    {
        public static readonly List<Customer> AllCustomers = new List<Customer>();
        public readonly List<Order> Orders = new List<Order>();
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
