using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class HopDongBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public TB_HOPDONG getItem(int id)
        {
            return db.TB_HOPDONG.FirstOrDefault(x => x.MAHOPDONG == id);
        }

        public List<TB_HOPDONG> getList()
        {
            return db.TB_HOPDONG.ToList();
        }

        public List<HOPDONGDTO> getListFull()
        {
            List<TB_HOPDONG> lstHD = db.TB_HOPDONG.ToList();
            List<HOPDONGDTO> lstDTO= new List<HOPDONGDTO>();
            HOPDONGDTO hd;
            foreach(var item in lstHD)
            {
                hd = new HOPDONGDTO();
                hd.MAHOPDONG = item.MAHOPDONG;
                hd.SOHOPDONG = item.SOHOPDONG;
                hd.HESOLUONG = item.HESOLUONG;
                hd.NGAYBATDAU = item.NGAYBATDAU;
                hd.NGAYKETTHUC = item.NGAYKETTHUC;
                hd.NGAYKY = item.NGAYKY;
                hd.LANKY = item.LANKY;
                hd.NOIDUNG = item.NOIDUNG;
                hd.THOIHAN = item.THOIHAN;
                hd.MANHANVIEN = item.MANHANVIEN;
                var nv = db.TB_NHANVIEN.FirstOrDefault(n => n.MANHANVIEN == item.MANHANVIEN);
                hd.HOVATEN = nv.HOVATEN;
                lstDTO.Add(hd);
            }

            return lstDTO;
        }

        public TB_HOPDONG Add(TB_HOPDONG hd)
        {
            try
            {
                db.TB_HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;
            }
            
            catch (Exception e)
            {
                throw new Exception("Lỗi: " + e.Message);
            }
        }

        public TB_HOPDONG Update(TB_HOPDONG hd)
        {
            try
            {
                var _hd = db.TB_HOPDONG.FirstOrDefault(x => x.MAHOPDONG == hd.MAHOPDONG);
                _hd.SOHOPDONG= hd.SOHOPDONG;
                _hd.NGAYBATDAU = hd.NGAYBATDAU;
                _hd.NGAYKETTHUC = hd.NGAYKETTHUC;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.LANKY = hd.LANKY;
                _hd.THOIHAN= hd.THOIHAN;
                _hd.MANHANVIEN = hd.MANHANVIEN;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.NOIDUNG = hd.NOIDUNG;
                db.SaveChanges();
                return hd;
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
            var _hd = db.TB_HOPDONG.FirstOrDefault(x => x.MAHOPDONG == id);
            db.SaveChanges();
        }
    }
}
