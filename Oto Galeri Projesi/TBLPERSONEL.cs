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
    
    public partial class TBLPERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPERSONEL()
        {
            this.TBLKIRA = new HashSet<TBLKIRA>();
        }
    
        public int Personel_ID { get; set; }
        public string Personel_TCNO { get; set; }
        public string Personel_AdiSoyadi { get; set; }
        public Nullable<System.DateTime> Personel_DogumTarihi { get; set; }
        public string Personel_Mail { get; set; }
        public string Personel_Telefon { get; set; }
        public string Personel_Adresi { get; set; }
        public string Personel_Fotograf { get; set; }
        public int Sube_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKIRA> TBLKIRA { get; set; }
        public virtual TBLSUBE TBLSUBE { get; set; }
    }
}
