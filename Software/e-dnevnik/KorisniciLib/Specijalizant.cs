using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public class Student : Korisnik
    {
        public int ID_studenta { get; set; }
        public Image Slika { get; set; }
        public Student()
        {

        }

        public Student(int id, string ime, string prezime, string korisnickoIme, string lozinka, string email) : base(ime, prezime, korisnickoIme, lozinka, email, Uloga.Student)
        {
            ID_studenta = id;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime + " <" + KorisnickoIme + "> ";
        }
    }
}