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
    
    public partial class tblNhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MatKhauNV { get; set; }
        public string ChucVu { get; set; }
        public Nullable<int> Luong { get; set; }
        public string MaRap { get; set; }
    
        public virtual tblRap tblRap { get; set; }
        public virtual tblQuyenTruyCap tblQuyenTruyCap { get; set; }
    }
}