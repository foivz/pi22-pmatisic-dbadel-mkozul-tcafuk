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
    public partial class frmDodajBiljesku : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private MainForm mainFrm;
        public frmDodajBiljesku(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmBiljeske(mainFrm));
        }

        private void btnDodajBiljesku_Click(object sender, EventArgs e)
        {
            try
            {
                var datum = dtpBiljeska.Value;
                var biljeska = rtbBiljeska.Text;

                Biljeske unosBiljeske = new Biljeske
                {
                    datumbiljeske = datum,
                    biljeska = biljeska,
                    Korisnik_idKorisnik = 2
                };

                entities.Biljeske.Add(unosBiljeske);
                entities.SaveChanges();

                mainFrm.ucitajFormu(new frmBiljeske(mainFrm));
            }
            catch
            {
                MessageBox.Show("Došlo je do greške.");
            }
        }
    }
}
