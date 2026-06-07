using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormThemMoi : Form
    {
        private int editIndex = -1;

        public FormThemMoi()
        {
            InitializeComponent();
            this.Load += FormThemMoi_Load;

            cboChungLoai.SelectedIndex = 0;
            cboCap.SelectedIndex = 0;
            cboTinhTrang.SelectedIndex = 0;

            // Xử lý sự kiện tự động tính ngày BD tiếp theo
            dtpNgayBDCuoi.ValueChanged += TinhNgayBDTiep;
            numChuKy.ValueChanged += TinhNgayBDTiep;

            if (btnLuu != null) btnLuu.Click += btnLuu_Click;
            if (btnNhapLai != null) btnNhapLai.Click += btnNhapLai_Click;
            if (btnHuy != null) btnHuy.Click += btnHuy_Click;
        }

        private string GenerateNewMaTTB()
        {
            int maxId = 0;
            foreach (var item in DataStore.DsTTB)
            {
                if (item.MaTTB.StartsWith("TTB"))
                {
                    if (int.TryParse(item.MaTTB.Substring(3), out int num))
                    {
                        if (num > maxId) maxId = num;
                    }
                }
            }
            return "TTB" + (maxId + 1).ToString("D3");
        }

        private void TinhNgayBDTiep(object sender, EventArgs e)
        {
            if (numChuKy.Value > 0)
            {
                dtpNgayBDTiep.Value = dtpNgayBDCuoi.Value.AddMonths((int)numChuKy.Value);
            }
        }

        public FormThemMoi(int index) : this()
        {
            editIndex = index;
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

            if (editIndex < 0)
            {
                var existingTTB = DataStore.DsTTB.Find(x => x.MaTTB.Equals(txtMaTTB.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                if (existingTTB != null)
                {
                    if (existingTTB.IsDeleted)
                        ShowSaveMessage("Mã TTB này đã tồn tại (đang nằm trong Thùng rác)!", false);
                    else
                        ShowSaveMessage("Mã TTB này đã tồn tại trong hệ thống!", false);
                    
                    txtMaTTB.Focus();
                    return;
                }
            }

            TrangThietBi ttb = new TrangThietBi
            {
                MaTTB = txtMaTTB.Text.Trim(),
                SoHieu = txtSoHieu.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                NgaySX = dtpNgaySX.Value,
                NgaySD = dtpNgaySD.Value,
                NguonCap = string.IsNullOrWhiteSpace(txtNguonCap.Text) ? "Không rõ" : txtNguonCap.Text.Trim(),
                SoLuong = (int)numSoLuong.Value,
                ChungLoai = cboChungLoai.SelectedItem?.ToString() ?? "Khác",
                Cap = int.Parse(cboCap.SelectedItem.ToString().Substring(0, 1)),
                GhiChu = txtGhiChu.Text.Trim(),
                NgayBaoDuongCuoi = dtpNgayBDCuoi.Value,
                NgayBaoDuongTiep = dtpNgayBDTiep.Value,
                ChuKyBaoDuong = (int)numChuKy.Value,
                TinhTrang = cboTinhTrang.SelectedItem.ToString(),
                LichSuBaoDuong = txtLichSu.Text.Trim()
            };

            if (editIndex >= 0)
            {
                // CHẾ ĐỘ SỬA: Cập nhật bản ghi tại vị trí editIndex
                DataStore.DsTTB[editIndex] = ttb;
                DataStore.SaveData();

                ShowSaveMessage(string.Format("Đã cập nhật hồ sơ: {0} thành công!", ttb.MaTTB), true);
                MessageBox.Show("Đã cập nhật thông tin trang thiết bị!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form sau khi sửa xong
                this.Close();
            }
            else
            {
                // CHẾ ĐỘ THÊM MỚI: Thêm vào danh sách
                DataStore.DsTTB.Add(ttb);
                DataStore.SaveData();

                ShowSaveMessage(string.Format("Đã lưu hồ sơ: {0} thành công!", ttb.MaTTB), true);
                
                // Xóa trắng form để nhập tiếp
                btnNhapLai_Click(null, null);

                MessageBox.Show("Đã lưu thông tin trang thiết bị vào hệ thống!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
            if (editIndex >= 0 && editIndex < DataStore.DsTTB.Count)
            {
                // Chế độ SỬA: Khôi phục lại dữ liệu gốc (không xóa Mã TTB)
                TrangThietBi ttb = DataStore.DsTTB[editIndex];
                txtSoHieu.Text = ttb.SoHieu;
                txtTen.Text = ttb.Ten;
                dtpNgaySX.Value = ttb.NgaySX;
                dtpNgaySD.Value = ttb.NgaySD;
                txtNguonCap.Text = ttb.NguonCap;
                numSoLuong.Value = ttb.SoLuong;
                txtGhiChu.Text = ttb.GhiChu;

                dtpNgayBDCuoi.Value = ttb.NgayBaoDuongCuoi >= dtpNgayBDCuoi.MinDate ? ttb.NgayBaoDuongCuoi : dtpNgayBDCuoi.MinDate;
                dtpNgayBDTiep.Value = ttb.NgayBaoDuongTiep >= dtpNgayBDTiep.MinDate ? ttb.NgayBaoDuongTiep : dtpNgayBDTiep.MinDate;
                numChuKy.Value = ttb.ChuKyBaoDuong > 0 ? ttb.ChuKyBaoDuong : 6;
                txtLichSu.Text = ttb.LichSuBaoDuong;

                for (int i = 0; i < cboTinhTrang.Items.Count; i++)
                {
                    if (cboTinhTrang.Items[i].ToString() == ttb.TinhTrang)
                    { cboTinhTrang.SelectedIndex = i; break; }
                }

                for (int i = 0; i < cboChungLoai.Items.Count; i++)
                {
                    if (cboChungLoai.Items[i].ToString() == ttb.ChungLoai)
                    { cboChungLoai.SelectedIndex = i; break; }
                }
                if (ttb.Cap >= 1 && ttb.Cap <= 5) cboCap.SelectedIndex = ttb.Cap - 1;
            }
            else
            {
                // Chế độ THÊM MỚI: Xóa trắng toàn bộ và sinh mã tự động
                txtMaTTB.Text = GenerateNewMaTTB();
                txtMaTTB.ReadOnly = true;
                txtMaTTB.BackColor = Color.FromArgb(230, 230, 230);
                
                txtSoHieu.Clear();
                txtTen.Clear();
                txtNguonCap.Clear();
                txtGhiChu.Clear();
                numSoLuong.Value = 1;
                cboChungLoai.SelectedIndex = -1;
                cboCap.SelectedIndex = 2;
                dtpNgaySX.Value = DateTime.Now;
                dtpNgaySD.Value = DateTime.Now;

                dtpNgayBDCuoi.Value = DateTime.Now;
                dtpNgayBDTiep.Value = DateTime.Now.AddMonths(6);
                numChuKy.Value = 6;
                cboTinhTrang.SelectedIndex = 0;
                txtLichSu.Clear();

                txtSoHieu.Focus(); // Focus vào ô kế tiếp
            }
            lblSaveMessage.Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (editIndex >= 0)
            {
                // Chế độ SỬA: Đóng form (quay lại danh sách)
                this.Close();
            }
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

            // Nếu đang ở chế độ SỬA → đổ dữ liệu bản ghi lên form
            if (editIndex >= 0 && editIndex < DataStore.DsTTB.Count)
            {
                TrangThietBi ttb = DataStore.DsTTB[editIndex];

                txtMaTTB.Text = ttb.MaTTB;
                txtMaTTB.ReadOnly = true; // Khóa ô Mã khi sửa
                txtMaTTB.BackColor = Color.FromArgb(230, 230, 230);

                txtSoHieu.Text = ttb.SoHieu;
                txtTen.Text = ttb.Ten;
                dtpNgaySX.Value = ttb.NgaySX;
                dtpNgaySD.Value = ttb.NgaySD;
                txtNguonCap.Text = ttb.NguonCap;
                numSoLuong.Value = ttb.SoLuong;
                txtGhiChu.Text = ttb.GhiChu;

                dtpNgayBDCuoi.Value = ttb.NgayBaoDuongCuoi >= dtpNgayBDCuoi.MinDate ? ttb.NgayBaoDuongCuoi : dtpNgayBDCuoi.MinDate;
                dtpNgayBDTiep.Value = ttb.NgayBaoDuongTiep >= dtpNgayBDTiep.MinDate ? ttb.NgayBaoDuongTiep : dtpNgayBDTiep.MinDate;
                numChuKy.Value = ttb.ChuKyBaoDuong > 0 ? ttb.ChuKyBaoDuong : 6;
                txtLichSu.Text = ttb.LichSuBaoDuong;

                for (int i = 0; i < cboTinhTrang.Items.Count; i++)
                {
                    if (cboTinhTrang.Items[i].ToString() == ttb.TinhTrang)
                    {
                        cboTinhTrang.SelectedIndex = i;
                        break;
                    }
                }

                // Tìm và chọn đúng mục Chủng loại trong ComboBox
                for (int i = 0; i < cboChungLoai.Items.Count; i++)
                {
                    if (cboChungLoai.Items[i].ToString() == ttb.ChungLoai)
                    {
                        cboChungLoai.SelectedIndex = i;
                        break;
                    }
                }

                // Chọn đúng Cấp (Cấp 1 = index 0, Cấp 2 = index 1, ...)
                if (ttb.Cap >= 1 && ttb.Cap <= 5)
                    cboCap.SelectedIndex = ttb.Cap - 1;

                // Đổi tiêu đề nút và form cho phù hợp
                btnLuu.Text = "💾 Cập nhật";
                this.Text = "Sửa hồ sơ trang thiết bị";
            }
            else
            {
                // Nếu đang ở chế độ THÊM MỚI → Tự động sinh mã TTB
                txtMaTTB.Text = GenerateNewMaTTB();
                txtMaTTB.ReadOnly = true;
                txtMaTTB.BackColor = Color.FromArgb(230, 230, 230);
            }
        }

        private void panelM1Actions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

