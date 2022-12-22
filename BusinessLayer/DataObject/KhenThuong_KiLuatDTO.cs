using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class KhenThuong_KiLuatDTO
    {
        public int MAKHENTHUONGKYLUAT { get; set; }
        public string LOAI { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> MANHANVIEN { get; set; }

        public string HOVATEN { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public string LYDO { get; set; }

        public virtual TB_NHANVIEN TB_NHANVIEN { get; set; }
    }

}
