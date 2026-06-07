namespace QUANLY_TTB
{
    partial class FormThungRac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThungRac = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnXoaVinhVien = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThungRac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThungRac
            // 
            this.dgvThungRac.AllowUserToAddRows = false;
            this.dgvThungRac.AllowUserToDeleteRows = false;
            this.dgvThungRac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThungRac.BackgroundColor = System.Drawing.Color.White;
            this.dgvThungRac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThungRac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThungRac.EnableHeadersVisualStyles = false;
            
            this.dgvThungRac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThungRac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThungRac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMa,
            this.colTen,
            this.colLoai,
            this.colGhiChu,
            this.colTinhTrang});
            this.dgvThungRac.Location = new System.Drawing.Point(12, 53);
            this.dgvThungRac.MultiSelect = false;
            this.dgvThungRac.Name = "dgvThungRac";
            this.dgvThungRac.ReadOnly = true;
            this.dgvThungRac.RowHeadersVisible = false;
            
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThungRac.DefaultCellStyle = dataGridViewCellStyle2;
            
            this.dgvThungRac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThungRac.Size = new System.Drawing.Size(776, 350);
            this.dgvThungRac.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 40;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã TTB";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên TTB";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 150;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Chủng loại";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(516, 409);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(128, 30);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnXoaVinhVien
            // 
            this.btnXoaVinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaVinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaVinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaVinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaVinhVien.ForeColor = System.Drawing.Color.White;
            this.btnXoaVinhVien.Location = new System.Drawing.Point(660, 409);
            this.btnXoaVinhVien.Name = "btnXoaVinhVien";
            this.btnXoaVinhVien.Size = new System.Drawing.Size(128, 30);
            this.btnXoaVinhVien.TabIndex = 2;
            this.btnXoaVinhVien.Text = "Xóa vĩnh viễn";
            this.btnXoaVinhVien.UseVisualStyleBackColor = false;
            this.btnXoaVinhVien.Click += new System.EventHandler(this.btnXoaVinhVien_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(12, 417);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(126, 15);
            this.lblRecordCount.TabIndex = 3;
            this.lblRecordCount.Text = "0 thiết bị trong thùng rác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thùng Rác";
            // 
            // FormThungRac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnXoaVinhVien);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dgvThungRac);
            this.Name = "FormThungRac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thùng Rác";
            this.Load += new System.EventHandler(this.FormThungRac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThungRac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThungRac;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnXoaVinhVien;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
    }
}
