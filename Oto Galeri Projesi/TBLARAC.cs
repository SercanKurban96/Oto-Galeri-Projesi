//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oto_Galeri_Projesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLARAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLARAC()
        {
            this.TBLKIRA = new HashSet<TBLKIRA>();
        }
    
        public int Arac_ID { get; set; }
        public string Arac_Plaka { get; set; }
        public string Arac_Marka { get; set; }
        public string Arac_Model { get; set; }
        public string Arac_Renk { get; set; }
        public Nullable<int> Arac_UretimYili { get; set; }
        public string Arac_Vites { get; set; }
        public string Arac_Yakit { get; set; }
        public Nullable<decimal> Arac_Fiyat { get; set; }
        public string Arac_Fotograf { get; set; }
        public string Arac_Durum { get; set; }
        public int Sube_ID { get; set; }
    
        public virtual TBLSUBE TBLSUBE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKIRA> TBLKIRA { get; set; }
    }
}
