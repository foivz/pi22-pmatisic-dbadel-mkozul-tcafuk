using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik
{
    public partial class frmSlucajBolesnika : Form
    {
        MainForm mainForm;
        public frmSlucajBolesnika(int ID_slucaja, MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            var query = getSlucaj(ID_slucaja);
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private object getSlucaj(int ID)
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from sb in context.SlucajBolesnika
                           from d in context.Dogadjaj
                           from k in context.Korisnik
                           where sb.idSlucajBolesnika == ID
                           && d.idDogadjaj == sb.Dogadjaj_idDogadjaj
                           && k.idKorisnik == d.Korisnik_idKorisnik
                           select new
                           {
                               Korisnik = k.korime,
                               Dijagnoza = sb.dijagnoza,
                               Vrsta = sb.vrstaosobe,
                               Datum = sb.datumpregleda,
                               Opis = sb.opisslucaja
                           };

                foreach (var s in upit)
                {
                    tbKorisnik.Text = s.Korisnik;
                    tbVrsta.Text = s.Vrsta;
                    tbOpis.Text = s.Opis;
                    tbDatum.Text = s.Datum.ToString();
                    tbDijagnoza.Text = s.Dijagnoza;
                }

                return upit;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            mainForm.ucitajFormu(new frmDogadaji(mainForm));
        }
    }

}
