using Kanc.MVP.Engine.Tasks;
using NHibernate;

namespace Kanc.MVP.Controllers.Base
{
    public interface ISubController
    {
        //MainTask Task { get; set; }
        //ISession Session { get; }

        //void ViewInitialized();
        //void ViewActivated();
        //bool IsValid();
        //void Save();
        //void Next();
        //void Previous();
        //void ShowErrors();
        void BindModel();
    }
}