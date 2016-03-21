using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Modeli
{
    public class Kupac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public Int64 KupacID { get; set; }
        public string Naziv { get; set; }
        public int MaticniBroj { get; set; }
        public int Pib { get; set; }
        public string Adresa { get; set; }

        public Kupac()
        {

        }
    }
}
