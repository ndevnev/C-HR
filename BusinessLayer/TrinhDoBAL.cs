using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TrinhDoBAL
    {
    
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_TRINHDO> getList()
        {
            return db.TB_TRINHDO.ToList();
        }

        public TB_TRINHDO getItem(int id)
        {
            return db.TB_TRINHDO.FirstOrDefault(x => x.MATRINHDO == id); ;
        }

        public TB_TRINHDO Add(TB_TRINHDO td)
        {
            try
            {
                db.TB_TRINHDO.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_TRINHDO Update(TB_TRINHDO td)
        {
            try
            {
                var _td = db.TB_TRINHDO.FirstOrDefault(x => x.MATRINHDO == td.MATRINHDO);
                _td.TENTRINHDO = td.TENTRINHDO;
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
                var _td = db.TB_TRINHDO.FirstOrDefault(x => x.MATRINHDO == id);
                db.TB_TRINHDO.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    
    }
}
