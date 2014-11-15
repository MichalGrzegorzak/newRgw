using System.Collections.Generic;

namespace Kanc.MVP.Core.nHibernate.Base
{
    public class Project : ModelBase, IAutoMap
    {
        public Project()
        {
            Tasks = new List<Task>();
        }

        public virtual string Name { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Task> Tasks { get; set; }
    }

    public class Task : ModelBase, IAutoMap
    {
        public virtual string Name { get; set; }
        public virtual Project Project { get; set; }
    }

    public class User : ModelBase, IAutoMap
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
    }
}