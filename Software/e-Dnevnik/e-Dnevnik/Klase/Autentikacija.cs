using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KorisnikLib;
using e_Dnevnik.Klase;

namespace e_Dnevnik.Klase
{
    public static class Autentikacija
    {

        // Metoda prijava provjerava ispravnost unosa (prazan unos, postojece korisnicko ime ili neispravnu lozinku)
        // U slučaju da je prijava ispravna dohvaća podatke o korisniku, u suprotnom vraća poruku greške, tj. baca iznimku

        /*public static Korisnik Prijava(string korisnickoIme, string lozinka)
        {
            Korisnik korisnikPrijava = null;

            ProvjeriPrazanUnosPrijave(korisnickoIme, lozinka);


            bool postojiKorisnik = RepozitorijHLK.PostojiKorisnik(korisnickoIme);

            // 1. Slučaj: Ne postoji korisničko ime u bazi podataka

            if (postojiKorisnik == false)
            {
                throw new IspravnostUnosa($"Neuspješna prijava! Ne postoji korisnik s korisničkim imenom {korisnickoIme}!");
            }

            // 2. Slučaj: Postoji korisničko ime u bazi podataka

            else if (postojiKorisnik == true)
            {

                // 2.1. Dohvaća se korisnik (ispravno korisničko ime i lozinka)

                korisnikPrijava = RepozitorijHLK.DohvatiKorisnika(korisnickoIme, lozinka);

                // 2.2. Baca se iznimka (pogrešna lozinka)

                if (korisnikPrijava == null)
                {
                    throw new IspravnostUnosa($"Neuspješna prijava! Pogrešna lozinka za {korisnickoIme}!");
                }
            }
            return korisnikPrijava;
        }*/

        public static void ProvjeriPrazanUnosPrijave(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme == "" || lozinka == "")
            {
                throw new IspravnostUnosa("Neuspješna prijava! Niste popunili sva polja!");
            }
        }

        public static bool ProvjeriPromjenuLozinke(string trenutnaLozinka, string novaLozinka, string ponovljenaLozinka)
        {
            bool ispravnaLozinka = true;

            if (novaLozinka == "" || ponovljenaLozinka == "")
            {
                throw new IspravnostUnosa("Neuspješna prijava! Niste popunili polja za lozinke!");
            }
            else if (trenutnaLozinka == novaLozinka)
            {
                throw new IspravnostUnosa("Trenutna lozinka i nova lozinka su jednake!");
            }
            else if (novaLozinka != ponovljenaLozinka)
            {
                throw new IspravnostUnosa($"Nova lozinka i ponovljena lozinka nisu jednake!");
            }

            return ispravnaLozinka;
        }

        /*public static bool ProvjeriKorisnickoIme(string korisnickoIme)
        {
            bool postojiKorisnik = RepozitorijHLK.PostojiKorisnik(korisnickoIme);

            if (postojiKorisnik == true)
            {
                throw new IspravnostUnosa($"Već postoji korisnik s korisničkim imenom {korisnickoIme}!");
            }
            return postojiKorisnik;
        }*/

        public static bool ProvjeriUnosProfil(string ime, string prezime, string korisnickoIme, string email, string mobitel)
        {
            bool ispravanUnos = true;

            if (korisnickoIme == "" || prezime == "" || ime == "" || email == "")
            {
                throw new IspravnostUnosa("Nisu uneseni svi obavezni podaci označeni s *");
            }

            //Mobitel može biti u unosu: 0917917899 (minimalno 10 znakova bez razmaka) ili sa spojnicama 091/791-8199 može imati maksimalno 12 znakova
            //Moguće je da se mobitel niti ne unese

            else if (mobitel.Length < 10 && mobitel.Length >= 1)
            {
                throw new IspravnostUnosa("Broj mobitela ima premalo znakova (minimalno 10 znakova)! Primjer: unos +385 91 791 7899, NIJE ispravan pokušajte s formatom 091 791 7899");
            }
            else if (mobitel.Length > 12)
            {
                throw new IspravnostUnosa("Broj mobitela ima previše znakova (dozvoljeno 12 znakova)! Primjer: unos +385 91 791 7899, NIJE ispravan pokušajte s formatom 091 791 7899");
            }

            ProvjeriEmailAdresu(email);

            return ispravanUnos;
        }

        public static bool ProvjeriEmailAdresu(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                throw new IspravnostUnosa("Neispravan format email adrese!");
            }
        }
    }
}
