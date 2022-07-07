using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik
{
    public partial class frmDogadaji : Form
    {
        MainForm mainForm;
        int selected;
        int ID_korisnika = -1;
        public frmDogadaji(MainForm mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();

            btnProvjereZnanja.Enabled = false;
            btnDetaljno.Enabled = false;
            selected = 1;

            dgvDogađaji.DataSource = GetProvjereZnanja();

            dgvDogađaji.AutoResizeColumns();
        }

        public frmDogadaji(int ID_korisnika,MainForm mainForm)
        {
            this.ID_korisnika = ID_korisnika;
            this.mainForm = mainForm;

            InitializeComponent();

            btnProvjereZnanja.Enabled = false;
            btnDetaljno.Enabled = false;
            selected = 1;

            dgvDogađaji.DataSource = GetProvjereZnanja();
        }

        private void frmDogadaji_Load(object sender, EventArgs e)
        {
            paintRows();

            dgvDogađaji.AutoResizeColumns();
        }

        private void btnSlucajeviBolesnika_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = false;

            dgvDogađaji.DataSource = GetSlucajeviBolesnika();

            selected = 2;
            paintRows();

        }

        private void btnDnevneAktivnosti_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = false;
            btnSlucajeviBolesnika.Enabled = true;

            dgvDogađaji.DataSource = GetDnevnikAktivnosti();

            dgvDogađaji.AutoResizeColumns();

            selected = 3;
            paintRows();
        }

        private void btnProvjereZnanja_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = false;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = true;

            dgvDogađaji.DataSource = GetProvjereZnanja();

            dgvDogađaji.AutoResizeColumns();

            selected = 1;
            paintRows();
        }


        private object GetProvjereZnanja()
        {
            if (ID_korisnika != -1)
            {
                using (var context = new PI2205_DBEntities())
                {
                    var upit =
                          from d in context.Dogadjaj
                          where d.Korisnik_idKorisnik == ID_korisnika
                          && d.TipDogadjaja_idTipDogadjaja == 1

                          from pz in context.ProvjeraZnanja
                          where pz.Dogadjaj_idDogadjaj == d.idDogadjaj

                          from t in context.TipDogadjaja
                          where t.idTipDogadjaja == d.TipDogadjaja_idTipDogadjaja

                          from k in context.Korisnik
                          where k.idKorisnik == ID_korisnika

                          select new
                          {
                              ID_dnevne = pz.idProvjeraZnanja,
                              Naziv_dogadaja = d.nazivdogadjaja,
                              Status = d.statusdogadjaja,
                              Tip = t.nazivtipa,
                              Korisnik = k.korime
                          };
                    return upit.ToList();
                }

            }

            using (var context = new PI2205_DBEntities())
            {
                var upit = from pz in context.ProvjeraZnanja
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           && d.idDogadjaj == pz.Dogadjaj_idDogadjaj
                           && d.Korisnik_idKorisnik == k.idKorisnik
                           && d.TipDogadjaja_idTipDogadjaja == t.idTipDogadjaja
                           && d.TipDogadjaja_idTipDogadjaja == 1
                           select new
                           {
                               ID_provjere = pz.idProvjeraZnanja,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status = d.statusdogadjaja,
                               Tip = t.nazivtipa,
                               Korisnik = k.korime
                           };
                return upit.ToList();
            }
        }

        private object GetSlucajeviBolesnika()
        {
            if (ID_korisnika != -1)
            {
                using (var context = new PI2205_DBEntities())
                {
                    var upit =
                          from d in context.Dogadjaj
                          where d.Korisnik_idKorisnik == ID_korisnika
                          && d.TipDogadjaja_idTipDogadjaja == 2

                          from sb in context.SlucajBolesnika
                          where sb.Dogadjaj_idDogadjaj == d.idDogadjaj

                          from t in context.TipDogadjaja
                          where t.idTipDogadjaja == d.TipDogadjaja_idTipDogadjaja

                          from k in context.Korisnik
                          where k.idKorisnik == ID_korisnika

                          select new
                          {
                              ID_dnevne = sb.idSlucajBolesnika,
                              Naziv_dogadaja = d.nazivdogadjaja,
                              Status = d.statusdogadjaja,
                              Tip = t.nazivtipa,
                              Korisnik = k.korime
                          };
                    return upit.ToList();
                }

            }

            using (var context = new PI2205_DBEntities())
            {

                var upit = from sb in context.SlucajBolesnika
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           && d.idDogadjaj == sb.Dogadjaj_idDogadjaj
                           && d.Korisnik_idKorisnik == k.idKorisnik
                           && d.TipDogadjaja_idTipDogadjaja == t.idTipDogadjaja
                           && d.TipDogadjaja_idTipDogadjaja == 2

                           select new
                           {
                               ID_slucaja = sb.idSlucajBolesnika,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status = d.statusdogadjaja,
                               Tip = t.nazivtipa,
                               Korisnik = k.korime
                           };

                return upit.ToList();
            }
        }

        private object GetDnevnikAktivnosti()
        {
            if (ID_korisnika != -1)
            {
                using (var context = new PI2205_DBEntities())
                {
                    var upit = 
                          from d in context.Dogadjaj
                            where d.Korisnik_idKorisnik == ID_korisnika
                            && d.TipDogadjaja_idTipDogadjaja == 3

                          from da in context.DnevnaAktivnost
                            where da.Dogadjaj_idDogadjaj == d.idDogadjaj

                          from t in context.TipDogadjaja
                             where t.idTipDogadjaja == d.TipDogadjaja_idTipDogadjaja

                          from k in context.Korisnik
                            where k.idKorisnik == ID_korisnika

                      select new
                      {
                          ID_dnevne = da.idDnevnaAktivnost,
                          Naziv_dogadaja = d.nazivdogadjaja,
                          Status = d.statusdogadjaja,
                          Tip = t.nazivtipa,
                          Korisnik = k.korime
                      };
                    return upit.ToList();
                }
                    
            }
            using (var context = new PI2205_DBEntities())
            {
                var upit = from da in context.DnevnaAktivnost
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           && d.idDogadjaj == da.Dogadjaj_idDogadjaj
                           && d.Korisnik_idKorisnik == k.idKorisnik
                           && d.TipDogadjaja_idTipDogadjaja == t.idTipDogadjaja
                           && d.TipDogadjaja_idTipDogadjaja == 3

                           select new
                           {
                               ID_dnevne = da.idDnevnaAktivnost,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status = d.statusdogadjaja,
                               Tip = t.nazivtipa,
                               Korisnik = k.korime
                           };
                return upit.ToList();
            }
        }
        private void paintRows()
        {
            foreach (DataGridViewRow row in dgvDogađaji.Rows)
            {
                if (row.Cells[2].Value.ToString() == "Pao rok" || row.Cells[2].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnDetaljno_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    mainForm.ucitajFormu(new frmDogadajProvjeraZnanja((int)dgvDogađaji.CurrentRow.Cells[0].Value, mainForm));
                    break;
                case 2:
                    mainForm.ucitajFormu(new frmSlucajBolesnika((int)dgvDogađaji.CurrentRow.Cells[0].Value, mainForm));
                    break;
                case 3: mainForm.ucitajFormu(new frmDogadajDnevnaAktivnost((int)dgvDogađaji.CurrentRow.Cells[0].Value, mainForm)); break;
            }
        }

        private void dgvDogađaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetaljno.Enabled = true;
        }
    }
}
