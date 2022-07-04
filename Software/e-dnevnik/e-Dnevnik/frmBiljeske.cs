using e_Dnevnik.Data;
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

namespace e_Dnevnik
{
    public partial class frmBiljeske : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        public frmBiljeske()
        {
            InitializeComponent();
        }

        public void Osvjezi()
        {
            entities.Biljeskes.Load();
            dgvEvidencijaBiljeski.DataSource = entities.Biljeskes.Local;
            dgvEvidencijaBiljeski.Columns["idBiljeske"].HeaderText = "ID bilješke";
            dgvEvidencijaBiljeski.Columns["datumbiljeske"].HeaderText = "Datum nastanka bilješke";
            dgvEvidencijaBiljeski.Columns["biljeska"].HeaderText = "Bilješka";
            dgvEvidencijaBiljeski.Columns["Korisnik_idKorisnik"].HeaderText = "Korisnik";
            //dgvEvidencijaBiljeski.Columns["Korisnik"].Visible = false;
            dgvEvidencijaBiljeski.Columns["idBiljeske"].ReadOnly = true;
            dgvEvidencijaBiljeski.AutoResizeColumns();
        }

        private void frmBiljeske_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
