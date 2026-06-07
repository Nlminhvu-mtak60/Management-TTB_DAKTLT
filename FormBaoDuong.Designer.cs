namespace QUANLY_TTB
{
    partial class FormBaoDuong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMaTTB = new System.Windows.Forms.Label();
            this.lblTenTTB = new System.Windows.Forms.Label();
            this.lblTinhTrangCu = new System.Windows.Forms.Label();
            this.dtpNgayBDMoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBDTiep = new System.Windows.Forms.DateTimePicker();
            this.numChuKyMoi = new System.Windows.Forms.NumericUpDown();
            this.cboTinhTrangMoi = new System.Windows.Forms.ComboBox();
            this.txtGhiChuBD = new System.Windows.Forms.TextBox();
            this.txtLichSu = new System.Windows.Forms.TextBox();
            this.btnLuuBD = new System.Windows.Forms.Button();
            this.btnHuyBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numChuKyMoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaTTB
            // 
            this.lblMaTTB.AutoSize = true;
            this.lblMaTTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaTTB.Location = new System.Drawing.Point(15, 30);
            this.lblMaTTB.Name = "lblMaTTB";
            this.lblMaTTB.Size = new System.Drawing.Size(65, 20);
            this.lblMaTTB.TabIndex = 0;
            this.lblMaTTB.Text = "Mã TTB:";
            // 
            // lblTenTTB
            // 
            this.lblTenTTB.AutoSize = true;
            this.lblTenTTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenTTB.Location = new System.Drawing.Point(15, 60);
            this.lblTenTTB.Name = "lblTenTTB";
            this.lblTenTTB.Size = new System.Drawing.Size(68, 20);
            this.lblTenTTB.TabIndex = 1;
            this.lblTenTTB.Text = "Tên TTB:";
            // 
            // lblTinhTrangCu
            // 
            this.lblTinhTrangCu.AutoSize = true;
            this.lblTinhTrangCu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTinhTrangCu.Location = new System.Drawing.Point(15, 90);
            this.lblTinhTrangCu.Name = "lblTinhTrangCu";
            this.lblTinhTrangCu.Size = new System.Drawing.Size(143, 20);
            this.lblTinhTrangCu.TabIndex = 2;
            this.lblTinhTrangCu.Text = "Tình trạng hiện tại:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaTTB);
            this.groupBox1.Controls.Add(this.lblTenTTB);
            this.groupBox1.Controls.Add(this.lblTinhTrangCu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bảo dưỡng vừa thực hiện";
            // 
            // dtpNgayBDMoi
            // 
            this.dtpNgayBDMoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBDMoi.Location = new System.Drawing.Point(235, 25);
            this.dtpNgayBDMoi.Name = "dtpNgayBDMoi";
            this.dtpNgayBDMoi.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayBDMoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bảo dưỡng tiếp theo";
            // 
            // dtpNgayBDTiep
            // 
            this.dtpNgayBDTiep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBDTiep.Location = new System.Drawing.Point(235, 65);
            this.dtpNgayBDTiep.Name = "dtpNgayBDTiep";
            this.dtpNgayBDTiep.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayBDTiep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chu kỳ bảo dưỡng (tháng)";
            // 
            // numChuKyMoi
            // 
            this.numChuKyMoi.Location = new System.Drawing.Point(235, 105);
            this.numChuKyMoi.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numChuKyMoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numChuKyMoi.Name = "numChuKyMoi";
            this.numChuKyMoi.Size = new System.Drawing.Size(200, 27);
            this.numChuKyMoi.TabIndex = 5;
            this.numChuKyMoi.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tình trạng mới";
            // 
            // cboTinhTrangMoi
            // 
            this.cboTinhTrangMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrangMoi.FormattingEnabled = true;
            this.cboTinhTrangMoi.Items.AddRange(new object[] {
            "Tốt",
            "Cần bảo dưỡng",
            "Quá hạn bảo dưỡng",
            "Đang sửa chữa",
            "Thanh lý"});
            this.cboTinhTrangMoi.Location = new System.Drawing.Point(235, 145);
            this.cboTinhTrangMoi.Name = "cboTinhTrangMoi";
            this.cboTinhTrangMoi.Size = new System.Drawing.Size(200, 28);
            this.cboTinhTrangMoi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghi chú lần bảo dưỡng này";
            // 
            // txtGhiChuBD
            // 
            this.txtGhiChuBD.Location = new System.Drawing.Point(19, 213);
            this.txtGhiChuBD.Multiline = true;
            this.txtGhiChuBD.Name = "txtGhiChuBD";
            this.txtGhiChuBD.Size = new System.Drawing.Size(416, 60);
            this.txtGhiChuBD.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpNgayBDMoi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpNgayBDTiep);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numChuKyMoi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboTinhTrangMoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGhiChuBD);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật bảo dưỡng mới";
            // 
            // txtLichSu
            // 
            this.txtLichSu.Location = new System.Drawing.Point(19, 26);
            this.txtLichSu.Multiline = true;
            this.txtLichSu.Name = "txtLichSu";
            this.txtLichSu.ReadOnly = true;
            this.txtLichSu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLichSu.Size = new System.Drawing.Size(416, 100);
            this.txtLichSu.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLichSu);
            this.groupBox3.Location = new System.Drawing.Point(12, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lịch sử bảo dưỡng";
            // 
            // btnLuuBD
            // 
            this.btnLuuBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnLuuBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuBD.ForeColor = System.Drawing.Color.White;
            this.btnLuuBD.Location = new System.Drawing.Point(226, 600);
            this.btnLuuBD.Name = "btnLuuBD";
            this.btnLuuBD.Size = new System.Drawing.Size(140, 35);
            this.btnLuuBD.TabIndex = 3;
            this.btnLuuBD.Text = "💾 Lưu cập nhật";
            this.btnLuuBD.UseVisualStyleBackColor = false;
            this.btnLuuBD.Click += new System.EventHandler(this.btnLuuBD_Click);
            // 
            // btnHuyBD
            // 
            this.btnHuyBD.BackColor = System.Drawing.Color.Silver;
            this.btnHuyBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyBD.ForeColor = System.Drawing.Color.Black;
            this.btnHuyBD.Location = new System.Drawing.Point(372, 600);
            this.btnHuyBD.Name = "btnHuyBD";
            this.btnHuyBD.Size = new System.Drawing.Size(100, 35);
            this.btnHuyBD.TabIndex = 4;
            this.btnHuyBD.Text = "Hủy";
            this.btnHuyBD.UseVisualStyleBackColor = false;
            this.btnHuyBD.Click += new System.EventHandler(this.btnHuyBD_Click);
            // 
            // FormBaoDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(484, 647);
            this.Controls.Add(this.btnHuyBD);
            this.Controls.Add(this.btnLuuBD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBaoDuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật bảo dưỡng";
            ((System.ComponentModel.ISupportInitialize)(this.numChuKyMoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaTTB;
        private System.Windows.Forms.Label lblTenTTB;
        private System.Windows.Forms.Label lblTinhTrangCu;
        private System.Windows.Forms.DateTimePicker dtpNgayBDMoi;
        private System.Windows.Forms.DateTimePicker dtpNgayBDTiep;
        private System.Windows.Forms.NumericUpDown numChuKyMoi;
        private System.Windows.Forms.ComboBox cboTinhTrangMoi;
        private System.Windows.Forms.TextBox txtGhiChuBD;
        private System.Windows.Forms.TextBox txtLichSu;
        private System.Windows.Forms.Button btnLuuBD;
        private System.Windows.Forms.Button btnHuyBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
