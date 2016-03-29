namespace Modeli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInitialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dokuments",
                c => new
                    {
                        DokumentID = c.Long(nullable: false, identity: true),
                        DatumIzdavanja = c.DateTime(nullable: false),
                        Mesto = c.String(),
                        RobuPrimio = c.String(),
                        RedniBroj = c.Int(nullable: false),
                        BrojOtkupnogLista = c.Int(),
                        Opis = c.String(maxLength: 300),
                        KorisnikID = c.Long(),
                        ReversID = c.Long(),
                        StanjeID = c.Long(),
                        BrojOtpremnice = c.Int(),
                        KlijentID = c.Long(),
                        StanjeID1 = c.Long(),
                        NacinOtpreme = c.String(maxLength: 50),
                        BrojPrijemnice = c.Int(),
                        KlijentID1 = c.Long(),
                        StanjeID2 = c.Long(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.DokumentID)
                .ForeignKey("dbo.Korisniks", t => t.KorisnikID)
                .ForeignKey("dbo.Revers", t => t.ReversID)
                .ForeignKey("dbo.Stanjes", t => t.StanjeID)
                .ForeignKey("dbo.Klijents", t => t.KlijentID)
                .ForeignKey("dbo.Stanjes", t => t.StanjeID1)
                .ForeignKey("dbo.Klijents", t => t.KlijentID1)
                .ForeignKey("dbo.StanjeRobes", t => t.StanjeID2)
                .Index(t => t.KorisnikID)
                .Index(t => t.ReversID)
                .Index(t => t.StanjeID)
                .Index(t => t.KlijentID)
                .Index(t => t.StanjeID1)
                .Index(t => t.KlijentID1)
                .Index(t => t.StanjeID2);
            
            CreateTable(
                "dbo.Korisniks",
                c => new
                    {
                        KorisnikID = c.Long(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Adresa = c.String(),
                        Jmbg = c.String(),
                        DatumRegistrovanja = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KorisnikID);
            
            CreateTable(
                "dbo.Revers",
                c => new
                    {
                        ReversID = c.Long(nullable: false, identity: true),
                        JedMere = c.String(),
                        RedniBroj = c.Int(nullable: false),
                        Ulaz = c.Int(nullable: false),
                        Izlaz = c.Int(nullable: false),
                        Ukupno = c.Int(nullable: false),
                        RobaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReversID)
                .ForeignKey("dbo.Robas", t => t.RobaID)
                .Index(t => t.RobaID);
            
            CreateTable(
                "dbo.Robas",
                c => new
                    {
                        RobaID = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.RobaID);
            
            CreateTable(
                "dbo.Stanjes",
                c => new
                    {
                        StanjeId = c.Long(nullable: false, identity: true),
                        DatumIzvodaStanja = c.DateTime(nullable: false),
                        BrojGajbica = c.Int(nullable: false),
                        VrstaID = c.Int(nullable: false),
                        KlasaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StanjeId)
                .ForeignKey("dbo.Klasas", t => t.KlasaID)
                .ForeignKey("dbo.Vrstas", t => t.VrstaID)
                .Index(t => t.VrstaID)
                .Index(t => t.KlasaID);
            
            CreateTable(
                "dbo.Klasas",
                c => new
                    {
                        KlasaID = c.Int(nullable: false, identity: true),
                        NazivKlase = c.String(),
                    })
                .PrimaryKey(t => t.KlasaID);
            
            CreateTable(
                "dbo.Vrstas",
                c => new
                    {
                        VrstaID = c.Int(nullable: false, identity: true),
                        NazivVrste = c.String(),
                    })
                .PrimaryKey(t => t.VrstaID);
            
            CreateTable(
                "dbo.StavkaOtkupnogListas",
                c => new
                    {
                        DokumentID = c.Long(nullable: false),
                        RedniBrojStavke = c.Int(nullable: false),
                        JedCena = c.Double(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        UkupnaCena = c.Double(nullable: false),
                        JedMere = c.String(),
                        KlasaID = c.Int(nullable: false),
                        VrstaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DokumentID, t.RedniBrojStavke })
                .ForeignKey("dbo.Klasas", t => t.KlasaID)
                .ForeignKey("dbo.Dokuments", t => t.DokumentID)
                .ForeignKey("dbo.Vrstas", t => t.VrstaID)
                .Index(t => t.DokumentID)
                .Index(t => t.KlasaID)
                .Index(t => t.VrstaID);
            
            CreateTable(
                "dbo.Klijents",
                c => new
                    {
                        KlijentID = c.Long(nullable: false, identity: true),
                        Naziv = c.String(),
                        Adresa = c.String(),
                        Pib = c.Int(nullable: false),
                        MaticniBroj = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KlijentID);
            
            CreateTable(
                "dbo.StavkaOtpremnices",
                c => new
                    {
                        DokumentID = c.Long(nullable: false),
                        RedniBrojStavke = c.Int(nullable: false),
                        JedCena = c.Double(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        UkupnaCena = c.Double(nullable: false),
                        JedMere = c.String(),
                        KlasaID = c.Int(nullable: false),
                        VrstaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DokumentID, t.RedniBrojStavke })
                .ForeignKey("dbo.Klasas", t => t.KlasaID)
                .ForeignKey("dbo.Dokuments", t => t.DokumentID)
                .ForeignKey("dbo.Vrstas", t => t.VrstaID)
                .Index(t => t.DokumentID)
                .Index(t => t.KlasaID)
                .Index(t => t.VrstaID);
            
            CreateTable(
                "dbo.StanjeRobes",
                c => new
                    {
                        StanjeID = c.Long(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        Naziv = c.String(),
                        RobaID = c.Int(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        JedMere = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.StanjeID)
                .ForeignKey("dbo.Robas", t => t.RobaID)
                .Index(t => t.RobaID);
            
            CreateTable(
                "dbo.StavkaPrijemnices",
                c => new
                    {
                        DokumentID = c.Long(nullable: false),
                        RedniBrojStavke = c.Int(nullable: false),
                        JedCena = c.Double(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        UkupnaCena = c.Double(nullable: false),
                        JedMere = c.String(),
                        RobaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DokumentID, t.RedniBrojStavke })
                .ForeignKey("dbo.Dokuments", t => t.DokumentID)
                .ForeignKey("dbo.Robas", t => t.RobaID)
                .Index(t => t.DokumentID)
                .Index(t => t.RobaID);
            
            CreateTable(
                "dbo.Kompenzacijas",
                c => new
                    {
                        DokumentID = c.Long(nullable: false),
                        StanjeID = c.Long(nullable: false),
                        Datum = c.DateTime(nullable: false),
                        Kolicina = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.DokumentID, t.StanjeID })
                .ForeignKey("dbo.Dokuments", t => t.DokumentID)
                .ForeignKey("dbo.StanjeRobes", t => t.StanjeID)
                .Index(t => t.DokumentID)
                .Index(t => t.StanjeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kompenzacijas", "StanjeID", "dbo.StanjeRobes");
            DropForeignKey("dbo.Kompenzacijas", "DokumentID", "dbo.Dokuments");
            DropForeignKey("dbo.StavkaPrijemnices", "RobaID", "dbo.Robas");
            DropForeignKey("dbo.StavkaPrijemnices", "DokumentID", "dbo.Dokuments");
            DropForeignKey("dbo.Dokuments", "StanjeID2", "dbo.StanjeRobes");
            DropForeignKey("dbo.StanjeRobes", "RobaID", "dbo.Robas");
            DropForeignKey("dbo.Dokuments", "KlijentID1", "dbo.Klijents");
            DropForeignKey("dbo.StavkaOtpremnices", "VrstaID", "dbo.Vrstas");
            DropForeignKey("dbo.StavkaOtpremnices", "DokumentID", "dbo.Dokuments");
            DropForeignKey("dbo.StavkaOtpremnices", "KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.Dokuments", "StanjeID1", "dbo.Stanjes");
            DropForeignKey("dbo.Dokuments", "KlijentID", "dbo.Klijents");
            DropForeignKey("dbo.StavkaOtkupnogListas", "VrstaID", "dbo.Vrstas");
            DropForeignKey("dbo.StavkaOtkupnogListas", "DokumentID", "dbo.Dokuments");
            DropForeignKey("dbo.StavkaOtkupnogListas", "KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.Dokuments", "StanjeID", "dbo.Stanjes");
            DropForeignKey("dbo.Stanjes", "VrstaID", "dbo.Vrstas");
            DropForeignKey("dbo.Stanjes", "KlasaID", "dbo.Klasas");
            DropForeignKey("dbo.Dokuments", "ReversID", "dbo.Revers");
            DropForeignKey("dbo.Revers", "RobaID", "dbo.Robas");
            DropForeignKey("dbo.Dokuments", "KorisnikID", "dbo.Korisniks");
            DropIndex("dbo.Kompenzacijas", new[] { "StanjeID" });
            DropIndex("dbo.Kompenzacijas", new[] { "DokumentID" });
            DropIndex("dbo.StavkaPrijemnices", new[] { "RobaID" });
            DropIndex("dbo.StavkaPrijemnices", new[] { "DokumentID" });
            DropIndex("dbo.StanjeRobes", new[] { "RobaID" });
            DropIndex("dbo.StavkaOtpremnices", new[] { "VrstaID" });
            DropIndex("dbo.StavkaOtpremnices", new[] { "KlasaID" });
            DropIndex("dbo.StavkaOtpremnices", new[] { "DokumentID" });
            DropIndex("dbo.StavkaOtkupnogListas", new[] { "VrstaID" });
            DropIndex("dbo.StavkaOtkupnogListas", new[] { "KlasaID" });
            DropIndex("dbo.StavkaOtkupnogListas", new[] { "DokumentID" });
            DropIndex("dbo.Stanjes", new[] { "KlasaID" });
            DropIndex("dbo.Stanjes", new[] { "VrstaID" });
            DropIndex("dbo.Revers", new[] { "RobaID" });
            DropIndex("dbo.Dokuments", new[] { "StanjeID2" });
            DropIndex("dbo.Dokuments", new[] { "KlijentID1" });
            DropIndex("dbo.Dokuments", new[] { "StanjeID1" });
            DropIndex("dbo.Dokuments", new[] { "KlijentID" });
            DropIndex("dbo.Dokuments", new[] { "StanjeID" });
            DropIndex("dbo.Dokuments", new[] { "ReversID" });
            DropIndex("dbo.Dokuments", new[] { "KorisnikID" });
            DropTable("dbo.Kompenzacijas");
            DropTable("dbo.StavkaPrijemnices");
            DropTable("dbo.StanjeRobes");
            DropTable("dbo.StavkaOtpremnices");
            DropTable("dbo.Klijents");
            DropTable("dbo.StavkaOtkupnogListas");
            DropTable("dbo.Vrstas");
            DropTable("dbo.Klasas");
            DropTable("dbo.Stanjes");
            DropTable("dbo.Robas");
            DropTable("dbo.Revers");
            DropTable("dbo.Korisniks");
            DropTable("dbo.Dokuments");
        }
    }
}
