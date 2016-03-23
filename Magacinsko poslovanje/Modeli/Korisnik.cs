using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modeli
{
    public class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public Int64 KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Jmbg { get; set; }
        public DateTime DatumRegistrovanja { get; set; }

        public Korisnik()
        {

        }
    }
}
