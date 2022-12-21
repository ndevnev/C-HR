using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public String GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<int> MaPB { get; set; }
        public String TenPB { get; set;}
        public Nullable<int> MaBP { get; set; }
        public String TenBP { get; set; }
        public Nullable<int> MaCV { get; set; }
        public String TenCV { get; set; }
        public Nullable<int> MaTD { get; set; }
        public String TenTD { get; set; }
    }
}
