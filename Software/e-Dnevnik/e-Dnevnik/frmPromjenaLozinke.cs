using e_Dnevnik.Klase;
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
    public partial class frmPromjenaLozinke : Form
    {
        private bool seePassword1 = false;
        private bool seePassword2 = false;
        MainForm mainFrm;
        public frmPromjenaLozinke(MainForm mainForm)
        {
            this.KeyPreview = true;
            this.mainFrm = mainForm;
            InitializeComponent();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmKorisnickiRacun(mainFrm));
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text != textBoxPonovljena.Text)
            {
                MessageBox.Show("Lozinke se ne podudaraju!");
            }
            else if (textBoxLozinka.Text.Length < 3)
            {
                MessageBox.Show("Lozinka mora biti minimalno 3 znakova!");
            }
            else
            {
                RepozitorijHLK.AzurirajKorisnika(Klase.RepozitorijHLK.prijavljeniKorisnik.EmailKorisnika, textBoxLozinka.Text);
                mainFrm.ucitajFormu(new frmKorisnickiRacun(mainFrm));
            }
        }

        private void frmPromjenaLozinke_Load(object sender, EventArgs e)
        {
            textBoxLozinka.PasswordChar = '•';
            textBoxPonovljena.PasswordChar = '•';
        }

        private void buttonSakrij_Click(object sender, EventArgs e)
        {
            if (seePassword1)
            {
                textBoxLozinka.PasswordChar = '•';
                seePassword1 = false;
            }
            else
            {
                textBoxLozinka.PasswordChar = '\0';
                seePassword1 = true;
            }
        }

        private void buttonSakrij2_Click(object sender, EventArgs e)
        {
            if (seePassword2)
            {
                textBoxPonovljena.PasswordChar = '•';
                seePassword2 = false;
            }
            else
            {
                textBoxPonovljena.PasswordChar = '\0';
                seePassword2 = true;
            }
        }
    }
}
