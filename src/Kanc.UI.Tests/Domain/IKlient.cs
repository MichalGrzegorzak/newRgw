using System;
using System.Collections.Generic;

namespace Kanc.UI.Tests
{
    public interface IKlient
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime? Urodz { get; set; }
        //IList<Rozliczenie> Rozliczenia { get; set; }
    }
}