using System;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormDanhSach : Form
    {
        public FormDanhSach()
        {
            InitializeComponent();
            this.Load += FormDanhSach_Load;
        }

        private void FormDanhSach_Load(object sender, EventArgs e)
        {
            // Kiểm tra giao diện thừa của Form1
            if (this.Controls.ContainsKey("panelSidebar")) this.Controls["panelSidebar"].Visible = false;
            if (this.Controls.ContainsKey("panelToolbar")) this.Controls["panelToolbar"].Visible = false;
            if (this.Controls.ContainsKey("panelTitleBar")) this.Controls["panelTitleBar"].Visible = false;
            if (this.Controls.ContainsKey("panelStatus")) this.Controls["panelStatus"].Visible = false;

            panelM2_DanhSach.Dock = DockStyle.Fill;
            panelM2_DanhSach.BringToFront();
            panelM2_DanhSach.Visible = true;

            if (cboSortCriteria != null) cboSortCriteria.SelectedIndex = 0;
            if (cboSortAlgorithm != null) cboSortAlgorithm.SelectedIndex = 0;
            LoadDataToGrid();
        }

        private void btnPerformSort_Click(object sender, EventArgs e)
        {
            if (DataStore.DsTTB.Count == 0) return;

            // 1. Lấy khóa sắp xếp
            string key = "MaTTB";
            if (cboSortCriteria.SelectedIndex == 1) key = "Ten";
            else if (cboSortCriteria.SelectedIndex == 2) key = "SoLuong";
            else if (cboSortCriteria.SelectedIndex == 3) key = "ChungLoai";

            // 2. Lấy thuật toán và thực hiện (Tuần 1: Khung hàm)
            int algoIdx = cboSortAlgorithm.SelectedIndex;
            switch (algoIdx)
            {
                case 0: DataStore.DsTTB = ThuatToan.SelectionSort(DataStore.DsTTB, key, true); break;
                case 1: DataStore.DsTTB = ThuatToan.InsertionSort(DataStore.DsTTB, key, true); break;
                case 2: DataStore.DsTTB = ThuatToan.BubbleSort(DataStore.DsTTB, key, true); break;
                case 3: DataStore.DsTTB = ThuatToan.QuickSort(DataStore.DsTTB, key, true); break;
            }
            
            DataStore.IsSorted = true; // Đánh dấu đã sắp xếp
            
            // 3. Cập nhật lại Grid
            LoadDataToGrid();
            
            MessageBox.Show(string.Format("Đã sắp xếp bằng thuật toán: {0}", cboSortAlgorithm.SelectedItem), 
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadDataToGrid()
        {
            //dgvDanhSach.Rows.Clear();
            var list = DataStore.DsTTB;

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                dgvDanhSach.Rows.Add(
                    i + 1,
                    item.MaTTB,
                    item.Ten,
                    item.ChungLoai,
                    item.SoLuong,
                    item.Cap,
                    item.NgaySD.ToString("dd/MM/yyyy"),
                    item.GhiChu
                );
            }

            lblRecordCount.Text = list.Count + " bản ghi";
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelM2_DanhSach_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
