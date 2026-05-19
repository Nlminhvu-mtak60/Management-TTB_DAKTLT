using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormThemMoi : Form
    {
        public FormThemMoi()
        {
            InitializeComponent();
            this.Load += FormThemMoi_Load;
            
            if (btnLuu != null) btnLuu.Click += btnLuu_Click;
            if (btnNhapLai != null) btnNhapLai.Click += btnNhapLai_Click;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính đúng đắn dữ liệu
            if (string.IsNullOrWhiteSpace(txtMaTTB.Text))
            {
                ShowSaveMessage("Vui lòng nhập Mã trang thiết bị (*)", false);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                ShowSaveMessage("Vui lòng nhập Tên trang thiết bị (*)", false);
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                ShowSaveMessage("Số lượng phải lớn hơn 0 (*)", false);
                return;
            }

            if (dtpNgaySX.Value > dtpNgaySD.Value)
            {
                ShowSaveMessage("Ngày sản xuất phải trước ngày đưa vào sử dụng (*)", false);
                return;
            }

            // Dữ liệu hợp lệ -> Tạo đối tượng mới
            TrangThietBi moi = new TrangThietBi
            {
                MaTTB = txtMaTTB.Text.Trim(),
                SoHieu = txtSoHieu.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySX = dtpNgaySX.Value,
                NgaySD = dtpNgaySD.Value,
                NguonCap = txtNguonCap.Text.Trim(),
                SoLuong = (int)numSoLuong.Value,
                ChungLoai = cboChungLoai.SelectedItem?.ToString() ?? "Khác",
                Cap = cboCap.SelectedIndex + 1,
                GhiChu = txtGhiChu.Text.Trim()
            };

            // Thêm vào danh sách và lưu file
            DataStore.DsTTB.Add(moi);
            DataStore.SaveData();

            ShowSaveMessage(string.Format("Đã lưu hồ sơ: {0} thành công!", moi.MaTTB), true);
            
            // Xóa trắng form để nhập tiếp
            btnNhapLai_Click(null, null);

            MessageBox.Show("Đã lưu thông tin trang thiết bị vào hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var timer = new Timer { Interval = 3500 };
            timer.Tick += (s, ev) =>
            {
                lblSaveMessage.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        private void ShowSaveMessage(string message, bool success)
        {
            lblSaveMessage.Text = message;
            lblSaveMessage.BackColor = success ? Color.FromArgb(40, 80, 40) : Color.FromArgb(100, 40, 40);
            lblSaveMessage.ForeColor = Color.White;
            lblSaveMessage.BorderStyle = BorderStyle.None;
            lblSaveMessage.Padding = new Padding(8, 4, 8, 4);
            lblSaveMessage.Visible = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaTTB.Clear();
            txtSoHieu.Clear();
            txtTen.Clear();
            txtNguonCap.Clear();
            txtGhiChu.Clear();
            numSoLuong.Value = 1;
            cboChungLoai.SelectedIndex = -1;
            cboCap.SelectedIndex = 2;
            dtpNgaySX.Value = DateTime.Now;
            dtpNgaySD.Value = DateTime.Now;
            lblSaveMessage.Visible = false;
        }

        private void FormThemMoi_Load(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("panelSidebar")) this.Controls["panelSidebar"].Visible = false;
            if (this.Controls.ContainsKey("panelToolbar")) this.Controls["panelToolbar"].Visible = false;
            if (this.Controls.ContainsKey("panelTitleBar")) this.Controls["panelTitleBar"].Visible = false;
            if (this.Controls.ContainsKey("panelStatus")) this.Controls["panelStatus"].Visible = false;
            
            panelM1_ThemMoi.Dock = DockStyle.Fill;
            panelM1_ThemMoi.BringToFront();
            panelM1_ThemMoi.Visible = true;
            
            cboChungLoai.SelectedIndex = -1;
            cboCap.SelectedIndex = 2;
        }

        private void panelM1Actions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
