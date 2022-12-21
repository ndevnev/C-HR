using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class NhanVienBAL
    {
        QUANLYNHANSUEntities db = new QUANLYNHANSUEntities();

        public List<TB_NHANVIEN> getList()
        {
            return db.TB_NHANVIEN.ToList();
        }

        public List<NhanVienDTO> getListFull()
        {
            var lstNV = db.TB_NHANVIEN.ToList();
            List<NhanVienDTO> lstNVDTO = new List<NhanVienDTO>();
            NhanVienDTO nvDTO;
            foreach(var item in lstNV)
            {
                nvDTO = new NhanVienDTO();
                nvDTO.MaNV = item.MANHANVIEN;
                nvDTO.HoTen = item.HOVATEN;
                nvDTO.GioiTinh = item.GIOITINH;
                nvDTO.NgaySinh = item.NGAYSINH;
                nvDTO.DiaChi = item.DIACHI;
                nvDTO.DienThoai = item.SODIENTHOAI;
                nvDTO.HinhAnh = item.HINHANH;
                nvDTO.MaBP = item.MABOPHAN;
                var bp = db.TB_BOPHAN.FirstOrDefault(b => b.MABOPHAN == item.MABOPHAN);
                nvDTO.TenBP = bp.TENBOPHAN;
                nvDTO.MaCV = item.MACHUCVU;
                var cv = db.TB_CHUCVU.FirstOrDefault(c => c.MACHUCVU == item.MACHUCVU);
                nvDTO.TenCV = cv.TENCHUCVU;
                nvDTO.MaPB = item.MAPHONGBAN;
                var pb = db.TB_PHONGBAN.FirstOrDefault(p => p.MAPHONGBAN == item.MAPHONGBAN);
                nvDTO.TenPB = pb.TENPHONGBAN;
                nvDTO.MaTD = item.MATRINHDO;
                var td = db.TB_TRINHDO.FirstOrDefault(t => t.MATRINHDO == item.MATRINHDO);
                nvDTO.TenTD = td.TENTRINHDO;
                lstNVDTO.Add(nvDTO);
            }

            return lstNVDTO;
        }

        public TB_NHANVIEN getItem(int id)
        {
            return db.TB_NHANVIEN.FirstOrDefault(x => x.MANHANVIEN == id); ;
        }

        public TB_NHANVIEN Add(TB_NHANVIEN nv)
        {
            try
            {
                db.TB_NHANVIEN.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public TB_NHANVIEN Update(TB_NHANVIEN nv)
        {
            try
            {
                var _nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANHANVIEN == nv.MANHANVIEN);
                _nv.HOVATEN = nv.HOVATEN;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.DIACHI = nv.DIACHI;
                _nv.SODIENTHOAI = nv.SODIENTHOAI;
                _nv.HINHANH = nv.HINHANH;
                _nv.MABOPHAN = nv.MABOPHAN;
                _nv.MAPHONGBAN = nv.MAPHONGBAN;
                _nv.MACHUCVU = nv.MACHUCVU;
                _nv.MATRINHDO = nv.MATRINHDO;
                db.SaveChanges();
                return nv;
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
                var _nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANHANVIEN == id);
                db.TB_NHANVIEN.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
