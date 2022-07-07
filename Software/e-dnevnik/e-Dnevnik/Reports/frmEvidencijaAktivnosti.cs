using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik.Reports
{
    public partial class frmEvidencijaAktivnosti : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        public frmEvidencijaAktivnosti()
        {
            InitializeComponent();
            entities.DnevnaAktivnost.Load();
        }

        private void frmEvidencijaAktivnosti_Load(object sender, EventArgs e)
        {
            var upit = from a in entities.DnevnaAktivnost.Local
                       select a;

            ReportDataSource rds = new ReportDataSource("DnevnikAktivnostiDataset", upit);

            var punoIme = Klase.RepozitorijHLK.prijavljeniKorisnik.ImeKorisnika + " " + Klase.RepozitorijHLK.prijavljeniKorisnik.PrezimeKorisnika;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CurrentTime", DateTime.Now.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Specijalizant", punoIme));

            this.reportViewer1.RefreshReport();
        }
    }
}
