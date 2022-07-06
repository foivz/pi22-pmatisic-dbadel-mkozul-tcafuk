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
        }

        private void frmDnevnik_Load(object sender, EventArgs e)
        {
            dgvEvidencijaDnevnihAktivnosti.DataSource = entities.DnevnaAktivnost.Local;
            dgvEvidencijaProvjeraZnanja.DataSource = entities.ProvjeraZnanja.Local;
            dgvEvidencijaBiljeski.DataSource = entities.Biljeske.Local;

            //var upit = from a in entities.DnevnaAktivnost.Local
            //           from d in entities.Dogadjaj.Local
            //           from k in entities.Korisnik.Local
            //           where a.Dogadjaj_idDogadjaj == d.idDogadjaj && d.Korisnik_idKorisnik == korisnikID
            //           select new
            //           {
            //               a.nazivaktivnosti,
            //               a.opisaktivnosti,
            //               a.datumobavljeneaktivnosti,
            //               a.brojsamostalnihzahvata,
            //               a.brojzahvatauznadzor
            //           };
            //dgvEvidencijaDnevnihAktivnosti.DataSource = upit.ToList();

            dgvEvidencijaDnevnihAktivnosti.AutoResizeColumns();
            dgvEvidencijaProvjeraZnanja.AutoResizeColumns();
            dgvEvidencijaBiljeski.AutoResizeColumns();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {

        }
    }
}