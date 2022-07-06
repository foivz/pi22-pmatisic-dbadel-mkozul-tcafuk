﻿using System;
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
        private MainForm mainFrm;
        public frmBiljeske(MainForm mainForm)
        {
            this.mainFrm = mainForm;
            InitializeComponent();
        }

        public void Osvjezi()
        {
            entities = new PI2205_DBEntities();
            entities.Biljeske.Load();
            entities.Korisnik.Load();

            dgvBiljeske.DataSource = entities.Biljeske.Local;
            dgvBiljeske.Columns["idBiljeske"].ReadOnly = true;
            //dgvBiljeske.Columns["idBiljeske"].HeaderText = "ID bilješke";
            dgvBiljeske.Columns["idBiljeske"].Visible = false;
            dgvBiljeske.Columns["datumbiljeske"].HeaderText = "Datum bilješke";
            dgvBiljeske.Columns["biljeska"].HeaderText = "Bilješka";
            dgvBiljeske.Columns["Korisnik_idKorisnik"].Visible = false;
            dgvBiljeske.Columns["Korisnik"].HeaderText = "ID i ime korisnika";
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
                var izabraniDatum = dgvBiljeske.CurrentRow.Cells["datumbiljeske"].Value.ToString();
                var izabraneBiljeske = dgvBiljeske.CurrentRow.Cells["biljeska"].Value.ToString();

                //MessageBox.Show(izabraniDatum);
                //MessageBox.Show(izabraneBiljeske);

                var upit = from b in entities.Biljeske.Local
                           where b.datumbiljeske.ToString().Equals(izabraniDatum) && b.biljeska.ToString().Equals(izabraneBiljeske)
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
    }
}
