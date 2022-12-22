namespace QLNHANSU
{
    partial class frmHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSohopdong = new System.Windows.Forms.TextBox();
            this.spLanki = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboThoihan = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.slkNhanvien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spHesoluong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayki = new System.Windows.Forms.DateTimePicker();
            this.dtNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HeSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOVATEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOHOPDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spLanki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHesoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1112, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 603);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1112, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 633);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1112, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 603);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.CausesValidation = false;
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.txtSohopdong);
            this.splitContainer1.Panel1.Controls.Add(this.spLanki);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtNoidung);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cboThoihan);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanvien);
            this.splitContainer1.Panel1.Controls.Add(this.spHesoluong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayki);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayketthuc);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgaybatdau);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 603);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(112, 36);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(98, 21);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Số hợp đồng:";
            // 
            // txtSohopdong
            // 
            this.txtSohopdong.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSohopdong.Location = new System.Drawing.Point(232, 37);
            this.txtSohopdong.Name = "txtSohopdong";
            this.txtSohopdong.Size = new System.Drawing.Size(147, 28);
            this.txtSohopdong.TabIndex = 21;
            // 
            // spLanki
            // 
            this.spLanki.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanki.Location = new System.Drawing.Point(761, 32);
            this.spLanki.MenuManager = this.barManager1;
            this.spLanki.Name = "spLanki";
            this.spLanki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spLanki.Properties.Appearance.Options.UseFont = true;
            this.spLanki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanki.Size = new System.Drawing.Size(147, 28);
            this.spLanki.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(696, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 21);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Lần kí:";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(232, 232);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(727, 175);
            this.txtNoidung.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // cboThoihan
            // 
            this.cboThoihan.FormattingEnabled = true;
            this.cboThoihan.Items.AddRange(new object[] {
            "1 tháng",
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.cboThoihan.Location = new System.Drawing.Point(812, 79);
            this.cboThoihan.Name = "cboThoihan";
            this.cboThoihan.Size = new System.Drawing.Size(147, 24);
            this.cboThoihan.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(692, 78);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 21);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Thời hạn:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(112, 227);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 21);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Nội dung:";
            // 
            // slkNhanvien
            // 
            this.slkNhanvien.EditValue = "";
            this.slkNhanvien.Location = new System.Drawing.Point(232, 79);
            this.slkNhanvien.MenuManager = this.barManager1;
            this.slkNhanvien.Name = "slkNhanvien";
            this.slkNhanvien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.slkNhanvien.Properties.Appearance.Options.UseFont = true;
            this.slkNhanvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanvien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanvien.Size = new System.Drawing.Size(355, 28);
            this.slkNhanvien.TabIndex = 12;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoten});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMaNV.AppearanceHeader.Options.UseFont = true;
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "MANHANVIEN";
            this.colMaNV.MaxWidth = 100;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHoten
            // 
            this.colHoten.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colHoten.AppearanceHeader.Options.UseFont = true;
            this.colHoten.Caption = "Họ tên";
            this.colHoten.FieldName = "HOVATEN";
            this.colHoten.Name = "colHoten";
            this.colHoten.Visible = true;
            this.colHoten.VisibleIndex = 1;
            // 
            // spHesoluong
            // 
            this.spHesoluong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHesoluong.Location = new System.Drawing.Point(232, 120);
            this.spHesoluong.MenuManager = this.barManager1;
            this.spHesoluong.Name = "spHesoluong";
            this.spHesoluong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spHesoluong.Properties.Appearance.Options.UseFont = true;
            this.spHesoluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHesoluong.Size = new System.Drawing.Size(147, 28);
            this.spHesoluong.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(112, 82);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 21);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Nhân viên:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(112, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 21);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Hệ số lương:";
            // 
            // dtNgayki
            // 
            this.dtNgayki.CustomFormat = "dd/MM/yyyy";
            this.dtNgayki.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayki.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayki.Location = new System.Drawing.Point(232, 173);
            this.dtNgayki.Name = "dtNgayki";
            this.dtNgayki.Size = new System.Drawing.Size(147, 28);
            this.dtNgayki.TabIndex = 7;
            // 
            // dtNgayketthuc
            // 
            this.dtNgayketthuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayketthuc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayketthuc.Location = new System.Drawing.Point(812, 173);
            this.dtNgayketthuc.Name = "dtNgayketthuc";
            this.dtNgayketthuc.Size = new System.Drawing.Size(147, 28);
            this.dtNgayketthuc.TabIndex = 6;
            // 
            // dtNgaybatdau
            // 
            this.dtNgaybatdau.CustomFormat = "dd/MM/yyyy";
            this.dtNgaybatdau.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaybatdau.Location = new System.Drawing.Point(812, 117);
            this.dtNgaybatdau.Name = "dtNgaybatdau";
            this.dtNgaybatdau.Size = new System.Drawing.Size(147, 28);
            this.dtNgaybatdau.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(112, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 21);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ngày kí:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(689, 174);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 21);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Ngày kết thúc:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(692, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ngày bắt đầu:";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1112, 189);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHD,
            this.NgayBD,
            this.NgayKT,
            this.NgayKi,
            this.HeSoLuong,
            this.NoiDung,
            this.ThoiHan,
            this.HOVATEN,
            this.LANKY,
            this.SOHOPDONG});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // MaHD
            // 
            this.MaHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MaHD.AppearanceHeader.Options.UseFont = true;
            this.MaHD.Caption = "Mã hợp đồng";
            this.MaHD.FieldName = "MAHOPDONG";
            this.MaHD.MaxWidth = 120;
            this.MaHD.MinWidth = 25;
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = true;
            this.MaHD.VisibleIndex = 0;
            this.MaHD.Width = 94;
            // 
            // NgayBD
            // 
            this.NgayBD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayBD.AppearanceHeader.Options.UseFont = true;
            this.NgayBD.Caption = "Ngày bắt đầu";
            this.NgayBD.FieldName = "NGAYBATDAU";
            this.NgayBD.MaxWidth = 200;
            this.NgayBD.MinWidth = 25;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Visible = true;
            this.NgayBD.VisibleIndex = 1;
            this.NgayBD.Width = 94;
            // 
            // NgayKT
            // 
            this.NgayKT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayKT.AppearanceHeader.Options.UseFont = true;
            this.NgayKT.Caption = "Ngày kết thúc";
            this.NgayKT.FieldName = "NGAYKETTHUC";
            this.NgayKT.MaxWidth = 200;
            this.NgayKT.MinWidth = 25;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Visible = true;
            this.NgayKT.VisibleIndex = 2;
            this.NgayKT.Width = 94;
            // 
            // NgayKi
            // 
            this.NgayKi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NgayKi.AppearanceHeader.Options.UseFont = true;
            this.NgayKi.Caption = "Ngày kí";
            this.NgayKi.FieldName = "NGAYKY";
            this.NgayKi.MaxWidth = 200;
            this.NgayKi.MinWidth = 25;
            this.NgayKi.Name = "NgayKi";
            this.NgayKi.Visible = true;
            this.NgayKi.VisibleIndex = 3;
            this.NgayKi.Width = 94;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HeSoLuong.AppearanceHeader.Options.UseFont = true;
            this.HeSoLuong.Caption = "Hệ số lương";
            this.HeSoLuong.FieldName = "HESOLUONG";
            this.HeSoLuong.MaxWidth = 150;
            this.HeSoLuong.MinWidth = 25;
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.Visible = true;
            this.HeSoLuong.VisibleIndex = 4;
            this.HeSoLuong.Width = 30;
            // 
            // NoiDung
            // 
            this.NoiDung.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NoiDung.AppearanceHeader.Options.UseFont = true;
            this.NoiDung.Caption = "Nội dung";
            this.NoiDung.FieldName = "NOIDUNG";
            this.NoiDung.MinWidth = 25;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 5;
            this.NoiDung.Width = 94;
            // 
            // ThoiHan
            // 
            this.ThoiHan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ThoiHan.AppearanceHeader.Options.UseFont = true;
            this.ThoiHan.Caption = "Thời hạn";
            this.ThoiHan.FieldName = "THOIHAN";
            this.ThoiHan.MinWidth = 25;
            this.ThoiHan.Name = "ThoiHan";
            this.ThoiHan.Visible = true;
            this.ThoiHan.VisibleIndex = 6;
            this.ThoiHan.Width = 94;
            // 
            // HOVATEN
            // 
            this.HOVATEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOVATEN.AppearanceHeader.Options.UseFont = true;
            this.HOVATEN.Caption = "Nhân viên";
            this.HOVATEN.FieldName = "HOVATEN";
            this.HOVATEN.MinWidth = 25;
            this.HOVATEN.Name = "HOVATEN";
            this.HOVATEN.Visible = true;
            this.HOVATEN.VisibleIndex = 7;
            this.HOVATEN.Width = 94;
            // 
            // LANKY
            // 
            this.LANKY.Caption = "Lần ký";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MinWidth = 25;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 8;
            this.LANKY.Width = 94;
            // 
            // SOHOPDONG
            // 
            this.SOHOPDONG.Caption = "Số hợp đồng";
            this.SOHOPDONG.FieldName = "SOHOPDONG";
            this.SOHOPDONG.MinWidth = 25;
            this.SOHOPDONG.Name = "SOHOPDONG";
            this.SOHOPDONG.Visible = true;
            this.SOHOPDONG.VisibleIndex = 9;
            this.SOHOPDONG.Width = 94;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHopDong";
            this.Text = "Hợp đồng lao động";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spLanki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHesoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SpinEdit spHesoluong;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtNgayki;
        private System.Windows.Forms.DateTimePicker dtNgayketthuc;
        private System.Windows.Forms.DateTimePicker dtNgaybatdau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaHD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKi;
        private DevExpress.XtraGrid.Columns.GridColumn HeSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiHan;
        private DevExpress.XtraGrid.Columns.GridColumn HOVATEN;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        //private DevExpress.XtraRichEdit.RichEditControl txtNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoten;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThoihan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtSohopdong;
        private DevExpress.XtraEditors.SpinEdit spLanki;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn SOHOPDONG;
    }
}