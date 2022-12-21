namespace QLNHANSU.frmChamCong
{
    partial class frmLoaiCa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiCa));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThemLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnInLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLoaiCa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcLoaiCa = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiCa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLoaiCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaTruongLoaiCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiCa)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemLoaiCa,
            this.btnSuaLoaiCa,
            this.btnXoaLoaiCa,
            this.btnLuuLoaiCa,
            this.btnHuyLoaiCa,
            this.btnDongLoaiCa,
            this.btnInLoaiCa});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemLoaiCa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaLoaiCa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaLoaiCa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuLoaiCa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyLoaiCa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongLoaiCa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInLoaiCa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnThemLoaiCa
            // 
            this.btnThemLoaiCa.Caption = "Thêm";
            this.btnThemLoaiCa.Id = 0;
            this.btnThemLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemLoaiCa.ImageOptions.SvgImage")));
            this.btnThemLoaiCa.Name = "btnThemLoaiCa";
            this.btnThemLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSuaLoaiCa
            // 
            this.btnSuaLoaiCa.Caption = "Sửa";
            this.btnSuaLoaiCa.Id = 1;
            this.btnSuaLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaLoaiCa.ImageOptions.SvgImage")));
            this.btnSuaLoaiCa.Name = "btnSuaLoaiCa";
            this.btnSuaLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoaLoaiCa
            // 
            this.btnXoaLoaiCa.Caption = "Xoá";
            this.btnXoaLoaiCa.Id = 2;
            this.btnXoaLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaLoaiCa.ImageOptions.SvgImage")));
            this.btnXoaLoaiCa.Name = "btnXoaLoaiCa";
            this.btnXoaLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuuLoaiCa
            // 
            this.btnLuuLoaiCa.Caption = "Lưu";
            this.btnLuuLoaiCa.Id = 3;
            this.btnLuuLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuuLoaiCa.ImageOptions.SvgImage")));
            this.btnLuuLoaiCa.Name = "btnLuuLoaiCa";
            this.btnLuuLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuyLoaiCa
            // 
            this.btnHuyLoaiCa.Caption = "Huỷ";
            this.btnHuyLoaiCa.Id = 4;
            this.btnHuyLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyLoaiCa.ImageOptions.SvgImage")));
            this.btnHuyLoaiCa.Name = "btnHuyLoaiCa";
            this.btnHuyLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDongLoaiCa
            // 
            this.btnDongLoaiCa.Caption = "Đóng";
            this.btnDongLoaiCa.Id = 5;
            this.btnDongLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDongLoaiCa.ImageOptions.SvgImage")));
            this.btnDongLoaiCa.Name = "btnDongLoaiCa";
            this.btnDongLoaiCa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // btnInLoaiCa
            // 
            this.btnInLoaiCa.Caption = "In";
            this.btnInLoaiCa.Id = 6;
            this.btnInLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInLoaiCa.ImageOptions.SvgImage")));
            this.btnInLoaiCa.Name = "btnInLoaiCa";
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1062, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 670);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1062, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 636);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1062, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 636);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaTruongLoaiCa);
            this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel1.Controls.Add(this.txtLoaiCa);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcLoaiCa);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 636);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Chưa chọn thao tác";
            // 
            // txtLoaiCa
            // 
            this.txtLoaiCa.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLoaiCa.Location = new System.Drawing.Point(120, 72);
            this.txtLoaiCa.Name = "txtLoaiCa";
            this.txtLoaiCa.Size = new System.Drawing.Size(307, 36);
            this.txtLoaiCa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại ca";
            // 
            // gcLoaiCa
            // 
            this.gcLoaiCa.Location = new System.Drawing.Point(12, 3);
            this.gcLoaiCa.MainView = this.gvLoaiCa;
            this.gcLoaiCa.MenuManager = this.barManager1;
            this.gcLoaiCa.Name = "gcLoaiCa";
            this.gcLoaiCa.Size = new System.Drawing.Size(1038, 500);
            this.gcLoaiCa.TabIndex = 0;
            this.gcLoaiCa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiCa});
            this.gcLoaiCa.Click += new System.EventHandler(this.gcLoaiCa_Click);
            // 
            // gvLoaiCa
            // 
            this.gvLoaiCa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLoaiCa,
            this.TenLoaiCA});
            this.gvLoaiCa.GridControl = this.gcLoaiCa;
            this.gvLoaiCa.Name = "gvLoaiCa";
            this.gvLoaiCa.Click += new System.EventHandler(this.gvLoaiCa_Click);
            // 
            // MaLoaiCa
            // 
            this.MaLoaiCa.Caption = "Mã loại ca";
            this.MaLoaiCa.FieldName = "MALOAICA";
            this.MaLoaiCa.MinWidth = 30;
            this.MaLoaiCa.Name = "MaLoaiCa";
            this.MaLoaiCa.Visible = true;
            this.MaLoaiCa.VisibleIndex = 0;
            this.MaLoaiCa.Width = 112;
            // 
            // TenLoaiCA
            // 
            this.TenLoaiCA.Caption = "Tên loại ca";
            this.TenLoaiCA.FieldName = "TENLOAICA";
            this.TenLoaiCA.MinWidth = 30;
            this.TenLoaiCA.Name = "TenLoaiCA";
            this.TenLoaiCA.Visible = true;
            this.TenLoaiCA.VisibleIndex = 1;
            this.TenLoaiCA.Width = 112;
            // 
            // btnXoaTruongLoaiCa
            // 
            this.btnXoaTruongLoaiCa.Location = new System.Drawing.Point(445, 82);
            this.btnXoaTruongLoaiCa.Name = "btnXoaTruongLoaiCa";
            this.btnXoaTruongLoaiCa.Size = new System.Drawing.Size(32, 24);
            this.btnXoaTruongLoaiCa.TabIndex = 4;
            this.btnXoaTruongLoaiCa.Text = "X";
            this.btnXoaTruongLoaiCa.UseVisualStyleBackColor = true;
            this.btnXoaTruongLoaiCa.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLoaiCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmLoaiCa";
            this.Text = "frmLoaiCa";
            this.Load += new System.EventHandler(this.frmLoaiCa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThemLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnSuaLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnXoaLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnLuuLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnHuyLoaiCa;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDongLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnInLoaiCa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtLoaiCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraGrid.GridControl gcLoaiCa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiCa;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiCa;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiCA;
        private System.Windows.Forms.Button btnXoaTruongLoaiCa;
    }
}