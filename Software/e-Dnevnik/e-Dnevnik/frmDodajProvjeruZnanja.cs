using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik
{
    public partial class frmDodajProvjeruZnanja : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private MainForm mainFrm;
        public frmDodajProvjeruZnanja(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
            entities.Korisnik.Load();
            entities.Dogadjaj.Load();
            entities.ProvjeraZnanja.Load();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            //this.Close();
            mainFrm.ucitajFormu(new frmProvjeraZnanja(mainFrm));
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var datum = dtpProvjeraZnanja.Value;
                var pitanja = tbPitanja.Text;
                var ocjena = int.Parse(cbOcjene.Text.Substring(0, 1));
                var dogadaj = cbDogadaj.Text;
                var specijalizant = cbSpecijalizant.Text;
                var statusDogadaja = "Prijavljeno";

                var upit = from d in entities.Dogadjaj.Local
                           join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals k.idKorisnik
                           where d.nazivdogadjaja == dogadaj && d.statusdogadjaja == statusDogadaja && k.PunoIme == specijalizant
                           select d.idDogadjaj;
                var IdDogadaja = upit.First();

                ProvjeraZnanja provjera = new ProvjeraZnanja
                {
                    datumprovjere = datum,
                    pitanja = pitanja,
                    ocjena = ocjena,
                    Dogadjaj_idDogadjaj = IdDogadaja
                };

                entities.ProvjeraZnanja.Add(provjera);
                entities.SaveChanges();

                var noviStatus = "";
                //MessageBox.Show("Uspješno uneseno.");
                if (ocjena == 1) 
                {
                    noviStatus = "Pao rok";
                }
                else
                {
                    noviStatus = "Odraden rok";
                }
                //Dogadjaj altDogadaj = new Dogadjaj
                //{
                //    statusdogadjaja = noviStatus
                //};
                //entities.Dogadjaj

                var updateDogadaj = entities.Dogadjaj.SingleOrDefault(x => x.idDogadjaj == IdDogadaja);
                if (updateDogadaj != null)
                {
                    updateDogadaj.statusdogadjaja = noviStatus;
                    entities.SaveChanges();
                }

                //this.Close();
                mainFrm.ucitajFormu(new frmProvjeraZnanja(mainFrm));
            }
            catch
            {
                MessageBox.Show("Niste popunili sva polja.");
            }

        }

        private void frmDodajProvjeruZnanja_Load(object sender, EventArgs e)
        {
            var cbUpit = (from d in entities.Dogadjaj.Local
                         where d.statusdogadjaja.Contains("Prijavljeno")
                         select d.nazivdogadjaja).Distinct();

            cbDogadaj.DataSource = cbUpit.Distinct().ToList();

            var upit = (from d in entities.Dogadjaj.Local
                       join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals k.idKorisnik
                       where d.statusdogadjaja.Contains("Prijavljeno")
                       select k.PunoIme).Distinct();
            cbSpecijalizant.DataSource = upit.ToList();
        }

        private void cbDogadaj_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var upit = (from d in entities.Dogadjaj.Local
                        join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals k.idKorisnik
                        where d.statusdogadjaja.Contains("Prijavljeno") && d.nazivdogadjaja.Contains(cbDogadaj.SelectedValue.ToString())
                        select k.PunoIme).Distinct();
            cbSpecijalizant.DataSource = upit.ToList();
        }

        private void tbPitanja_Leave(object sender, EventArgs e)
        {
            var unosPitanja = tbPitanja.Text;

            if(unosPitanja.Length > 250)
            {
                MessageBox.Show("Unijeli ste više od 250 dopuštenih znakova.\nUkoliko ostavite bit će spremljeno prvih 250.");
            }
        }
    }
}
