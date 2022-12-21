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
using System.IO;

namespace HRM
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBAL nhanvien;
        ChucVuBAL chucvu;
        TrinhDoBAL trinhdo;
        PhongBanBAL phongban;
        BoPhanBAL bophan;
        int id;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            nhanvien = new NhanVienBAL();
            chucvu = new ChucVuBAL();
            trinhdo = new TrinhDoBAL();
            phongban = new PhongBanBAL();
            bophan = new BoPhanBAL();
            show(true);
            loadData();
            loadCombobox();
            splitContainer1.Panel1Collapsed = true;
        }

        void show(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThoat.Enabled = kt;
        }

        void reset()
        {
            txtHoten.Text = String.Empty;
            txtDienthoai.Text = String.Empty;
            txtDiachi.Text = String.Empty;
            chkGioitinh.Checked = false;
        }

        void loadCombobox()
        {
            cboBophan.DataSource = bophan.getList();
            cboBophan.DisplayMember = "TENBOPHAN";
            cboBophan.ValueMember = "MABOPHAN";

            cboPhongban.DataSource = phongban.getList();
            cboPhongban.DisplayMember = "TENPHONGBAN";
            cboPhongban.ValueMember = "MAPHONGBAN";

            cboChucvu.DataSource = chucvu.getList();
            cboChucvu.DisplayMember = "TENCHUCVU";
            cboChucvu.ValueMember = "MACHUCVU";

            cboTrinhdo.DataSource = trinhdo.getList();
            cboTrinhdo.DisplayMember = "TENTRINHDO";
            cboTrinhdo.ValueMember = "MATRINHDO";
        }

        void loadData()
        {
            gcDanhSach.DataSource = nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
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
                nhanvien.Delete(id);
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
            TB_NHANVIEN nv = new TB_NHANVIEN();

            if (btnThem.Enabled) //nếu btnThem bật thì thêm
            {
                if (chkGioitinh.Checked)
                {
                    nv.GIOITINH = "Nam";
                } else
                {
                    nv.GIOITINH = "Nữ";
                }
                nv.HOVATEN = txtHoten.Text;
                nv.NGAYSINH = dtNgaysinh.Value;
                nv.DIACHI = txtDiachi.Text;
                nv.SODIENTHOAI = txtDienthoai.Text;
                nv.HINHANH = ImageToBase64(picHinhanh.Image, picHinhanh.Image.RawFormat);
                nv.MABOPHAN = int.Parse(cboBophan.SelectedValue.ToString());
                nv.MAPHONGBAN = int.Parse(cboPhongban.SelectedValue.ToString());
                nv.MACHUCVU = int.Parse(cboChucvu.SelectedValue.ToString());
                nv.MATRINHDO = int.Parse(cboTrinhdo.SelectedValue.ToString());
                nhanvien.Add(nv);
            }
            else //ngược lại thì Update
            {
                nv = nhanvien.getItem(id);
                nv.HOVATEN = txtHoten.Text;
                if (chkGioitinh.Checked)
                {
                    nv.GIOITINH = "Nam";
                } else
                {
                    nv.GIOITINH = "Nữ"; 
                }
                nv.NGAYSINH = dtNgaysinh.Value;
                nv.DIACHI = txtDiachi.Text;
                nv.SODIENTHOAI = txtDienthoai.Text;
                nv.HINHANH = ImageToBase64(picHinhanh.Image, picHinhanh.Image.RawFormat);
                nv.MABOPHAN = int.Parse(cboBophan.SelectedValue.ToString());
                nv.MAPHONGBAN = int.Parse(cboPhongban.SelectedValue.ToString());
                nv.MACHUCVU = int.Parse(cboChucvu.SelectedValue.ToString());
                nv.MATRINHDO = int.Parse(cboTrinhdo.SelectedValue.ToString());
                nhanvien.Update(nv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                splitContainer1.Panel1Collapsed = false;
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaNV").ToString());
                var nv = nhanvien.getItem(id);
                txtHoten.Text = nv.HOVATEN;
                if (nv.GIOITINH == "Nam")
                {
                    chkGioitinh.Checked = true;
                } else
                {
                    chkGioitinh.Checked = false;
                }
                dtNgaysinh.Value = nv.NGAYSINH.Value;
                txtDiachi.Text = nv.DIACHI;
                txtDienthoai.Text = nv.SODIENTHOAI;
                picHinhanh.Image = Base64ToImage(nv.HINHANH);
                cboBophan.SelectedValue = nv.MABOPHAN;
                cboPhongban.SelectedValue = nv.MAPHONGBAN;
                cboChucvu.SelectedValue = nv.MACHUCVU;
                cboTrinhdo.SelectedValue = nv.MATRINHDO;
            }
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            if (imageBytes == null)
            {
                return null;
            }
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Picture file (.png, jpg)|*.png;*.jpg";
            dlg.Title = "Chọn hình ảnh";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picHinhanh.Image = Image.FromFile(dlg.FileName);
                picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}