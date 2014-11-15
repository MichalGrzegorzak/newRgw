using System;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;

namespace Kanc.MVP.Core.Infrastructure
{
    public static class SessionExtensions
    {
        public static Boolean IsDirtyEntity(this ISession session, Object entity)
        {
            String className = NHibernateProxyHelper.GuessClass(entity).FullName;
            ISessionImplementor sessionImpl = session.GetSessionImplementation();
            IPersistenceContext persistenceContext = sessionImpl.PersistenceContext;
            IEntityPersister persister = sessionImpl.Factory.GetEntityPersister(className);
            EntityEntry oldEntry = sessionImpl.PersistenceContext.GetEntry(entity);

            if ((oldEntry == null) && (entity is INHibernateProxy))
            {
                INHibernateProxy proxy = entity as INHibernateProxy;
                Object obj = sessionImpl.PersistenceContext.Unproxy(proxy);
                oldEntry = sessionImpl.PersistenceContext.GetEntry(obj);
            }

            Object[] oldState = oldEntry.LoadedState;
            Object[] currentState = persister.GetPropertyValues(entity, sessionImpl.EntityMode);
            Int32[] dirtyProps = persister.FindDirty(currentState, oldState, entity, sessionImpl);

            return (dirtyProps != null);
        }

        public static Boolean IsDirtyProperty(this ISession session, Object entity, String propertyName)
        {
            String className = NHibernateProxyHelper.GuessClass(entity).FullName;
            ISessionImplementor sessionImpl = session.GetSessionImplementation();
            IPersistenceContext persistenceContext = sessionImpl.PersistenceContext;
            IEntityPersister persister = sessionImpl.Factory.GetEntityPersister(className);
            EntityEntry oldEntry = sessionImpl.PersistenceContext.GetEntry(entity);

            if ((oldEntry == null) && (entity is INHibernateProxy))
            {
                INHibernateProxy proxy = entity as INHibernateProxy;
                Object obj = sessionImpl.PersistenceContext.Unproxy(proxy);
                oldEntry = sessionImpl.PersistenceContext.GetEntry(obj);
            }

            Object[] oldState = oldEntry.LoadedState;
            Object[] currentState = persister.GetPropertyValues(entity, sessionImpl.EntityMode);
            Int32[] dirtyProps = persister.FindDirty(currentState, oldState, entity, sessionImpl);
            Int32 index = Array.IndexOf(persister.PropertyNames, propertyName);

            Boolean isDirty = (dirtyProps != null) ? (Array.IndexOf(dirtyProps, index) != -1) : false;

            return (isDirty);
        }

        public static Object GetOriginalEntityProperty(this ISession session, Object entity, String propertyName)
        {
            String className = NHibernateProxyHelper.GuessClass(entity).FullName;
            ISessionImplementor sessionImpl = session.GetSessionImplementation();
            IPersistenceContext persistenceContext = sessionImpl.PersistenceContext;
            IEntityPersister persister = sessionImpl.Factory.GetEntityPersister(className);
            EntityEntry oldEntry = sessionImpl.PersistenceContext.GetEntry(entity);

            if ((oldEntry == null) && (entity is INHibernateProxy))
            {
                INHibernateProxy proxy = entity as INHibernateProxy;
                Object obj = sessionImpl.PersistenceContext.Unproxy(proxy);
                oldEntry = sessionImpl.PersistenceContext.GetEntry(obj);
            }

            Object[] oldState = oldEntry.LoadedState;
            Object[] currentState = persister.GetPropertyValues(entity, sessionImpl.EntityMode);
            Int32[] dirtyProps = persister.FindDirty(currentState, oldState, entity, sessionImpl);
            Int32 index = Array.IndexOf(persister.PropertyNames, propertyName);

            Boolean isDirty = (dirtyProps != null) ? (Array.IndexOf(dirtyProps, index) != -1) : false;

            return ((isDirty == true) ? oldState[index] : currentState[index]);
        }
    }
}
