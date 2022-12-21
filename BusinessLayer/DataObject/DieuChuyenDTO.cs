using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class DieuChuyenDTO
    { public int MaDC { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> MaNV { get; set; }
        public String HoTen { get;set;}
        public Nullable<int> MaPB { get; set; }
        public String TenPB { get; set; }
        public Nullable<int> MaPB2 { get; set; }
        public String TenBP2 { get; set; }
    }
}
