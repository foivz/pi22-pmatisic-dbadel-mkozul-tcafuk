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
        public int a = 1;
        public frmPocetnaModerator(uloge uloga)
        {
            InitializeComponent();
            if (uloga == uloge.mentor)
            {
                lblMentori.Text = "Specijalizanti";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
