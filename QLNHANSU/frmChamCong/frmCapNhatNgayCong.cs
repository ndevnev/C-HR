using BusinessLayer;
using BusinessLayer.Common;
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
        BangKyCongChiTietBAL _bcctBAL;
        frmBangCongChiTiet frmBCCC = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KyCongChiTietBAL();
            _bcctBAL = new BangKyCongChiTietBAL();            lblID.Text = _maNhanVien.ToString();
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



            if (cldNgayCong.SelectionRange.Start.Year * 100 + cldNgayCong.SelectionRange.Start.Month != +_maKyCong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Cập nhật KYCONGCHITIET=> cập nhật BANGCONG_NV_CT
            DatabaseHelper.execQuery("UPDATE tb_KYCONGCHITIET SET " + fieldName + "='" + _valueChamCong + "' WHERE MAKYCONG=" + _maKyCong + " AND MANV=" + _maNhanVien);

            TB_BANGCONG_NHANVIEN_CHITIET bcnvct = _bcctBAL.getItem(_maKyCong, _maNhanVien, cldNgayCong.SelectionStart.Day);
            bcnvct.KYHIEU = _valueChamCong;

            switch (_valueChamCong)
            {
                case "P":
                    if (_valueNgayNghi=="CN")
                    {
                        bcnvct.NGAYPHEP = 1;
                        bcnvct.NGAYCONG= 0;
                    } else {
                        bcnvct.NGAYPHEP = 0.5;
                        bcnvct.NGAYCONG = 0.5;
                    }
                    break;

                case "V":
                    if (_valueNgayNghi == "CN")
                    {
                        bcnvct.NGAYPHEP = 0;
                        bcnvct.NGAYCONG = 0;
                    }
                    else
                    {
                        bcnvct.NGAYPHEP = 0.5;
                        bcnvct.NGAYCONG = 0.5;
                    }
                    break;

                case "VR":
                    if (_valueNgayNghi == "CN")
                    {
                        bcnvct.NGAYPHEP = 1;
                        bcnvct.NGAYCONG = 0;
                    }
                    else
                    {
                        bcnvct.NGAYPHEP = 0.5;
                        bcnvct.NGAYCONG = 0.5;
                    }
                    break;

                case "CT":
                    if (_valueNgayNghi == "CN")
                    {
                        bcnvct.NGAYPHEP = 1;
                        bcnvct.NGAYCONG = 0;
                    }
                    else
                    {
                        bcnvct.NGAYPHEP = 0.5;
                        bcnvct.NGAYCONG = 0.5;
                    }
                    break;
                default:
                    break;
            }

            //Update tb_BANGCONG_NV_CT
            _bcctBAL.Update(bcnvct);

            //Tính lại tổng các ngày: ngày phép, ngày công, ngày vắng,...
            double tongngaycong = _bcctBAL.tongNgayCong(_maKyCong, _maNhanVien);
            double tongngayphep = _bcctBAL.tongNgayPhep(_maKyCong, _maNhanVien);
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG = tongngaycong;
            _kcct.Update(kcct);

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