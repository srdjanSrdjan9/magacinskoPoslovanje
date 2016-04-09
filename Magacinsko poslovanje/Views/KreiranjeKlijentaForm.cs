using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modeli;
using Controllors;
using Controllors.Korisnici;

namespace Views
{
    public partial class KreiranjeKlijentaForm : Form
    {
        KreiranjeKlijenta k = new KreiranjeKlijenta();
        public KreiranjeKlijentaForm()
        {
            InitializeComponent();
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            int broj;
            bool isJmbgValid = true;
            bool saved = false;
            try
            {
                foreach (char c in pibTextBox.Text)
                {
                    if (c < '0' || c > '9' || c == ' ')
                        isJmbgValid = false;
                }
                if (!isJmbgValid)
                {
                    MessageBox.Show("Podaci uneti u Pib nisu validni. Dozvoljeno je unositi isključivo brojeve!");
                    return;
                }
                if (Int32.TryParse(brojTextBox.Text.Trim(), out broj))
                    saved = k.KreirajKlijenta(nazivTextBox.Text.Trim(), pibTextBox.Text.Trim(), adresaTextBox.Text.Trim(), mestoTextBox.Text.Trim(), broj, maticniBrojTextBox.Text.Trim());
                else
                    MessageBox.Show("Broj sedista klijenta nije unet u odgovarajućem formatu!");
                if (saved)
                    MessageBox.Show("Klijent je uspesno sačuvan u bazu!");
                else
                    MessageBox.Show("Klijent već postoji u bazi!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Uneti podaci nisu u odgovarajućem formatu!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Nešto nije u redu! Obratite se administratoru! Hvala! \n" + exc.ToString());
            }
        }

        private void ponistiButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}