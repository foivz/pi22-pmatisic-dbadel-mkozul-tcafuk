using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnikLib
{
    public enum Uloga
    {
        Mentor,
        Specijalizant
    }
    public abstract class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string Mobitel { get; set; }
        public string Mjesto { get; set; }
        public string Ulica { get; set; }
        public string Opis { get; set; }

        public Uloga Uloga { get; set; }

        public Korisnik(string ime, string prezime, string korisnickoIme, string lozinka, string email, Uloga uloga)
        {
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Email = email;
            Uloga = uloga;
        }
    }
}
