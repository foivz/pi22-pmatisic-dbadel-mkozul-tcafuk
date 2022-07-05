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
    public partial class frmMentorSpecijalizant : Form
    {
        MainForm mainForm;
        public frmMentorSpecijalizant(MainForm mainFrm)
        {
            mainForm = mainFrm;
            InitializeComponent();
            if(mainFrm.uloga == MainForm.uloge.glavni_mentor)
            {
                lblTitle.Text = "Prikaz mentora i specijalizanata";
                pnlFilter.Visible = true;
            }
        }

        private void lblFilter_Click(object sender, EventArgs e)
        {
        }

        private void frmMentorSpecijalizant_Load(object sender, EventArgs e)
        {
            dgvMentoriSpecijalizanti.DataSource = GetMentoriSpecijalizanti();
        }

        private object GetMentoriSpecijalizanti()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from k in context.Korisnik
                           from u in context.Uloga
                           from ps in context.ProgramSpecijalizacije
                           where u.idUloga == k.Uloga_idUloga
                           && k.Uloga_idUloga == 3
                           && ps.idProgramSpecijalizacije == k.ProgramSpecijalizacije_idProgramSpecijalizacije
                           && k.ProgramSpecijalizacije_idProgramSpecijalizacije == 2
                           select new
                           {
                               Ime = k.ime,
                               Korisnicko_ime = k.korime,
                               Uloga = u.nazivuloge,
                               Program = ps.nazivps
                           };

                if (mainForm.uloga == MainForm.uloge.glavni_mentor)
                {
                    upit = from k in context.Korisnik
                               from u in context.Uloga
                               from ps in context.ProgramSpecijalizacije
                               where u.idUloga == k.Uloga_idUloga
                               && k.Uloga_idUloga != 1
                               && ps.idProgramSpecijalizacije == k.ProgramSpecijalizacije_idProgramSpecijalizacije
                               && k.ProgramSpecijalizacije_idProgramSpecijalizacije == 2
                               select new
                               {
                                   Ime = k.ime,
                                   Korisnicko_ime = k.korime,
                                   Uloga = u.nazivuloge,
                                   Program = ps.nazivps
                               };
                }
                return upit.ToList();


            }
        }
    }
}
