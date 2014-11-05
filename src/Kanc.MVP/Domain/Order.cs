namespace Kanc.MVP.Domain
{
    public class Order
    {
        public Order(int id)
        {
            Id = id;
        }

        private OrderState state = OrderState.Open;
        
        public OrderState State
        {
            get { return state; }
        }

        public int Id { get; set; }

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
