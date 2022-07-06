using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Dnevnik
{
    internal class Dogadaji
    {

        public MainForm mainForm { get; set; }

        public object GetProvjereZnanja()
        {


            using (var context = new PI2205_DBEntities())
            {
                var upit = from pz in context.ProvjeraZnanja
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           && d.idDogadjaj == pz.Dogadjaj_idDogadjaj
                           && d.Korisnik_idKorisnik == k.idKorisnik
                           && d.TipDogadjaja_idTipDogadjaja == t.idTipDogadjaja
                           && d.TipDogadjaja_idTipDogadjaja == 1
                           select new
                           {
                               ID_provjere = pz.idProvjeraZnanja,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status = d.statusdogadjaja,
                               Tip = t.nazivtipa,
                               Korisnik = k.korime
                           };
                return upit.ToList();
            }
        }

        public object GetSlucajeviBolesnika()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from sb in context.SlucajBolesnika
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           && d.idDogadjaj == sb.Dogadjaj_idDogadjaj
                           && d.Korisnik_idKorisnik == k.idKorisnik
                           && d.TipDogadjaja_idTipDogadjaja == t.idTipDogadjaja
                           && d.TipDogadjaja_idTipDogadjaja == 2

                           select new
                           {
                               ID_slucaja = sb.idSlucajBolesnika,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status = d.statusdogadjaja,
                               Tip = t.nazivtipa,
                               Korisnik = k.korime
                           };
                return upit.ToList();
            }
        }

        public object GetDnevnikAktivnosti()
        {
            using (var context = new PI2205_DBEntities())
            {
                var upit = from da in context.DnevnaAktivnost
                           from d in context.Dogadjaj
                           from t in context.TipDogadjaja
                           from k in context.Korisnik
                           where k.ProgramSpecijalizacije_idProgramSpecijalizacije == mainForm.programSpecijalizacije
                           && d.idDogadjaj == da.Dogadjaj_idDogadjaj
                           && d.Korisnik_idKorisnik == k.idKorisnik
                           && d.TipDogadjaja_idTipDogadjaja == t.idTipDogadjaja
                           && d.TipDogadjaja_idTipDogadjaja == 3

                           select new
                           {
                               ID_dnevne = da.idDnevnaAktivnost,
                               Naziv_dogadaja = d.nazivdogadjaja,
                               Status = d.statusdogadjaja,
                               Tip = t.nazivtipa,
                               Korisnik = k.korime
                           };
                return upit.ToList();
            }
        }
    }
}
