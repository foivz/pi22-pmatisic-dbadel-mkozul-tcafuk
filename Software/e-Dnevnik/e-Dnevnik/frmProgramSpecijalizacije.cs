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

            var cbUpit = (from ps in entities.ProgramSpecijalizacije.Local
                          select ps.nazivps).Distinct();

            cbPS.DataSource = cbUpit.ToList();

            var upit = from ps in entities.ProgramSpecijalizacije.Local
                       join k in entities.Korisnik.Local on ps.idProgramSpecijalizacije equals k.ProgramSpecijalizacije_idProgramSpecijalizacije
                       join pi in entities.PrijavaIspita.Local on k.idKorisnik equals pi.Korisnik_idKorisnik
                       group new { ps, k, pi } by new { ps.nazivps, k.idKorisnik, pi.idPrijavaIspita }
                       into grp
                       select new
                       {
                           Naziv_programa_specijalizacije = grp.Key.nazivps,
                           Broj_specijalizanata = grp.Count(),
                           Broj_prijava_ispita = grp.Count()
                       };
            dgvPS1.DataSource = upit.ToList();

            var upit2 = from k in entities.Korisnik.Local
                        from u in entities.Uloga.Local
                        from ps in entities.ProgramSpecijalizacije.Local
                        from pi in entities.PrijavaIspita.Local
                        where k.Uloga_idUloga == u.idUloga && k.ProgramSpecijalizacije_idProgramSpecijalizacije == ps.idProgramSpecijalizacije && pi.Korisnik_idKorisnik == k.idKorisnik
                        orderby pi.nazivispitivaca
                        select new
                        {
                            Ime = k.ime,
                            Prezime = k.prezime,
                            Email = k.email,
                            Naziv_uloge = u.nazivuloge,
                            Naziv_programa_specijalizacije = ps.nazivps,
                            Duljina_programa_specijalizacije = ps.duljinaps,
                            Naziv_ispitivaca = pi.nazivispitivaca,
                            Datum_ispita = pi.datumispita,
                            Polozio = pi.polozen
                        };
            dgvPS2.DataSource = upit2.ToList();

            dgvPS1.AutoResizeColumns();
            dgvPS2.AutoResizeColumns();
        }

        private void frmProgramSpecijalizacije_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void cbPS_SelectedValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                var upit = from ps in entities.ProgramSpecijalizacije.Local
                           join k in entities.Korisnik.Local on ps.idProgramSpecijalizacije equals k.ProgramSpecijalizacije_idProgramSpecijalizacije
                           join pi in entities.PrijavaIspita.Local on k.idKorisnik equals pi.Korisnik_idKorisnik
                           where ps.nazivps == cbPS.SelectedValue.ToString()
                           group new { ps, k, pi } by new { ps.nazivps, k.idKorisnik, pi.idPrijavaIspita }
                           into grp
                           select new
                           {
                               Naziv_programa_specijalizacije = grp.Key.nazivps,
                               Broj_specijalizanata = grp.Count(),
                               Broj_prijava_ispita = grp.Count()
                           };
                dgvPS1.DataSource = upit.ToList();
                dgvPS1.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Ne postoje podatci za taj program specijalizacije.");
                Osvjezi();
            }
        }

        private void btnOsvjezi_Click_1(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
