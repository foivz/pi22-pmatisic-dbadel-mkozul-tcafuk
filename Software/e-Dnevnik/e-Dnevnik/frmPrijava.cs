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
    public partial class frmPrijava : Form
    {
        MainForm mainForm;
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            Program.ValidLogin = true;
            this.Close();
        }
    }
}
