using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modeli
{
    public class Klijent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public long KlijentID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int Pib { get; set; }
        public int MaticniBroj { get; set; }

        public Klijent()
        {

        }
    }
}