using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class HOPDONGDTO
    {
        public int MAHOPDONG { get; set; }
        public string SOHOPDONG { get; set; }
        public Nullable<System.DateTime> NGAYBATDAU { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public Nullable<System.DateTime> NGAYKY { get; set; }
        public Nullable<int> LANKY { get; set; }
        public string THOIHAN { get; set; }
        public Nullable<double> HESOLUONG { get; set; }
        public Nullable<int> MANHANVIEN { get; set; }

        public string HOVATEN { get; set; }
        public string NOIDUNG { get; set; }

        public virtual TB_NHANVIEN TB_NHANVIEN { get; set; }
    }
}
