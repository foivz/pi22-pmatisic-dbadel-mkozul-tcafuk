//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_Dnevnik
{
    using System;
    using System.Collections.Generic;
    
    public partial class StrucniRad
    {
        public int idStrucniRad { get; set; }
        public string nazivrada { get; set; }
        public string nazivcasopisa { get; set; }
        public System.DateTime datumobjave { get; set; }
        public int Korisnik_idKorisnik { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
    }
}