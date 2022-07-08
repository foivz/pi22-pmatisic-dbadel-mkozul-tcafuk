using e_Dnevnik.Reports;
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
    public partial class frmDnevnik : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private int korisnikID = Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId;
        public frmDnevnik()
        {
            InitializeComponent();
            entities.DnevnaAktivnost.Load();
            entities.ProvjeraZnanja.Load();
            entities.Biljeske.Load();
            entities.Dogadjaj.Load();
            entities.Korisnik.Load();
        }

        private void frmDnevnik_Load(object sender, EventArgs e)
        {
            //dgvEvidencijaDnevnihAktivnosti.DataSource = entities.DnevnaAktivnost.Local;
            //dgvEvidencijaProvjeraZnanja.DataSource = entities.ProvjeraZnanja.Local;
            //dgvEvidencijaBiljeski.DataSource = entities.Biljeske.Local;

            var upitAktivnost = from a in entities.DnevnaAktivnost.Local
                       join d in entities.Dogadjaj.Local on a.Dogadjaj_idDogadjaj equals d.idDogadjaj
                       join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                       orderby a.datumobavljeneaktivnosti ascending
                       select new
                       {
                           Naziv_aktivnosti = a.nazivaktivnosti,
                           Opis_aktivnosti = a.opisaktivnosti,
                           Datum_obavljene_aktivnosti = a.datumobavljeneaktivnosti,
                           Broj_samostalnih_zahvata = a.brojsamostalnihzahvata,
                           Broj_zahvata_uz_nadzor = a.brojzahvatauznadzor
                       };
            dgvEvidencijaDnevnihAktivnosti.DataSource = upitAktivnost.Distinct().ToList();

            dgvEvidencijaDnevnihAktivnosti.Columns["Naziv_aktivnosti"].HeaderText = "Naziv aktivnosti";
            dgvEvidencijaDnevnihAktivnosti.Columns["Opis_aktivnosti"].HeaderText = "Opis aktivnosti";
            dgvEvidencijaDnevnihAktivnosti.Columns["Datum_obavljene_aktivnosti"].HeaderText = "Datum obavljene aktivnosti";
            dgvEvidencijaDnevnihAktivnosti.Columns["Broj_samostalnih_zahvata"].HeaderText = "Broj samostalnih aktivnosti";
            dgvEvidencijaDnevnihAktivnosti.Columns["Broj_zahvata_uz_nadzor"].HeaderText = "Broj zahvata uz nadzor";

            var upitProvjera = from p in entities.ProvjeraZnanja.Local
                                join d in entities.Dogadjaj.Local on p.Dogadjaj_idDogadjaj equals d.idDogadjaj
                                join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                                orderby p.datumprovjere ascending
                                select new
                                {
                                    Naziv_aktivnosti = p.datumprovjere,
                                    Pitanja = p.pitanja,
                                    Ocjena = p.ocjena,
                                    Naziv_dogadaja = d.nazivdogadjaja,
                                    Status_dogadaja = d.statusdogadjaja
                                };
            dgvEvidencijaProvjeraZnanja.DataSource = upitProvjera.Distinct().ToList();

            dgvEvidencijaProvjeraZnanja.Columns["Naziv_aktivnosti"].HeaderText = "Naziv aktivnosti";
            dgvEvidencijaProvjeraZnanja.Columns["Naziv_dogadaja"].HeaderText = "Naziv događaja";
            dgvEvidencijaProvjeraZnanja.Columns["Status_dogadaja"].HeaderText = "Status događaja";

            var upitBiljeske = from b in entities.Biljeske.Local
                               where b.Korisnik_idKorisnik == korisnikID
                               orderby b.datumbiljeske ascending
                               select new
                               {
                                   Datum_biljeske = b.datumbiljeske,
                                   Biljeska = b.biljeska
                               };
            dgvEvidencijaBiljeski.DataSource = upitBiljeske.Distinct().ToList();

            dgvEvidencijaBiljeski.Columns["Datum_biljeske"].HeaderText = "Datum bilješke";
            dgvEvidencijaBiljeski.Columns["Biljeska"].HeaderText = "Bilješka";

            dgvEvidencijaDnevnihAktivnosti.AutoResizeColumns();
            dgvEvidencijaProvjeraZnanja.AutoResizeColumns();
            dgvEvidencijaBiljeski.AutoResizeColumns();
        }

        private void btnIspisiAktivnosti_Click(object sender, EventArgs e)
        {
            frmAktivnost reportAktivnosti = new frmAktivnost();
            reportAktivnosti.ShowDialog();
        }

        private void btnIspisiProvjere_Click(object sender, EventArgs e)
        {
            frmEvidencijaProvjera reportProvjere = new frmEvidencijaProvjera();
            reportProvjere.ShowDialog();
        }

        private void btnIspisiBiljeske_Click(object sender, EventArgs e)
        {
            frmEvidencijaBiljeski reportBiljeske = new frmEvidencijaBiljeski();
            reportBiljeske.ShowDialog();
        }
    }
}