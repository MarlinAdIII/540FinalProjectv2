//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _540FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class STYLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STYLE()
        {
            this.APPOINTMENTs = new HashSet<APPOINTMENT>();
            this.DESIGNWITHs = new HashSet<DESIGNWITH>();
            this.EXTRATSTYLEs = new HashSet<EXTRATSTYLE>();
            this.SKILLS = new HashSet<SKILL>();
        }
    
        public byte IDStyle { get; set; }
        public string DesigStyle { get; set; }
        public string DescriptStyle { get; set; }
        public Nullable<bool> HairProvStyle { get; set; }
        public byte[] PictureStyle { get; set; }
        public Nullable<decimal> PriceStyle { get; set; }
        public Nullable<decimal> PriceExtrat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPOINTMENT> APPOINTMENTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DESIGNWITH> DESIGNWITHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXTRATSTYLE> EXTRATSTYLEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SKILL> SKILLS { get; set; }
    }
}
