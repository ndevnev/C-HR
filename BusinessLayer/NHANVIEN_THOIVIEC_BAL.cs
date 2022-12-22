using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN_THOIVIEC_BAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public TB_NHANVIEN_THOIVIEC getItem(string soqd)
        {
            return db.TB_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<TB_NHANVIEN_THOIVIEC> getList()
        {
            return db.TB_NHANVIEN_THOIVIEC.ToList();
        }

        public List<NHANVIEN_THOIVIEC_DTO> getListFull()
        {
            var lstDC = db.TB_NHANVIEN_THOIVIEC.ToList();
            List<NHANVIEN_THOIVIEC_DTO> lstDTO = new List<NHANVIEN_THOIVIEC_DTO>();
            NHANVIEN_THOIVIEC_DTO nvDTO;
            foreach (var item in lstDC)
            {
                nvDTO = new NHANVIEN_THOIVIEC_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.NGAYNOPDON = item.NGAYNOPDON;
                nvDTO.NGAYNGHI = item.NGAYNGHI;
                nvDTO.MANV = item.MANV;
                var nv = db.TB_NHANVIEN.FirstOrDefault(n => n.MANHANVIEN == item.MANV);
                nvDTO.HOTEN = nv.HOVATEN;
                nvDTO.LYDO = item.LYDO;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.CREATED_BY = item.CREATED_BY;
                nvDTO.CREATED_DATE = item.CREATED_DATE;
                nvDTO.UPDATED_BY = item.UPDATED_BY;
                nvDTO.UPDATED_DATE = item.UPDATED_DATE;
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public TB_NHANVIEN_THOIVIEC Add(TB_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                db.TB_NHANVIEN_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_NHANVIEN_THOIVIEC Update(TB_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                var _tv = db.TB_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.MANV = tv.MANV;
                _tv.LYDO = tv.LYDO;
                _tv.GHICHU = tv.GHICHU;
                _tv.UPDATED_BY = tv.UPDATED_BY;
                _tv.UPDATED_DATE = tv.UPDATED_DATE;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _tv = db.TB_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
                
                _tv.DELETED_BY = iduser;
                _tv.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _soqd = db.TB_NHANVIEN_THOIVIEC.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_soqd != null)
            {
                return _soqd.SOQD;
            }
            else
                return "00000";
        }
    }
}
