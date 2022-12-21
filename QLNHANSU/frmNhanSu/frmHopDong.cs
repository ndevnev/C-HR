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
using DataLayer;
using BusinessLayer;

namespace QLNHANSU
{
    public partial class frmHopDong : DevExpress.XtraEditors.XtraForm
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        HopDongBAL hopdong;
        NhanVienBAL nhanvien;
        int id;

        private void show(bool kt)
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
            dtNgaybatdau.Value = DateTime.Now;
            dtNgayketthuc.Value = dtNgaybatdau.Value.AddMonths(6); //them 6 thang
            dtNgayki.Value = DateTime.Now;
            spHesoluong.Text = "1";
            
        }

        private void loadData()
        {
            gcDanhSach.DataSource = hopdong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadNhanvien()
        {
            slkNhanvien.Properties.DataSource = nhanvien.getList();
            slkNhanvien.Properties.ValueMember = "MANHANVIEN";
            slkNhanvien.Properties.DisplayMember = "HOVATEN";
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            hopdong = new HopDongBAL();
            nhanvien = new NhanVienBAL();
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
                hopdong.Delete(id);
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
                TB_HOPDONG hd = new TB_HOPDONG();
                hd.HESOLUONG = float.Parse(spHesoluong.EditValue.ToString());
                hd.NGAYBATDAU = dtNgaybatdau.Value;
                hd.NGAYKETTHUC = dtNgayketthuc.Value;
                hd.NGAYKY = dtNgayki.Value;
                //hd.THOIHAN = cboThoihan.Text;
                hd.MANHANVIEN = int.Parse(slkNhanvien.EditValue.ToString());
                //hd.NOIDUNG = txtNoidung.RtfText;
                hopdong.Add(hd);
            }
            else //ngược lại thì Update
            {
                var hd = hopdong.getItem(id);
                hd.HESOLUONG = float.Parse(spHesoluong.EditValue.ToString());
                hd.NGAYBATDAU = dtNgaybatdau.Value;
                hd.NGAYKETTHUC = dtNgayketthuc.Value;
                hd.NGAYKY = dtNgayki.Value;
                //hd.THOIHAN = cboThoihan.Text;
                hd.MANHANVIEN = int.Parse(slkNhanvien.EditValue.ToString());
                //hd.NOIDUNG = txtNoidung.RtfText;
                hopdong.Update(hd);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                splitContainer1.Panel1Collapsed = false;
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MAHOPDONG").ToString());
                var hd = hopdong.getItem(id);
                spHesoluong.Text = hd.HESOLUONG.ToString();
                dtNgaybatdau.Value = hd.NGAYBATDAU.Value;
                dtNgayketthuc.Value =  hd.NGAYKETTHUC.Value;
                dtNgayki.Value = hd.NGAYKY.Value;
                cboThoihan.Text = hd.THOIHAN.ToString();
                //txtNoidung.RtfText = hd.NoiDung;
                slkNhanvien.EditValue = hd.MANHANVIEN;

            }
        }
    }
}