namespace QUANLY_TTB
{
    partial class FormDanhSach
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
            this.panelM2_DanhSach = new System.Windows.Forms.Panel();
            this.panelSort = new System.Windows.Forms.Panel();
            this.btnPerformSort = new System.Windows.Forms.Button();
            this.cboSortAlgorithm = new System.Windows.Forms.ComboBox();
            this.cboSortCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panelM2_DanhSach.SuspendLayout();
            this.panelSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelM2_DanhSach
            // 
            this.panelM2_DanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelM2_DanhSach.Controls.Add(this.panelSort);
            this.panelM2_DanhSach.Controls.Add(this.lblRecordCount);
            this.panelM2_DanhSach.Controls.Add(this.dgvDanhSach);
            this.panelM2_DanhSach.Controls.Add(this.label6);
            this.panelM2_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelM2_DanhSach.Location = new System.Drawing.Point(0, 0);
            this.panelM2_DanhSach.Name = "panelM2_DanhSach";
            this.panelM2_DanhSach.Size = new System.Drawing.Size(800, 548);
            this.panelM2_DanhSach.TabIndex = 1;
            // 
            // panelSort
            // 
            this.panelSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSort.Controls.Add(this.btnPerformSort);
            this.panelSort.Controls.Add(this.cboSortAlgorithm);
            this.panelSort.Controls.Add(this.cboSortCriteria);
            this.panelSort.Controls.Add(this.label1);
            this.panelSort.Location = new System.Drawing.Point(240, 7);
            this.panelSort.Name = "panelSort";
            this.panelSort.Size = new System.Drawing.Size(460, 38);
            this.panelSort.TabIndex = 3;
            // 
            // btnPerformSort
            // 
            this.btnPerformSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnPerformSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformSort.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnPerformSort.ForeColor = System.Drawing.Color.White;
            this.btnPerformSort.Location = new System.Drawing.Point(375, 4);
            this.btnPerformSort.Name = "btnPerformSort";
            this.btnPerformSort.Size = new System.Drawing.Size(80, 28);
            this.btnPerformSort.TabIndex = 3;
            this.btnPerformSort.Text = "Sắp xếp";
            this.btnPerformSort.UseVisualStyleBackColor = false;
            this.btnPerformSort.Click += new System.EventHandler(this.btnPerformSort_Click);
            // 
            // cboSortAlgorithm
            // 
            this.cboSortAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortAlgorithm.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cboSortAlgorithm.FormattingEnabled = true;
            this.cboSortAlgorithm.Items.AddRange(new object[] {
            "Sắp xếp Chọn",
            "Sắp xếp Chèn",
            "Sắp xếp Nổi bọt",
            "Sắp xếp Nhanh"});
            this.cboSortAlgorithm.Location = new System.Drawing.Point(220, 5);
            this.cboSortAlgorithm.Name = "cboSortAlgorithm";
            this.cboSortAlgorithm.Size = new System.Drawing.Size(150, 27);
            this.cboSortAlgorithm.TabIndex = 2;
            // 
            // cboSortCriteria
            // 
            this.cboSortCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortCriteria.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cboSortCriteria.FormattingEnabled = true;
            this.cboSortCriteria.Items.AddRange(new object[] {
            "Theo Mã TTB",
            "Theo Tên",
            "Theo Số lượng",
            "Theo Chung Loại"});
            this.cboSortCriteria.Location = new System.Drawing.Point(80, 5);
            this.cboSortCriteria.Name = "cboSortCriteria";
            this.cboSortCriteria.Size = new System.Drawing.Size(130, 27);
            this.cboSortCriteria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.lblRecordCount.Location = new System.Drawing.Point(720, 18);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(71, 20);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "0 bản ghi";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.ColumnHeadersHeight = 35;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMa,
            this.colTen,
            this.colLoai,
            this.colSL,
            this.colCap,
            this.colNgaySD,
            this.colGhiChu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDanhSach.Location = new System.Drawing.Point(16, 50);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 30;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(768, 480);
            this.dgvDanhSach.TabIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 40F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã TTB";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.FillWeight = 150F;
            this.colTen.HeaderText = "Tên trang thiết bị";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Chủng loại";
            this.colLoai.MinimumWidth = 6;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.FillWeight = 60F;
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colCap
            // 
            this.colCap.FillWeight = 50F;
            this.colCap.HeaderText = "Cấp";
            this.colCap.MinimumWidth = 6;
            this.colCap.Name = "colCap";
            this.colCap.ReadOnly = true;
            // 
            // colNgaySD
            // 
            this.colNgaySD.HeaderText = "Ngày SD";
            this.colNgaySD.MinimumWidth = 6;
            this.colNgaySD.Name = "colNgaySD";
            this.colNgaySD.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(16, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách thiết bị";
            // 
            // FormDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panelM2_DanhSach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSach";
            this.Text = "Danh sách trang thiết bị";
            this.panelM2_DanhSach.ResumeLayout(false);
            this.panelM2_DanhSach.PerformLayout();
            this.panelSort.ResumeLayout(false);
            this.panelSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelM2_DanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.Button btnPerformSort;
        private System.Windows.Forms.ComboBox cboSortCriteria;
        private System.Windows.Forms.ComboBox cboSortAlgorithm;
        private System.Windows.Forms.Label label1;
    }
}
