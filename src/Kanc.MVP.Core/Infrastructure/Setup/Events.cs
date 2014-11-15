using NHibernate.Event;
using NHibernate.Event.Default;

namespace Kanc.MVP.Core.Infrastructure.Setup
{
    /// <summary>
    /// Ustawia domyslne obiekty, jesli zaladowano NULL`a z bazy
    /// </summary>
    public class LoadedEvent : DefaultPostLoadEventListener
    {
        public override void OnPostLoad(PostLoadEvent @event)
        {
            base.OnPostLoad(@event);
            //if (@event.Entity is Rachunek_A && ((Rachunek_A)@event.Entity).KlientA == null)
            //{
            //    ((Rachunek_A)@event.Entity).KlientA = DataBindingFactory.Create<Klient_A>();
            //}
            //if (@event.Entity is Rachunek_B && ((Rachunek_B)@event.Entity).KlientB == null)
            //{
            //    ((Rachunek_B)@event.Entity).KlientB = new Klient_B();
            //}
        }

    }
}
