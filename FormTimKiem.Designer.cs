namespace QUANLY_TTB
{
    partial class FormTimKiem
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
            this.panelM4_TimKiem = new System.Windows.Forms.Panel();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchMessage = new System.Windows.Forms.Label();
            this.btnXoaTim = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchKey = new System.Windows.Forms.ComboBox();
            this.rbTuanTu = new System.Windows.Forms.RadioButton();
            this.rbNhiPhan = new System.Windows.Forms.RadioButton();
            this.lblThuatToan = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelM4_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelM4_TimKiem
            // 
            this.panelM4_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelM4_TimKiem.Controls.Add(this.dgvTimKiem);
            this.panelM4_TimKiem.Controls.Add(this.lblSearchMessage);
            this.panelM4_TimKiem.Controls.Add(this.btnXoaTim);
            this.panelM4_TimKiem.Controls.Add(this.btnTim);
            this.panelM4_TimKiem.Controls.Add(this.txtSearch);
            this.panelM4_TimKiem.Controls.Add(this.cboSearchKey);
            this.panelM4_TimKiem.Controls.Add(this.rbTuanTu);
            this.panelM4_TimKiem.Controls.Add(this.rbNhiPhan);
            this.panelM4_TimKiem.Controls.Add(this.lblThuatToan);
            this.panelM4_TimKiem.Controls.Add(this.label16);
            this.panelM4_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelM4_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.panelM4_TimKiem.Name = "panelM4_TimKiem";
            this.panelM4_TimKiem.Size = new System.Drawing.Size(800, 548);
            this.panelM4_TimKiem.TabIndex = 1;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AllowUserToAddRows = false;
            this.dgvTimKiem.AllowUserToDeleteRows = false;
            this.dgvTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvTimKiem.Location = new System.Drawing.Point(16, 148);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            this.dgvTimKiem.RowHeadersVisible = false;
            this.dgvTimKiem.RowHeadersWidth = 51;
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiem.Size = new System.Drawing.Size(768, 410);
            this.dgvTimKiem.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã TTB";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên trang thiết bị";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Chủng loại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cấp";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngày BD Tiếp";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tình Trạng";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // lblSearchMessage
            // 
            this.lblSearchMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.lblSearchMessage.Location = new System.Drawing.Point(16, 118);
            this.lblSearchMessage.Name = "lblSearchMessage";
            this.lblSearchMessage.Size = new System.Drawing.Size(768, 24);
            this.lblSearchMessage.TabIndex = 6;
            this.lblSearchMessage.Text = "Nhập từ khóa và nhấn Tìm";
            // 
            // btnXoaTim
            // 
            this.btnXoaTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnXoaTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.btnXoaTim.Location = new System.Drawing.Point(680, 50);
            this.btnXoaTim.Name = "btnXoaTim";
            this.btnXoaTim.Size = new System.Drawing.Size(100, 28);
            this.btnXoaTim.TabIndex = 5;
            this.btnXoaTim.Text = "Xóa tìm";
            this.btnXoaTim.UseVisualStyleBackColor = false;
            this.btnXoaTim.Click += new System.EventHandler(this.btnXoaTim_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(570, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(220, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // cboSearchKey
            // 
            this.cboSearchKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchKey.FormattingEnabled = true;
            this.cboSearchKey.Items.AddRange(new object[] {
            "Mã TTB",
            "Tên",
            "Chủng loại",
            "Nguồn cấp"});
            this.cboSearchKey.Location = new System.Drawing.Point(20, 51);
            this.cboSearchKey.Name = "cboSearchKey";
            this.cboSearchKey.Size = new System.Drawing.Size(190, 28);
            this.cboSearchKey.TabIndex = 1;


            // 
            // lblThuatToan
            // 
            this.lblThuatToan.AutoSize = true;
            this.lblThuatToan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblThuatToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.lblThuatToan.Location = new System.Drawing.Point(16, 90);
            this.lblThuatToan.Name = "lblThuatToan";
            this.lblThuatToan.Size = new System.Drawing.Size(100, 20);
            this.lblThuatToan.TabIndex = 10;
            this.lblThuatToan.Text = "Thuật toán tìm:";
            // 
            // rbTuanTu
            // 
            this.rbTuanTu.AutoSize = true;
            this.rbTuanTu.Checked = true;
            this.rbTuanTu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbTuanTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.rbTuanTu.Location = new System.Drawing.Point(130, 88);
            this.rbTuanTu.Name = "rbTuanTu";
            this.rbTuanTu.Size = new System.Drawing.Size(130, 24);
            this.rbTuanTu.TabIndex = 8;
            this.rbTuanTu.TabStop = true;
            this.rbTuanTu.Text = "Tìm tuần tự";
            this.rbTuanTu.UseVisualStyleBackColor = true;
            // 
            // rbNhiPhan
            // 
            this.rbNhiPhan.AutoSize = true;
            this.rbNhiPhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbNhiPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.rbNhiPhan.Location = new System.Drawing.Point(280, 88);
            this.rbNhiPhan.Name = "rbNhiPhan";
            this.rbNhiPhan.Size = new System.Drawing.Size(130, 24);
            this.rbNhiPhan.TabIndex = 9;
            this.rbNhiPhan.Text = "Tìm nhị phân";
            this.rbNhiPhan.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.label16.Location = new System.Drawing.Point(16, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tìm kiếm thông tin";
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panelM4_TimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTimKiem";
            this.Text = "Tìm kiếm trang thiết bị";
            this.panelM4_TimKiem.ResumeLayout(false);
            this.panelM4_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelM4_TimKiem;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label lblSearchMessage;
        private System.Windows.Forms.Button btnXoaTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearchKey;
        private System.Windows.Forms.RadioButton rbTuanTu;
        private System.Windows.Forms.RadioButton rbNhiPhan;
        private System.Windows.Forms.Label lblThuatToan;
        private System.Windows.Forms.Label label16;
    }
}
