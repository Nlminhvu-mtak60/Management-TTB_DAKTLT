using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
            this.Load += FormTimKiem_Load;
        }

        private void LoadAllData()
        {
            dgvTimKiem.Rows.Clear();
            if (DataStore.DsTTB == null) return;
            for (int i = 0; i < DataStore.DsTTB.Count; i++)
            {
                var item = DataStore.DsTTB[i];
                dgvTimKiem.Rows.Add(
                    i + 1,
                    item.MaTTB,
                    item.Ten,
                    item.ChungLoai,
                    item.SoLuong,
                    item.Cap
                );
            }
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            if (cboSearchKey != null) cboSearchKey.SelectedIndex = 0;
            LoadAllData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định trường tìm kiếm từ ComboBox
            string key = "MaTTB";
            string searchFieldName = "mã";
            if (cboSearchKey != null)
            {
                switch (cboSearchKey.SelectedIndex)
                {
                    case 0: key = "MaTTB"; searchFieldName = "mã"; break;
                    case 1: key = "Ten"; searchFieldName = "tên"; break;
                    case 2: key = "ChungLoai"; searchFieldName = "chủng loại"; break;
                    case 3: key = "NguonCap"; searchFieldName = "nguồn cấp"; break;
                }
            }

            // Tìm kiếm trên chỉ mục — chọn thuật toán theo RadioButton
            List<TrangThietBi> results;
            string tenThuatToan;

            if (rbNhiPhan.Checked)
            {
                // Tìm nhị phân trên chỉ mục: sắp xếp key → binary search O(log k)
                results = DataStore.ChiMuc.TimNhiPhanChiMuc(key, keyword);
                tenThuatToan = "Nhị phân trên chỉ mục";
            }
            else
            {
                // Tìm tuần tự trên chỉ mục: duyệt lần lượt key O(k)
                results = DataStore.ChiMuc.TimTuanTuChiMuc(key, keyword);
                tenThuatToan = "Tuần tự trên chỉ mục";
            }

            dgvTimKiem.Rows.Clear();
            for (int i = 0; i < results.Count; i++)
            {
                var item = results[i];
                dgvTimKiem.Rows.Add(
                    i + 1,
                    item.MaTTB,
                    item.Ten,
                    item.ChungLoai,
                    item.SoLuong,
                    item.Cap
                );
            }

            lblSearchMessage.Text = string.Format(
                "Tìm thấy {0} kết quả cho {1} \"{2}\" (Thuật toán: {3})",
                results.Count, searchFieldName, keyword, tenThuatToan);
        }

        private void btnXoaTim_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadAllData();
            lblSearchMessage.Text = "Đã hiển thị toàn bộ danh sách";
        }

        private void panelM4_TimKiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

