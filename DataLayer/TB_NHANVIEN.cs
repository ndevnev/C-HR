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
    
    public partial class TB_NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_NHANVIEN()
        {
            this.TB_BANGCONG = new HashSet<TB_BANGCONG>();
            this.TB_BAOHIEM = new HashSet<TB_BAOHIEM>();
            this.TB_HOPDONG = new HashSet<TB_HOPDONG>();
            this.TB_KHENTHUONGKYLUAT = new HashSet<TB_KHENTHUONGKYLUAT>();
            this.TB_NHANVIENPHUCAP = new HashSet<TB_NHANVIENPHUCAP>();
            this.TB_TANGCA = new HashSet<TB_TANGCA>();
            this.TB_UNGLUONG = new HashSet<TB_UNGLUONG>();
        }
    
        public int MANHANVIEN { get; set; }
        public string HOVATEN { get; set; }
        public string GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string SODIENTHOAI { get; set; }
        public string SOCANCUOC { get; set; }
        public string DIACHI { get; set; }
        public byte[] HINHANH { get; set; }
        public Nullable<int> MAPHONGBAN { get; set; }
        public Nullable<int> MABOPHAN { get; set; }
        public Nullable<int> MACHUCVU { get; set; }
        public Nullable<int> MATRINHDO { get; set; }
        public Nullable<double> LUONG { get; set; }
        public Nullable<bool> DATHOIVIEC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_BANGCONG> TB_BANGCONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_BAOHIEM> TB_BAOHIEM { get; set; }
        public virtual TB_BOPHAN TB_BOPHAN { get; set; }
        public virtual TB_CHUCVU TB_CHUCVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_HOPDONG> TB_HOPDONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_KHENTHUONGKYLUAT> TB_KHENTHUONGKYLUAT { get; set; }
        public virtual TB_PHONGBAN TB_PHONGBAN { get; set; }
        public virtual TB_TRINHDO TB_TRINHDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_NHANVIENPHUCAP> TB_NHANVIENPHUCAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TANGCA> TB_TANGCA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_UNGLUONG> TB_UNGLUONG { get; set; }
    }
}
