//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UInvcapcao
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblGioChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGioChieu()
        {
            this.tblLichChieux = new HashSet<tblLichChieu>();
        }
    
        public string MaGioChieu { get; set; }
        public string MaRap { get; set; }
        public Nullable<System.TimeSpan> GioChieu { get; set; }
    
        public virtual tblRap tblRap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLichChieu> tblLichChieux { get; set; }
    }
}
