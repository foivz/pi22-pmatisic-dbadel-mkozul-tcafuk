using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KorisnikLib;

namespace e_Dnevnik.Klase
{
    public static class RepozitorijHLK
    {
        // Metodom PopuniListu stvara se kopija liste korisnika iz baze podataka 
        // Svrha: Svesti rad s bazom na minimum i stvoriti jedinstven popis svih korisnika (ientora i studenata)

        public static List<Korisnik> PopuniListu()
        {
            using (var context = new PI2205_DBEntities())
            {
                List<Specijalizanti> specijalizanti = context.Korisnik.ToList();
                List<Mentori> mentori = context.Korisnik.ToList();

                List<Korisnik> ListaKorisnika = new List<Korisnik>();

                foreach (var item in specijalizanti)
                {
                    ListaKorisnika.Add(
                    new Specijalizant
                    {
                        ID_specijalizanta = item.ID_specijalizanta,
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
                        Uloga = Uloga.Specijalizant
                    });
                }

                foreach (var item in mentori)
                {
                    ListaKorisnika.Add(
                    new Mentor
                    {
                        ID_mentora = item.ID_mentora,
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
                        Uloga = Uloga.Mentor
                    });
                }

                return ListaKorisnika;
            }
        }



        // Slika u bazi pohranjena je kao tip byte[], u klasi Ientor i Specijalizant slika je tipa Image
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
                if (korisnik.Uloga == Uloga.Mentor)
                {
                    Mentori mentorBaza = context.Mentori.FirstOrDefault(x => (x.korisnicko_ime == korisnik.KorisnickoIme));
                    mentorBaza.lozinka = korisnik.Lozinka;

                    context.SaveChanges();

                }
                else if (korisnik.Uloga == Uloga.Specijalizant)
                {
                    Specijalizanti specijalizantBaza = context.Specijalizanti.FirstOrDefault(x => (x.korisnicko_ime == korisnik.KorisnickoIme));
                    specijalizantBaza.lozinka = korisnik.Lozinka;

                    context.SaveChanges();
                }
            }
        }
        public static void AzurirajIentora(Mentor mentor, string korisnickoIme)
        {
            using (var context = new Entities())
            {
                Mentori mentorBaza = context.Ientori.FirstOrDefault(x => (x.korisnicko_ime == korisnickoIme));

                mentorBaza.ime = mentor.Ime;
                mentorBaza.prezime = mentor.Prezime;
                mentorBaza.korisnicko_ime = mentor.KorisnickoIme;
                mentorBaza.email = mentor.Email;
                mentorBaza.mjesto = mentor.Mjesto;
                mentorBaza.ulica = mentor.Ulica;
                mentorBaza.mobitel = mentor.Mobitel;
                mentorBaza.opis = mentor.Opis;
                mentorBaza.titula = mentor.Titula;

                if (mentor.Slika != null)
                {
                    MemoryStream ms = new MemoryStream();
                    mentor.Slika.Save(ms, ImageFormat.Png);
                    mentorBaza.slika = ms.ToArray();
                }

                context.SaveChanges();
            }
        }

        public static void AzurirajSpecijalizanta(Specijalizant specijalizant, string korisnickoIme)
        {
            using (var context = new Entities())
            {
                Specijalizanti specijalizantBaza = context.Specijalizanti.FirstOrDefault(x => (x.korisnicko_ime == korisnickoIme));

                specijalizantBaza.ime = specijalizant.Ime;
                specijalizantBaza.prezime = specijalizant.Prezime;
                specijalizantBaza.korisnicko_ime = specijalizant.KorisnickoIme;
                specijalizantBaza.email = specijalizant.Email;
                specijalizantBaza.mjesto = specijalizant.Mjesto;
                specijalizantBaza.ulica = specijalizant.Ulica;
                specijalizantBaza.mobitel = specijalizant.Mobitel;
                specijalizantBaza.opis = specijalizant.Opis;

                if (specijalizant.Slika != null)
                {
                    MemoryStream ms = new MemoryStream();
                    specijalizant.Slika.Save(ms, ImageFormat.Png);
                    specijalizantBaza.slika = ms.ToArray();
                }

                context.SaveChanges();
            }
        }

        public static Korisnik DodajKorisnika(Uloga uloga, string ime, string prezime, string korisnickoIme, string lozinka, string email, string mobitel, string mjesto, string ulica, string opis, string titula = null)
        {
            using (var context = new Entities())
            {
                if (uloga == Uloga.Mentor)
                {
                    Mentori mentor = new Mentori()
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
                    context.Mentori.Add(mentor);
                    context.SaveChanges();
                }
                else
                {
                    Specijalizanti specijalizant = new Specijalizanti()
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
                    context.Specijalizanti.Add(specijalizant);
                    context.SaveChanges();
                }
            }

            List<Korisnik> listaKorisnika = RepozitorijHLK.PopuniListu();
            Korisnik noviKorisnik = listaKorisnika.Find(x => (x.KorisnickoIme == korisnickoIme));

            return noviKorisnik;
        }
    }
}