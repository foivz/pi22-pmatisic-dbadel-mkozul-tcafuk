using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static e_Dnevnik.frmEDnevnik;

namespace e_Dnevnik
{
    public partial class frmPocetnaModerator : Form
    {
        private MainForm mainFrm;
        Dogadaji dogadaj;
        public frmPocetnaModerator(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
            dogadaj = new Dogadaji();

            dogadaj.mainForm = mainFrm;

            if (mainFrm.uloga == MainForm.uloge.mentor)
            {
                lblMentori.Text = "Specijalizanti";
            }


            btnProvjereZnanja.Enabled = false;
            dgvPocetnaAktivnosti.DataSource = dogadaj.GetProvjereZnanja();
            dgvPocetnaAktivnosti.AutoResizeColumns();
            btnPogledajDogadaj.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPocetnaModerator_Load(object sender, EventArgs e)
        {

        }

        private void btnPocetnDnevnik_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmDogadaji(mainFrm));
        }

        private void btnMentoriSpecijalizant_click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmMentorSpecijalizant(mainFrm));
        }

        private void btnProvjereZnanja_Click(object sender, EventArgs e)
        {
            

            btnProvjereZnanja.Enabled = false;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = true;
            dgvPocetnaAktivnosti.DataSource = dogadaj.GetProvjereZnanja();

        }

        private void btnSlucajeviBolesnika_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = false;
            dgvPocetnaAktivnosti.DataSource = dogadaj.GetSlucajeviBolesnika();

        }

        private void btnDnevneAktivnosti_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = false;
            btnSlucajeviBolesnika.Enabled = true;
            dgvPocetnaAktivnosti.DataSource = dogadaj.GetDnevnikAktivnosti();
        }

        private void dgvPocetnaAktivnosti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPogledajDogadaj.Enabled = true;
        }

        private void btnPogledajDogadaj_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmSlucajBolesnika((int)dgvPocetnaAktivnosti.CurrentRow.Cells[0].Value, mainFrm));
        }
    }
}
