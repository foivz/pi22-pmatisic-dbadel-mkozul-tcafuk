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
    public partial class frmDogadajProvjeraZnanja : Form
    {
        private MainForm mainFrm;
        private int ID_provjere = -1;
        public frmDogadajProvjeraZnanja(int ID_provjere, MainForm mainForm)
        {
            this.mainFrm = mainForm;
            this.ID_provjere = ID_provjere;
            InitializeComponent();
            getProvjera();
        }

        public void getProvjera()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from pz in context.ProvjeraZnanja
                           from d in context.Dogadjaj
                           from k in context.Korisnik
                           where pz.idProvjeraZnanja == ID_provjere
                           && d.idDogadjaj == pz.Dogadjaj_idDogadjaj
                           && k.idKorisnik == d.Korisnik_idKorisnik
                           select new
                           {
                               Korisnik = k.korime,
                               Ocjena = pz.ocjena,
                               Pitanja = pz.pitanja,
                               Datum = pz.datumprovjere,
                               Status = d.statusdogadjaja
                           };

                foreach (var s in upit)
                {
                    dtpProvjeraZnanja.Value = s.Datum;
                    tbPitanja.Text = s.Pitanja;
                    cbOcjene.Text = s.Ocjena.ToString();
                    cbDogadaj.Text = s.Status;
                    cbSpecijalizant.Text = s.Korisnik;

                    dtpProvjeraZnanja.Enabled = false;
                    tbPitanja.Enabled = false;
                    cbOcjene.Enabled = false;
                    cbDogadaj.Enabled = false;
                    cbSpecijalizant.Enabled = false;
                }
            }
            
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmPocetnaModerator(mainFrm));
        }
    }
}
