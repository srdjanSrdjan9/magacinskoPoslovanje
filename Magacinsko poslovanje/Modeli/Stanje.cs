using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Modeli
{
    public class Stanje
    {
        [Browsable(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StanjeId { get; set; }
        public DateTime DatumIzvodaStanja { get; set; }
        public int BrojGajbica { get; set; }
        public int VrstaID { get; set; }
        public virtual Vrsta Vrsta { get; set; }
        public int KlasaID { get; set; }
        public virtual Klasa Klasa { get; set; }

        public Stanje()
        {
            DatumIzvodaStanja = DateTime.Now;
        }
    }
}
