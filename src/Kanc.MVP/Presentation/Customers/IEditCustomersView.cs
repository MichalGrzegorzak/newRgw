using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MVCSharp.Core;
using MVCSharp.Winforms;

namespace Kanc.MVP.Presentation.Customers
{
    public interface IMyBaseView
    {
        int Id { get; set; }
        bool IsNew { get; set; }
        string Message { get; set; }
        
        void NotifyUser(string message);
        void ClearView();

        void SetError(Control control, string message);
        void SetError(string ctrlName, string message);
    }

    public class MyBaseControlView<T> : WinUserControlView<T>, IMyBaseView 
        where T : class, IController
    {
        public List<Control> availableControls = new List<Control>();
        protected ErrorProvider errorProvider;

        public virtual int Id { get; set; }
        public virtual bool IsNew { get; set; }
        public virtual string Message { get; set; }

        public virtual void NotifyUser(string message)
        {
            MessageBox.Show(message);
        }

        public virtual void ClearView()
        {
            availableControls.ForEach(x=>x.ResetText());
        }

        public virtual void SetError(Control control, string message)
        {
            if(errorProvider == null)
                throw new Exception("Nie przypisany error provider w widoku!");

            errorProvider.SetError(control, message);
        }
        public virtual void SetError(string ctrlName, string message)
        {
            Control ctrl = availableControls.Where(x => x.Name == ctrlName).FirstOrDefault();
            SetError(ctrl, message);
        }
    }

    public interface IBaseEditCustomersView : IMyBaseView
    {
        string NazwiskoPl { get; set; }
        DateTime? Urodzony { get; set; }
    }

    //public interface IEditCustomersView : IBaseEditCustomersView
    //{
        
    //}

    //public interface INewCustomersView : IBaseEditCustomersView
    //{
    //    //string Name { get; set; }
    //    //string Message { get; set; }
    //}
}
