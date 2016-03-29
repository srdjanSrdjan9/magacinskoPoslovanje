using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeli;

namespace Controllors.Korisnici
{
    public class KreiranjeKorisnika
    {
        public bool KreirajKorisnika(string ime, string prezime, string adresa, string mesto, int broj, string jmbg)
        {
            using(MPContextDb context = new MPContextDb())
            {
                bool isUserAllreadyInDb = context.Korisnici.Any(k => k.Jmbg == jmbg);
                if(!isUserAllreadyInDb)
                {
                    context.Korisnici.Add(new Korisnik()
                    {
                        Ime = ime,
                        Prezime = prezime,
                        Adresa = adresa + ", " + broj.ToString() + ", " + mesto,
                        Jmbg = jmbg
                    });
                    context.SaveChanges();
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
