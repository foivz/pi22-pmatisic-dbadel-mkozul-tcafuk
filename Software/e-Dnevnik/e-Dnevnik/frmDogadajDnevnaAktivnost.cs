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
    public partial class frmDogadajDnevnaAktivnost : Form
    {
        private MainForm mainFrm;
        private int ID_aktivnosti = -1;
        public frmDogadajDnevnaAktivnost(int ID_aktivnosti, MainForm mainForm)
        {
            this.mainFrm = mainForm;
            this.ID_aktivnosti = ID_aktivnosti;
            InitializeComponent();
            getAktivnost();
        }

        private void getAktivnost()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from da in context.DnevnaAktivnost
                           from d in context.Dogadjaj
                           from k in context.Korisnik
                           where da.idDnevnaAktivnost == ID_aktivnosti
                           && d.idDogadjaj == da.Dogadjaj_idDogadjaj
                           && k.idKorisnik == d.Korisnik_idKorisnik
                           select new
                           {
                               Korisnik = k.korime,

                               Naziv = da.nazivaktivnosti,
                               Opis = da.opisaktivnosti,
                               BrojS = da.brojsamostalnihzahvata,
                               BrojUz = da.brojzahvatauznadzor,
                               Datum = da.datumobavljeneaktivnosti,
                               Status = d.statusdogadjaja
                           };

                foreach (var s in upit)
                {
                    tbKorisnik.Text = s.Korisnik;
                    dtpDatum.Value = s.Datum;
                    tbNaziv.Text = s.Naziv;
                    tbOpis.Text = s.Opis;
                    tbBrojSolo.Text = s.BrojS.ToString();
                    tbBrojUzNadzor.Text = s.BrojUz.ToString();

                    if (s.Status != "")
                    {
                        tbNazivCom.Enabled = false;
                        tbOpisCom.Enabled = false;
                        tbBrojSoloCom.Enabled = false;
                        tbBrojUzNadCom.Enabled = false;
                        btnDetaljno.Visible = false;
                        btnOstaviKomentar.Text = "Izađi";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmPocetnaModerator(mainFrm));
        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            using (var context = new PI2205_DBEntities())
            {

                var upitDogadaj = from d in context.Dogadjaj
                                  from da in context.DnevnaAktivnost
                                  where da.idDnevnaAktivnost == ID_aktivnosti
                                  && d.idDogadjaj == da.Dogadjaj_idDogadjaj
                                  select d.idDogadjaj;

                var IdDog = upitDogadaj.First();

                var updateDogadaj = context.Dogadjaj.SingleOrDefault(x => x.idDogadjaj == IdDog);
                if (updateDogadaj != null)
                {
                    updateDogadaj.statusdogadjaja = "Provjereno";
                    context.SaveChanges();
                }
            }
            mainFrm.ucitajFormu(new frmDogadaji(mainFrm));
        }
    }
}
