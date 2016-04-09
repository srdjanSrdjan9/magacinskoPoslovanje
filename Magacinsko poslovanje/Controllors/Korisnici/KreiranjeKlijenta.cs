using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeli;

namespace Controllors.Korisnici
{
    public class KreiranjeKlijenta
    {
        public bool KreirajKlijenta(string naziv, string pib, string adresa, string mesto, int broj, string maticniBroj)
        {
            using (MPContextDb context = new MPContextDb())
            {
                bool isUserAllreadyInDb = context.Klijenti.Any(k => k.Pib == pib);
                if (!isUserAllreadyInDb)
                {
                    context.Klijenti.Add(new Klijent()
                    {
                        Naziv = naziv,
                        Pib = pib,
                        Adresa = adresa + ", " + broj.ToString() + ", " + mesto,
                        MaticniBroj = maticniBroj
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
