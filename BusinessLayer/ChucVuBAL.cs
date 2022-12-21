using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ChucVuBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_CHUCVU> getList()
        {
            return db.TB_CHUCVU.ToList();
        }

        public TB_CHUCVU getItem(int id)
        {
            return db.TB_CHUCVU.FirstOrDefault(x => x.MACHUCVU == id); ;
        }

        public TB_CHUCVU Add(TB_CHUCVU cv)
        {
            try
            {
                db.TB_CHUCVU.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_CHUCVU Update(TB_CHUCVU cv)
        {
            try
            {
                var _cv = db.TB_CHUCVU.FirstOrDefault(x => x.MACHUCVU == cv.MACHUCVU);
                _cv.TENCHUCVU = cv.TENCHUCVU;
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _cv = db.TB_CHUCVU.FirstOrDefault(x => x.MACHUCVU == id);
                db.TB_CHUCVU.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}