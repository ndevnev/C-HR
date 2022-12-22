using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;

namespace QUANLYNHANSU
{
    public partial class frmThoiViec : DevExpress.XtraEditors.XtraForm
    {
        public frmThoiViec()
        {
            InitializeComponent();
        }
        bool _them, _xoa;
        string _soQD;
        NHANVIEN_THOIVIEC_BAL _nvtv;
        NhanVienBAL _nhanvien;
        private void frmThoiViec_Load(object sender, EventArgs e)
        {
            _nvtv = new NHANVIEN_THOIVIEC_BAL();
            _nhanvien = new NhanVienBAL();
            _them = false;
            _xoa = false;
            _showHide(true);
            loadNhanVien();
            loadData();

            splitContainer1.Panel1Collapsed = true;
        }

        private void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnDong.Enabled = kt;
            gcDanhSach.Enabled = kt;
            txtSoQD.Enabled = !kt;
            dtNgayNopDon.Enabled = !kt;
            dtNgayNghi.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }

        private void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtNgayNopDon.Value = DateTime.Now;
            dtNgayNghi.Value = dtNgayNopDon.Value.AddDays(45);

        }

        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANHANVIEN";
            slkNhanVien.Properties.DisplayMember = "HOVATEN";
        }
        private void loadData()
        {
            gcDanhSach.DataSource = _nvtv.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _xoa = true;
                _nvtv.Delete(_soQD, 1);
                saveData();
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {
            TB_NHANVIEN_THOIVIEC tv;
            if (_them) //nếu btnThem bật thì thêm
            {
                var maxSoQD = _nvtv.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tv = new TB_NHANVIEN_THOIVIEC();
                tv.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐTV";
                tv.LYDO = txtLyDo.Text;
                tv.NGAYNOPDON = dtNgayNopDon.Value;
                tv.NGAYNGHI = dtNgayNghi.Value;
                tv.GHICHU = txtGhiChu.Text;
                tv.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.CREATED_BY = 1;
                tv.CREATED_DATE = DateTime.Now;
                _nvtv.Add(tv);

            }
            else //ngược lại thì Update
            {
                tv = _nvtv.getItem(_soQD);
                tv.LYDO = txtLyDo.Text;
                tv.NGAYNOPDON = dtNgayNopDon.Value;
                tv.NGAYNGHI = dtNgayNghi.Value;
                tv.GHICHU = txtGhiChu.Text;
                tv.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                tv.UPDATED_BY = 1;
                tv.UPDATED_DATE = DateTime.Now;
                _nvtv.Update(tv);
            }
            var nv = _nhanvien.getItem(tv.MANV.Value);
            if (_xoa)
            {
                _xoa = false;
                nv.DATHOIVIEC = null;
                _nhanvien.Update(nv);
            }
            else
            {
                nv.DATHOIVIEC = true;
                _nhanvien.Update(nv);
            }
        }
        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var tv = _nvtv.getItem(_soQD);
                txtSoQD.Text = _soQD;
                tv.NGAYNOPDON = dtNgayNopDon.Value;
                tv.NGAYNGHI = dtNgayNghi.Value;
                slkNhanVien.EditValue = tv.MANV;
                txtGhiChu.Text = tv.GHICHU;
                txtLyDo.Text = tv.LYDO;
                splitContainer1.Panel1Collapsed = false;
                _showHide(true);
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = QLNHANSU.Properties.Resources.del_Icon_x16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
        private void dtNgayNopDon_ValueChanged(object sender, EventArgs e)
        {
            dtNgayNghi.Value = dtNgayNopDon.Value.AddDays(45);
        }
    }
}