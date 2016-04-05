using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modeli
{
    public class StavkaOtkupnogLista
    {
        [Required(ErrorMessage = "Redni broj stavke otkupnog lista mora biti unet")]
        [Key]
        [Column(Order = 2)]
        public int RedniBrojStavke { get; set; }
        public double JedCena { get; set; }
        public double Kolicina { get; set; }
        public double UkupnaCena { get; set; }
        public string JedMere { get; set; }
        [Required]
        public int KlasaID { get; set; }
        public virtual Klasa Klasa { get; set; }
        [Required]
        public int VrstaID { get; set; }
        public virtual Vrsta Vrsta { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("OtkupniList")]
        public long DokumentID { get; set; }
        public virtual OtkupniList OtkupniList { get; set; }

        public StavkaOtkupnogLista()
        { }
    }
}
