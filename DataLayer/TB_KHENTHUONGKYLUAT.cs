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
    
    public partial class TB_KHENTHUONGKYLUAT
    {
        public int MAKHENTHUONGKYLUAT { get; set; }
        public string LOAI { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> MANHANVIEN { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public string LYDO { get; set; }
        public Nullable<int> MAKYCONG { get; set; }
    
        public virtual TB_NHANVIEN TB_NHANVIEN { get; set; }
    }
}
