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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelM2_DanhSach = new System.Windows.Forms.Panel();
            this.btnThungRac = new System.Windows.Forms.Button();
            this.btnBaoDuong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelSort = new System.Windows.Forms.Panel();
            this.btnPerformSort = new System.Windows.Forms.Button();
            this.cboSortAlgorithm = new System.Windows.Forms.ComboBox();
            this.cboSortCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguonCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBDTiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panelM2_DanhSach.SuspendLayout();
            this.panelSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panelM2_DanhSach
            // 
            this.panelM2_DanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelM2_DanhSach.Controls.Add(this.btnThungRac);
            this.panelM2_DanhSach.Controls.Add(this.btnBaoDuong);
            this.panelM2_DanhSach.Controls.Add(this.btnSua);
            this.panelM2_DanhSach.Controls.Add(this.btnXoa);
            this.panelM2_DanhSach.Controls.Add(this.panelSort);
            this.panelM2_DanhSach.Controls.Add(this.lblRecordCount);
            this.panelM2_DanhSach.Controls.Add(this.dgvDanhSach);
            this.panelM2_DanhSach.Controls.Add(this.label6);
            this.panelM2_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelM2_DanhSach.Location = new System.Drawing.Point(0, 0);
            this.panelM2_DanhSach.Name = "panelM2_DanhSach";
            this.panelM2_DanhSach.Size = new System.Drawing.Size(800, 548);
            this.panelM2_DanhSach.TabIndex = 1;
            // this.panelM2_DanhSach.Paint += new System.Windows.Forms.PaintEventHandler(this.panelM2_DanhSach_Paint_2);
            // 
            // btnThungRac
            // 
            this.btnThungRac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThungRac.BackColor = System.Drawing.Color.DimGray;
            this.btnThungRac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThungRac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThungRac.ForeColor = System.Drawing.Color.White;
            this.btnThungRac.Location = new System.Drawing.Point(12, 510);
            this.btnThungRac.Name = "btnThungRac";
            this.btnThungRac.Size = new System.Drawing.Size(128, 30);
            this.btnThungRac.TabIndex = 6;
            this.btnThungRac.Text = "🗑 Thùng rác";
            this.btnThungRac.UseVisualStyleBackColor = false;
            this.btnThungRac.Click += new System.EventHandler(this.btnThungRac_Click);
            // 
            // btnBaoDuong
            // 
            this.btnBaoDuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaoDuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnBaoDuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoDuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaoDuong.ForeColor = System.Drawing.Color.White;
            this.btnBaoDuong.Location = new System.Drawing.Point(395, 510);
            this.btnBaoDuong.Name = "btnBaoDuong";
            this.btnBaoDuong.Size = new System.Drawing.Size(128, 30);
            this.btnBaoDuong.TabIndex = 6;
            this.btnBaoDuong.Text = "🔧 Bảo dưỡng";
            this.btnBaoDuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoDuong.UseVisualStyleBackColor = false;
            this.btnBaoDuong.Click += new System.EventHandler(this.btnBaoDuong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(529, 510);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 30);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "✏ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(663, 510);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnPerformSort.Size = new System.Drawing.Size(85, 28);
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
            "Sắp xếp Nhanh",
            "Sắp xếp Trộn"});
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
            "Theo Chủng Loại",
            "Theo cấp"});
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSach.ColumnHeadersHeight = 35;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMa,
            this.colSoHieu,
            this.colTen,
            this.colLoai,
            this.colNguonCap,
            this.colSL,
            this.colCap,
            this.colNgaySX,
            this.colNgaySD,
            this.colGhiChu,
            this.colNgayBDTiep,
            this.colTinhTrang});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSach.EnableHeadersVisualStyles = false;
            this.dgvDanhSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDanhSach.Location = new System.Drawing.Point(16, 50);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 30;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(768, 450);
            this.dgvDanhSach.TabIndex = 1;
            // this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
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
            // colSoHieu
            // 
            this.colSoHieu.HeaderText = "Số hiệu";
            this.colSoHieu.MinimumWidth = 6;
            this.colSoHieu.Name = "colSoHieu";
            this.colSoHieu.ReadOnly = true;
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
            // colNguonCap
            // 
            this.colNguonCap.HeaderText = "Nguồn cấp";
            this.colNguonCap.MinimumWidth = 6;
            this.colNguonCap.Name = "colNguonCap";
            this.colNguonCap.ReadOnly = true;
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
            // colNgaySX
            // 
            this.colNgaySX.HeaderText = "Ngày SX";
            this.colNgaySX.MinimumWidth = 6;
            this.colNgaySX.Name = "colNgaySX";
            this.colNgaySX.ReadOnly = true;
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
            // colNgayBDTiep
            // 
            this.colNgayBDTiep.HeaderText = "Ngày BD Tiếp";
            this.colNgayBDTiep.MinimumWidth = 6;
            this.colNgayBDTiep.Name = "colNgayBDTiep";
            this.colNgayBDTiep.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.MinimumWidth = 6;
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguonCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBDTiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.Panel panelSort;
        private System.Windows.Forms.Button btnPerformSort;
        private System.Windows.Forms.ComboBox cboSortCriteria;
        private System.Windows.Forms.ComboBox cboSortAlgorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBaoDuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThungRac;
    }
}
