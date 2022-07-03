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

        }
    }
}
