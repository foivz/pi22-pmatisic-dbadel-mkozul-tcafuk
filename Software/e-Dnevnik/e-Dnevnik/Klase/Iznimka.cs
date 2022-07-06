using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Dnevnik.Klase
{
    public class Iznimka : ApplicationException
    {
        public string Poruka { get; set; }
        public Iznimka(string poruka)
        {
            Poruka = poruka;
        }
    }
}