using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.ComponentModel;

namespace Modeli
{
    public class Klasa
    {
        public int KlasaID { get; set; }
        public string NazivKlase { get; set; }
        
        public Klasa()
        {

        }
    }
}
