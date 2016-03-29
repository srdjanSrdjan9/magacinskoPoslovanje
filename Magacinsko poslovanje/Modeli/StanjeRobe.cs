using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Modeli
{
    public class StanjeRobe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StanjeID { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public int RobaID { get; set; }
        public virtual Roba Roba { get; set; }
        public double Kolicina { get; set; }
        public double JedMere { get; set; }

        public StanjeRobe()
        {
            Datum = DateTime.Now;
        }
    }
}
