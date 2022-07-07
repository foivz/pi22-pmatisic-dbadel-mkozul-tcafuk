using e_Dnevnik.Klase;
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
    public partial class frmKorisnickiRacun : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private MainForm mainFrm;
        public frmKorisnickiRacun(MainForm mainForm)
        {
            entities.Korisnik.Load();
            this.mainFrm = mainForm;
            InitializeComponent();
        }

        private void buttonPromijeni_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmPromjenaLozinke(mainFrm));
        }

        private void frmKorisnickiRacun_Load(object sender, EventArgs e)
        {
            var upit = from k in entities.Korisnik.Local
                        where Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId == k.idKorisnik
                        select new
                        {
                            k.ime,
                            k.prezime,
                            k.adresa,
                            k.telefon,
                            k.email,
                            k.korime,
                            k.lozinka
                        };
            foreach (var item in upit)
            {
                tbIme.Text = item.ime;
                tbPrezime.Text = item.prezime;
                tbAdresa.Text = item.adresa;
                tbTelefon.Text = item.telefon;
                tbEmail.Text = item.email;
                tbKorime.Text = item.korime;
                tbLozinka.Text = item.lozinka;
            }

        }

        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {
            Klase.RepozitorijHLK.prijavljeniKorisnik.ImeKorisnika = tbIme.Text;
            Klase.RepozitorijHLK.prijavljeniKorisnik.PrezimeKorisnika = tbPrezime.Text;
            Klase.RepozitorijHLK.prijavljeniKorisnik.AdresaKorisnika = tbAdresa.Text;
            Klase.RepozitorijHLK.prijavljeniKorisnik.KontaktTelefonKorisnika = tbTelefon.Text;
            Klase.RepozitorijHLK.prijavljeniKorisnik.EmailKorisnika = tbEmail.Text;
            Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnickoImeKorisnika = tbKorime.Text;

            int numAffectedRows = Klase.RepozitorijHLK.AzurirajKorisnika(Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId, Klase.RepozitorijHLK.prijavljeniKorisnik);
            if (numAffectedRows > 0)
            {
                MessageBox.Show("Uspješno ste ažurirali podatke! ");

            }
        }
    }
}
