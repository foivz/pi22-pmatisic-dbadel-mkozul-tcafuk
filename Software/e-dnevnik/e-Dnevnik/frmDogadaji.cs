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
        public frmDogadaji(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            btnProvjereZnanja.Enabled = false;
            dgvDogađaji.DataSource = GetProvjereZnanja();
            btnDetaljno.Enabled = false;
        }

        private void frmDogadaji_Load(object sender, EventArgs e)
        {
            paintRows();
        }

        private object GetProvjereZnanja()
        {

            using(var context = new PI2205_DBEntities())
            {
                var upit = from pz in context.ProvjeraZnanja
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == 2
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSlucajeviBolesnika_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = false;
            dgvDogađaji.DataSource = GetSlucajeviBolesnika();
            paintRows();

        }

        private object GetSlucajeviBolesnika()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from sb in context.SlucajBolesnika
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == 1
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

        private void btnDnevneAktivnosti_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = false;
            btnSlucajeviBolesnika.Enabled = true;
            dgvDogađaji.DataSource = GetDnevnikAktivnosti();
            paintRows();
        }

        private object GetDnevnikAktivnosti()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from da in context.DnevnaAktivnost
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == 1
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

        private void btnProvjereZnanja_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = false;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = true;
            dgvDogađaji.DataSource = GetProvjereZnanja();
            paintRows();
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
            
            mainForm.ucitajFormu(new frmSlucajBolesnika((int)dgvDogađaji.CurrentRow.Cells[0].Value,mainForm));
        }

        private void dgvDogađaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetaljno.Enabled = true;
        }
    }
}
