using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class KhenThuong_KiLuatDTO
    {
        public int MaKTKL { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> Loai { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string HoTen { get; set; }
        public string LyDo { get; set; }
        public Nullable<System.DateTime> TuNgay { get; set; }
        public Nullable<System.DateTime> DenNgay { get; set; }

    }
}
