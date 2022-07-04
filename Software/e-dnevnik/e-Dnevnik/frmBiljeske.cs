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
            entities.Biljeske.Load();
            dgvBiljeske.DataSource = entities.Biljeske.Local;
            dgvBiljeske.Columns["idBiljeske"].ReadOnly = true;
            dgvBiljeske.Columns["idBiljeske"].HeaderText = "ID bilješke";
            dgvBiljeske.Columns["datumbiljeske"].HeaderText = "Datum bilješke";
            dgvBiljeske.AutoResizeColumns();
        }

        private void frmBiljeske_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
