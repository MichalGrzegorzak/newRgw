using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;
using NHibernate.Event;
using NHibernate.Event.Default;

namespace Kanc.UI.Tests.Infrastructure
{
    /// <summary>
    /// Ustawia domyslne obiekty, jesli zaladowano NULL`a z bazy
    /// </summary>
    public class LoadedEvent : DefaultPostLoadEventListener
    {
        public override void OnPostLoad(PostLoadEvent @event)
        {
            base.OnPostLoad(@event);
            //if (@event.Entity is Klient_A && ((Klient_A)@event.Entity).KrajA == null)
            //{
            //    ((Klient_A)@event.Entity).KrajA = DataBindingFactory.Create<Kraj_A>();
            //}
            if (@event.Entity is Rachunek_A && ((Rachunek_A)@event.Entity).KlientA == null)
            {
                ((Rachunek_A)@event.Entity).KlientA = DataBindingFactory.Create<Klient_A>();
            }
            if (@event.Entity is Rachunek_B && ((Rachunek_B)@event.Entity).Klient == null)
            {
                ((Rachunek_B)@event.Entity).Klient = new Klient_B();
            }
        }

    }
}
