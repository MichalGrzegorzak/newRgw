using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanc.Data
{
    public class Database : IDisposable
    {
        public RogowDataCtx _ctx = null;
        //private bool autocommit = true;

        public RogowDataCtx ctx
        {
            get
            {
                if(_ctx == null)
                    _ctx = new RogowDataCtx();
                return _ctx;
            }
        }

        public Database()
        {
            _ctx = new RogowDataCtx();
        }

        public void Commit()
        {
            _ctx.SubmitChanges();
        }

        //public void CommitAndClose()
        //{
        //    _ctx.SubmitChanges();
        //    //Dispose();
        //    _ctx.Dispose();
        //    _ctx = null;
        //}

        public void Dispose()
        {
            //if (autocommit) Commit();

            _ctx.Dispose();
            _ctx = null;
            _ctx = new RogowDataCtx();
        }

        //public void DisposeForced()
        //{
        //    _ctx.Dispose();
        //    _ctx = null;
        //}

    }
}
