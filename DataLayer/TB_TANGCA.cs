//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_TANGCA
    {
        public int MATANGCA { get; set; }
        public Nullable<System.DateTime> NGAYGIOBATDAUCA { get; set; }
        public Nullable<System.DateTime> NGAYGIOKETTHUCCA { get; set; }
        public Nullable<int> MALOAICA { get; set; }
        public Nullable<int> MANHANVIEN { get; set; }
    
        public virtual TB_LOAICA TB_LOAICA { get; set; }
        public virtual TB_NHANVIEN TB_NHANVIEN { get; set; }
    }
}
