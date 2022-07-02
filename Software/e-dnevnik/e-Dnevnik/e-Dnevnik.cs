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
        bool isOpen = false;
        int sideBarWidth;

        Form openForm = null;
        public frmEDnevnik()
        {
            InitializeComponent();
            pboxResize.Image = Properties.Resources.window_decrease;
            sideBarWidth = panelSideBar.Width;
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

        //Sakrivanje menia
        private void pboxHamburger_Click(object sender, EventArgs e)
        {
            timerZatvoriMeni.Start();
        }

        private void timerZatvoriMeni_Tick(object sender, EventArgs e)
        {
            if (isOpen)
            {
                panelSideBar.Width += 20;
                if (panelSideBar.Width >= sideBarWidth)
                {
                    timerZatvoriMeni.Stop();
                    isOpen = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSideBar.Width -= 20;
                if (panelSideBar.Width <= 0)
                {
                    timerZatvoriMeni.Stop();
                    isOpen= true;
                    this.Refresh();
                }
            }
        }

        //Ucitavnje formi
        public void ucitajFormu(Form newForm)
        {
            if (openForm != null)
            {
                openForm.Close();
            }
            openForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(newForm);
            panelBody.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();

        }

        //Ostatak koda

        private void btnDnevnikAktivnosti_Click(object sender, EventArgs e)
        {
            ucitajFormu(new frmDnevnikAktivnosti());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm.Close();
            
        }

        private void btnPocetnDnevnik_Click(object sender, EventArgs e)
        {
            ucitajFormu(new frmDnevnikAktivnosti());
        }

        private void btnProfilDnevnik2_Click(object sender, EventArgs e)
        {
            ucitajFormu(new frmDnevnikAktivnosti());
        }

        private void frmEDnevnik_Load(object sender, EventArgs e)
        {
            ucitajFormu(new frmPocetnaModerator());

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
