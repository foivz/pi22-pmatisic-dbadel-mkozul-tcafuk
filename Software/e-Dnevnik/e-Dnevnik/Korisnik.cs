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
    
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            this.Biljeske = new HashSet<Biljeske>();
            this.Dogadjaj = new HashSet<Dogadjaj>();
            this.PrijavaIspita = new HashSet<PrijavaIspita>();
            this.StrucniRad = new HashSet<StrucniRad>();
        }
    
        public int idKorisnik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string korime { get; set; }
        public string lozinka { get; set; }
        public byte[] slika { get; set; }
        public int Uloga_idUloga { get; set; }
        public int ProgramSpecijalizacije_idProgramSpecijalizacije { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biljeske> Biljeske { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogadjaj> Dogadjaj { get; set; }
        public virtual ProgramSpecijalizacije ProgramSpecijalizacije { get; set; }
        public virtual Uloga Uloga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrijavaIspita> PrijavaIspita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StrucniRad> StrucniRad { get; set; }
    }
}