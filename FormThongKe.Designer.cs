namespace QUANLY_TTB
{
    partial class FormThongKe
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
            this.panelM5_ThongKe = new System.Windows.Forms.Panel();
            this.tabControlThongKe = new System.Windows.Forms.TabControl();
            this.tabPageLoai = new System.Windows.Forms.TabPage();
            this.panelChartLoai = new System.Windows.Forms.Panel();
            this.tabPageCap = new System.Windows.Forms.TabPage();
            this.panelChartCap = new System.Windows.Forms.Panel();
            this.lblStatRecords = new System.Windows.Forms.Label();
            this.lblStatTypes = new System.Windows.Forms.Label();
            this.lblStatTotal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panelM5_ThongKe.SuspendLayout();
            this.tabControlThongKe.SuspendLayout();
            this.tabPageLoai.SuspendLayout();
            this.tabPageCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelM5_ThongKe
            // 
            this.panelM5_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelM5_ThongKe.Controls.Add(this.tabControlThongKe);
            this.panelM5_ThongKe.Controls.Add(this.lblStatRecords);
            this.panelM5_ThongKe.Controls.Add(this.lblStatTypes);
            this.panelM5_ThongKe.Controls.Add(this.lblStatTotal);
            this.panelM5_ThongKe.Controls.Add(this.label21);
            this.panelM5_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelM5_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.panelM5_ThongKe.Name = "panelM5_ThongKe";
            this.panelM5_ThongKe.Size = new System.Drawing.Size(800, 548);
            this.panelM5_ThongKe.TabIndex = 1;
            // 
            // tabControlThongKe
            // 
            this.tabControlThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlThongKe.Controls.Add(this.tabPageLoai);
            this.tabControlThongKe.Controls.Add(this.tabPageCap);
            this.tabControlThongKe.Location = new System.Drawing.Point(16, 100);
            this.tabControlThongKe.Name = "tabControlThongKe";
            this.tabControlThongKe.SelectedIndex = 0;
            this.tabControlThongKe.Size = new System.Drawing.Size(768, 430);
            this.tabControlThongKe.TabIndex = 4;
            // 
            // tabPageLoai
            // 
            this.tabPageLoai.Controls.Add(this.panelChartLoai);
            this.tabPageLoai.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoai.Name = "tabPageLoai";
            this.tabPageLoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoai.Size = new System.Drawing.Size(760, 401);
            this.tabPageLoai.TabIndex = 0;
            this.tabPageLoai.Text = "Theo chủng loại";
            this.tabPageLoai.UseVisualStyleBackColor = true;
            // 
            // panelChartLoai
            // 
            this.panelChartLoai.AutoScroll = true;
            this.panelChartLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartLoai.Location = new System.Drawing.Point(3, 3);
            this.panelChartLoai.Name = "panelChartLoai";
            this.panelChartLoai.Size = new System.Drawing.Size(754, 395);
            this.panelChartLoai.TabIndex = 0;
            // 
            // tabPageCap
            // 
            this.tabPageCap.Controls.Add(this.panelChartCap);
            this.tabPageCap.Location = new System.Drawing.Point(4, 25);
            this.tabPageCap.Name = "tabPageCap";
            this.tabPageCap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCap.Size = new System.Drawing.Size(760, 401);
            this.tabPageCap.TabIndex = 1;
            this.tabPageCap.Text = "Theo cấp trang bị";
            this.tabPageCap.UseVisualStyleBackColor = true;
            // 
            // panelChartCap
            // 
            this.panelChartCap.AutoScroll = true;
            this.panelChartCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartCap.Location = new System.Drawing.Point(3, 3);
            this.panelChartCap.Name = "panelChartCap";
            this.panelChartCap.Size = new System.Drawing.Size(754, 395);
            this.panelChartCap.TabIndex = 0;
            // 
            // lblStatRecords
            // 
            this.lblStatRecords.AutoSize = true;
            this.lblStatRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.lblStatRecords.Location = new System.Drawing.Point(520, 50);
            this.lblStatRecords.Name = "lblStatRecords";
            this.lblStatRecords.Size = new System.Drawing.Size(24, 28);
            this.lblStatRecords.TabIndex = 3;
            this.lblStatRecords.Text = "—";
            // 
            // lblStatTypes
            // 
            this.lblStatTypes.AutoSize = true;
            this.lblStatTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.lblStatTypes.Location = new System.Drawing.Point(300, 50);
            this.lblStatTypes.Name = "lblStatTypes";
            this.lblStatTypes.Size = new System.Drawing.Size(24, 28);
            this.lblStatTypes.TabIndex = 2;
            this.lblStatTypes.Text = "—";
            // 
            // lblStatTotal
            // 
            this.lblStatTotal.AutoSize = true;
            this.lblStatTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.lblStatTotal.Location = new System.Drawing.Point(80, 50);
            this.lblStatTotal.Name = "lblStatTotal";
            this.lblStatTotal.Size = new System.Drawing.Size(24, 28);
            this.lblStatTotal.TabIndex = 1;
            this.lblStatTotal.Text = "—";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.label21.Location = new System.Drawing.Point(16, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Thống kê TTB";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panelM5_ThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "Thống kê trang thiết bị";
            this.panelM5_ThongKe.ResumeLayout(false);
            this.panelM5_ThongKe.PerformLayout();
            this.tabControlThongKe.ResumeLayout(false);
            this.tabPageLoai.ResumeLayout(false);
            this.tabPageCap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelM5_ThongKe;
        private System.Windows.Forms.TabControl tabControlThongKe;
        private System.Windows.Forms.TabPage tabPageLoai;
        private System.Windows.Forms.Panel panelChartLoai;
        private System.Windows.Forms.TabPage tabPageCap;
        private System.Windows.Forms.Panel panelChartCap;
        private System.Windows.Forms.Label lblStatRecords;
        private System.Windows.Forms.Label lblStatTypes;
        private System.Windows.Forms.Label lblStatTotal;
        private System.Windows.Forms.Label label21;
    }
}

