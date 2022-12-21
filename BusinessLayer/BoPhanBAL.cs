using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BoPhanBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_BOPHAN> getList()
        {
            return db.TB_BOPHAN.ToList();
        }

        public TB_BOPHAN getItem(int id)
        {
            return db.TB_BOPHAN.FirstOrDefault(x => x.MABOPHAN == id); ;
        }

        public TB_BOPHAN Add(TB_BOPHAN bp)
        {
            try
            {
                db.TB_BOPHAN.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_BOPHAN Update(TB_BOPHAN bp)
        {
            try
            {
                var _bp = db.TB_BOPHAN.FirstOrDefault(x => x.MABOPHAN == bp.MABOPHAN);
                _bp.TENBOPHAN = bp.TENBOPHAN;
                db.SaveChanges();
                return bp;
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
                var _bp = db.TB_BOPHAN.FirstOrDefault(x => x.MABOPHAN == id);
                db.TB_BOPHAN.Remove(_bp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
