using e_Dnevnik.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace e_Dnevnik
{
    public partial class frmZaboravljenaLozinka : Form
    {
        public frmZaboravljenaLozinka()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void buttonPodnesi_Click(object sender, EventArgs e)
        {
            Klase.Korisnik korisnik = RepozitorijHLK.ProvjeriEmail(textBoxUnos.Text);

            if (korisnik != null)
            {
                string novaLozinka = "";
                string znakovi = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                Random r = new Random();
                r.Next();

                for (int i = 0; i < 10; i++)
                {
                    novaLozinka += znakovi[r.Next(znakovi.Length)];
                }

                int numAffectedRows = RepozitorijHLK.AzurirajKorisnika(textBoxUnos.Text, novaLozinka);

                if (numAffectedRows != 0)
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                    client.UseDefaultCredentials = false;
                    NetworkCredential cred = new NetworkCredential("ednevnikhlk@gmail.com", "ydgqwzwoldmlhohz");

                    MailMessage Msg = new MailMessage();

                    Msg.From = new MailAddress("ednevnikhlk@gmail.com");

                    Msg.To.Add($"{textBoxUnos.Text}");

                    Msg.Subject = "Oporavak računa";

                    Msg.Body = $"Poštovani,\n\n" +
                        $"Nova lozinka za vaš račun je: {novaLozinka}\n" +
                        "Ovu lozinku možete nastaviti koristiti ili je promjeniti u postavkama korisničkog računa.\n\n" +
                        "S poštovanjem,\n" +
                        "Hrvatska liječnička komora";

                    client.Credentials = cred;

                    client.EnableSsl = true;

                    client.Send(Msg);
                    client.Dispose();

                    MessageBox.Show("Uspješna promjena lozinke!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške pri oporavku lozinke! Molimo provjerite uneseni email i pokušajte ponovno.");
                }
            }
            else
            {
                MessageBox.Show("Korisnik s tom email adresom ne postoji!");
            }

        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
