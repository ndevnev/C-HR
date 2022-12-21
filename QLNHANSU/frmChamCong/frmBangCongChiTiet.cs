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

namespace QLNHANSU.frmChamCong
{
    public partial class frmBangCongChiTiet : DevExpress.XtraEditors.XtraForm
    {
        public frmBangCongChiTiet()
        {
            InitializeComponent();
        }

        KyCongChiTietBAL _kyCongChiTietBAL;
        public int _macty;
        public int _thang;
        public int _nam;
        public int _maKyCong;

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _kyCongChiTietBAL.phatSinhKyCongChiTiet(_macty, _thang, _nam);
            gcBangCongChiTiet.DataSource = _kyCongChiTietBAL.getList(_nam * 100 + _thang);
        }

     

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmBangCongChiTiet_Load(object sender, EventArgs e)
        {
            _kyCongChiTietBAL = new KyCongChiTietBAL();
            gcBangCongChiTiet.DataSource = _kyCongChiTietBAL.getList(_maKyCong);
        }
    }
}