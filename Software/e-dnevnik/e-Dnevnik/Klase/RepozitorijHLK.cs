using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KorisniciLib;

namespace e_Dnevnik.Klase
{
    public static class RepozitorijHLK
    {
        // Metodom PopuniListu stvara se kopija liste korisnika iz baze podataka 
        // Svrha: Svesti rad s bazom na minimum i stvoriti jedinstven popis svih korisnika (instruktora i studenata)

        public static List<Korisnik> PopuniListu()
        {
            using (var context = new Entities())
            {
                List<Studenti> studenti = context.Studenti.ToList();
                List<Instruktori> instruktori = context.Instruktori.ToList();

                List<Korisnik> ListaKorisnika = new List<Korisnik>();

                foreach (var item in studenti)
                {
                    ListaKorisnika.Add(
                    new Student
                    {
                        ID_studenta = item.ID_studenta,
                        Ime = item.ime,
                        Prezime = item.prezime,
                        KorisnickoIme = item.korisnicko_ime,
                        Lozinka = item.lozinka,
                        Email = item.email,
                        Mjesto = item.mjesto,
                        Ulica = item.ulica,
                        Mobitel = item.mobitel,
                        Slika = PretvoriSlikuIzBaze(item.slika),
                        Opis = item.opis,
                        Uloga = Uloga.Student
                    });
                }

                foreach (var item in instruktori)
                {
                    ListaKorisnika.Add(
                    new Instruktor
                    {
                        ID_instruktora = item.ID_instruktora,
                        Ime = item.ime,
                        Prezime = item.prezime,
                        KorisnickoIme = item.korisnicko_ime,
                        Lozinka = item.lozinka,
                        Email = item.email,
                        Mjesto = item.mjesto,
                        Ulica = item.ulica,
                        Mobitel = item.mobitel,
                        Slika = PretvoriSlikuIzBaze(item.slika),
                        Opis = item.opis,
                        Titula = item.titula,
                        Uloga = Uloga.Instruktor
                    });
                }

                return ListaKorisnika;
            }
        }



        // Slika u bazi pohranjena je kao tip byte[], u klasi Instruktor i Student slika je tipa Image
        // Metoda PretvoriSlikuIzBaze pretvara tip byte[] u Image u svrhu kasnijeg mogućeg prikaza slike korisnika u PictureBox-u

        public static Image PretvoriSlikuIzBaze(byte[] slikaBaza)
        {
            if (slikaBaza != null)
            {
                MemoryStream ms = new MemoryStream(slikaBaza);
                return Image.FromStream(ms);
            }
            else
            {
                return null;
            }
        }

        // Metodom DohvatiKorisnika se prvo metodom PopuniListu dohvaća lista s najnovijim podacima

        public static Korisnik DohvatiKorisnika(string korisnickoIme, string lozinka)
        {
            List<Korisnik> listaKorisnika = PopuniListu();
            Korisnik korisnik = listaKorisnika.Find(x => (x.KorisnickoIme == korisnickoIme) && (x.Lozinka == lozinka));
            return korisnik;

        }

        public static bool PostojiKorisnik(string korisnickoIme)
        {
            List<Korisnik> listaKorisnika = PopuniListu();
            return listaKorisnika.Exists(x => (x.KorisnickoIme == korisnickoIme));
        }


        //Metoda AzurirajLozinku ažurira korisnika temeljem korisničkog imena kako u bazi ne postoje dva korisnika s istim korisničkim imenom

        public static void AzurirajLozinku(Korisnik korisnik)
        {
            using (var context = new Entities())
            {
                if (korisnik.Uloga == Uloga.Instruktor)
                {
                    Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(x => (x.korisnicko_ime == korisnik.KorisnickoIme));
                    instruktorBaza.lozinka = korisnik.Lozinka;

                    context.SaveChanges();

                }
                else if (korisnik.Uloga == Uloga.Student)
                {
                    Studenti studentBaza = context.Studenti.FirstOrDefault(x => (x.korisnicko_ime == korisnik.KorisnickoIme));
                    studentBaza.lozinka = korisnik.Lozinka;

                    context.SaveChanges();
                }
            }
        }
        public static void AzurirajInstruktora(Instruktor instruktor, string korisnickoIme)
        {
            using (var context = new Entities())
            {
                Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(x => (x.korisnicko_ime == korisnickoIme));

                instruktorBaza.ime = instruktor.Ime;
                instruktorBaza.prezime = instruktor.Prezime;
                instruktorBaza.korisnicko_ime = instruktor.KorisnickoIme;
                instruktorBaza.email = instruktor.Email;
                instruktorBaza.mjesto = instruktor.Mjesto;
                instruktorBaza.ulica = instruktor.Ulica;
                instruktorBaza.mobitel = instruktor.Mobitel;
                instruktorBaza.opis = instruktor.Opis;
                instruktorBaza.titula = instruktor.Titula;

                if (instruktor.Slika != null)
                {
                    MemoryStream ms = new MemoryStream();
                    instruktor.Slika.Save(ms, ImageFormat.Png);
                    instruktorBaza.slika = ms.ToArray();
                }

                context.SaveChanges();
            }
        }

        public static void AzurirajStudenta(Student student, string korisnickoIme)
        {
            using (var context = new Entities())
            {
                Studenti studentBaza = context.Studenti.FirstOrDefault(x => (x.korisnicko_ime == korisnickoIme));

                studentBaza.ime = student.Ime;
                studentBaza.prezime = student.Prezime;
                studentBaza.korisnicko_ime = student.KorisnickoIme;
                studentBaza.email = student.Email;
                studentBaza.mjesto = student.Mjesto;
                studentBaza.ulica = student.Ulica;
                studentBaza.mobitel = student.Mobitel;
                studentBaza.opis = student.Opis;

                if (student.Slika != null)
                {
                    MemoryStream ms = new MemoryStream();
                    student.Slika.Save(ms, ImageFormat.Png);
                    studentBaza.slika = ms.ToArray();
                }

                context.SaveChanges();
            }
        }

        public static Korisnik DodajKorisnika(Uloga uloga, string ime, string prezime, string korisnickoIme, string lozinka, string email, string mobitel, string mjesto, string ulica, string opis, string titula = null)
        {
            using (var context = new Entities())
            {
                if (uloga == Uloga.Instruktor)
                {
                    Instruktori instruktor = new Instruktori()
                    {
                        titula = titula,
                        ime = ime,
                        prezime = prezime,
                        korisnicko_ime = korisnickoIme,
                        lozinka = lozinka,
                        email = email,
                        mobitel = mobitel,
                        mjesto = mjesto,
                        ulica = ulica,
                        opis = opis,
                    };
                    context.Instruktori.Add(instruktor);
                    context.SaveChanges();
                }
                else
                {
                    Studenti student = new Studenti()
                    {
                        ime = ime,
                        prezime = prezime,
                        korisnicko_ime = korisnickoIme,
                        lozinka = lozinka,
                        email = email,
                        mobitel = mobitel,
                        mjesto = mjesto,
                        ulica = ulica,
                        opis = opis,
                    };
                    context.Studenti.Add(student);
                    context.SaveChanges();
                }
            }

            List<Korisnik> listaKorisnika = RepozitorijHLK.PopuniListu();
            Korisnik noviKorisnik = listaKorisnika.Find(x => (x.KorisnickoIme == korisnickoIme));

            return noviKorisnik;
        }
    }
}