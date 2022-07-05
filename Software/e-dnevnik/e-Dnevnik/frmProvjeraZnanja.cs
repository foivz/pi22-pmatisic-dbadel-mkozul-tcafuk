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
    public partial class frmProvjeraZnanja : Form
    {
        MainForm mainForm;
        frmEDnevnik frm;
        public frmProvjeraZnanja()
        {
            InitializeComponent();
            mainForm = new MainForm();
            frm = new frmEDnevnik();
        }

        private void btnPrijaviIspit_Click(object sender, EventArgs e)
        {
            mainForm.ucitajFormu(new frmPrijavaIspita());
        }
    }
}
