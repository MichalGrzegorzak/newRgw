using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanc.Commons;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Event;

namespace Kanc.UI.Tests.Infrastructure.Setup
{
    public class SessionFactoryInitializer
    {
        private Configuration conf;

        public SessionFactoryInitializer(Configuration conf)
        {
            this.conf = conf;
        }
        
        public void SetupDynamicProxy()
        {
            //conf.EventListeners.PostLoadEventListeners = new IPostLoadEventListener[] { new LoadedEvent() };

            var intercepter = new DataBindingIntercepter();
            Context.SessionFactory = conf
                .SetInterceptor(intercepter)
                .BuildSessionFactory();
            intercepter.SessionFactory = Context.SessionFactory;
        }

        public void SetupNormal()
        {
            //conf.EventListeners.PostLoadEventListeners = new IPostLoadEventListener[] { new LoadedEvent() };

            Context.SessionFactory = conf
                .BuildSessionFactory();
        }
    }
}
