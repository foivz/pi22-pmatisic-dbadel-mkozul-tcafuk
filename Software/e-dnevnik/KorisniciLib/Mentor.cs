using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public class Instruktor : Korisnik
    {
        public string Titula { get; set; }
        public Image Slika { get; set; }
        public int ID_instruktora { get; set; }

        public Instruktor()
        {

        }

        public Instruktor(int id, string ime, string prezime, string korisnickoIme, string lozinka, string email) : base(ime, prezime, korisnickoIme, lozinka, email, Uloga.Instruktor)
        {
            ID_instruktora = id;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " <" + KorisnickoIme + "> ";
        }
    }
}