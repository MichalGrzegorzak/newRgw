using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Event;
using NHibernate.Validator.Engine;

namespace Kanc.Commons.Infrastructure.Interceptors
{
    public class NHVTypeInspector : IEntityTypeInspector
    {
        public Type GuessType(object entityInstance)
        {
            var entity = entityInstance as IWellKnownProxy;
            if (entity != null)
                return entity.EntityType;
            return null;
        }
    }

    public interface IWellKnownProxy
    {
        string EntityName { get; }
        Type EntityType { get; }
    }

    public static class ConfigurationExtension
    {
        public static NHibernate.Cfg.Configuration RegisterEntityNameResolver(this NHibernate.Cfg.Configuration configuration)
        {
            EventListeners listeners = configuration.EventListeners;
            var entityNameResolver = new EntityNameResolver();
            listeners.MergeEventListeners =
                new[] { entityNameResolver }.Concat(listeners.MergeEventListeners).ToArray();
            listeners.UpdateEventListeners =
                new[] { entityNameResolver }.Concat(listeners.UpdateEventListeners).ToArray();
            listeners.SaveOrUpdateEventListeners =
                new[] { entityNameResolver }.Concat(listeners.SaveOrUpdateEventListeners).ToArray();
            listeners.SaveEventListeners =
                new[] { entityNameResolver }.Concat(listeners.SaveEventListeners).ToArray();
            listeners.PersistEventListeners =
                new[] { entityNameResolver }.Concat(listeners.PersistEventListeners).ToArray();

            configuration.Interceptor = new EntityNameInterceptor();
            return configuration;
        }
    }
}
