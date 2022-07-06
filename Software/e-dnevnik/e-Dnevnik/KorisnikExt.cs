using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Dnevnik
{
    public partial class Korisnik
    {
        private string punoIme;

        public string PunoIme
        {
            get { return this.ime + " " + this.prezime; }
            set { punoIme = value; }
        }
        public override string ToString()
        {
            return this.idKorisnik + " " + this.ime + " " + this.prezime;
        }
    }
}
