using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Modeli
{
    public class Revers
    {
        [Browsable(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 ReversID { get; set; }
        public string JedMere { get; set; }
        public int RedniBroj { get; set; }
        public int Ulaz { get; set; }
        public int Izlaz { get; set; }
        public int Ukupno { get; set; }

        public Revers()
        {

        }
    }
}
