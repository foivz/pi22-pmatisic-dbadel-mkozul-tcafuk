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
        }

        private void frmDogadaji_Load(object sender, EventArgs e)
        {
            dgvDogađaji.DataSource = GetProvjereZnanja();
            btnProvjereZnanja.Enabled = false;
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
        }

        private void btnDnevneAktivnosti_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = false;
            btnSlucajeviBolesnika.Enabled = true;
        }

        private void btnProvjereZnanja_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = false;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = true;
        }
    }
}
