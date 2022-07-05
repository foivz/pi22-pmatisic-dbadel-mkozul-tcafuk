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
                       join p in entities.ProvjeraZnanja.Local on d.idDogadjaj equals p.idProvjeraZnanja
                       where k.idKorisnik == 2
                       orderby p.datumprovjere ascending, p.ocjena ascending
                       select new
                       {
                           Ime = k.ime,
                           Prezime = k.prezime,
                           Naziv_dogadaja = d.nazivdogadjaja,
                           Status_dogadaja = d.statusdogadjaja,
                           Datum_provjere = p.datumprovjere,
                           Pitanja = p.pitanja,
                           Ocjena = p.ocjena
                       };

            dgvProvjereZnanja.DataSource = upit.ToList();


            //dgvProvjereZnanja.Columns["idProvjeraZnanja"].Visible = false;
            //dgvProvjereZnanja.Columns["datumprovjere"].HeaderText = "Datum provjere";
            //dgvProvjereZnanja.Columns["pitanja"].HeaderText = "Pitanja";
            //dgvProvjereZnanja.Columns["ocjena"].HeaderText = "Ocjena";
            //dgvProvjereZnanja.Columns["Dogadjaj_idDogadjaj"].Visible = false;
            //dgvProvjereZnanja.Columns["Dogadjaj"].DisplayIndex = 0;
            dgvProvjereZnanja.AutoResizeColumns();
        }

        private void btnPrijaviIspit_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmPrijavaIspita(mainFrm));
        }

        private void frmProvjeraZnanja_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void cbProvjeraZnanja_SelectedValueChanged(object sender, EventArgs e)
        {
            var upit = from k in entities.Korisnik.Local
                       join d in entities.Dogadjaj.Local on k.idKorisnik equals d.Korisnik_idKorisnik
                       join p in entities.ProvjeraZnanja.Local on d.idDogadjaj equals p.idProvjeraZnanja
                       where k.idKorisnik == 2 && d.nazivdogadjaja == cbProvjeraZnanja.SelectedValue.ToString()
                       orderby p.datumprovjere ascending, p.ocjena ascending
                       select new
                       {
                           Ime = k.ime,
                           Prezime = k.prezime,
                           Naziv_dogadaja = d.nazivdogadjaja,
                           Status_dogadaja = d.statusdogadjaja,
                           Datum_provjere = p.datumprovjere,
                           Pitanja = p.pitanja,
                           Ocjena = p.ocjena
                       };

            dgvProvjereZnanja.DataSource = upit.ToList();
            dgvProvjereZnanja.AutoResizeColumns();
        }
    }
}
