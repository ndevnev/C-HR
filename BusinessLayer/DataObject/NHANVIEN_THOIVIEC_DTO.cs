using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataObject
{
    public class NHANVIEN_THOIVIEC_DTO
    {
        public string SOQD { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<System.DateTime> NGAYNOPDON { get; set; }
        public Nullable<System.DateTime> NGAYNGHI { get; set; }
        public string LYDO { get; set; }
        public string GHICHU { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
    }
}
