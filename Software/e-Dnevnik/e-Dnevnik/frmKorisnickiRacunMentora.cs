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
    public partial class frmKorisnickiRacunMentora : Form
    {
        private MainForm mainFrm;
        int ID_mentora = -1;
        public frmKorisnickiRacunMentora(int ID_mentora, MainForm mainForm)
        {
            this.ID_mentora = ID_mentora;
            mainFrm = mainForm;

            InitializeComponent();
        }

        private void frmKorisnickiRacunMentora_Load(object sender, EventArgs e)
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit2 = from k in context.Korisnik
                            where k.idKorisnik == ID_mentora
                            select new
                            {
                                k.ime,
                                k.prezime,
                                k.adresa,
                                k.telefon,
                                k.email,
                                k.korime,
                                k.lozinka
                            };
                foreach (var item in upit2)
                {
                    tbIme.Text = item.ime;
                    tbPrezime.Text = item.prezime;
                    tbAdresa.Text = item.adresa;
                    tbTelefon.Text = item.telefon;
                    tbEmail.Text = item.email;
                    tbKorime.Text = item.korime;
                    tbLozinka.Text = item.lozinka;
                }
            }
        }
    }
}
