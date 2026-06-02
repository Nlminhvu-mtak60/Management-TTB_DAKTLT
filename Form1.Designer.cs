namespace QUANLY_TTB
{
    partial class Form1
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
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnT_Thoat = new System.Windows.Forms.Button();
            this.btnT_ThongKe = new System.Windows.Forms.Button();
            this.btnT_TimKiem = new System.Windows.Forms.Button();
            this.btnT_DanhSach = new System.Windows.Forms.Button();
            this.btnT_ThemMoi = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelToolbar.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelToolbar.Controls.Add(this.btnT_Thoat);
            this.panelToolbar.Controls.Add(this.btnT_ThongKe);
            this.panelToolbar.Controls.Add(this.btnT_TimKiem);
            this.panelToolbar.Controls.Add(this.btnT_DanhSach);
            this.panelToolbar.Controls.Add(this.btnT_ThemMoi);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 28);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(950, 50);
            this.panelToolbar.TabIndex = 1;
            // 
            // btnT_Thoat
            // 
            this.btnT_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnT_Thoat.BackColor = System.Drawing.Color.Brown;
            this.btnT_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnT_Thoat.ForeColor = System.Drawing.Color.White;
            this.btnT_Thoat.Location = new System.Drawing.Point(840, 8);
            this.btnT_Thoat.Name = "btnT_Thoat";
            this.btnT_Thoat.Size = new System.Drawing.Size(100, 34);
            this.btnT_Thoat.TabIndex = 5;
            this.btnT_Thoat.Text = "🚪Thoát";
            this.btnT_Thoat.UseVisualStyleBackColor = false;
            this.btnT_Thoat.Click += new System.EventHandler(this.btnNav_Thoat_Click);
            // 
            // btnT_ThongKe
            // 
            this.btnT_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnT_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT_ThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnT_ThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.btnT_ThongKe.Location = new System.Drawing.Point(363, 8);
            this.btnT_ThongKe.Name = "btnT_ThongKe";
            this.btnT_ThongKe.Size = new System.Drawing.Size(111, 34);
            this.btnT_ThongKe.TabIndex = 4;
            this.btnT_ThongKe.Text = "📊Thống kê";
            this.btnT_ThongKe.UseVisualStyleBackColor = false;
            this.btnT_ThongKe.Click += new System.EventHandler(this.btnNav_ThongKe_Click);
            // 
            // btnT_TimKiem
            // 
            this.btnT_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnT_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnT_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.btnT_TimKiem.Location = new System.Drawing.Point(246, 8);
            this.btnT_TimKiem.Name = "btnT_TimKiem";
            this.btnT_TimKiem.Size = new System.Drawing.Size(111, 34);
            this.btnT_TimKiem.TabIndex = 3;
            this.btnT_TimKiem.Text = "🔍Tìm kiếm";
            this.btnT_TimKiem.UseVisualStyleBackColor = false;
            this.btnT_TimKiem.Click += new System.EventHandler(this.btnNav_TimKiem_Click);
            // 
            // btnT_DanhSach
            // 
            this.btnT_DanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnT_DanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT_DanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnT_DanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.btnT_DanhSach.Location = new System.Drawing.Point(129, 8);
            this.btnT_DanhSach.Name = "btnT_DanhSach";
            this.btnT_DanhSach.Size = new System.Drawing.Size(111, 34);
            this.btnT_DanhSach.TabIndex = 1;
            this.btnT_DanhSach.Text = "📋Danh sách";
            this.btnT_DanhSach.UseVisualStyleBackColor = false;
            this.btnT_DanhSach.Click += new System.EventHandler(this.btnNav_DanhSach_Click);
            // 
            // btnT_ThemMoi
            // 
            this.btnT_ThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.btnT_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT_ThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnT_ThemMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.btnT_ThemMoi.Location = new System.Drawing.Point(12, 8);
            this.btnT_ThemMoi.Name = "btnT_ThemMoi";
            this.btnT_ThemMoi.Size = new System.Drawing.Size(111, 34);
            this.btnT_ThemMoi.TabIndex = 0;
            this.btnT_ThemMoi.Text = "➕Thêm mới";
            this.btnT_ThemMoi.UseVisualStyleBackColor = false;
            this.btnT_ThemMoi.Click += new System.EventHandler(this.btnNav_ThemMoi_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelStatus.Controls.Add(this.lblStatusRight);
            this.panelStatus.Controls.Add(this.lblStatusLeft);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 613);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(950, 25);
            this.panelStatus.TabIndex = 3;
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.lblStatusRight.Location = new System.Drawing.Point(818, 2);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(129, 20);
            this.lblStatusRight.TabIndex = 1;
            this.lblStatusRight.Text = "QUẢN LÝ THIẾT BỊ";
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.lblStatusLeft.Location = new System.Drawing.Point(10, 2);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(141, 20);
            this.lblStatusLeft.TabIndex = 0;
            this.lblStatusLeft.Text = "Hệ thống sẵn sàng...";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 78);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(950, 535);
            this.panelMain.TabIndex = 4;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(950, 28);
            this.panelTitleBar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(950, 638);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Trang Thiết Bị";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelToolbar.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Button btnT_Thoat;
        private System.Windows.Forms.Button btnT_ThongKe;
        private System.Windows.Forms.Button btnT_TimKiem;
        private System.Windows.Forms.Button btnT_DanhSach;
        private System.Windows.Forms.Button btnT_ThemMoi;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatusRight;
        private System.Windows.Forms.Label lblStatusLeft;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}
