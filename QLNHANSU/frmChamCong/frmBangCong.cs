using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Common;
using System.Runtime.InteropServices;

namespace QLNHANSU.frmChamCong
{
    public partial class frmBangCong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCong()
        {
            InitializeComponent();
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();

        }

        bool _btnThem = false;
        KyCongBAL kyCongBAL;
        int _maKyCong;

        void loadData()
        {
            gcDanhSach.DataSource = kyCongBAL.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _btnThem = true;
            lblStatus.Text = "Bạn đang thêm";
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
            cbKhoa.Checked= false;
            cbTrangThai.Checked= false;
            show(false);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _btnThem = false;
            lblStatus.Text = "Bạn đang sửa";
            show(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lblStatus.Text = "Bạn đang xoá";
            show(false);
            if (MessageBox.Show("Xac nhan xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                kyCongBAL.Delete(_maKyCong, 1);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _btnThem = false;
            show(true);
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _maKyCong = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAKYCONG").ToString());
            cboNam.Text=gvDanhSach.GetFocusedRowCellValue("NAM").ToString();
            cboThang.Text = gvDanhSach.GetFocusedRowCellValue("THANG").ToString();
            cbKhoa.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("KHOA").ToString());
            cbTrangThai.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            _btnThem = false;
            show(true);
        }

        private void frmBangCong_Load(object sender, EventArgs e)
        {
            _btnThem= false;
            kyCongBAL = new KyCongBAL();
            show(true);
            loadData();
        }

        void show(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
        }

        void saveData()
        {

            if (_btnThem) //nếu btnThem bật thì thêm
            {
                TB_KYCONG kc = new TB_KYCONG();
                kc.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                kc.NAM = int.Parse(cboNam.Text);
                kc.THANG = int.Parse(cboThang.Text);
                kc.KHOA = cbKhoa.Checked;
                kc.TRANGTHAI = cbTrangThai.Checked;
                kc.NGAYCONGTRONGTHANG = CommonDateTimeBAL.demSoNgayLamViecTrongThang(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE= DateTime.Now;
                kyCongBAL.Add(kc);
            }
            else //ngược lại thì Update
            {
                var kc = kyCongBAL.getItem(_maKyCong);
                kc.MAKYCONG = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                kc.NAM = int.Parse(cboNam.Text);
                kc.THANG = int.Parse(cboThang.Text);
                kc.KHOA = cbKhoa.Checked;
                kc.TRANGTHAI = cbTrangThai.Checked;
                kc.NGAYCONGTRONGTHANG = CommonDateTimeBAL.demSoNgayLamViecTrongThang(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                kyCongBAL.Update(kc, 1);
            }
            loadData();
        }

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCongChiTiet f = new frmBangCongChiTiet();
            f._maKyCong = _maKyCong;
            f._macty = 1;
            try {
                f._thang = int.Parse(cboThang.Text);
                f._nam = int.Parse(cboNam.Text);
                f.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show("Chưa chọn kỳ công hoặc chọn tháng[cbx] và năm[cbx] của kỳ công");
            }
        }
    }
}