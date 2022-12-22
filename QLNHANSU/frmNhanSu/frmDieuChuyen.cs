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
using BusinessLayer.DataObject;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;

namespace QUANLYNHANSU
{
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChuyen()
        {
            InitializeComponent();
        }
        bool _them, _xoa;
        string _soQD;
        NHANVIEN_DIEUCHUYEN_BAL _nvdc;
        NhanVienBAL _nhanvien;
        PhongBanBAL _phongban;

        private void frmNhanVien_DieuChuyen_Load(object sender, EventArgs e)
        {
            _nvdc = new NHANVIEN_DIEUCHUYEN_BAL();
            _nhanvien = new NhanVienBAL();
            _phongban = new PhongBanBAL();
            _them = false;
            _xoa = false;
            _showHide(true);
            loadNhanVien();
            loadDonViDen();
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
            dtNgay.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            cboDonViDen.Enabled = !kt;
            slkNhanVien.Enabled = !kt;

        }

        private void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

        }

        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANHANVIEN";
            slkNhanVien.Properties.DisplayMember = "HOVATEN";
        }

        void loadDonViDen()
        {
            cboDonViDen.DataSource = _phongban.getList();
            cboDonViDen.DisplayMember = "TENPHONGBAN";
            cboDonViDen.ValueMember = "MAPHONGBAN";
        }

        private void loadData()
        {
            gcDanhSach.DataSource = _nvdc.getListFull();
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
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _xoa = true;
                _nvdc.Delete(_soQD, 1);
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
            TB_NHANVIEN_DIEUCHUYEN dc;
            if (_them) //nếu btnThem bật thì thêm
            {
                var maxSoQD = _nvdc.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                dc = new TB_NHANVIEN_DIEUCHUYEN();
                dc.SOQD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+@"/QĐDC";
                dc.LYDO = txtLyDo.Text;
                dc.NGAY = dtNgay.Value;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).MAPHONGBAN;
                dc.MAPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _nvdc.Add(dc);

            }
            else //ngược lại thì Update
            {
                dc = _nvdc.getItem(_soQD);
                dc.LYDO = txtLyDo.Text;
                dc.NGAY = dtNgay.Value;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.UPDATED_BY = 1;
                dc.UPDATED_DATE = DateTime.Now;
                _nvdc.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.MANV.Value);
            if (_xoa)
            {
                _xoa = false;
                nv.MAPHONGBAN = dc.MAPB;
                _nhanvien.Update(nv);
            }
            else
            {
                nv.MAPHONGBAN = dc.MAPB2;
                _nhanvien.Update(nv);
            }   
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soQD = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var dc = _nvdc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = dc.NGAY.Value;
                slkNhanVien.EditValue = dc.MANV;
                txtGhiChu.Text = dc.GHICHU;
                txtLyDo.Text = dc.LYDO;
                cboDonViDen.SelectedValue = dc.MAPB2;
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
                e.Handled= true; 
            }    
        }
    }


}