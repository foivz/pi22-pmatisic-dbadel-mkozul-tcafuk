using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik
{
    public class MainForm
    {
        public Form openForm { get; set; }
        public Panel panelBody { get; set; }

        public enum uloge
        {
            specijalizant,
            mentor,
            glavni_mentor
        }

        public uloge uloga { get; set; }

        public void ucitajFormu(Form newForm)
        {
            if (openForm != null)
            {
                openForm.Close();
            }
            openForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(newForm);
            panelBody.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();

        }
    }
}
