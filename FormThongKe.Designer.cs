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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            
            // New charts
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaBD = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesBD = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaSD = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesSD = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaThoiGianSX = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesThoiGianSX = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaThoiGianSD = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesThoiGianSD = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.chartLoai = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.chartCap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvCap = new System.Windows.Forms.DataGridView();
            this.chartNguon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvNguon = new System.Windows.Forms.DataGridView();

            this.panelM5_ThongKe = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblStatTotal = new System.Windows.Forms.Label();
            this.labelDesc1 = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblStatTypes = new System.Windows.Forms.Label();
            this.labelDesc2 = new System.Windows.Forms.Label();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblStatRecords = new System.Windows.Forms.Label();
            this.labelDesc3 = new System.Windows.Forms.Label();

            // Cards 2
            this.tableLayoutPanelCards2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCard4 = new System.Windows.Forms.Panel();
            this.lblStatQHBaoDuong = new System.Windows.Forms.Label();
            this.labelDesc4 = new System.Windows.Forms.Label();
            this.panelCard5 = new System.Windows.Forms.Panel();
            this.lblStatCanBaoDuong = new System.Windows.Forms.Label();
            this.labelDesc5 = new System.Windows.Forms.Label();
            this.panelCard6 = new System.Windows.Forms.Panel();
            this.lblStatDangSuaChua = new System.Windows.Forms.Label();
            this.labelDesc6 = new System.Windows.Forms.Label();

            this.label21 = new System.Windows.Forms.Label();
            this.tabControlThongKe = new System.Windows.Forms.TabControl();
            this.tabPageLoai = new System.Windows.Forms.TabPage();
            this.panelChartLoai = new System.Windows.Forms.Panel();
            this.tabPageCap = new System.Windows.Forms.TabPage();
            this.panelChartCap = new System.Windows.Forms.Panel();
            this.tabPageNguon = new System.Windows.Forms.TabPage();
            this.panelChartNguon = new System.Windows.Forms.Panel();

            // Tabs mới
            this.tabPageTinhTrangBD = new System.Windows.Forms.TabPage();
            this.panelChartTinhTrangBD = new System.Windows.Forms.Panel();
            this.chartTinhTrangBD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTinhTrangBD = new System.Windows.Forms.DataGridView();

            this.tabPageTinhTrangSD = new System.Windows.Forms.TabPage();
            this.panelChartTinhTrangSD = new System.Windows.Forms.Panel();
            this.chartTinhTrangSD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTinhTrangSD = new System.Windows.Forms.DataGridView();

            this.tabPageTheoThoiGian = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelThoiGian = new System.Windows.Forms.TableLayoutPanel();
            this.panelSX = new System.Windows.Forms.Panel();
            this.chartThoiGianSX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvThoiGianSX = new System.Windows.Forms.DataGridView();
            this.panelSD = new System.Windows.Forms.Panel();
            this.chartThoiGianSD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvThoiGianSD = new System.Windows.Forms.DataGridView();

            this.tabPageBaoCao = new System.Windows.Forms.TabPage();
            this.panelBaoCaoTop = new System.Windows.Forms.Panel();
            this.panelBaoCaoFill = new System.Windows.Forms.Panel();
            this.rb_BaoCaoTong = new System.Windows.Forms.RadioButton();
            this.rb_BaoCaoBD = new System.Windows.Forms.RadioButton();
            this.rb_BaoCaoThanhLy = new System.Windows.Forms.RadioButton();
            this.btnXemTruoc = new System.Windows.Forms.Button();
            this.btnXuatTXT = new System.Windows.Forms.Button();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.chartLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNguon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguon)).BeginInit();
            this.panelM5_ThongKe.SuspendLayout();
            this.tableLayoutPanelCards.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.tableLayoutPanelCards2.SuspendLayout();
            this.panelCard4.SuspendLayout();
            this.panelCard5.SuspendLayout();
            this.panelCard6.SuspendLayout();
            this.tabControlThongKe.SuspendLayout();
            this.tabPageLoai.SuspendLayout();
            this.tabPageCap.SuspendLayout();
            this.tabPageNguon.SuspendLayout();
            this.tabPageTinhTrangBD.SuspendLayout();
            this.panelChartTinhTrangBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTinhTrangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangBD)).BeginInit();
            this.tabPageTinhTrangSD.SuspendLayout();
            this.panelChartTinhTrangSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTinhTrangSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangSD)).BeginInit();
            this.tabPageTheoThoiGian.SuspendLayout();
            this.tableLayoutPanelThoiGian.SuspendLayout();
            this.panelSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThoiGianSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThoiGianSX)).BeginInit();
            this.panelSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThoiGianSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThoiGianSD)).BeginInit();
            this.tabPageBaoCao.SuspendLayout();
            this.panelBaoCaoTop.SuspendLayout();
            this.panelBaoCaoFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelM5_ThongKe
            // 
            this.panelM5_ThongKe.AutoScroll = true;
            this.panelM5_ThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panelM5_ThongKe.Controls.Add(this.tabControlThongKe);
            this.panelM5_ThongKe.Controls.Add(this.tableLayoutPanelCards2);
            this.panelM5_ThongKe.Controls.Add(this.tableLayoutPanelCards);
            this.panelM5_ThongKe.Controls.Add(this.label21);
            this.panelM5_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelM5_ThongKe.Location = new System.Drawing.Point(0, 0);
            this.panelM5_ThongKe.Name = "panelM5_ThongKe";
            this.panelM5_ThongKe.Size = new System.Drawing.Size(800, 650);
            this.panelM5_ThongKe.TabIndex = 1;
            // 
            // tableLayoutPanelCards
            // 
            this.tableLayoutPanelCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCards.ColumnCount = 3;
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.Controls.Add(this.panelCard1, 0, 0);
            this.tableLayoutPanelCards.Controls.Add(this.panelCard2, 1, 0);
            this.tableLayoutPanelCards.Controls.Add(this.panelCard3, 2, 0);
            this.tableLayoutPanelCards.Location = new System.Drawing.Point(16, 45);
            this.tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            this.tableLayoutPanelCards.RowCount = 1;
            this.tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCards.Size = new System.Drawing.Size(768, 90);
            this.tableLayoutPanelCards.TabIndex = 8;
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.White;
            this.panelCard1.Controls.Add(this.lblStatTotal);
            this.panelCard1.Controls.Add(this.labelDesc1);
            this.panelCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard1.Location = new System.Drawing.Point(0, 0);
            this.panelCard1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(246, 90);
            this.panelCard1.TabIndex = 5;
            // 
            // lblStatTotal
            // 
            this.lblStatTotal.AutoSize = true;
            this.lblStatTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.lblStatTotal.Location = new System.Drawing.Point(10, 10);
            this.lblStatTotal.Name = "lblStatTotal";
            this.lblStatTotal.Size = new System.Drawing.Size(24, 28);
            this.lblStatTotal.TabIndex = 1;
            this.lblStatTotal.Text = "—";
            // 
            // labelDesc1
            // 
            this.labelDesc1.AutoSize = true;
            this.labelDesc1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDesc1.ForeColor = System.Drawing.Color.Gray;
            this.labelDesc1.Location = new System.Drawing.Point(10, 52);
            this.labelDesc1.Name = "labelDesc1";
            this.labelDesc1.Size = new System.Drawing.Size(121, 23);
            this.labelDesc1.TabIndex = 2;
            this.labelDesc1.Text = "Tổng số lượng thiết bị";
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.White;
            this.panelCard2.Controls.Add(this.lblStatTypes);
            this.panelCard2.Controls.Add(this.labelDesc2);
            this.panelCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard2.Location = new System.Drawing.Point(266, 0);
            this.panelCard2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(236, 90);
            this.panelCard2.TabIndex = 6;
            // 
            // lblStatTypes
            // 
            this.lblStatTypes.AutoSize = true;
            this.lblStatTypes.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.lblStatTypes.Location = new System.Drawing.Point(10, 10);
            this.lblStatTypes.Name = "lblStatTypes";
            this.lblStatTypes.Size = new System.Drawing.Size(24, 28);
            this.lblStatTypes.TabIndex = 1;
            this.lblStatTypes.Text = "—";
            // 
            // labelDesc2
            // 
            this.labelDesc2.AutoSize = true;
            this.labelDesc2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDesc2.ForeColor = System.Drawing.Color.Gray;
            this.labelDesc2.Location = new System.Drawing.Point(10, 52);
            this.labelDesc2.Name = "labelDesc2";
            this.labelDesc2.Size = new System.Drawing.Size(121, 23);
            this.labelDesc2.TabIndex = 2;
            this.labelDesc2.Text = "Tổng số chủng loại";
            // 
            // panelCard3
            // 
            this.panelCard3.BackColor = System.Drawing.Color.White;
            this.panelCard3.Controls.Add(this.lblStatRecords);
            this.panelCard3.Controls.Add(this.labelDesc3);
            this.panelCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard3.Location = new System.Drawing.Point(522, 0);
            this.panelCard3.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Size = new System.Drawing.Size(246, 90);
            this.panelCard3.TabIndex = 7;
            // 
            // lblStatRecords
            // 
            this.lblStatRecords.AutoSize = true;
            this.lblStatRecords.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.lblStatRecords.Location = new System.Drawing.Point(10, 10);
            this.lblStatRecords.Name = "lblStatRecords";
            this.lblStatRecords.Size = new System.Drawing.Size(24, 28);
            this.lblStatRecords.TabIndex = 1;
            this.lblStatRecords.Text = "—";
            // 
            // labelDesc3
            // 
            this.labelDesc3.AutoSize = true;
            this.labelDesc3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDesc3.ForeColor = System.Drawing.Color.Gray;
            this.labelDesc3.Location = new System.Drawing.Point(10, 52);
            this.labelDesc3.Name = "labelDesc3";
            this.labelDesc3.Size = new System.Drawing.Size(121, 23);
            this.labelDesc3.TabIndex = 2;
            this.labelDesc3.Text = "Bản ghi hệ thống";

            // tableLayoutPanelCards2
            // 
            this.tableLayoutPanelCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCards2.ColumnCount = 3;
            this.tableLayoutPanelCards2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards2.Controls.Add(this.panelCard4, 0, 0);
            this.tableLayoutPanelCards2.Controls.Add(this.panelCard5, 1, 0);
            this.tableLayoutPanelCards2.Controls.Add(this.panelCard6, 2, 0);
            this.tableLayoutPanelCards2.Location = new System.Drawing.Point(16, 145);
            this.tableLayoutPanelCards2.Name = "tableLayoutPanelCards2";
            this.tableLayoutPanelCards2.RowCount = 1;
            this.tableLayoutPanelCards2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCards2.Size = new System.Drawing.Size(768, 90);
            this.tableLayoutPanelCards2.TabIndex = 9;
            // 
            // panelCard4
            // 
            this.panelCard4.BackColor = System.Drawing.Color.White;
            this.panelCard4.Controls.Add(this.lblStatQHBaoDuong);
            this.panelCard4.Controls.Add(this.labelDesc4);
            this.panelCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard4.Location = new System.Drawing.Point(0, 0);
            this.panelCard4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelCard4.Name = "panelCard4";
            this.panelCard4.Size = new System.Drawing.Size(246, 90);
            this.panelCard4.TabIndex = 5;
            // 
            // lblStatQHBaoDuong
            // 
            this.lblStatQHBaoDuong.AutoSize = true;
            this.lblStatQHBaoDuong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatQHBaoDuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblStatQHBaoDuong.Location = new System.Drawing.Point(10, 10);
            this.lblStatQHBaoDuong.Name = "lblStatQHBaoDuong";
            this.lblStatQHBaoDuong.Size = new System.Drawing.Size(24, 28);
            this.lblStatQHBaoDuong.TabIndex = 1;
            this.lblStatQHBaoDuong.Text = "—";
            // 
            // labelDesc4
            // 
            this.labelDesc4.AutoSize = true;
            this.labelDesc4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDesc4.ForeColor = System.Drawing.Color.Gray;
            this.labelDesc4.Location = new System.Drawing.Point(10, 52);
            this.labelDesc4.Name = "labelDesc4";
            this.labelDesc4.Size = new System.Drawing.Size(121, 23);
            this.labelDesc4.TabIndex = 2;
            this.labelDesc4.Text = "Quá hạn bảo dưỡng";
            // 
            // panelCard5
            // 
            this.panelCard5.BackColor = System.Drawing.Color.White;
            this.panelCard5.Controls.Add(this.lblStatCanBaoDuong);
            this.panelCard5.Controls.Add(this.labelDesc5);
            this.panelCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard5.Location = new System.Drawing.Point(266, 0);
            this.panelCard5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelCard5.Name = "panelCard5";
            this.panelCard5.Size = new System.Drawing.Size(236, 90);
            this.panelCard5.TabIndex = 6;
            // 
            // lblStatCanBaoDuong
            // 
            this.lblStatCanBaoDuong.AutoSize = true;
            this.lblStatCanBaoDuong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatCanBaoDuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblStatCanBaoDuong.Location = new System.Drawing.Point(10, 10);
            this.lblStatCanBaoDuong.Name = "lblStatCanBaoDuong";
            this.lblStatCanBaoDuong.Size = new System.Drawing.Size(24, 28);
            this.lblStatCanBaoDuong.TabIndex = 1;
            this.lblStatCanBaoDuong.Text = "—";
            // 
            // labelDesc5
            // 
            this.labelDesc5.AutoSize = true;
            this.labelDesc5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDesc5.ForeColor = System.Drawing.Color.Gray;
            this.labelDesc5.Location = new System.Drawing.Point(10, 52);
            this.labelDesc5.Name = "labelDesc5";
            this.labelDesc5.Size = new System.Drawing.Size(121, 23);
            this.labelDesc5.TabIndex = 2;
            this.labelDesc5.Text = "Sắp đến hạn bảo dưỡng";
            // 
            // panelCard6
            // 
            this.panelCard6.BackColor = System.Drawing.Color.White;
            this.panelCard6.Controls.Add(this.lblStatDangSuaChua);
            this.panelCard6.Controls.Add(this.labelDesc6);
            this.panelCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard6.Location = new System.Drawing.Point(522, 0);
            this.panelCard6.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelCard6.Name = "panelCard6";
            this.panelCard6.Size = new System.Drawing.Size(246, 90);
            this.panelCard6.TabIndex = 7;
            // 
            // lblStatDangSuaChua
            // 
            this.lblStatDangSuaChua.AutoSize = true;
            this.lblStatDangSuaChua.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatDangSuaChua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.lblStatDangSuaChua.Location = new System.Drawing.Point(10, 10);
            this.lblStatDangSuaChua.Name = "lblStatDangSuaChua";
            this.lblStatDangSuaChua.Size = new System.Drawing.Size(24, 28);
            this.lblStatDangSuaChua.TabIndex = 1;
            this.lblStatDangSuaChua.Text = "—";
            // 
            // labelDesc6
            // 
            this.labelDesc6.AutoSize = true;
            this.labelDesc6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDesc6.ForeColor = System.Drawing.Color.Gray;
            this.labelDesc6.Location = new System.Drawing.Point(10, 52);
            this.labelDesc6.Name = "labelDesc6";
            this.labelDesc6.Size = new System.Drawing.Size(121, 23);
            this.labelDesc6.TabIndex = 2;
            this.labelDesc6.Text = "Đang sửa chữa";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.label21.Location = new System.Drawing.Point(12, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Thống kê TTB";
            // 
            // tabControlThongKe
            // 
            this.tabControlThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlThongKe.Controls.Add(this.tabPageLoai);
            this.tabControlThongKe.Controls.Add(this.tabPageCap);
            this.tabControlThongKe.Controls.Add(this.tabPageNguon);
            this.tabControlThongKe.Controls.Add(this.tabPageTinhTrangBD);
            // this.tabControlThongKe.Controls.Add(this.tabPageTinhTrangSD);
            // this.tabControlThongKe.Controls.Add(this.tabPageTheoThoiGian);
            this.tabControlThongKe.Controls.Add(this.tabPageBaoCao);
            this.tabControlThongKe.Location = new System.Drawing.Point(16, 245);
            this.tabControlThongKe.Name = "tabControlThongKe";
            this.tabControlThongKe.SelectedIndex = 0;
            this.tabControlThongKe.Size = new System.Drawing.Size(768, 390);
            this.tabControlThongKe.TabIndex = 4;
            // 
            // tabPageLoai
            // 
            this.tabPageLoai.Controls.Add(this.panelChartLoai);
            this.tabPageLoai.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoai.Name = "tabPageLoai";
            this.tabPageLoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoai.Size = new System.Drawing.Size(760, 361);
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
            this.panelChartLoai.Size = new System.Drawing.Size(754, 355);
            this.panelChartLoai.TabIndex = 0;
            // 
            // chartLoai
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartLoai.ChartAreas.Add(chartArea1);
            this.chartLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartLoai.Location = new System.Drawing.Point(3, 3);
            this.chartLoai.Name = "chartLoai";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chartLoai.Series.Add(series1);
            this.chartLoai.Size = new System.Drawing.Size(754, 300);
            this.chartLoai.TabIndex = 0;
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoai.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvLoai.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvLoai.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLoai.EnableHeadersVisualStyles = false;
            this.dgvLoai.Location = new System.Drawing.Point(3, 303);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersVisible = false;
            this.dgvLoai.Size = new System.Drawing.Size(754, 200);
            this.dgvLoai.TabIndex = 1;
            
            this.panelChartLoai.Controls.Add(this.dgvLoai);
            this.panelChartLoai.Controls.Add(this.chartLoai);

            // 
            // tabPageCap
            // 
            this.tabPageCap.Controls.Add(this.panelChartCap);
            this.tabPageCap.Location = new System.Drawing.Point(4, 25);
            this.tabPageCap.Name = "tabPageCap";
            this.tabPageCap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCap.Size = new System.Drawing.Size(760, 361);
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
            this.panelChartCap.Size = new System.Drawing.Size(754, 355);
            this.panelChartCap.TabIndex = 0;
            // 
            // chartCap
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartCap.ChartAreas.Add(chartArea2);
            this.chartCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartCap.Location = new System.Drawing.Point(3, 3);
            this.chartCap.Name = "chartCap";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            series2.IsValueShownAsLabel = true;
            series2.Name = "Series1";
            this.chartCap.Series.Add(series2);
            this.chartCap.Size = new System.Drawing.Size(754, 300);
            this.chartCap.TabIndex = 0;
            // 
            // dgvCap
            // 
            this.dgvCap.AllowUserToAddRows = false;
            this.dgvCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCap.BackgroundColor = System.Drawing.Color.White;
            this.dgvCap.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvCap.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCap.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCap.EnableHeadersVisualStyles = false;
            this.dgvCap.Location = new System.Drawing.Point(3, 303);
            this.dgvCap.Name = "dgvCap";
            this.dgvCap.ReadOnly = true;
            this.dgvCap.RowHeadersVisible = false;
            this.dgvCap.Size = new System.Drawing.Size(754, 200);
            this.dgvCap.TabIndex = 1;
            
            this.panelChartCap.Controls.Add(this.dgvCap);
            this.panelChartCap.Controls.Add(this.chartCap);

            // 
            // tabPageNguon
            // 
            this.tabPageNguon.Controls.Add(this.panelChartNguon);
            this.tabPageNguon.Location = new System.Drawing.Point(4, 25);
            this.tabPageNguon.Name = "tabPageNguon";
            this.tabPageNguon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNguon.Size = new System.Drawing.Size(760, 361);
            this.tabPageNguon.TabIndex = 2;
            this.tabPageNguon.Text = "Theo nguồn cấp";
            this.tabPageNguon.UseVisualStyleBackColor = true;
            // 
            // panelChartNguon
            // 
            this.panelChartNguon.AutoScroll = true;
            this.panelChartNguon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartNguon.Location = new System.Drawing.Point(3, 3);
            this.panelChartNguon.Name = "panelChartNguon";
            this.panelChartNguon.Size = new System.Drawing.Size(754, 355);
            this.panelChartNguon.TabIndex = 0;
            // 
            // chartNguon
            // 
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "ChartArea1";
            this.chartNguon.ChartAreas.Add(chartArea3);
            this.chartNguon.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartNguon.Location = new System.Drawing.Point(3, 3);
            this.chartNguon.Name = "chartNguon";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            this.chartNguon.Series.Add(series3);
            this.chartNguon.Size = new System.Drawing.Size(754, 300);
            this.chartNguon.TabIndex = 0;
            // 
            // dgvNguon
            // 
            this.dgvNguon.AllowUserToAddRows = false;
            this.dgvNguon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguon.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguon.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvNguon.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvNguon.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNguon.EnableHeadersVisualStyles = false;
            this.dgvNguon.Location = new System.Drawing.Point(3, 303);
            this.dgvNguon.Name = "dgvNguon";
            this.dgvNguon.ReadOnly = true;
            this.dgvNguon.RowHeadersVisible = false;
            this.dgvNguon.Size = new System.Drawing.Size(754, 200);
            this.dgvNguon.TabIndex = 1;
            
            this.panelChartNguon.Controls.Add(this.dgvNguon);
            this.panelChartNguon.Controls.Add(this.chartNguon);

            // 
            // tabPageTinhTrangBD
            // 
            this.tabPageTinhTrangBD.Controls.Add(this.panelChartTinhTrangBD);
            this.tabPageTinhTrangBD.Location = new System.Drawing.Point(4, 25);
            this.tabPageTinhTrangBD.Name = "tabPageTinhTrangBD";
            this.tabPageTinhTrangBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTinhTrangBD.Size = new System.Drawing.Size(760, 361);
            this.tabPageTinhTrangBD.TabIndex = 3;
            this.tabPageTinhTrangBD.Text = "Tình trạng bảo dưỡng";
            this.tabPageTinhTrangBD.UseVisualStyleBackColor = true;
            // 
            // panelChartTinhTrangBD
            // 
            this.panelChartTinhTrangBD.AutoScroll = true;
            this.panelChartTinhTrangBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartTinhTrangBD.Location = new System.Drawing.Point(3, 3);
            this.panelChartTinhTrangBD.Name = "panelChartTinhTrangBD";
            this.panelChartTinhTrangBD.Size = new System.Drawing.Size(754, 355);
            this.panelChartTinhTrangBD.TabIndex = 0;
            // 
            // chartTinhTrangBD
            // 
            chartAreaBD.AxisX.Interval = 1D;
            chartAreaBD.AxisX.MajorGrid.Enabled = false;
            chartAreaBD.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartAreaBD.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartAreaBD.Name = "ChartArea1";
            this.chartTinhTrangBD.ChartAreas.Add(chartAreaBD);
            this.chartTinhTrangBD.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartTinhTrangBD.Location = new System.Drawing.Point(3, 3);
            this.chartTinhTrangBD.Name = "chartTinhTrangBD";
            seriesBD.ChartArea = "ChartArea1";
            seriesBD.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriesBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            seriesBD.IsValueShownAsLabel = true;
            seriesBD.Name = "Series1";
            this.chartTinhTrangBD.Series.Add(seriesBD);
            this.chartTinhTrangBD.Size = new System.Drawing.Size(754, 300);
            this.chartTinhTrangBD.TabIndex = 0;
            // 
            // dgvTinhTrangBD
            // 
            this.dgvTinhTrangBD.AllowUserToAddRows = false;
            this.dgvTinhTrangBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTrangBD.BackgroundColor = System.Drawing.Color.White;
            this.dgvTinhTrangBD.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvTinhTrangBD.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTinhTrangBD.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTinhTrangBD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTinhTrangBD.EnableHeadersVisualStyles = false;
            this.dgvTinhTrangBD.Location = new System.Drawing.Point(3, 303);
            this.dgvTinhTrangBD.Name = "dgvTinhTrangBD";
            this.dgvTinhTrangBD.ReadOnly = true;
            this.dgvTinhTrangBD.RowHeadersVisible = false;
            this.dgvTinhTrangBD.Size = new System.Drawing.Size(754, 200);
            this.dgvTinhTrangBD.TabIndex = 1;
            
            this.panelChartTinhTrangBD.Controls.Add(this.dgvTinhTrangBD);
            this.panelChartTinhTrangBD.Controls.Add(this.chartTinhTrangBD);

            // 
            // tabPageTinhTrangSD
            // 
            this.tabPageTinhTrangSD.Controls.Add(this.panelChartTinhTrangSD);
            this.tabPageTinhTrangSD.Location = new System.Drawing.Point(4, 25);
            this.tabPageTinhTrangSD.Name = "tabPageTinhTrangSD";
            this.tabPageTinhTrangSD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTinhTrangSD.Size = new System.Drawing.Size(760, 361);
            this.tabPageTinhTrangSD.TabIndex = 4;
            this.tabPageTinhTrangSD.Text = "Tình trạng sử dụng";
            this.tabPageTinhTrangSD.UseVisualStyleBackColor = true;
            // 
            // panelChartTinhTrangSD
            // 
            this.panelChartTinhTrangSD.AutoScroll = true;
            this.panelChartTinhTrangSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChartTinhTrangSD.Location = new System.Drawing.Point(3, 3);
            this.panelChartTinhTrangSD.Name = "panelChartTinhTrangSD";
            this.panelChartTinhTrangSD.Size = new System.Drawing.Size(754, 355);
            this.panelChartTinhTrangSD.TabIndex = 0;
            // 
            // chartTinhTrangSD
            // 
            chartAreaSD.Name = "ChartArea1";
            this.chartTinhTrangSD.ChartAreas.Add(chartAreaSD);
            this.chartTinhTrangSD.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartTinhTrangSD.Location = new System.Drawing.Point(3, 3);
            this.chartTinhTrangSD.Name = "chartTinhTrangSD";
            seriesSD.ChartArea = "ChartArea1";
            seriesSD.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            seriesSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            seriesSD.IsValueShownAsLabel = true;
            seriesSD.Name = "Series1";
            this.chartTinhTrangSD.Series.Add(seriesSD);
            this.chartTinhTrangSD.Size = new System.Drawing.Size(754, 300);
            this.chartTinhTrangSD.TabIndex = 0;
            // 
            // dgvTinhTrangSD
            // 
            this.dgvTinhTrangSD.AllowUserToAddRows = false;
            this.dgvTinhTrangSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTrangSD.BackgroundColor = System.Drawing.Color.White;
            this.dgvTinhTrangSD.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvTinhTrangSD.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTinhTrangSD.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTinhTrangSD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTinhTrangSD.EnableHeadersVisualStyles = false;
            this.dgvTinhTrangSD.Location = new System.Drawing.Point(3, 303);
            this.dgvTinhTrangSD.Name = "dgvTinhTrangSD";
            this.dgvTinhTrangSD.ReadOnly = true;
            this.dgvTinhTrangSD.RowHeadersVisible = false;
            this.dgvTinhTrangSD.Size = new System.Drawing.Size(754, 200);
            this.dgvTinhTrangSD.TabIndex = 1;

            this.panelChartTinhTrangSD.Controls.Add(this.dgvTinhTrangSD);
            this.panelChartTinhTrangSD.Controls.Add(this.chartTinhTrangSD);

            // 
            // tabPageTheoThoiGian
            // 
            this.tabPageTheoThoiGian.Controls.Add(this.tableLayoutPanelThoiGian);
            this.tabPageTheoThoiGian.Location = new System.Drawing.Point(4, 25);
            this.tabPageTheoThoiGian.Name = "tabPageTheoThoiGian";
            this.tabPageTheoThoiGian.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheoThoiGian.Size = new System.Drawing.Size(760, 361);
            this.tabPageTheoThoiGian.TabIndex = 5;
            this.tabPageTheoThoiGian.Text = "Theo thời gian";
            this.tabPageTheoThoiGian.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelThoiGian
            // 
            this.tableLayoutPanelThoiGian.ColumnCount = 2;
            this.tableLayoutPanelThoiGian.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelThoiGian.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelThoiGian.Controls.Add(this.panelSX, 0, 0);
            this.tableLayoutPanelThoiGian.Controls.Add(this.panelSD, 1, 0);
            this.tableLayoutPanelThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelThoiGian.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelThoiGian.Name = "tableLayoutPanelThoiGian";
            this.tableLayoutPanelThoiGian.RowCount = 1;
            this.tableLayoutPanelThoiGian.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelThoiGian.Size = new System.Drawing.Size(754, 355);
            this.tableLayoutPanelThoiGian.TabIndex = 0;
            // 
            // panelSX
            // 
            this.panelSX.AutoScroll = true;
            this.panelSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSX.Location = new System.Drawing.Point(3, 3);
            this.panelSX.Name = "panelSX";
            this.panelSX.Size = new System.Drawing.Size(371, 349);
            this.panelSX.TabIndex = 0;
            // 
            // chartThoiGianSX
            // 
            chartAreaThoiGianSX.AxisX.Interval = 1D;
            chartAreaThoiGianSX.AxisX.MajorGrid.Enabled = false;
            chartAreaThoiGianSX.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartAreaThoiGianSX.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartAreaThoiGianSX.Name = "ChartArea1";
            this.chartThoiGianSX.ChartAreas.Add(chartAreaThoiGianSX);
            this.chartThoiGianSX.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartThoiGianSX.Location = new System.Drawing.Point(0, 0);
            this.chartThoiGianSX.Name = "chartThoiGianSX";
            seriesThoiGianSX.ChartArea = "ChartArea1";
            seriesThoiGianSX.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriesThoiGianSX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            seriesThoiGianSX.IsValueShownAsLabel = true;
            seriesThoiGianSX.Name = "Series1";
            this.chartThoiGianSX.Series.Add(seriesThoiGianSX);
            this.chartThoiGianSX.Size = new System.Drawing.Size(371, 200);
            this.chartThoiGianSX.TabIndex = 0;
            // 
            // dgvThoiGianSX
            // 
            this.dgvThoiGianSX.AllowUserToAddRows = false;
            this.dgvThoiGianSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThoiGianSX.BackgroundColor = System.Drawing.Color.White;
            this.dgvThoiGianSX.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvThoiGianSX.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvThoiGianSX.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThoiGianSX.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThoiGianSX.EnableHeadersVisualStyles = false;
            this.dgvThoiGianSX.Location = new System.Drawing.Point(0, 200);
            this.dgvThoiGianSX.Name = "dgvThoiGianSX";
            this.dgvThoiGianSX.ReadOnly = true;
            this.dgvThoiGianSX.RowHeadersVisible = false;
            this.dgvThoiGianSX.Size = new System.Drawing.Size(371, 150);
            this.dgvThoiGianSX.TabIndex = 1;
            
            this.panelSX.Controls.Add(this.dgvThoiGianSX);
            this.panelSX.Controls.Add(this.chartThoiGianSX);

            // panelSD
            // 
            this.panelSD.AutoScroll = true;
            this.panelSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSD.Location = new System.Drawing.Point(380, 3);
            this.panelSD.Name = "panelSD";
            this.panelSD.Size = new System.Drawing.Size(371, 349);
            this.panelSD.TabIndex = 1;
            // 
            // chartThoiGianSD
            // 
            chartAreaThoiGianSD.AxisX.Interval = 1D;
            chartAreaThoiGianSD.AxisX.MajorGrid.Enabled = false;
            chartAreaThoiGianSD.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartAreaThoiGianSD.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartAreaThoiGianSD.Name = "ChartArea1";
            this.chartThoiGianSD.ChartAreas.Add(chartAreaThoiGianSD);
            this.chartThoiGianSD.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartThoiGianSD.Location = new System.Drawing.Point(0, 0);
            this.chartThoiGianSD.Name = "chartThoiGianSD";
            seriesThoiGianSD.ChartArea = "ChartArea1";
            seriesThoiGianSD.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriesThoiGianSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            seriesThoiGianSD.IsValueShownAsLabel = true;
            seriesThoiGianSD.Name = "Series1";
            this.chartThoiGianSD.Series.Add(seriesThoiGianSD);
            this.chartThoiGianSD.Size = new System.Drawing.Size(371, 200);
            this.chartThoiGianSD.TabIndex = 0;
            // 
            // dgvThoiGianSD
            // 
            this.dgvThoiGianSD.AllowUserToAddRows = false;
            this.dgvThoiGianSD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThoiGianSD.BackgroundColor = System.Drawing.Color.White;
            this.dgvThoiGianSD.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.dgvThoiGianSD.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvThoiGianSD.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThoiGianSD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThoiGianSD.EnableHeadersVisualStyles = false;
            this.dgvThoiGianSD.Location = new System.Drawing.Point(0, 200);
            this.dgvThoiGianSD.Name = "dgvThoiGianSD";
            this.dgvThoiGianSD.ReadOnly = true;
            this.dgvThoiGianSD.RowHeadersVisible = false;
            this.dgvThoiGianSD.Size = new System.Drawing.Size(371, 150);
            this.dgvThoiGianSD.TabIndex = 1;
            
            this.panelSD.Controls.Add(this.dgvThoiGianSD);
            this.panelSD.Controls.Add(this.chartThoiGianSD);

            // 
            // tabPageBaoCao
            // 
            this.tabPageBaoCao.Controls.Add(this.panelBaoCaoFill);
            this.tabPageBaoCao.Controls.Add(this.panelBaoCaoTop);
            this.tabPageBaoCao.Location = new System.Drawing.Point(4, 25);
            this.tabPageBaoCao.Name = "tabPageBaoCao";
            this.tabPageBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBaoCao.Size = new System.Drawing.Size(760, 361);
            this.tabPageBaoCao.TabIndex = 6;
            this.tabPageBaoCao.Text = "Báo cáo tổng hợp";
            this.tabPageBaoCao.UseVisualStyleBackColor = true;
            // 
            // panelBaoCaoTop
            // 
            this.panelBaoCaoTop.Controls.Add(this.rb_BaoCaoTong);
            this.panelBaoCaoTop.Controls.Add(this.rb_BaoCaoBD);
            this.panelBaoCaoTop.Controls.Add(this.rb_BaoCaoThanhLy);
            // this.panelBaoCaoTop.Controls.Add(this.btnXemTruoc);
            this.panelBaoCaoTop.Controls.Add(this.btnXuatTXT);
            this.panelBaoCaoTop.Controls.Add(this.btnXuatCSV);
            this.panelBaoCaoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaoCaoTop.Location = new System.Drawing.Point(3, 3);
            this.panelBaoCaoTop.Name = "panelBaoCaoTop";
            this.panelBaoCaoTop.Size = new System.Drawing.Size(754, 50);
            this.panelBaoCaoTop.TabIndex = 0;
            // 
            // rb_BaoCaoTong
            // 
            this.rb_BaoCaoTong.AutoSize = true;
            this.rb_BaoCaoTong.Checked = true;
            this.rb_BaoCaoTong.Location = new System.Drawing.Point(10, 15);
            this.rb_BaoCaoTong.Name = "rb_BaoCaoTong";
            this.rb_BaoCaoTong.Size = new System.Drawing.Size(180, 21);
            this.rb_BaoCaoTong.TabIndex = 0;
            this.rb_BaoCaoTong.TabStop = true;
            this.rb_BaoCaoTong.Text = "Báo cáo tổng hợp toàn bộ";
            this.rb_BaoCaoTong.UseVisualStyleBackColor = true;
            // 
            // rb_BaoCaoBD
            // 
            this.rb_BaoCaoBD.AutoSize = true;
            this.rb_BaoCaoBD.Location = new System.Drawing.Point(200, 15);
            this.rb_BaoCaoBD.Name = "rb_BaoCaoBD";
            this.rb_BaoCaoBD.Size = new System.Drawing.Size(183, 21);
            this.rb_BaoCaoBD.TabIndex = 1;
            this.rb_BaoCaoBD.Text = "Danh sách cần bảo dưỡng";
            this.rb_BaoCaoBD.UseVisualStyleBackColor = true;
            // 
            // rb_BaoCaoThanhLy
            // 
            this.rb_BaoCaoThanhLy.AutoSize = true;
            this.rb_BaoCaoThanhLy.Location = new System.Drawing.Point(390, 15);
            this.rb_BaoCaoThanhLy.Name = "rb_BaoCaoThanhLy";
            this.rb_BaoCaoThanhLy.Size = new System.Drawing.Size(142, 21);
            this.rb_BaoCaoThanhLy.TabIndex = 2;
            this.rb_BaoCaoThanhLy.Text = "Danh sách thanh lý";
            this.rb_BaoCaoThanhLy.UseVisualStyleBackColor = true;
            // 
            // btnXemTruoc
            // 
            this.btnXemTruoc.Location = new System.Drawing.Point(540, 10);
            this.btnXemTruoc.Name = "btnXemTruoc";
            this.btnXemTruoc.Size = new System.Drawing.Size(100, 30);
            this.btnXemTruoc.TabIndex = 3;
            this.btnXemTruoc.Text = "👁 Xem trước";
            this.btnXemTruoc.UseVisualStyleBackColor = true;
            // 
            // btnXuatTXT
            // 
            this.btnXuatTXT.Location = new System.Drawing.Point(645, 10);
            this.btnXuatTXT.Name = "btnXuatTXT";
            this.btnXuatTXT.Size = new System.Drawing.Size(90, 30);
            this.btnXuatTXT.TabIndex = 4;
            this.btnXuatTXT.Text = "📄 Xuất TXT";
            this.btnXuatTXT.UseVisualStyleBackColor = true;
            // 
            // btnXuatCSV
            // 
            this.btnXuatCSV.Location = new System.Drawing.Point(740, 10);
            this.btnXuatCSV.Name = "btnXuatCSV";
            this.btnXuatCSV.Size = new System.Drawing.Size(90, 30);
            this.btnXuatCSV.TabIndex = 5;
            this.btnXuatCSV.Text = "📊 Xuất CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = true;
            // 
            // panelBaoCaoFill
            // 
            this.panelBaoCaoFill.Controls.Add(this.txtPreview);
            this.panelBaoCaoFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaoCaoFill.Location = new System.Drawing.Point(3, 53);
            this.panelBaoCaoFill.Name = "panelBaoCaoFill";
            this.panelBaoCaoFill.Size = new System.Drawing.Size(754, 305);
            this.panelBaoCaoFill.TabIndex = 1;
            // 
            // txtPreview
            // 
            this.txtPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(0, 0);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreview.Size = new System.Drawing.Size(754, 305);
            this.txtPreview.TabIndex = 0;
            this.txtPreview.WordWrap = false;

            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelM5_ThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "Thống kê trang thiết bị";
            this.panelM5_ThongKe.ResumeLayout(false);
            this.panelM5_ThongKe.PerformLayout();
            this.tableLayoutPanelCards.ResumeLayout(false);
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panelCard3.ResumeLayout(false);
            this.panelCard3.PerformLayout();
            this.tableLayoutPanelCards2.ResumeLayout(false);
            this.panelCard4.ResumeLayout(false);
            this.panelCard4.PerformLayout();
            this.panelCard5.ResumeLayout(false);
            this.panelCard5.PerformLayout();
            this.panelCard6.ResumeLayout(false);
            this.panelCard6.PerformLayout();
            this.tabControlThongKe.ResumeLayout(false);
            this.tabPageLoai.ResumeLayout(false);
            this.tabPageCap.ResumeLayout(false);
            this.tabPageNguon.ResumeLayout(false);
            this.tabPageTinhTrangBD.ResumeLayout(false);
            this.panelChartTinhTrangBD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTinhTrangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangBD)).EndInit();
            this.tabPageTinhTrangSD.ResumeLayout(false);
            this.panelChartTinhTrangSD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTinhTrangSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangSD)).EndInit();
            this.tabPageTheoThoiGian.ResumeLayout(false);
            this.tableLayoutPanelThoiGian.ResumeLayout(false);
            this.panelSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThoiGianSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThoiGianSX)).EndInit();
            this.panelSD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThoiGianSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThoiGianSD)).EndInit();
            this.tabPageBaoCao.ResumeLayout(false);
            this.panelBaoCaoTop.ResumeLayout(false);
            this.panelBaoCaoTop.PerformLayout();
            this.panelBaoCaoFill.ResumeLayout(false);
            this.panelBaoCaoFill.PerformLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.chartLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNguon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguon)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelM5_ThongKe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards2;
        private System.Windows.Forms.Panel panelCard4;
        private System.Windows.Forms.Panel panelCard5;
        private System.Windows.Forms.Panel panelCard6;
        private System.Windows.Forms.TabControl tabControlThongKe;
        private System.Windows.Forms.TabPage tabPageLoai;
        private System.Windows.Forms.Panel panelChartLoai;
        private System.Windows.Forms.TabPage tabPageCap;
        private System.Windows.Forms.Panel panelChartCap;
        private System.Windows.Forms.TabPage tabPageNguon;
        private System.Windows.Forms.Panel panelChartNguon;
        private System.Windows.Forms.TabPage tabPageTinhTrangBD;
        private System.Windows.Forms.Panel panelChartTinhTrangBD;
        private System.Windows.Forms.TabPage tabPageTinhTrangSD;
        private System.Windows.Forms.Panel panelChartTinhTrangSD;
        private System.Windows.Forms.TabPage tabPageTheoThoiGian;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelThoiGian;
        private System.Windows.Forms.Panel panelSX;
        private System.Windows.Forms.Panel panelSD;
        private System.Windows.Forms.TabPage tabPageBaoCao;
        private System.Windows.Forms.Panel panelBaoCaoTop;
        private System.Windows.Forms.Panel panelBaoCaoFill;
        
        private System.Windows.Forms.Label lblStatRecords;
        private System.Windows.Forms.Label lblStatTypes;
        private System.Windows.Forms.Label lblStatTotal;
        private System.Windows.Forms.Label lblStatQHBaoDuong;
        private System.Windows.Forms.Label lblStatCanBaoDuong;
        private System.Windows.Forms.Label lblStatDangSuaChua;
        private System.Windows.Forms.Label labelDesc1;
        private System.Windows.Forms.Label labelDesc2;
        private System.Windows.Forms.Label labelDesc3;
        private System.Windows.Forms.Label labelDesc4;
        private System.Windows.Forms.Label labelDesc5;
        private System.Windows.Forms.Label labelDesc6;
        private System.Windows.Forms.Label label21;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoai;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCap;
        private System.Windows.Forms.DataGridView dgvCap;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNguon;
        private System.Windows.Forms.DataGridView dgvNguon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTinhTrangBD;
        private System.Windows.Forms.DataGridView dgvTinhTrangBD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTinhTrangSD;
        private System.Windows.Forms.DataGridView dgvTinhTrangSD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThoiGianSX;
        private System.Windows.Forms.DataGridView dgvThoiGianSX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThoiGianSD;
        private System.Windows.Forms.DataGridView dgvThoiGianSD;

        private System.Windows.Forms.RadioButton rb_BaoCaoTong;
        private System.Windows.Forms.RadioButton rb_BaoCaoBD;
        private System.Windows.Forms.RadioButton rb_BaoCaoThanhLy;
        private System.Windows.Forms.Button btnXemTruoc;
        private System.Windows.Forms.Button btnXuatTXT;
        private System.Windows.Forms.Button btnXuatCSV;
        private System.Windows.Forms.TextBox txtPreview;
    }
}
