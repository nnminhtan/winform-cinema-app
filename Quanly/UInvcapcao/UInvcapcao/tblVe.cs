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
    
    public partial class tblVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVe()
        {
            this.tblThongTinVes = new HashSet<tblThongTinVe>();
        }
    
        public int MaVe { get; set; }
        public string MaShow { get; set; }
    
        public virtual tblLichChieu tblLichChieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblThongTinVe> tblThongTinVes { get; set; }
    }
}
