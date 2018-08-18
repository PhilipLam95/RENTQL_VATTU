using QL_VATTU;

namespace QLYVATTU.VIEW.REPORT_VIEW
{
    partial class ChiTietHangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnTKNhapXuat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTongThu = new System.Windows.Forms.Button();
            this.editDateTo = new DevExpress.XtraEditors.DateEdit();
            this.editDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.btnHangXuat = new System.Windows.Forms.Button();
            this.btnHangNhap = new System.Windows.Forms.Button();
            this.qL_VATTUDataSet = new QL_VATTU.QL_VATTUDataSet();
            this.btnTongChi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.btnTKNhapXuat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTongChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTongThu);
            this.panel1.Controls.Add(this.editDateTo);
            this.panel1.Controls.Add(this.editDateFrom);
            this.panel1.Controls.Add(this.btnHangXuat);
            this.panel1.Controls.Add(this.btnHangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 176);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ten chi Nhanh :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DisplayMember = "MACN";
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(296, 57);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(121, 22);
            this.cbbChiNhanh.TabIndex = 13;
            this.cbbChiNhanh.ValueMember = "MACN";
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cBox_SelectedIndexChanged);
            // 
            // btnTKNhapXuat
            // 
            this.btnTKNhapXuat.Location = new System.Drawing.Point(593, 103);
            this.btnTKNhapXuat.Name = "btnTKNhapXuat";
            this.btnTKNhapXuat.Size = new System.Drawing.Size(75, 55);
            this.btnTKNhapXuat.TabIndex = 12;
            this.btnTKNhapXuat.Text = "Thống kê nhập xuất";
            this.btnTKNhapXuat.UseVisualStyleBackColor = true;
            this.btnTKNhapXuat.Click += new System.EventHandler(this.btnTKNhapXuat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(222, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "THỐNG KÊ NHẬP XUẤT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(58, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(58, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Từ ngày";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // btnTongThu
            // 
            this.btnTongThu.Location = new System.Drawing.Point(470, 138);
            this.btnTongThu.Name = "btnTongThu";
            this.btnTongThu.Size = new System.Drawing.Size(75, 23);
            this.btnTongThu.TabIndex = 7;
            this.btnTongThu.Text = "Tổng thu";
            this.btnTongThu.UseVisualStyleBackColor = true;
            this.btnTongThu.Visible = false;
            this.btnTongThu.Click += new System.EventHandler(this.btnTongThu_Click);
            // 
            // editDateTo
            // 
            this.editDateTo.EditValue = null;
            this.editDateTo.Location = new System.Drawing.Point(134, 141);
            this.editDateTo.Name = "editDateTo";
            this.editDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDateTo.Size = new System.Drawing.Size(100, 20);
            this.editDateTo.TabIndex = 5;
            // 
            // editDateFrom
            // 
            this.editDateFrom.EditValue = null;
            this.editDateFrom.Location = new System.Drawing.Point(135, 92);
            this.editDateFrom.Name = "editDateFrom";
            this.editDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editDateFrom.Size = new System.Drawing.Size(100, 20);
            this.editDateFrom.TabIndex = 4;
            // 
            // btnHangXuat
            // 
            this.btnHangXuat.Location = new System.Drawing.Point(289, 139);
            this.btnHangXuat.Name = "btnHangXuat";
            this.btnHangXuat.Size = new System.Drawing.Size(141, 23);
            this.btnHangXuat.TabIndex = 3;
            this.btnHangXuat.Text = "Thống kê hàng xuất";
            this.btnHangXuat.UseVisualStyleBackColor = true;
            this.btnHangXuat.Click += new System.EventHandler(this.btnHangXuat_Click);
            // 
            // btnHangNhap
            // 
            this.btnHangNhap.Location = new System.Drawing.Point(289, 90);
            this.btnHangNhap.Name = "btnHangNhap";
            this.btnHangNhap.Size = new System.Drawing.Size(141, 23);
            this.btnHangNhap.TabIndex = 2;
            this.btnHangNhap.Text = "Thống kê hàng nhập";
            this.btnHangNhap.UseVisualStyleBackColor = true;
            this.btnHangNhap.Click += new System.EventHandler(this.btnHangNhap_Click);
            // 
            // qL_VATTUDataSet
            // 
            this.qL_VATTUDataSet.DataSetName = "QL_VATTUDataSet";
            this.qL_VATTUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTongChi
            // 
            this.btnTongChi.Location = new System.Drawing.Point(470, 90);
            this.btnTongChi.Name = "btnTongChi";
            this.btnTongChi.Size = new System.Drawing.Size(75, 23);
            this.btnTongChi.TabIndex = 8;
            this.btnTongChi.Text = "Tổng chi";
            this.btnTongChi.UseVisualStyleBackColor = true;
            this.btnTongChi.Visible = false;
            this.btnTongChi.Click += new System.EventHandler(this.btnTongChi_Click);
            // 
            // ChiTietHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 345);
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietHangNhap";
            this.Text = "ChiTietHangNhap";
            this.Load += new System.EventHandler(this.ChiTietHangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHangXuat;
        private System.Windows.Forms.Button btnHangNhap;
        private DevExpress.XtraEditors.DateEdit editDateTo;
        private DevExpress.XtraEditors.DateEdit editDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTongThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTKNhapXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private QL_VATTUDataSet qL_VATTUDataSet;
        private System.Windows.Forms.Button btnTongChi;
    }
}