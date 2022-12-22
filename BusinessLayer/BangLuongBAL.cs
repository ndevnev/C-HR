using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BangLuongBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public TB_BANGLUONG getItem(int makycong, int manv)
        {
            return db.TB_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv);
        }

        public List<TB_BANGLUONG> getList(int maKyCong)
        {
            return db.TB_BANGLUONG.Where(x=>x.MAKYCONG==maKyCong).ToList();
        }

        public bool kiemTra(int maKyCong)
        {
            if (db.TB_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == maKyCong) != null)
            {
                return true;
            }
            return false;
        }

        public void tinhLuongNhanVien(int maKyCong)
        {
            double luongNgayThuong, luongPhep, thucLanh;
            var lstNV = db.TB_NHANVIEN.Where(x=>x.DATHOIVIEC==null).ToList();
            foreach (var item in lstNV)
            {
                var hd = db.TB_HOPDONG.FirstOrDefault(x => x.MANHANVIEN == item.MANHANVIEN);
                var kcct = db.TB_KYCONGCHITIET.FirstOrDefault(x => x.MANV == item.MANHANVIEN && x.MAKYCONG == maKyCong);
                var luong1NgayCong = item.LUONG;
                luongPhep = Convert.ToDouble(kcct.NGAYPHEP * luong1NgayCong * 0.3);
                luongNgayThuong = Convert.ToDouble(kcct.NGAYCONG * luong1NgayCong);
                thucLanh = luongPhep + luongNgayThuong;
               
                TB_BANGLUONG bl = new TB_BANGLUONG();
                
                bl.MAKYCONG = maKyCong;
                bl.MANV = item.MANHANVIEN;
                bl.HOTEN = item.HOVATEN;
                bl.NGAYPHEP = luongPhep;
                bl.NGAYTHUONG= luongNgayThuong;
                bl.THUCLANH = thucLanh;
                Add(bl);
            }
        }

        public TB_BANGLUONG Add(TB_BANGLUONG bl)
        {
            try
            {
                db.TB_BANGLUONG.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_BANGLUONG Update(TB_BANGLUONG bl)
        {
            try
            {
                TB_BANGLUONG _bl = db.TB_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == bl.MAKYCONG && x.MANV == bl.MANV);
                _bl.MANV = bl.MANV;
                _bl.MAKYCONG = bl.MAKYCONG;
                _bl.HOTEN = bl.HOTEN;
                _bl.NGAYPHEP = bl.NGAYPHEP;
                _bl.KHONGPHEP = bl.KHONGPHEP;
                _bl.NGAYTHUONG = bl.NGAYTHUONG;
                _bl.THUCLANH = bl.THUCLANH;
                _bl.UPDATED_BY = bl.UPDATED_BY;
                bl.UPDATED_DATE = bl.UPDATED_DATE;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
