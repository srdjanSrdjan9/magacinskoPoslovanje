using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modeli
{
    public class Dobavljac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public Int64 DobavljacID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int Pib { get; set; }
        public int MaticniBroj { get; set; }

        public Dobavljac()
        {

        }
    }
}