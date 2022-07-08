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
        int selected;
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
            btnPogledajDogadaj.Enabled = false;
            selected = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            paintRows();
        }

        private void frmPocetnaModerator_Load(object sender, EventArgs e)
        {

            dgvPocetnaAktivnosti.AutoResizeColumns();
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

            paintRows();
            dgvPocetnaAktivnosti.AutoResizeColumns();
            selected = 1;

        }

        private void btnSlucajeviBolesnika_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = true;
            btnSlucajeviBolesnika.Enabled = false;
            dgvPocetnaAktivnosti.DataSource = dogadaj.GetSlucajeviBolesnika();

            paintRows();
            dgvPocetnaAktivnosti.AutoResizeColumns();
            selected = 2;

        }

        private void btnDnevneAktivnosti_Click(object sender, EventArgs e)
        {
            btnProvjereZnanja.Enabled = true;
            btnDnevneAktivnosti.Enabled = false;
            btnSlucajeviBolesnika.Enabled = true;
            dgvPocetnaAktivnosti.DataSource = dogadaj.GetDnevnikAktivnosti();

            paintRows();
            dgvPocetnaAktivnosti.AutoResizeColumns();
            selected = 3;
        }

        private void dgvPocetnaAktivnosti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPogledajDogadaj.Enabled = true;
        }

        private void btnPogledajDogadaj_Click(object sender, EventArgs e)
        {
            switch (selected)
            {
                case 1:
                    mainFrm.ucitajFormu(new frmDogadajProvjeraZnanja((int)dgvPocetnaAktivnosti.CurrentRow.Cells[0].Value, mainFrm));

                    break;
                case 2:
                    mainFrm.ucitajFormu(new frmSlucajBolesnika((int)dgvPocetnaAktivnosti.CurrentRow.Cells[0].Value, mainFrm));
                break;
                case 3: mainFrm.ucitajFormu(new frmDogadajDnevnaAktivnost((int)dgvPocetnaAktivnosti.CurrentRow.Cells[0].Value, mainFrm)); break;
            }
        }

        private void btnProvjereZnanjaBody_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmProvjeraZnanja(mainFrm));
        }

        private void paintRows()
        {
            foreach (DataGridViewRow row in dgvPocetnaAktivnosti.Rows)
            {
                if (row.Cells[2].Value.ToString() == "Pao rok" || row.Cells[2].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
    }
}
