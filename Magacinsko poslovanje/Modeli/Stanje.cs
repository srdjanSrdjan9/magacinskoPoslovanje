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
        public Int64 StanjeId { get; set; }
        public DateTime DatumIzvodaStanja { get; set; }
        public int BrojGajbica { get; set; }
        public int VrstaID { get; set; }
        public int KlasaID { get; set; }

        public Stanje()
        {

        }
    }
}
