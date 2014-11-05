using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Kanc.Data
{
    public partial class Adres
    {
        // Place custom code here.

        #region Metadata
        // For more information about how to use the metadata class visit:
        // http://www.plinqo.com/metadata.ashx
        [CodeSmith.Data.Audit.Audit]
        internal class Metadata
        {
             // WARNING: Only attributes inside of this class will be preserved.

            public int Id { get; set; }

            [Required]
            public string Kod { get; set; }

            [Required]
            public string Miasto { get; set; }

            [Required]
            public string Ulica { get; set; }

            public string Miejsce { get; set; }

            public int KrajId { get; set; }

            public Kraj Kraj { get; set; }

            public EntitySet<Rozliczenie> ZameldRozliczenieList { get; set; }

            public EntitySet<Rozliczenie> KorespRozliczenieList { get; set; }

        }

        #endregion
    }
}