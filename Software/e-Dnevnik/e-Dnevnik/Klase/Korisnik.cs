using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Dnevnik.Klase
{
    public enum UlogaKorisnika
    {
        GlavniMentor,
        Mentor,
        Specijalizant
    };

    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public string EmailKorisnika { get; set; }
        public string KorisnickoImeKorisnika { get; set; }
        public string LozinkaKorisnika { get; set; }
        public UlogaKorisnika UlogaKorisnika { get; set; }
        public ProgramSpecijalizacije ProgramSpecijalizacije { get; set; }

        public void PromijeniUlogu(UlogaKorisnika uloga)
        {
            UlogaKorisnika = uloga;
        }

        public override string ToString()
        {
            return ImeKorisnika + " " + PrezimeKorisnika;
        }
    }
}