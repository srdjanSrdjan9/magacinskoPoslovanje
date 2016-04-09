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
using Controllors.Korisnici;

namespace Views
{
    public partial class KreiranjeKorisnikaFrm : Form
    {
        private KreiranjeKorisnika k = new KreiranjeKorisnika();
        public KreiranjeKorisnikaFrm()
        {
            InitializeComponent();
        }

        private void SacuvajButton_Click(object sender, EventArgs e)
        {
            int broj;
            bool isJmbgValid = true;
            bool saved = false;
            try
            {
                foreach (char c in JMBGTextBox.Text)
                {
                    if (c < '0' || c > '9' || c == ' ')
                        isJmbgValid = false;
                }
                if (!isJmbgValid)
                {
                    MessageBox.Show("Podaci uneti u JMBG nisu validni. Dozvoljeno je unositi isključivo brojeve!");
                    return;
                }
                if (Int32.TryParse(BrojTextBox.Text.Trim(), out broj))
                   saved = k.KreirajKorisnika(ImeTextBox.Text.Trim(), PrezimeTextBox.Text.Trim(), AdresaTextBox.Text.Trim(), MestoTextBox.Text.Trim(), broj, JMBGTextBox.Text);
                else
                    MessageBox.Show("Broj stanovanja nije unet u odgovarajućem formatu!");
                if (saved)
                    MessageBox.Show("Korisnik je uspesno sačuvan u bazu!");
                else
                    MessageBox.Show("Korisnik već postoji u bazi!");
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

        private void PonistiButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
