using BusinessLayer;
using BusinessLayer.Common;
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

namespace QLNHANSU.frmChamCong
{
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }

        public int _maNhanVien, _cNgay;
        public string _hoVaTen;
        public int _maKyCong;
        public string _ngayCong;

        KyCongChiTietBAL _kcct;
        frmBangCongChiTiet frmBCCC = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KyCongChiTietBAL();
            lblID.Text = _maNhanVien.ToString();
            lblHoTen.Text = _hoVaTen;
            string nam = _maKyCong.ToString().Substring(0, 4);
            string thang = _maKyCong.ToString().Substring(4);
            string ngay = _ngayCong.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNgayCong.SetDate(_d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NV: " + _maNhanVien.ToString() + " - " + "KC: " +_maKyCong.ToString() + " - Ng.Cong: " + _ngayCong);
            string _valueChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
            string _valueNgayNghi = rdgNgayNghi.Properties.Items[rdgNgayNghi.SelectedIndex].Value.ToString();
            string fieldName = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_maKyCong, _maNhanVien);

            double? tongngaycong = kcct.TONGNGAYCONG;
            double? tongngayphep = kcct.NGAYPHEP;
            double? tongngaykhongphep = kcct.NGHIKHONGPHEP; ;
            double? tongngayle = kcct.CONGNGAYLE;//2022*100+1=202201
            if (cldNgayCong.SelectionRange.Start.Year * 100 + cldNgayCong.SelectionRange.Start.Month != +_maKyCong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Cập nhật KYCONGCHITIET=> cập nhật BANGCONG_NV_CT
            DatabaseHelper.execQuery("UPDATE tb_KYCONGCHITIET SET " + fieldName + "='" + _valueChamCong + "' WHERE MAKYCONG=" + _maKyCong + " AND MANV=" + _maNhanVien);

            frmBCCC.loadBangCong();
        }

        private void btnDiLam_Click(object sender, EventArgs e)
        {

        }

        private void cldNgayCong_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldNgayCong.SelectionRange.Start.Day;
        }

        private void cldNgayCong_DateChanged(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldNgayCong.SelectionRange.Start.Day;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}