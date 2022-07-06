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
                       select new
                       {
                           Naziv_aktivnosti = a.nazivaktivnosti,
                           Opis_aktivnosti = a.opisaktivnosti,
                           Datum_obavljene_aktivnosti = a.datumobavljeneaktivnosti,
                           Broj_samostalnih_zahvata = a.brojsamostalnihzahvata,
                           Broj_zahvata_uz_nadzor = a.brojzahvatauznadzor
                       };
            dgvEvidencijaDnevnihAktivnosti.DataSource = upitAktivnost.Distinct().ToList();

            var upitProvjera = from p in entities.ProvjeraZnanja.Local
                                join d in entities.Dogadjaj.Local on p.Dogadjaj_idDogadjaj equals d.idDogadjaj
                                join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                                select new
                                {
                                    Naziv_aktivnosti = p.datumprovjere,
                                    Pitanja = p.pitanja,
                                    Ocjena = p.ocjena,
                                    Naziv_dogadaja = d.nazivdogadjaja,
                                    Status_dogadaja = d.statusdogadjaja
                                };
            dgvEvidencijaProvjeraZnanja.DataSource = upitProvjera.Distinct().ToList();

            var upitBiljeske = from b in entities.Biljeske.Local
                               where b.Korisnik_idKorisnik == korisnikID
                               select new
                               {
                                   Datum_biljeske = b.datumbiljeske,
                                   Biljeska = b.biljeska
                               };
            dgvEvidencijaBiljeski.DataSource = upitBiljeske.Distinct().ToList();

            dgvEvidencijaDnevnihAktivnosti.AutoResizeColumns();
            dgvEvidencijaProvjeraZnanja.AutoResizeColumns();
            dgvEvidencijaBiljeski.AutoResizeColumns();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {

        }
    }
}