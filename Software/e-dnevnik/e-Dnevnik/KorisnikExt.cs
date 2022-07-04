using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Dnevnik.Data
{
    public partial class Korisnik
    {
        private string imeKorisnika;
        public string ImeKorisnika
        {
            get { return this.ime + " " + this.prezime; }
            set { imeKorisnika = value; }
        }

        public override string ToString()
        {
            return this.ImeKorisnika;
        }
    }
}
