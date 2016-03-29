using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modeli
{
    public class OtkupniList : Dokument
    {
        [Required(ErrorMessage = "Redni broj otkupnog lista mora biti unet")]
        public int BrojOtkupnogLista { get; set; }
        [StringLength(300, ErrorMessage = "Opis za otkupni list ne sme da sadrži više od 300 karaktera")]
        public string Opis { get; set; }
        public virtual ICollection<StavkaOtkupnogLista> Stavke { get; set; }
        [Required]
        public long KorisnikID { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        [Required]
        public long ReversID { get; set; }
        public virtual Revers Revers { get; set; }
        [Required]
        public long StanjeID { get; set; }
        public virtual Stanje Stanje { get; set; }

        public OtkupniList()
            : base()
        { }
    }
}
