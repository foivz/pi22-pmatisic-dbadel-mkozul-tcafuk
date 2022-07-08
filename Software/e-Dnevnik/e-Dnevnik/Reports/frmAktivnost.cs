using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik.Reports
{
    public partial class frmAktivnost : Form
    {
        private int korisnikID = Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId;
        public frmAktivnost()
        {
            InitializeComponent();
        }

        private void frmAktivnost_Load(object sender, EventArgs e)
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from a in context.DnevnaAktivnost
                           join d in context.Dogadjaj on a.Dogadjaj_idDogadjaj equals d.idDogadjaj
                           where d.Korisnik_idKorisnik == korisnikID
                           select a;
                List<DnevnaAktivnost> sveAktivnosti = upit.ToList();
                dnevnaAktivnostBindingSource.DataSource = sveAktivnosti;
            }

            var punoIme = Klase.RepozitorijHLK.prijavljeniKorisnik.ImeKorisnika + " " + Klase.RepozitorijHLK.prijavljeniKorisnik.PrezimeKorisnika;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TrenutnoVrijeme", DateTime.Now.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Specijalizant", punoIme));
            this.reportViewer1.RefreshReport();
        }
    }
}
