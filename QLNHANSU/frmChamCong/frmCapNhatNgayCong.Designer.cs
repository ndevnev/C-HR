namespace QLNHANSU.frmChamCong
{
    partial class frmCapNhatNgayCong
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cldNgayCong = new System.Windows.Forms.MonthCalendar();
            this.grpChamCong = new DevExpress.XtraEditors.GroupControl();
            this.rdgChamCong = new DevExpress.XtraEditors.RadioGroup();
            this.grpTGNghi = new DevExpress.XtraEditors.GroupControl();
            this.rdgNgayNghi = new DevExpress.XtraEditors.RadioGroup();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin = new DevExpress.XtraEditors.GroupControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpChamCong)).BeginInit();
            this.grpChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTGNghi)).BeginInit();
            this.grpTGNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdgNgayNghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(378, 328);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 59);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cldNgayCong
            // 
            this.cldNgayCong.Location = new System.Drawing.Point(18, 18);
            this.cldNgayCong.Name = "cldNgayCong";
            this.cldNgayCong.TabIndex = 1;
            this.cldNgayCong.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldNgayCong_DateChanged);
            this.cldNgayCong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldNgayCong_DateSelected_1);
            // 
            // grpChamCong
            // 
            this.grpChamCong.Controls.Add(this.rdgChamCong);
            this.grpChamCong.Location = new System.Drawing.Point(373, 18);
            this.grpChamCong.Name = "grpChamCong";
            this.grpChamCong.Size = new System.Drawing.Size(260, 150);
            this.grpChamCong.TabIndex = 2;
            this.grpChamCong.Text = "Chấm công";
            // 
            // rdgChamCong
            // 
            this.rdgChamCong.EditValue = "P";
            this.rdgChamCong.Location = new System.Drawing.Point(5, 37);
            this.rdgChamCong.Name = "rdgChamCong";
            this.rdgChamCong.Properties.Columns = 2;
            this.rdgChamCong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("VR", "Việc riêng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công tác")});
            this.rdgChamCong.Size = new System.Drawing.Size(250, 108);
            this.rdgChamCong.TabIndex = 0;
            // 
            // grpTGNghi
            // 
            this.grpTGNghi.Controls.Add(this.rdgNgayNghi);
            this.grpTGNghi.Location = new System.Drawing.Point(373, 174);
            this.grpTGNghi.Name = "grpTGNghi";
            this.grpTGNghi.Size = new System.Drawing.Size(260, 148);
            this.grpTGNghi.TabIndex = 3;
            this.grpTGNghi.Text = "Thời gian nghỉ";
            // 
            // rdgNgayNghi
            // 
            this.rdgNgayNghi.EditValue = "CN";
            this.rdgNgayNghi.Location = new System.Drawing.Point(5, 37);
            this.rdgNgayNghi.Name = "rdgNgayNghi";
            this.rdgNgayNghi.Properties.Columns = 2;
            this.rdgNgayNghi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CN", "Cả ngày")});
            this.rdgNgayNghi.Size = new System.Drawing.Size(250, 106);
            this.rdgNgayNghi.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(537, 333);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 59);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.lblID);
            this.grpThongTin.Location = new System.Drawing.Point(18, 283);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(297, 113);
            this.grpThongTin.TabIndex = 6;
            this.grpThongTin.Text = "Thông tin";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(6, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 19);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên\r\n";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(6, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID: ";
            // 
            // frmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 408);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpTGNghi);
            this.Controls.Add(this.grpChamCong);
            this.Controls.Add(this.cldNgayCong);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "frmCapNhatNgayCong";
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.frmCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpChamCong)).EndInit();
            this.grpChamCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgChamCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTGNghi)).EndInit();
            this.grpTGNghi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdgNgayNghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTin)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.MonthCalendar cldNgayCong;
        private DevExpress.XtraEditors.GroupControl grpChamCong;
        private DevExpress.XtraEditors.RadioGroup rdgChamCong;
        private DevExpress.XtraEditors.GroupControl grpTGNghi;
        private DevExpress.XtraEditors.RadioGroup rdgNgayNghi;
        private System.Windows.Forms.Button btnDong;
        private DevExpress.XtraEditors.GroupControl grpThongTin;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.LabelControl lblID;
    }
}