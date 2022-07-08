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
    public partial class frmProvjeraZnanja : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private MainForm mainFrm;
        public frmProvjeraZnanja(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
        }

        public void Osvjezi()
        {
            entities.Korisnik.Load();
            entities.Dogadjaj.Load();
            entities.ProvjeraZnanja.Load();
            //dgvProvjereZnanja.DataSource = entities.ProvjeraZnanja.Local;
            //dgvProvjereZnanja.Columns["idProvjeraZnanja"].ReadOnly = true;

            var cbUpit = (from d in entities.Dogadjaj.Local
                          where d.nazivdogadjaja.Contains("Provjera znanja")
                          select d.nazivdogadjaja).Distinct();

            cbProvjeraZnanja.DataSource = cbUpit.ToList();

            var upit = from k in entities.Korisnik.Local
                       join d in entities.Dogadjaj.Local on k.idKorisnik equals d.Korisnik_idKorisnik
                       join p in entities.ProvjeraZnanja.Local on d.idDogadjaj equals p.Dogadjaj_idDogadjaj
                       orderby p.datumprovjere ascending, p.ocjena ascending
                       select new
                       {
                           //ID = p.idProvjeraZnanja,
                           Ime = k.ime,
                           Prezime = k.prezime,
                           Naziv_dogadaja = d.nazivdogadjaja,
                           Status_dogadaja = d.statusdogadjaja,
                           Datum_provjere = p.datumprovjere,
                           Pitanja = p.pitanja,
                           Ocjena = p.ocjena
                       };

            dgvProvjereZnanja.DataSource = upit.ToList();
            NaziviStupaca();
            //dgvProvjereZnanja.Columns[0].Visible = false;


            //dgvProvjereZnanja.Columns["idProvjeraZnanja"].Visible = false;
            //dgvProvjereZnanja.Columns["datumprovjere"].HeaderText = "Datum provjere";
            //dgvProvjereZnanja.Columns["pitanja"].HeaderText = "Pitanja";
            //dgvProvjereZnanja.Columns["ocjena"].HeaderText = "Ocjena";
            //dgvProvjereZnanja.Columns["Dogadjaj_idDogadjaj"].Visible = false;
            //dgvProvjereZnanja.Columns["Dogadjaj"].DisplayIndex = 0;
            dgvProvjereZnanja.AutoResizeColumns();
            double Avg = entities.ProvjeraZnanja.Average(x => x.ocjena);
            tbProsjecnaOcjena.Text = Math.Round(Avg, 2).ToString();
            ObojajRedove();
        }

        private void frmProvjeraZnanja_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void cbProvjeraZnanja_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var upit = from k in entities.Korisnik.Local
                           join d in entities.Dogadjaj.Local on k.idKorisnik equals d.Korisnik_idKorisnik
                           join p in entities.ProvjeraZnanja.Local on d.idDogadjaj equals p.Dogadjaj_idDogadjaj
                           where d.nazivdogadjaja == cbProvjeraZnanja.SelectedValue.ToString()
                           orderby p.datumprovjere ascending, p.ocjena ascending
                           select new
                           {
                               //ID = p.idProvjeraZnanja,
                               Ime = k.ime,
                               Prezime = k.prezime,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status_dogadaja = d.statusdogadjaja,
                               Datum_provjere = p.datumprovjere,
                               Pitanja = p.pitanja,
                               Ocjena = p.ocjena
                           };
                double prosjek = upit.Average(x => x.Ocjena);
                dgvProvjereZnanja.DataSource = upit.ToList();
                //dgvProvjereZnanja.Columns[0].Visible = false;
                dgvProvjereZnanja.AutoResizeColumns();

                tbProsjecnaOcjena.Text = Math.Round(prosjek, 2).ToString();
                ObojajRedove();
                NaziviStupaca();
            }
            catch
            {
                MessageBox.Show("Ne postoji unos za tu provjeru.");
                Osvjezi();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmDodajProvjeruZnanja(mainFrm));
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var izabraniDatum = dgvProvjereZnanja.CurrentRow.Cells["Datum_provjere"].Value.ToString();
                var izabranaPitanja = dgvProvjereZnanja.CurrentRow.Cells["Pitanja"].Value.ToString();

                var upitDogadaj = from p in entities.ProvjeraZnanja.Local
                                  where p.datumprovjere.ToString().Equals(izabraniDatum) && p.pitanja.Equals(izabranaPitanja)
                                  select p.Dogadjaj_idDogadjaj;

                var IdDog = upitDogadaj.First();

                var updateDogadaj = entities.Dogadjaj.SingleOrDefault(x => x.idDogadjaj == IdDog);
                if (updateDogadaj != null)
                {
                    updateDogadaj.statusdogadjaja = "Novi rok";
                    entities.SaveChanges();
                }

                var upit = from p in entities.ProvjeraZnanja.Local
                           where p.datumprovjere.ToString() == izabraniDatum && p.pitanja == izabranaPitanja
                           select p.idProvjeraZnanja;
                var idProvjere = upit.First();

                var deleteProvjera = entities.ProvjeraZnanja.SingleOrDefault(x => x.idProvjeraZnanja == idProvjere);
                if (deleteProvjera != null)
                {
                    entities.ProvjeraZnanja.Remove(deleteProvjera);
                    entities.SaveChanges();
                }
                
                Osvjezi();
            }
            catch
            {
                MessageBox.Show("Došlo je do greške.");
            }
        }

        private void ObojajRedove()
        {
            foreach (DataGridViewRow red in dgvProvjereZnanja.Rows)
            {
                if (red.Cells[3].Value.ToString() == "Pao rok")
                {
                    red.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else if(red.Cells[3].Value.ToString() == "Novi rok")
                {
                    red.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void NaziviStupaca()
        {
            dgvProvjereZnanja.Columns["Naziv_dogadaja"].HeaderText = "Naziv događaja";
            dgvProvjereZnanja.Columns["Status_dogadaja"].HeaderText = "Status događaja";
            dgvProvjereZnanja.Columns["Datum_provjere"].HeaderText = "Datum provjere";
        }
    }
}
