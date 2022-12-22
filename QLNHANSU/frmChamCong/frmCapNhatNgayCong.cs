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

        public int _maNhanVien;
        public string _hoVaTen;
        public int _maKyCong;
        public string _ngayCong;

        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NV: " + _maNhanVien.ToString() + " - " + "KC: " +_maKyCong.ToString() + " - Ng.Cong: " + _ngayCong);

        }

        private void btnDiLam_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}