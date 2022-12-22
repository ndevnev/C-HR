using BusinessLayer;
using BusinessLayer.Common;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
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
    public partial class frmBangCongChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongChiTiet()
        {
            InitializeComponent();
        }

        KyCongChiTietBAL _kyCongChiTietBAL;
        KyCongBAL _kyCongBAL;
        NhanVienBAL _nhanVienBAL;
        BangKyCongChiTietBAL _bangCongChiTietBAL;
        public int _macty;
        public int _thang;
        public int _nam;
        public int _maKyCong;

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_kyCongBAL.daTonTai(int.Parse(cboCTNam.Text) * 100 + int.Parse(cboCTThang.Text)))
            {
				MessageBox.Show("Kỳ công đã được phát sinh.","Thông báo");
				return;
            }
           
            var kc = _kyCongBAL.getItem(int.Parse(cboCTNam.Text) * 100 + int.Parse(cboCTThang.Text));
            if (kc != null)
            {
                kc.TRANGTHAI = true;
                _kyCongBAL.Update(kc, 1);
            }
            else
            {
                int mkc = int.Parse(cboCTNam.Text) * 100 + int.Parse(cboCTThang.Text);
                MessageBox.Show("Chưa tạo kỳ công ["+mkc+"] ở bảng công");
                return;
            }

            _kyCongChiTietBAL.phatSinhKyCongChiTiet(1, int.Parse(cboCTThang.Text), int.Parse(cboCTNam.Text));
            List<TB_NHANVIEN> lstNhanVien = _nhanVienBAL.getList();
            foreach (var item in lstNhanVien)
            {
                for (int i = 1; i <= GetDayNumber(int.Parse(cboCTThang.Text), int.Parse(cboCTNam.Text)); i++)
                {
                    TB_BANGCONG_NHANVIEN_CHITIET bcct = new TB_BANGCONG_NHANVIEN_CHITIET();
                    bcct.MANV = item.MANHANVIEN;
                    bcct.MACTY = "1";
                    bcct.HOTEN = item.HOVATEN;
                    bcct.GIOVAO = "08:00";
                    bcct.GIORA = "17:00";
                    bcct.NGAY = DateTime.Parse(cboCTNam.Text + "-" + cboCTThang.Text + "-" + i.ToString());
                    bcct.THU = CommonDateTimeBAL.layThuTrongTuan(int.Parse(cboCTNam.Text), int.Parse(cboCTThang.Text), i);
                    bcct.NGAYPHEP = 0;
                    bcct.CONGNGAYLE = 0;
                    bcct.CONGCHUNHAT = 0;
                    if (bcct.THU == "Chủ nhật")
                        bcct.KYHIEU = "CN";
                    else
                        bcct.KYHIEU = "X";
                    bcct.MAKYCONG = _maKyCong;
                    bcct.CREATED_DATE = DateTime.Now;
                    bcct.CREATED_BY = 1;
                    _bangCongChiTietBAL.Add(bcct);
                }
                loadBangCong();
            }
        }


        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadBangCong();
        }

        private void frmBangCongChiTiet_Load(object sender, EventArgs e)
        {
            _kyCongChiTietBAL = new KyCongChiTietBAL();
            _kyCongBAL = new KyCongBAL();
            _nhanVienBAL = new NhanVienBAL();
             _bangCongChiTietBAL=new BangKyCongChiTietBAL();
            gvBangCongChiTiet.OptionsBehavior.Editable = false;
            gcBangCongChiTiet.DataSource = _kyCongChiTietBAL.getList(_maKyCong); // Load ctiet ky cong len bang
            CustomView(_thang, _nam);
            cboCTThang.Text = _thang.ToString();
            cboCTNam.Text = _nam.ToString();
            loadBangCong();
        }

        private int GetDayNumber(int thang, int nam)
        {
            int dayNumber = 0;
            switch (thang)
            {
                case 2:
                    dayNumber = (nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0 ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dayNumber = 30;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dayNumber = 31;
                    break;
            }

            return dayNumber;
        }

        private void CustomView(int thang, int nam)
        {
            gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\BangCong_Layout.xml");
            int i;
            foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
            {
                if (gridColumn.FieldName == "HOTEN") continue;

                RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
                textEdit.Mask.MaskType = MaskType.RegEx;
                textEdit.Mask.EditMask = @"\p{Lu}+";
                gridColumn.ColumnEdit = textEdit;
            }

            for (i = 1; i <= GetDayNumber(thang, nam); i++)
            {
                DateTime newDate = new DateTime(nam, thang, i);

                GridColumn column = new GridColumn();
                column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                string fieldName = "D" + i;
                switch (newDate.DayOfWeek.ToString())
                {
                    case "Monday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T2 - " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        //column.Width = 30;
                        //column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
                        break;

                    case "Tuesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T3 - " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        break;

                    case "Wednesday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T4 - " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        break;
                    case "Thursday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T5 - " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        break;
                    case "Friday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T6 - " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Blue;
                        column.AppearanceHeader.BackColor = Color.Transparent;
                        column.AppearanceHeader.BackColor2 = Color.Transparent;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Transparent;
                        column.OptionsColumn.AllowFocus = true;
                        break;
                    case "Saturday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "T7 - " + i;
                        column.OptionsColumn.AllowEdit = true;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.Violet;
                        column.AppearanceHeader.BackColor2 = Color.Violet;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Khaki;
                        column.OptionsColumn.AllowFocus = true;
                        break;
                    case "Sunday":
                        column = gvBangCongChiTiet.Columns[fieldName];
                        column.Caption = "CN - " + i;
                        column.OptionsColumn.AllowEdit = false;
                        column.AppearanceHeader.ForeColor = Color.Red;
                        column.AppearanceHeader.BackColor = Color.GreenYellow;
                        column.AppearanceHeader.BackColor2 = Color.GreenYellow;
                        column.AppearanceCell.ForeColor = Color.Black;
                        column.AppearanceCell.BackColor = Color.Orange;
                        //column.OptionsColumn.AllowFocus = false;
                        break;
                }
            }

            while (i <= 31)
            {
                gvBangCongChiTiet.Columns[i + 1].Visible = false;
                i++;
            }

        }

        public void loadBangCong()
        {
            _kyCongChiTietBAL = new KyCongChiTietBAL();
            gcBangCongChiTiet.DataSource = _kyCongChiTietBAL.getList(int.Parse(cboCTNam.Text)*100 + int.Parse(cboCTThang.Text));
            _maKyCong = int.Parse(cboCTNam.Text) * 100 + int.Parse(cboCTThang.Text);
            CustomView(int.Parse(cboCTThang.Text), int.Parse(cboCTNam.Text));
            gvBangCongChiTiet.OptionsBehavior.Editable= false;
        }

        private void mnCapNhatNgayCong_Click(object sender, EventArgs e)
        {
            frmCapNhatNgayCong f = new frmCapNhatNgayCong();
            f.ShowDialog();
        }

        private void mnCapNhatNgayCong_Click_1(object sender, EventArgs e)
        {
            frmCapNhatNgayCong f = new frmCapNhatNgayCong();
            f._maKyCong = _maKyCong;
            f._maNhanVien = int.Parse(gvBangCongChiTiet.GetFocusedRowCellValue("MANV").ToString());
            f._hoVaTen = gvBangCongChiTiet.GetFocusedRowCellValue("HOTEN").ToString();
            f._ngayCong = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();
            f.ShowDialog();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}