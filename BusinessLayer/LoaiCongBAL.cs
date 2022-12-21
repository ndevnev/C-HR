using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoaiCongBAL
    {

        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_LOAICONG> getList()
        {
            return db.TB_LOAICONG.ToList();
        }

        public TB_LOAICONG getItem(int id)
        {
            return db.TB_LOAICONG.FirstOrDefault(x => x.MALOAICONG == id); ;
        }

        public TB_LOAICONG Add(TB_LOAICONG td)
        {
            try
            {
                db.TB_LOAICONG.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_LOAICONG Update(TB_LOAICONG td)
        {
            try
            {
                var _td = db.TB_LOAICONG.FirstOrDefault(x => x.MALOAICONG == td.MALOAICONG);
                _td.TENLOAICONG = td.TENLOAICONG;
                db.SaveChanges();
                return td;
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
                var _td = db.TB_LOAICONG.FirstOrDefault(x => x.MALOAICONG == id);
                db.TB_LOAICONG.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
