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
            InitializeComponent();
            mainForm = mainFrm;
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
            cboxFilter.SelectedIndex = 0;
            dgvMentoriSpecijalizanti.DataSource = GetMentoriSpecijalizanti();
            dgvMentoriSpecijalizanti.AutoResizeColumns();
        }

        private void cboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            object popis;
            if (cboxFilter.SelectedIndex == -1 || cboxFilter.SelectedIndex == 0) //Svi
            {
                popis = GetMentoriSpecijalizanti();

            }
            else
            {
                popis = GetSpecificno(cboxFilter.Text);
            }
            dgvMentoriSpecijalizanti.DataSource = popis;
            dgvMentoriSpecijalizanti.AutoResizeColumns();

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
                           && k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           select new
                           {
                               ID = k.idKorisnik,
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
                           && k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           select new
                           {
                               ID = k.idKorisnik,
                               Ime = k.ime,
                               Korisnicko_ime = k.korime,
                               Uloga = u.nazivuloge,
                               Program = ps.nazivps
                           };
                }
                return upit.ToList();


            }
        }


        private object GetSpecificno(string uloga)
        {
            int kUloge;
            if (uloga == "Mentori") kUloge = 2;
            else kUloge = 3;

            using (var context = new PI2205_DBEntities())
            {
                var upit = from k in context.Korisnik
                           from u in context.Uloga
                           from ps in context.ProgramSpecijalizacije
                           where u.idUloga == k.Uloga_idUloga
                           && k.Uloga_idUloga == kUloge
                           && ps.idProgramSpecijalizacije == k.ProgramSpecijalizacije_idProgramSpecijalizacije
                           && k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           select new
                           {
                               ID = k.idKorisnik,
                               Ime = k.ime,
                               Korisnicko_ime = k.korime,
                               Uloga = u.nazivuloge,
                               Program = ps.nazivps
                           };

                return upit.ToList();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dgvMentoriSpecijalizanti.CurrentRow.Cells[3].Value.ToString() != "Mentor")
            {
                mainForm.ucitajFormu(new frmDogadaji((int)dgvMentoriSpecijalizanti.CurrentRow.Cells[0].Value, mainForm));
            }
            else
            {

            }

        }
    }
}
