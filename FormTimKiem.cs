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
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            if (cboSearchType != null) cboSearchType.SelectedIndex = 0;
            if (cboSearchKey != null) cboSearchKey.SelectedIndex = 0;
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

            string key = "MaTTB";
            string searchFieldName = "mã";
            if (cboSearchKey != null && cboSearchKey.SelectedIndex == 1)
            {
                key = "Ten";
                searchFieldName = "tên";
            }

            List<TrangThietBi> results;
            string usedAlgo = "";

            if (cboSearchType.SelectedIndex == 1 && DataStore.IsSorted)
            {
                results = ThuatToan.BinarySearch(DataStore.DsTTB, key, keyword);
                usedAlgo = "Tìm nhị phân";
            }
            else
            {
                results = ThuatToan.LinearSearch(DataStore.DsTTB, key, keyword);
                usedAlgo = "Tìm tuần tự";

                if (cboSearchType.SelectedIndex == 1 && !DataStore.IsSorted)
                {
                    usedAlgo = "Tìm tuần tự (chưa sắp xếp, tự động chuyển)";
                }
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
                "Tìm thấy {0} kết quả cho {1} \"{2}\" ({3})",
                results.Count, searchFieldName, keyword, usedAlgo);
        }

        private void btnXoaTim_Click(object sender, EventArgs e)
        {
            
            txtSearch.Text = "";

            dgvTimKiem.Rows.Clear();

            lblSearchMessage.Text = "Nhập từ khóa và nhấn Tìm";
        }

        private void panelM4_TimKiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
