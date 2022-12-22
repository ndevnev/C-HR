using BusinessLayer;
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

namespace QLNHANSU.frmLuong
{
    public partial class frmLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmLuong()
        {
            InitializeComponent();
        }

        BangLuongBAL _bangLuongBAL;

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int kyCong = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
                try
                {
                    if (_bangLuongBAL.kiemTra(kyCong))
                    {
                        MessageBox.Show("Đã có bảng lương");
                        loadData();
                        return;
                    }
                    KyCongBAL k = new KyCongBAL();
                    if (!k.daTonTai(kyCong)){
                        MessageBox.Show("Không tồn tại kỳ công: " + kyCong);
                        return;
                    }
                    _bangLuongBAL.tinhLuongNhanVien(kyCong);
                    loadData();
                }
                catch (Exception ex) {
                    MessageBox.Show("Chưa có kỳ công: " + kyCong);
                    return;
                }
            } catch (Exception ex){
                MessageBox.Show("Chưa chọn kỳ công");
            }
        }
        public void loadData()
        {
            _bangLuongBAL = new BangLuongBAL();
            int kyCong = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
            gcDanhSach.DataSource= _bangLuongBAL.getList(kyCong);
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnXemBangLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            _bangLuongBAL = new BangLuongBAL();
        }
    }
}