using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisnikLib
{
    public class Mentor : Korisnik
    {
        public string Titula { get; set; }
        //public Image Slika { get; set; }
        public int ID_mentora { get; set; }

        public Mentor(int id, string ime, string prezime, string korisnickoIme, string lozinka, string email) : base(ime, prezime, korisnickoIme, lozinka, email, Uloga.Mentor)
        {
            ID_mentora = id;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " <" + KorisnickoIme + "> ";
        }
    }
}
