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
        public frmPocetnaModerator(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
            if (mainFrm.uloga == MainForm.uloge.mentor)
            {
                lblMentori.Text = "Specijalizanti";
            }
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
    }
}
