﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Modeli
{
    public abstract class Dokument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Browsable(false)]
        public Int64 DokumentID { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string Mesto { get; set; }
        public string RobuPrimio { get; set; }
        public int RedniBroj { get; set; }

        public Dokument()
        {

        }
    }
}
