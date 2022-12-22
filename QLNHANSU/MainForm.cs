using HRM;
using QLNHANSU.frmChamCong;
using QLNHANSU.frmNhanSu;
using QUANLYNHANSU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTrinhDo frm = new frmTrinhDo();
            frm.MdiParent= this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHopDong frm = new frmHopDong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhongBan f = new frmPhongBan(); 
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThoiViec f = new frmThoiViec();
            f.MdiParent = this;
            f.Show();
        }

        private void btnLoaiCa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiCa f = new frmLoaiCa();
            f.MdiParent = this;
            f.Show();
        }

        private void btnLoaiCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiCong f = new frmLoaiCong();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangCong f = new frmBangCong();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDieuChuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDieuChuyen f = new frmDieuChuyen();
            f.MdiParent = this;
            f.Show();
        }

        private void btnBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnKhenThuong1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhenThuong f = new frmKhenThuong();
            f.MdiParent= this;
            f.Show();
        }

        private void btnKyLuat1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKyLuat f = new frmKyLuat();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChucVu f = new frmChucVu();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBoPhan f = new frmBoPhan();
            f.MdiParent = this;
            f.Show();
        }
    }
}
