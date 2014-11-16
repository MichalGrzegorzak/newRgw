using System.Collections.Generic;

namespace Kanc.MVP.Domain
{
    public class OsobaLookup
    {
        public static readonly List<OsobaLookup> AllCustomers = new List<OsobaLookup>();
        public readonly List<Rozliczenie> Orders = new List<Rozliczenie>();

        public OsobaLookup(string name)
        {
            Id = 0;
            Name = name;
            Orders = new List<Rozliczenie>();
        }
        
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        //public bool IsValid()
        //{
            
        //}
    }
}
