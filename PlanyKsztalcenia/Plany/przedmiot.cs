//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plany
{
    using System;
    using System.Collections.Generic;
    
    public partial class przedmiot
    {
        public decimal id_przedmiot { get; set; }
        public string nazwa { get; set; }
        public Nullable<int> ile_godzin { get; set; }
        public string typ_zajec { get; set; }
        public Nullable<int> semestr { get; set; }
        public Nullable<decimal> id_katedra { get; set; }
        public Nullable<decimal> id_specjalnosc { get; set; }
        public Nullable<decimal> id_pracownik { get; set; }
    }
}
