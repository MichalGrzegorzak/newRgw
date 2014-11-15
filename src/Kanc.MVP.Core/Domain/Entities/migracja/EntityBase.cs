using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SubSonic;

namespace MigrationTool.Entities
{
    public interface IId
    {
        int Id { get; set; }
    }

    //public abstract class BaseTracking : EntityBase
    //{
    //    public string CreatedBy { get; set; }
    //    public DateTime CreatedOn { get; set; }
    //    public string ModifiedBy { get; set; }
    //    public DateTime ModifiedOn { get; set; }
    //    //public bool IsDeleted { get; set; }

    //    public BaseTracking()
    //    {
    //        CreatedOn =  (DateTime)SqlDateTime.MinValue;
    //        ModifiedOn =  (DateTime)SqlDateTime.MinValue;
    //        //IsDeleted = false;
    //        CreatedBy = "anon";
    //        ModifiedBy = "anon";
    //    }
    //}

    public abstract class EntityBase : IId
    {
        public abstract int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        //public string ModifiedBy { get; set; }
        //public DateTime ModifiedOn { get; set; }
        //public bool IsDeleted { get; set; }

        public EntityBase()
        {
            CreatedOn =  (DateTime)SqlDateTime.MinValue;
            CreatedBy = "anon";
            //ModifiedOn =  (DateTime)SqlDateTime.MinValue;
            //IsDeleted = false;
            //ModifiedBy = "anon";
        }

        private Hashtable ForeignCache = new Hashtable();

        protected T GetForeign<T>(int key) where T : EntityBase, new()
        {
            string relation = typeof(T).Name;
            T foreign = ForeignCache[relation] as T;
            if (foreign == null || foreign.Id != key)
            {
                foreign = Repository.Get<T>(key);
                ForeignCache[relation] = foreign;
            }
            return foreign;
        }

        protected int SetForeign<T>(T foreign) where T : EntityBase, new()
        {
            string relation = typeof(T).Name;
            ForeignCache[relation] = foreign;
            return (foreign == null) ? 0 : foreign.Id;
        }

        protected List<T> GetForeignList<T>(Expression<Func<T, bool>> expression) where T : EntityBase, new()
        {
            return GetForeignList<T>(expression, false);
        }

        protected List<T> GetForeignList<T>(Expression<Func<T, bool>> expression, bool refresh) where T : EntityBase, new()
        {
            string relation = "l-" + typeof(T).Name;
            List<T> foreign = ForeignCache[relation] as List<T>;
            if (foreign == null || refresh)
            {
                foreign = Repository.GetRepository().Find<T>(expression).ToList();
                ForeignCache[relation] = foreign;
            }
            return foreign;
        }
    }
}
