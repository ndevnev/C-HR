using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoaiCaBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_LOAICA> getList()
        {
            return db.TB_LOAICA.ToList();
        }

        public TB_LOAICA getItem(int id)
        {
            return db.TB_LOAICA.FirstOrDefault(x => x.MALOAICA == id);
        }

        public TB_LOAICA Add(TB_LOAICA lc)
        {
            try
            {
                db.TB_LOAICA.Add(lc);
                db.SaveChanges();
                return lc;
            } catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }

        public TB_LOAICA Update(TB_LOAICA lc)
        {
            try
            {
                var _lc = db.TB_LOAICA.FirstOrDefault(x => x.MALOAICA == lc.MALOAICA);
                _lc.TENLOAICA = lc.TENLOAICA;
                db.SaveChanges();
                return lc;
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var lc = db.TB_LOAICA.FirstOrDefault(x => x.MALOAICA == id);
                db.TB_LOAICA.Remove(lc);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }
    }
}
