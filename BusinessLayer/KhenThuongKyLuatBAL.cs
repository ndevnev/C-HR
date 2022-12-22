using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;

namespace BusinessLayer
{
    public class KhenThuongKyLuatBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public TB_KHENTHUONGKYLUAT getItem(int id)
        {
            return db.TB_KHENTHUONGKYLUAT.FirstOrDefault(x => x.MAKHENTHUONGKYLUAT == id);
        }

        public List<TB_KHENTHUONGKYLUAT> getList(string loai)
        {
            return db.TB_KHENTHUONGKYLUAT.Where(x => x.LOAI == loai).ToList();
        }


        public List<KhenThuong_KiLuatDTO> getListFull(string loai)
        {
            List<TB_KHENTHUONGKYLUAT> lstKT = db.TB_KHENTHUONGKYLUAT.Where(x => x.LOAI == loai).ToList();
            List<KhenThuong_KiLuatDTO> lstKTDTO = new List<KhenThuong_KiLuatDTO>();
            KhenThuong_KiLuatDTO kt;

            foreach (var item in lstKT)
            {
                kt = new KhenThuong_KiLuatDTO();
                kt.LOAI = item.LOAI;
                kt.MAKHENTHUONGKYLUAT = item.MAKHENTHUONGKYLUAT;
                kt.LYDO = item.LYDO;
                kt.NGAY = item.NGAY;
                kt.SOTIEN = item.SOTIEN;
                kt.MANHANVIEN = item.MANHANVIEN;
                var nv = db.TB_NHANVIEN.FirstOrDefault(n => n.MANHANVIEN == item.MANHANVIEN);
                kt.HOVATEN = nv.HOVATEN;
                lstKTDTO.Add(kt);

            }

            return lstKTDTO;
        }

        public TB_KHENTHUONGKYLUAT Add(TB_KHENTHUONGKYLUAT ktkl)
        {
            try
            {
                db.TB_KHENTHUONGKYLUAT.Add(ktkl);
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public TB_KHENTHUONGKYLUAT Update(TB_KHENTHUONGKYLUAT ktkl)
        {
            try
            {
                TB_KHENTHUONGKYLUAT _ktkl = db.TB_KHENTHUONGKYLUAT.FirstOrDefault(x => x.MAKHENTHUONGKYLUAT == ktkl.MAKHENTHUONGKYLUAT);
                _ktkl.NGAY = ktkl.NGAY;
                _ktkl.LYDO = ktkl.LYDO;
                _ktkl.LOAI = ktkl.LOAI;
                _ktkl.MANHANVIEN = ktkl.MANHANVIEN;
                _ktkl.SOTIEN = ktkl.SOTIEN;
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                TB_KHENTHUONGKYLUAT ktkl = db.TB_KHENTHUONGKYLUAT.FirstOrDefault(x => x.MAKHENTHUONGKYLUAT == id);
                db.TB_KHENTHUONGKYLUAT.Remove(ktkl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }
    }
}
