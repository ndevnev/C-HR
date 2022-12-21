using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PhongBanBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_PHONGBAN> getList()
        {
            return db.TB_PHONGBAN.ToList();
        }

        public TB_PHONGBAN getItem(int id)
        {
            return db.TB_PHONGBAN.FirstOrDefault(x => x.MAPHONGBAN == id); ;
        }

        public TB_PHONGBAN Add(TB_PHONGBAN td)
        {
            try
            {
                db.TB_PHONGBAN.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_PHONGBAN Update(TB_PHONGBAN pb)
        {
            try
            {
                var _td = db.TB_PHONGBAN.FirstOrDefault(x => x.MAPHONGBAN == pb.MAPHONGBAN);
                _td.TENPHONGBAN = pb.TENPHONGBAN;
                db.SaveChanges();
                return pb;
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
                var _td = db.TB_PHONGBAN.FirstOrDefault(x => x.MAPHONGBAN == id);
                db.TB_PHONGBAN.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
