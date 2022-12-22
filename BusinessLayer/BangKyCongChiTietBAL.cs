using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BangKyCongChiTietBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();
        public TB_BANGCONG_NHANVIEN_CHITIET Add(TB_BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                db.TB_BANGCONG_NHANVIEN_CHITIET.Add(bcct);
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
