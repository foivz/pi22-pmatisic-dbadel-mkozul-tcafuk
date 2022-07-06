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
        public int ID_slucaja;
        public frmSlucajBolesnika(int ID_slucaja, MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.ID_slucaja = ID_slucaja;
            InitializeComponent();

            getSlucaj();
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void getSlucaj()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from sb in context.SlucajBolesnika
                           from d in context.Dogadjaj
                           from k in context.Korisnik
                           where sb.idSlucajBolesnika == ID_slucaja
                           && d.idDogadjaj == sb.Dogadjaj_idDogadjaj
                           && k.idKorisnik == d.Korisnik_idKorisnik
                           select new
                           {
                               Korisnik = k.korime,
                               Dijagnoza = sb.dijagnoza,
                               Vrsta = sb.vrstaosobe,
                               Datum = sb.datumpregleda,
                               Opis = sb.opisslucaja,
                               Status = d.statusdogadjaja
                           };

                foreach (var s in upit)
                {
                    tbKorisnik.Text = s.Korisnik;
                    tbVrsta.Text = s.Vrsta;
                    tbOpis.Text = s.Opis;
                    tbDatum.Text = s.Datum.ToString();
                    tbDijagnoza.Text = s.Dijagnoza;

                    if(s.Status != "")
                    {
                        tbDatumCom.Enabled = false;
                        tbDijagnozaCom.Enabled = false;
                        tbOpisCom.Enabled = false;
                        tbDatumCom.Enabled = false;
                        tbVrstaCom.Enabled = false;
                        btnDetaljno.Enabled = false;
                    }
                }

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.ucitajFormu(new frmPocetnaModerator(mainForm));
        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            using (var context = new PI2205_DBEntities())
            {

                var upitDogadaj = from d in context.Dogadjaj
                                  from sb in context.SlucajBolesnika
                                  where sb.idSlucajBolesnika == ID_slucaja
                                  && d.idDogadjaj == sb.Dogadjaj_idDogadjaj
                                  select d.idDogadjaj;

                var IdDog = upitDogadaj.First();

                var updateDogadaj = context.Dogadjaj.SingleOrDefault(x => x.idDogadjaj == IdDog);
                if (updateDogadaj != null)
                {
                    updateDogadaj.statusdogadjaja = "Provjereno";
                    context.SaveChanges();
                }
            }
            mainForm.ucitajFormu(new frmDogadaji(mainForm));
        }
    }

}
