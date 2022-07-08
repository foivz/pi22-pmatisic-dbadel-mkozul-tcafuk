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
    public partial class frmEvidencijaBiljeski : Form
    {
        private int korisnikID = Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId;
        public frmEvidencijaBiljeski()
        {
            InitializeComponent();
        }

        private void frmEvidencijaBiljeski_Load(object sender, EventArgs e)
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from b in context.Biljeske
                           where b.Korisnik_idKorisnik == korisnikID
                           select b;
                List<Biljeske> sveBiljeske = upit.ToList();
                biljeskeBindingSource.DataSource = sveBiljeske;
            }

                //ReportDataSource rds = new ReportDataSource("BiljeskeDataset", upit);

            var punoIme = Klase.RepozitorijHLK.prijavljeniKorisnik.ImeKorisnika + " " + Klase.RepozitorijHLK.prijavljeniKorisnik.PrezimeKorisnika;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TrenutnoVrijeme", DateTime.Now.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Specijalizant", punoIme));
            this.reportViewer1.RefreshReport();
        }
    }
}
