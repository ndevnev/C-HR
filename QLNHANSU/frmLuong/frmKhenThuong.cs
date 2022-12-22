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
using BusinessLayer;

namespace QLNHANSU.frmNhanSu
{
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        KhenThuongKyLuatBAL ktkl;
        NhanVienBAL nhanvien;
        int id;

        void show(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThoat.Enabled = kt;
        }

        private void reset()
        {
            dtNgay.Value = DateTime.Now;
            txtLydo.Text = string.Empty;
            txtSotien.Text = string.Empty;

        }

        void loadData()
        {
            gcDanhSach.DataSource = ktkl.getListFull("KhenThuong");
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = nhanvien.getList();
            slkNhanvien.Properties.ValueMember = "MANHANVIEN";
            slkNhanvien.Properties.DisplayMember = "HOVATEN";
        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            ktkl = new KhenThuongKyLuatBAL();
            nhanvien = new NhanVienBAL();
            show(true);
            loadData();
            loadNhanvien();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
            btnThem.Enabled = true;
            reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
            btnSua.Enabled = true;
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ktkl.Delete(id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            show(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {


            if (btnThem.Enabled) //nếu btnThem bật thì thêm
            {
                TB_KHENTHUONGKYLUAT kt = new TB_KHENTHUONGKYLUAT();
                kt.LYDO = txtLydo.Text;
                kt.SOTIEN = int.Parse(txtSotien.Text);
                kt.NGAY = dtNgay.Value;
                kt.LOAI = "KhenThuong";
                kt.MANHANVIEN = int.Parse(slkNhanvien.EditValue.ToString());
                ktkl.Add(kt);

            }
            else //ngược lại thì Update
            {
                var kt = ktkl.getItem(id);
                kt.LYDO = txtLydo.Text;
                kt.NGAY = dtNgay.Value;
                kt.SOTIEN = int.Parse(txtSotien.Text);
                kt.LOAI = "KhenThuong";
                kt.MANHANVIEN = int.Parse(slkNhanvien.EditValue.ToString());
                ktkl.Update(kt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAKHENTHUONGKYLUAT").ToString());
                var kt = ktkl.getItem(id);
                slkNhanvien.EditValue = kt.MANHANVIEN;
                txtMaktkl.Text = kt.MAKHENTHUONGKYLUAT.ToString();
                txtLydo.Text = kt.LYDO;
                dtNgay.Value = kt.NGAY.Value;
                txtSotien.Text =  kt.SOTIEN.ToString();
            }
        }
        
    }
}