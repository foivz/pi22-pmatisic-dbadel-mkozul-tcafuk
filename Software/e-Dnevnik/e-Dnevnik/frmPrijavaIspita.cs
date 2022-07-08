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
    public partial class frmPrijavaIspita : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private int korisnikID = Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId;
        public frmPrijavaIspita()
        {
            InitializeComponent();
            entities.Dogadjaj.Load();
            entities.Korisnik.Load();
            entities.ProgramSpecijalizacije.Load();
        }

        private void Osvjezi()
        {
            var prijava = "Novi rok";
            var upitPrijava = from d in entities.Dogadjaj.Local
                              join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                              join p in entities.ProgramSpecijalizacije.Local on k.ProgramSpecijalizacije_idProgramSpecijalizacije equals p.idProgramSpecijalizacije
                              where d.statusdogadjaja == prijava
                              orderby d.nazivdogadjaja descending
                              select new
                              {
                                  d.nazivdogadjaja,
                                  d.statusdogadjaja,
                                  d.datumodrzavanja,
                                  p.nazivps
                              };

            var crtica = "- Nema -";
            if (upitPrijava.Any() == true)
            {
                foreach (var item in upitPrijava)
                {
                    tbProgramPrijavi.Text = item.nazivps;
                    tbNazivPrijavi.Text = item.nazivdogadjaja;
                    tbStatusPrijavi.Text = item.statusdogadjaja;
                    tbDatumPrijavi.Text = item.datumodrzavanja.ToString();
                    btnPrijavi.Visible = true;
                }
            }
            else
            {
                tbProgramPrijavi.Text = crtica;
                tbNazivPrijavi.Text = crtica;
                tbStatusPrijavi.Text = crtica;
                tbDatumPrijavi.Text = crtica;
                btnPrijavi.Visible = false;
            }

            var prijavljeno = "Prijavljeno";
            var upitPrijavljeno = from d in entities.Dogadjaj.Local
                                  join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                                  join p in entities.ProgramSpecijalizacije.Local on k.ProgramSpecijalizacije_idProgramSpecijalizacije equals p.idProgramSpecijalizacije
                                  where d.statusdogadjaja == prijavljeno
                                  orderby d.nazivdogadjaja ascending
                                  select new
                                  {
                                      d.nazivdogadjaja,
                                      d.statusdogadjaja,
                                      d.datumodrzavanja,
                                      p.nazivps
                                  };

            if (upitPrijavljeno.Any() == true)
            {
                foreach (var attr in upitPrijavljeno)
                {
                    tbProgramPrijavljeno.Text = attr.nazivps;
                    tbNazivPrijavljeno.Text = attr.nazivdogadjaja;
                    tbStatusPrijavljeno.Text = attr.statusdogadjaja;
                    tbDatumPrijavljeno.Text = attr.datumodrzavanja.ToString();
                }
                btnOdjava.Visible = true;
            }
            else
            {
                tbProgramPrijavljeno.Text = crtica;
                tbNazivPrijavljeno.Text = crtica;
                tbStatusPrijavljeno.Text = crtica;
                tbDatumPrijavljeno.Text = crtica;
                btnOdjava.Visible = false;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            var dogadaj = tbNazivPrijavljeno.Text;
            var statusDogadaja = tbStatusPrijavljeno.Text;
            var upit = from d in entities.Dogadjaj.Local
                       join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                       where d.nazivdogadjaja == dogadaj && d.statusdogadjaja == statusDogadaja
                       select d.idDogadjaj;
            var IdDogadaja = upit.First();
            var noviStatus = "Novi rok";
            var updateDogadaj = entities.Dogadjaj.SingleOrDefault(x => x.idDogadjaj == IdDogadaja);
            if (updateDogadaj != null)
            {
                updateDogadaj.statusdogadjaja = noviStatus;
                entities.SaveChanges();
            }
            Osvjezi();
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            var dogadaj = tbNazivPrijavi.Text;
            var statusDogadaja = tbStatusPrijavi.Text;
            var upit = from d in entities.Dogadjaj.Local
                       join k in entities.Korisnik.Local on d.Korisnik_idKorisnik equals korisnikID
                       where d.nazivdogadjaja == dogadaj && d.statusdogadjaja == statusDogadaja
                       select d.idDogadjaj;
            var IdDogadaja = upit.First();
            var noviStatus = "Prijavljeno";
            var updateDogadaj = entities.Dogadjaj.SingleOrDefault(x => x.idDogadjaj == IdDogadaja);
            if (updateDogadaj != null)
            {
                updateDogadaj.statusdogadjaja = noviStatus;
                entities.SaveChanges();
            }
            Osvjezi();
        }

        private void frmPrijavaIspita_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
