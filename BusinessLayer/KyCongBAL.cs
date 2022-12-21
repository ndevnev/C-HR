using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KyCongBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public TB_KYCONG getItem(int id)
        {
            return db.TB_KYCONG.FirstOrDefault(x => x.MAKYCONG == id);
        }

        public List<TB_KYCONG> getList()
        {
            return db.TB_KYCONG.ToList();
        }

        public TB_KYCONG Add(TB_KYCONG kc)
        {
            try
            {
                db.TB_KYCONG.Add(kc);
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_KYCONG Update(TB_KYCONG kc, int id)
        {
            try
            {
                var _kc = db.TB_KYCONG.FirstOrDefault(x => x.MAKYCONG == kc.MAKYCONG);
                _kc.MAKYCONG = kc.MAKYCONG;
                _kc.NAM = kc.NAM;
                _kc.THANG = kc.THANG;
                _kc.KHOA = kc.KHOA;
                _kc.NGAYCONGTRONGTHANG = kc.NGAYCONGTRONGTHANG;
                _kc.NGAYTINHCONG = kc.NGAYTINHCONG;
                _kc.TRANGTHAI = kc.TRANGTHAI;
                _kc.UPDATED_BY = id;
                _kc.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id, int userID)
        {
            try
            {
                var _kc = db.TB_KYCONG.FirstOrDefault(x => x.MAKYCONG == id);
                _kc.DELETE_BY = userID;
                _kc.DELETE_DATE= DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
