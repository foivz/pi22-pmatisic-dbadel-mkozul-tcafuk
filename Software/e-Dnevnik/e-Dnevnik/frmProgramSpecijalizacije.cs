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
    public partial class frmProgramSpecijalizacije : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private MainForm mainFrm;
        public frmProgramSpecijalizacije(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
        }

        public void Osvjezi()
        {
            entities.Uloga.Load();
            entities.Korisnik.Load();
            entities.ProgramSpecijalizacije.Load();
            entities.PrijavaIspita.Load();

            var cbUpit = (from d in entities.Dogadjaj.Local
                          where d.nazivdogadjaja.Contains("Provjera znanja")
                          select d.nazivdogadjaja).Distinct();

            cbPS.DataSource = cbUpit.ToList();


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

            dgvPS.DataSource = upit.ToList();
            //dgvProvjereZnanja.Columns[0].Visible = false;


            //dgvProvjereZnanja.Columns["idProvjeraZnanja"].Visible = false;
            //dgvProvjereZnanja.Columns["datumprovjere"].HeaderText = "Datum provjere";
            //dgvProvjereZnanja.Columns["pitanja"].HeaderText = "Pitanja";
            //dgvProvjereZnanja.Columns["ocjena"].HeaderText = "Ocjena";
            //dgvProvjereZnanja.Columns["Dogadjaj_idDogadjaj"].Visible = false;
            //dgvProvjereZnanja.Columns["Dogadjaj"].DisplayIndex = 0;
            dgvPS.AutoResizeColumns();
            double Avg = entities.ProvjeraZnanja.Average(x => x.ocjena);
            tbProsjecnaOcjena.Text = Math.Round(Avg, 2).ToString();
        }

        private void frmProgramSpecijalizacije_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
