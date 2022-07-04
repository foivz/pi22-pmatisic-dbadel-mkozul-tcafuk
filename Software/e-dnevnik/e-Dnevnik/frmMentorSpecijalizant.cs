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
    public partial class frmMentorSpecijalizant : Form
    {
        public frmMentorSpecijalizant(MainForm mainFrm)
        {
            InitializeComponent();
            if(mainFrm.uloga == MainForm.uloge.glavni_mentor)
            {
                lblTitle.Text = "Prikaz mentora i specijalizanata";
                pnlFilter.Visible = true;
            }
        }

        private void lblFilter_Click(object sender, EventArgs e)
        {
        }

        private void frmMentorSpecijalizant_Load(object sender, EventArgs e)
        {
            dgvMentoriSpecijalizanti.DataSource = GetMentoriSpecijalizanti();
            dgvMentoriSpecijalizanti.Columns["ProgramSpecijalizacije_idProgramSpecijalizacije"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["Uloga_idUloga"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["Biljeske"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["Dogadjaj"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["ProgramSpecijalizacije"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["Uloga"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["PrijavaIspita"].Visible = false;
            dgvMentoriSpecijalizanti.Columns["StrucniRad"].Visible = false;
        }

        private object GetMentoriSpecijalizanti()
        {
            using (var context = new PI2205_DBEntities())
            {
                return context.Korisnik.ToList();
            }
        }
    }
}
