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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.grpChamCong = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.grpThoiGianNghi = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnDiLam = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpChamCong)).BeginInit();
            this.grpChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThoiGianNghi)).BeginInit();
            this.grpThoiGianNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(18, 305);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(168, 59);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // grpChamCong
            // 
            this.grpChamCong.Controls.Add(this.radioGroup1);
            this.grpChamCong.Location = new System.Drawing.Point(373, 18);
            this.grpChamCong.Name = "grpChamCong";
            this.grpChamCong.Size = new System.Drawing.Size(260, 150);
            this.grpChamCong.TabIndex = 2;
            this.grpChamCong.Text = "Chấm công";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = "P";
            this.radioGroup1.Location = new System.Drawing.Point(5, 37);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("VR", "Việc riêng")});
            this.radioGroup1.Size = new System.Drawing.Size(250, 108);
            this.radioGroup1.TabIndex = 0;
            // 
            // grpThoiGianNghi
            // 
            this.grpThoiGianNghi.Controls.Add(this.radioGroup2);
            this.grpThoiGianNghi.Location = new System.Drawing.Point(373, 174);
            this.grpThoiGianNghi.Name = "grpThoiGianNghi";
            this.grpThoiGianNghi.Size = new System.Drawing.Size(260, 148);
            this.grpThoiGianNghi.TabIndex = 3;
            this.grpThoiGianNghi.Text = "Thời gian nghỉ";
            // 
            // radioGroup2
            // 
            this.radioGroup2.EditValue = "CN";
            this.radioGroup2.Location = new System.Drawing.Point(5, 37);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Columns = 2;
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CN", "Cả ngày")});
            this.radioGroup2.Size = new System.Drawing.Size(250, 106);
            this.radioGroup2.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(199, 305);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(168, 59);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDiLam
            // 
            this.btnDiLam.Location = new System.Drawing.Point(486, 328);
            this.btnDiLam.Name = "btnDiLam";
            this.btnDiLam.Size = new System.Drawing.Size(147, 56);
            this.btnDiLam.TabIndex = 5;
            this.btnDiLam.Text = "Đi làm";
            this.btnDiLam.Click += new System.EventHandler(this.btnDiLam_Click);
            // 
            // frmCapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 396);
            this.Controls.Add(this.btnDiLam);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grpThoiGianNghi);
            this.Controls.Add(this.grpChamCong);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnCapNhat);
            this.Name = "frmCapNhatNgayCong";
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.frmCapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpChamCong)).EndInit();
            this.grpChamCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThoiGianNghi)).EndInit();
            this.grpThoiGianNghi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.GroupControl grpChamCong;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.GroupControl grpThoiGianNghi;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private System.Windows.Forms.Button btnDong;
        private DevExpress.XtraEditors.SimpleButton btnDiLam;
    }
}