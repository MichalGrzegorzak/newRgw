using System.Security.Cryptography;

namespace Kanc.MVP.Domain
{
    public class Rozliczenie
    {
        public Rozliczenie(int id, string desc)
        {
            Id = id;
            Desc = desc;
        }

        private OrderState state = OrderState.Open;
        
        public OrderState State
        {
            get { return state; }
        }

        public int Id { get; set; }
        public string Desc { get; set; }

        public void Accept()
        {
            if (State == OrderState.Open)
                state = OrderState.Pending;
        }

        public void Ship()
        {
            if (State == OrderState.Pending)
                state = OrderState.Shipped;
        }

        public void Cancel()
        {
            if (State != OrderState.Shipped)
                state = OrderState.Cancelled;
        }
    }
}
