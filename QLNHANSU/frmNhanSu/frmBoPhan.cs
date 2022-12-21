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

namespace HRM
{
    public partial class frmBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }

        BoPhanBAL bophan;
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

        void loadData()
        {
            gcDanhSach.DataSource = bophan.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            bophan = new BoPhanBAL();
            show(true);
            loadData();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            show(false);
            btnThem.Enabled = true;
            txtTenbophan.Clear();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bophan.Delete(id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(true);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {
            TB_BOPHAN bp = new TB_BOPHAN();

            if (btnThem.Enabled) //nếu btnThem bật thì thêm
            {
                bp.TENBOPHAN = txtTenbophan.Text;
                bophan.Add(bp);
            }
            else //ngược lại thì Update
            {
                bp = bophan.getItem(id);
                bp.TENBOPHAN = txtTenbophan.Text;
                bophan.Update(bp);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MABOPHAN").ToString());
                txtTenbophan.Text = gvDanhSach.GetFocusedRowCellValue("TENBOPHAN").ToString();
            }
        }
    }
}