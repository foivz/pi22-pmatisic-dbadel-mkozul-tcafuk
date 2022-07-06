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
    public partial class frmPrijava : Form
    {
        bool SeePassword = false;
        bool Autentikacija = false;

        public frmPrijava()
        {
            this.KeyPreview = true;
            InitializeComponent();
            SetupPasswordTextbox();
        }

        private void SetupPasswordTextbox()
        {
            textBoxLozinka.PasswordChar = '•';
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            string KorisnickoIme = textBoxKorime.Text;
            string Lozinka = textBoxLozinka.Text;

            List<Klase.Korisnik> korisnici = RepozitorijHLK.DohvatiSveKorisnike();
            Klase.Korisnik korisnik = new Klase.Korisnik();
            foreach (var item in korisnici)
            {
                if (KorisnickoIme == item.KorisnickoImeKorisnika && Lozinka == item.LozinkaKorisnika)
                {
                    Autentikacija = true;
                    korisnik = item;
                }
            }

            if (Autentikacija == true)
            {
                RepozitorijHLK.prijavljeniKorisnik = korisnik;
                Program.ValidLogin = true; //otvaranje glavne forme
                this.Close();
            }
            else
            {
                MessageBox.Show("Korisnik sa navedenim podacima ne postoji!");
            }
        }

        private void buttonSakrij_Click(object sender, EventArgs e)
        {
            if (SeePassword)
            {
                textBoxLozinka.PasswordChar = '•';
                SeePassword = false;
            }
            else
            {
                textBoxLozinka.PasswordChar = '\0';
                SeePassword = true;
            }
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelZabLozinka_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmZaboravljenaLozinka form = new frmZaboravljenaLozinka();
            form.ShowDialog();
        }

        //private void frmPrijava_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F1)
        //    {
        //        Controler controler = new Controler();

        //        controler.OtvoriUserHelp(this, "Prijava.htm");
        //    }
        //}
    }
}
