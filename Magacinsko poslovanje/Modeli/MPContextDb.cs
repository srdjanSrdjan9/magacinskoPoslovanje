using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Modeli
{
    public class MPContextDb : DbContext
    {
        public DbSet<Klasa> Klase { get; set; }
        public DbSet<Vrsta> Vrste { get; set; }
        public DbSet<Dokument> Dokumenti { get; set; }
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Kompenzacija> Kompenzacije { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Revers> Reversi { get; set; }
        public DbSet<Roba> Roba { get; set; }
        public DbSet<Stanje> Stanje { get; set; }
        public DbSet<StanjeRobe> StanjeRobe { get; set; }
        public DbSet<StavkaOtkupnogLista> StavkeOtkupnogLista { get; set; }
        public DbSet<StavkaOtpremnice> StavkeOtpremnice { get; set; }
        public DbSet<StavkaPrijemnice> StavkePrijemnice { get; set; }

        public MPContextDb()
            : base("name = magacinskoPoslovanje")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
