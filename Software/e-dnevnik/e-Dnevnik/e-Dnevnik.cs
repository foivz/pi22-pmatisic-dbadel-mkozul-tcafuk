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
    public partial class frmEDnevnik : Form
    {
        public frmEDnevnik()
        {
            InitializeComponent();
            pboxResize.Image = Properties.Resources.window_decrease;
        }

        private void frmEDnevnik_Load(object sender, EventArgs e)
        {

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                pboxResize.Image = Properties.Resources.window_increase;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                pboxResize.Image = Properties.Resources.window_decrease;
            }
            pboxResize.Refresh();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
