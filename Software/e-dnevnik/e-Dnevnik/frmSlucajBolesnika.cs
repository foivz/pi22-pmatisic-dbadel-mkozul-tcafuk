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
    public partial class frmSlucajBolesnika : Form
    {
        public frmSlucajBolesnika(int ID_slucaja)
        {
            InitializeComponent();

            var query = getSlucaj(ID_slucaja);
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private object getSlucaj(int ID)
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from sb in context.SlucajBolesnika
                           where sb.idSlucajBolesnika == ID
                           select new
                           {
                               Nesto = sb.dijagnoza
                           };

                foreach (var s in upit)
                {
                    return tbVrsta.Text = s.Nesto;
                }

                return upit;

                
            }
        }
    }

}
