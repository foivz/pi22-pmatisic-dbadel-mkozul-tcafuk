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
using e_Dnevnik.Klase;

namespace e_Dnevnik
{
    public partial class frmBiljeske : Form
    {
        PI2205_DBEntities entities = new PI2205_DBEntities();
        private MainForm mainFrm;
        private int korisnikID = Klase.RepozitorijHLK.prijavljeniKorisnik.KorisnikId;
        public frmBiljeske(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
        }
                
        public void Osvjezi()
        {
            //entities = new PI2205_DBEntities();
            entities.Biljeske.Load();
            entities.Korisnik.Load();            

            var upit = from b in entities.Biljeske.Local
                       join k in entities.Korisnik.Local on b.Korisnik_idKorisnik equals k.idKorisnik
                       where b.Korisnik_idKorisnik == korisnikID
                       select new
                       {
                           Datum_biljeske = b.datumbiljeske,
                           Biljeska = b.biljeska,
                           ID_i_ime_korisnika = b.Korisnik_idKorisnik + " " + k.PunoIme
                       };
            dgvBiljeske.DataSource = upit.ToList();

            //dgvBiljeske.DataSource = entities.Biljeske.Local;
            //dgvBiljeske.Columns["idBiljeske"].ReadOnly = true;
            ////dgvBiljeske.Columns["idBiljeske"].HeaderText = "ID bilješke";
            //dgvBiljeske.Columns["idBiljeske"].Visible = false;
            //dgvBiljeske.Columns["datumbiljeske"].HeaderText = "Datum bilješke";
            //dgvBiljeske.Columns["biljeska"].HeaderText = "Bilješka";
            //dgvBiljeske.Columns["Korisnik_idKorisnik"].Visible = false;
            //dgvBiljeske.Columns["Korisnik"].HeaderText = "ID i ime korisnika";

            dgvBiljeske.Columns["Datum_biljeske"].HeaderText = "Datum bilješke";
            dgvBiljeske.Columns["Biljeska"].HeaderText = "Bilješka";
            dgvBiljeske.Columns["ID_i_ime_korisnika"].HeaderText = "ID i ime korisnika";

            dgvBiljeske.AutoResizeColumns();
        }

        private void frmBiljeske_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainFrm.ucitajFormu(new frmDodajBiljesku(mainFrm));
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                var izabraniDatum = dgvBiljeske.CurrentRow.Cells["Datum_biljeske"].Value.ToString();
                var izabraneBiljeske = dgvBiljeske.CurrentRow.Cells["Biljeska"].Value.ToString();

                //MessageBox.Show(izabraniDatum);
                //MessageBox.Show(izabraneBiljeske);

                var upit = from b in entities.Biljeske.Local
                           where b.datumbiljeske.ToString().Equals(izabraniDatum) && b.biljeska.ToString().Equals(izabraneBiljeske) && b.Korisnik_idKorisnik == korisnikID
                           select b.idBiljeske;
                var idBiljeske = upit.First();
                //MessageBox.Show(idBiljeske.ToString());

                var deleteBiljeska = entities.Biljeske.SingleOrDefault(x => x.idBiljeske == idBiljeske);
                if (deleteBiljeska != null)
                {
                    entities.Biljeske.Remove(deleteBiljeska);
                    entities.SaveChanges();
                }

                Osvjezi();
            }
            catch
            {
                MessageBox.Show("Došlo je do pogreške.");
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            var izabranPocetak = dtpPocetak.Value;
            var izabranKraj = dtpKraj.Value;

            var upit = from b in entities.Biljeske.Local
                       join k in entities.Korisnik.Local on b.Korisnik_idKorisnik equals k.idKorisnik
                       where b.Korisnik_idKorisnik == korisnikID && (b.datumbiljeske >= izabranPocetak && b.datumbiljeske <= izabranKraj)
                       select new
                       {
                           Datum_biljeske = b.datumbiljeske,
                           Biljeska = b.biljeska,
                           ID_i_ime_korisnika = b.Korisnik_idKorisnik + " " + k.PunoIme
                       };
            dgvBiljeske.DataSource = upit.ToList();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
