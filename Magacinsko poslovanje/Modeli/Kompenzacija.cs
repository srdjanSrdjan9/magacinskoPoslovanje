using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modeli
{
    public class Kompenzacija
    {
        public DateTime Datum { get; set; }
        public double Kolicina { get; set; }
        [Key]
        [Column(Order = 1)]
        public long DokumentID { get; set; }
        public virtual OtkupniList OtkupniList { get; set; }
        [Key]
        [Column(Order = 2)]
        public long StanjeID { get; set; }
        public virtual StanjeRobe StanjeRobe { get; set; }

        public Kompenzacija()
        {
            Datum = DateTime.Now;
        }
    }
}
