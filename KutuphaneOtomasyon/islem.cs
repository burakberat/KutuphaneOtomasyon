//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class islem
    {
        public int islemno { get; set; }
        public Nullable<int> ogrno { get; set; }
        public Nullable<int> kitapno { get; set; }
        public Nullable<System.DateTime> atarih { get; set; }
        public Nullable<System.DateTime> vtarih { get; set; }
        public Nullable<bool> teslimedildimi { get; set; }
    
        public virtual kitap kitap { get; set; }
        public virtual ogrenci ogrenci { get; set; }
    }
}