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

namespace QLNHANSU.frmChamCong
{
    public partial class frmLoaiCa : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiCa()
        {
            InitializeComponent();
        }

        bool _btnThem = false;
        LoaiCaBAL loaiCa;
        int _id;

        void loadData()
        {
            gcLoaiCa.DataSource = loaiCa.getList();
            gvLoaiCa.OptionsBehavior.Editable= false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _btnThem = false;
            lblStatus.Text = "Bạn đang sửa";
            show(false);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _btnThem = true;
            lblStatus.Text = "Bạn đang thêm";
            show(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lblStatus.Text = "Bạn đang xoá";
            show(false);
            if (MessageBox.Show("Xac nhan xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                loaiCa.Delete(_id);
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            _btnThem = false;
            show(true);
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

        private void frmLoaiCa_Load(object sender, EventArgs e)
        {
            loaiCa = new LoaiCaBAL();
            show(true);
            loadData();
        }

        void show(bool kt)
        {
            btnLuuLoaiCa.Enabled = !kt;
            btnHuyLoaiCa.Enabled = !kt;
            btnThemLoaiCa.Enabled = kt;
            btnSuaLoaiCa.Enabled = kt;
            btnXoaLoaiCa.Enabled = kt;
            btnDongLoaiCa.Enabled = kt;
            txtLoaiCa.Enabled = !kt;
        }

        void saveData()
        {
            TB_LOAICA lc = new TB_LOAICA();

            if (_btnThem) //nếu btnThem bật thì thêm
            {
                lc.TENLOAICA = txtLoaiCa.Text;
                loaiCa.Add(lc);
            }
            else //ngược lại thì Update
            {
                lc = loaiCa.getItem(_id);
                lc.TENLOAICA = txtLoaiCa.Text;
                loaiCa.Update(lc);
            }
            loadData();
        }

        private void gcLoaiCa_Click(object sender, EventArgs e)
        {

        }

        private void gvLoaiCa_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvLoaiCa.GetFocusedRowCellValue("MALOAICA").ToString());
            txtLoaiCa.Text = gvLoaiCa.GetFocusedRowCellValue("TENLOAICA").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLoaiCa.Text = "";
        }
    }
}