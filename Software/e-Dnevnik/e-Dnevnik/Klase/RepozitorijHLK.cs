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
using e_Dnevnik.Klase;

namespace e_Dnevnik.Klase
{
    public static class RepozitorijHLK
    {
        public static Korisnik prijavljeniKorisnik;

        internal static int AzurirajKorisnika(string email, string lozinka)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Korisnik SET Lozinka = '{lozinka}' " +
                $"WHERE EmailAdresaKorisnika = '{email}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        internal static int AzurirajKorisnika(int Id, Korisnik korisnik)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Korisnik SET Ime = '{korisnik.ImeKorisnika}', Prezime = '{korisnik.PrezimeKorisnika}', AdresaKorisnika = '{korisnik.AdresaKorisnika}', KontaktTelefon = '{korisnik.KontaktTelefonKorisnika}', " +
                $"EmailAdresaKorisnika = '{korisnik.EmailKorisnika}', OIBKorisnika = '{korisnik.OIBKorisnika}', KorisnickoIme = '{korisnik.KorisnickoImeKorisnika}', Lozinka = '{korisnik.LozinkaKorisnika}' " +
                $"WHERE KorisnikId = {Id};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

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
                if (dataReader["NazivUlogeKorisnika"].ToString() == "GlavniMentor")
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
                    KorisnikId = (int)dataReader["KorisnikId"],
                    UlogaKorisnika = uloga,
                    Aviokompanija = null,
                    ImeKorisnika = dataReader["Ime"].ToString(),
                    PrezimeKorisnika = dataReader["Prezime"].ToString(),
                    AdresaKorisnika = dataReader["AdresaKorisnika"].ToString(),
                    KontaktTelefonKorisnika = dataReader["KontaktTelefon"].ToString(),
                    EmailKorisnika = dataReader["EmailAdresaKorisnika"].ToString(),
                    OIBKorisnika = dataReader["OIBKorisnika"].ToString(),
                    KorisnickoImeKorisnika = dataReader["KorisnickoIme"].ToString(),
                    LozinkaKorisnika = dataReader["Lozinka"].ToString()

                };
                dataReader.Close();
                Database.Instance.Disconnect();
                return korisnik;
            }
        }

        /*public static int DodajKorisnika(Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sqlNULL = "NULL";
            string sql = "INSERT INTO Korisnik (IdUlogaKorisnika, AviokompanijaKorisnika, Ime, Prezime, AdresaKorisnika, KontaktTelefon, EmailAdresaKorisnika, OIBKorisnika, KorisnickoIme, Lozinka) " +
                $"VALUES('{1}', {sqlNULL}, '{korisnik.ImeKorisnika}', '{korisnik.PrezimeKorisnika}', '{korisnik.AdresaKorisnika}', '{korisnik.KontaktTelefonKorisnika}', '{korisnik.EmailKorisnika}', '{korisnik.OIBKorisnika}', '{korisnik.KorisnickoImeKorisnika}', '{korisnik.LozinkaKorisnika}');";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }*/

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            string sql = "SELECT * FROM Korisnik k " +
                "INNER JOIN UlogaKorisnika u ON k.IdUlogaKorisnika = u.UlogaKorisnikaId " +
                "LEFT JOIN Aviokompanija a ON k.AviokompanijaKorisnika = a.AviokompanijaId;";

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
                if (dataReader["NazivUlogeKorisnika"].ToString() == "GlavniMentor")
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
                /*bool aviokompanijaNull = dataReader.IsDBNull(dataReader.GetOrdinal("AviokompanijaKorisnika"));
                if (!aviokompanijaNull)
                {
                    Aviokompanija aviokompanija = new Aviokompanija()
                    {
                        AviokompanijaId = (int)dataReader["AviokompanijaId"],
                        NazivAviokompanije = dataReader["NazivAviokompanije"].ToString(),
                        OIBAviokompanije = dataReader["OIBAviokompanije"].ToString(),
                        IBANAviokompanije = dataReader["IBANAviokompanije"].ToString(),
                        AdresaAviokompanije = dataReader["AdresaAviokompanije"].ToString(),
                        KontaktAviokompanije = dataReader["KontaktTelefonAviokompanije"].ToString(),
                        EmailAviokompanije = dataReader["EmailAviokompanije"].ToString()
                    };

                    Korisnik korisnik = new Korisnik()
                    {
                        KorisnikId = (int)dataReader["KorisnikId"],
                        UlogaKorisnika = uloga,
                        Aviokompanija = aviokompanija,
                        ImeKorisnika = dataReader["Ime"].ToString(),
                        PrezimeKorisnika = dataReader["Prezime"].ToString(),
                        AdresaKorisnika = dataReader["AdresaKorisnika"].ToString(),
                        KontaktTelefonKorisnika = dataReader["KontaktTelefon"].ToString(),
                        EmailKorisnika = dataReader["EmailAdresaKorisnika"].ToString(),
                        OIBKorisnika = dataReader["OIBKorisnika"].ToString(),
                        KorisnickoImeKorisnika = dataReader["KorisnickoIme"].ToString(),
                        LozinkaKorisnika = dataReader["Lozinka"].ToString()

                    };
                    korisnici.Add(korisnik);
                }*/
                //else
                //{
                    Korisnik korisnik = new Korisnik()
                    {
                        KorisnikId = (int)dataReader["KorisnikId"],
                        UlogaKorisnika = uloga,
                        Aviokompanija = null,
                        ImeKorisnika = dataReader["Ime"].ToString(),
                        PrezimeKorisnika = dataReader["Prezime"].ToString(),
                        AdresaKorisnika = dataReader["AdresaKorisnika"].ToString(),
                        KontaktTelefonKorisnika = dataReader["KontaktTelefon"].ToString(),
                        EmailKorisnika = dataReader["EmailAdresaKorisnika"].ToString(),
                        OIBKorisnika = dataReader["OIBKorisnika"].ToString(),
                        KorisnickoImeKorisnika = dataReader["KorisnickoIme"].ToString(),
                        LozinkaKorisnika = dataReader["Lozinka"].ToString()

                    };
                    korisnici.Add(korisnik);
                //}
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return korisnici;
        }

        /*public static void ObrisiKorisnika(string id)
        {
            string sql = "DELETE FROM Korisnik " +
                $"WHERE KorisnikId = '{id}';";
            Database.Instance.ExecuteCommand(sql);
        }*/

        /*public static int DodajUloguAdministratora(int id)
        {
            Database.Instance.Connect();

            string sql = "UPDATE Korisnik SET IdUlogaKorisnika = 3 " +
                $"WHERE KorisnikId = '{id}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }*/

        /*public static int DodajUloguRegistriranogKorisnika(int id)
        {
            Database.Instance.Connect();
            string sqlNULL = "NULL";
            string sql = $"UPDATE Korisnik SET IdUlogaKorisnika = 1, AviokompanijaKorisnika = {sqlNULL} " +
                $"WHERE KorisnikId = '{id}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }*/

        /*public static int DodajUloguModeratora(int id, Aviokompanija aviokompanija)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Korisnik SET IdUlogaKorisnika = 2,  AviokompanijaKorisnika = '{aviokompanija.AviokompanijaId}'" +
                $"WHERE KorisnikId = '{id}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }*/
    }
}