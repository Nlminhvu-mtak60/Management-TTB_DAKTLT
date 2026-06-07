using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormBaoDuong : Form
    {
        private int _index;

        public FormBaoDuong(int index)
        {
            InitializeComponent();
            _index = index;
            this.Load += FormBaoDuong_Load;
        }

        private void FormBaoDuong_Load(object sender, EventArgs e)
        {
            if (_index < 0 || _index >= DataStore.DsTTB.Count)
            {
                MessageBox.Show("Không tìm thấy trang thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            var ttb = DataStore.DsTTB[_index];

            // 1. Hiển thị thông tin TTB hiện tại
            lblMaTTB.Text = "Mã TTB: " + ttb.MaTTB;
            lblTenTTB.Text = "Tên: " + ttb.Ten;
            
            string tinhTrangHienTai = ttb.TinhTrangHienTai();
            lblTinhTrangCu.Text = "Tình trạng hiện tại: " + tinhTrangHienTai;
            if (tinhTrangHienTai == "Tốt") lblTinhTrangCu.ForeColor = Color.Green;
            else if (tinhTrangHienTai == "Cần bảo dưỡng") lblTinhTrangCu.ForeColor = Color.Orange;
            else lblTinhTrangCu.ForeColor = Color.Red;

            // 2. Đổ dữ liệu bảo dưỡng hiện tại lên các control
            if (ttb.NgayBaoDuongCuoi > DateTime.MinValue)
                dtpNgayBDMoi.Value = ttb.NgayBaoDuongCuoi;
            else
                dtpNgayBDMoi.Value = DateTime.Now;

            if (ttb.NgayBaoDuongTiep > DateTime.MinValue)
                dtpNgayBDTiep.Value = ttb.NgayBaoDuongTiep;
            else
                dtpNgayBDTiep.Value = DateTime.Now.AddMonths(6);

            if (ttb.ChuKyBaoDuong > 0 && ttb.ChuKyBaoDuong <= 60)
                numChuKyMoi.Value = ttb.ChuKyBaoDuong;
            else
                numChuKyMoi.Value = 6;

            if (!string.IsNullOrEmpty(ttb.TinhTrang) && cboTinhTrangMoi.Items.Contains(ttb.TinhTrang))
                cboTinhTrangMoi.SelectedItem = ttb.TinhTrang;
            else
                cboTinhTrangMoi.SelectedIndex = 0;

            // 3. Hiển thị lịch sử bảo dưỡng
            txtLichSu.Text = ttb.LichSuBaoDuong;
            txtLichSu.SelectionStart = txtLichSu.Text.Length;
            txtLichSu.ScrollToCaret();
        }

        private void btnLuuBD_Click(object sender, EventArgs e)
        {
            if (dtpNgayBDTiep.Value.Date <= dtpNgayBDMoi.Value.Date)
            {
                MessageBox.Show("Ngày bảo dưỡng tiếp theo phải sau ngày bảo dưỡng vừa thực hiện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTinhTrangMoi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ttb = DataStore.DsTTB[_index];

            ttb.NgayBaoDuongCuoi = dtpNgayBDMoi.Value;
            ttb.NgayBaoDuongTiep = dtpNgayBDTiep.Value;
            ttb.ChuKyBaoDuong = (int)numChuKyMoi.Value;
            string tinhTrangMoi = cboTinhTrangMoi.SelectedItem.ToString();
            ttb.TinhTrang = tinhTrangMoi;

            string ghiChu = txtGhiChuBD.Text.Trim();
            string dongLichSuMoi = $"[{DateTime.Now.ToString("dd/MM/yyyy HH:mm")}] — Tình trạng: {tinhTrangMoi} — Ghi chú: {ghiChu}" + Environment.NewLine;
            
            ttb.LichSuBaoDuong += dongLichSuMoi;

            DataStore.SaveData();

            MessageBox.Show("Cập nhật bảo dưỡng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuyBD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
