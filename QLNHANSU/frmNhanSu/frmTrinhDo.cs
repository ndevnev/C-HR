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
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }

        private TrinhDoBAL trinhDoBAL;
        int id;

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            trinhDoBAL = new TrinhDoBAL();
            show(true); 
            loadData();
        }

        void show(bool kt)
        {
            btnLuuTD.Enabled = !kt;
            btnHuyTD.Enabled = !kt;
            btnThemTD.Enabled = kt;
            btnSuaTD.Enabled = kt;
            btnXoaTD.Enabled = kt;
            btnThoatTD.Enabled = kt;
        }

        void loadData()
        {
            gcDanhSach.DataSource = trinhDoBAL.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThemTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
            btnThemTD.Enabled = true;
            txtTentrinhdo.Clear();
        }

        private void btnSuaTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(false);
        }

        private void btnXoaTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                trinhDoBAL.Delete(id);
                loadData();
            }
        }
        private void btnLuuTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
        }

        private void btnHuyTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show(true);
        }

        private void btnThoatTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {
            TB_TRINHDO td = new TB_TRINHDO();

            if (btnThemTD.Enabled) //nếu btnThem bật thì thêm
            {
                td.TENTRINHDO = txtTentrinhdo.Text;
                trinhDoBAL.Add(td);
            }
            else //ngược lại thì Update
            {
                td = trinhDoBAL.getItem(id);
                td.TENTRINHDO = txtTentrinhdo.Text;
                trinhDoBAL.Update(td);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MATRINHDO").ToString());
            txtTentrinhdo.Text = gvDanhSach.GetFocusedRowCellValue("TENTRINHDO").ToString();
        }
    }
}