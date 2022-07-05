using Database_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Dnevnik.Klase
{
    public static class RepozitorijHLK
    {
        public static Korisnik prijavljeniKorisnik;

        private static Korisnik DohvatiPodatkeOdabranogKorisnika(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            bool recvData = dataReader.Read();
            if (recvData == false)
            {
                dataReader.Close();
                Database.Instance.Disconnect();
                return null;
            }
            else
            {
                UlogaKorisnika uloga = new UlogaKorisnika();
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Glavni mentor")
                {
                    uloga = UlogaKorisnika.GlavniMentor;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Mentor")
                {
                    uloga = UlogaKorisnika.Mentor;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Specijalizant")
                {
                    uloga = UlogaKorisnika.Specijalizant;
                }
                Korisnik korisnik = new Korisnik()
                {
                    KorisnikId = (int)dataReader["idKorisnik"],
                    UlogaKorisnika = uloga,
                    ProgramSpecijalizacije = (int)dataReader["ProgramSpecijalizacije_idProgramSpecijalizacije"],
                    ImeKorisnika = dataReader["ime"].ToString(),
                    PrezimeKorisnika = dataReader["prezime"].ToString(),
                    EmailKorisnika = dataReader["email"].ToString(),
                    KorisnickoImeKorisnika = dataReader["korime"].ToString(),
                    LozinkaKorisnika = dataReader["lozinka"].ToString()
                };
                dataReader.Close();
                Database.Instance.Disconnect();
                return korisnik;
            }
        }

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            string sql = "SELECT * FROM Korisnik k " +
                         "INNER JOIN Uloga u ON k.Uloga_idUloga = u.idUloga " +
                         "LEFT JOIN ProgramSpecijalizacije ps ON k.ProgramSpecijalizacije_idProgramSpecijalizacije = ps.idProgramSpecijalizacije;";

            List<Korisnik> korisnik = DohvatiPodatkeKorisnika(sql);

            return korisnik;
        }

        private static List<Korisnik> DohvatiPodatkeKorisnika(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Korisnik> korisnici = new List<Korisnik>();
            while (dataReader.Read())
            {
                UlogaKorisnika uloga = new UlogaKorisnika();
                if (dataReader["nazivuloge"].ToString() == "Glavni mentor")
                {
                    uloga = UlogaKorisnika.GlavniMentor;
                }
                if (dataReader["nazivuloge"].ToString() == "Mentor")
                {
                    uloga = UlogaKorisnika.Mentor;
                }
                if (dataReader["nazivuloge"].ToString() == "Specijalizant")
                {
                    uloga = UlogaKorisnika.Specijalizant;
                }
                Korisnik korisnik = new Korisnik()
                {
                    KorisnikId = (int)dataReader["idKorisnik"],
                    UlogaKorisnika = uloga,
                    ProgramSpecijalizacije = (int)dataReader["ProgramSpecijalizacije_idProgramSpecijalizacije"],
                    ImeKorisnika = dataReader["ime"].ToString(),
                    PrezimeKorisnika = dataReader["prezime"].ToString(),
                    EmailKorisnika = dataReader["email"].ToString(),
                    KorisnickoImeKorisnika = dataReader["korime"].ToString(),
                    LozinkaKorisnika = dataReader["lozinka"].ToString()
                };
                korisnici.Add(korisnik);
            }

            dataReader.Close();
            Database.Instance.Disconnect();
            return korisnici;
        }
    }
}