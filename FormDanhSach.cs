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
            LoadDataToGrid();
            if(cboSortCriteria != null) cboSortCriteria.SelectedIndex = 0;
            if(cboSortAlgorithm != null) cboSortAlgorithm.SelectedIndex = 0;
        }

        private void btnPerformSort_Click(object sender, EventArgs e)
        {
            if (DataStore.DsTTB.Count == 0) return;

            string key = "MaTTB";
            if (cboSortCriteria.SelectedIndex == 1) key = "SoLuong";

            int algoIdx = cboSortAlgorithm.SelectedIndex;

            switch (algoIdx)
            {
                case 0: DataStore.DsTTB = ThuatToan.SelectionSort(DataStore.DsTTB, key, false);
                    break;
                case 1: DataStore.DsTTB = ThuatToan.InsertionSort(DataStore.DsTTB, key, true);
                    break;
                case 2: DataStore.DsTTB = ThuatToan.BubbleSort(DataStore.DsTTB, key, true);
                    break;
            }

            DataStore.IsSorted = true;
            LoadDataToGrid();  
            MessageBox.Show(
                string.Format("Đã sắp xếp bằng thuật toán: {0}", cboSortAlgorithm.SelectedItem),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            ); 
        }

        

       

        public void LoadDataToGrid()
        {
            dgvDanhSach.Rows.Clear();
            var list = DataStore.DsTTB;

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                dgvDanhSach.Rows.Add(
                    i + 1,
                    item.MaTTB,
                    item.SoHieu,
                    item.Ten,
                    item.ChungLoai,
                    item.NguonCap,
                    item.SoLuong,
                    item.Cap,
                    item.NgaySX.ToString("dd/MM/yyyy"),
                    item.NgaySD.ToString("dd/MM/yyyy"),
                    item.GhiChu
                );
            }

            lblRecordCount.Text = list.Count + " bản ghi";
        }

        //Sửa 
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dgvDanhSach.SelectedRows[0].Index;
            if (rowIndex < 0 || rowIndex >= DataStore.DsTTB.Count) return;

            FormThemMoi formSua = new FormThemMoi(rowIndex);
            formSua.ShowDialog();

            LoadDataToGrid();
        }

        // Xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy chỉ số dòng đang chọn
            int rowIndex = dgvDanhSach.SelectedRows[0].Index;
            if (rowIndex < 0 || rowIndex >= DataStore.DsTTB.Count) return;

            // Lấy tên TTB để hiển thị trong hộp thoại xác nhận
            string tenTTB = DataStore.DsTTB[rowIndex].Ten;

            // Hỏi xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show(
                string.Format("Bạn có chắc chắn muốn xóa:\n\"{0}\"?", tenTTB),
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Xóa phần tử khỏi danh sách
                DataStore.DsTTB.RemoveAt(rowIndex);

                // Lưu lại file
                DataStore.SaveData();

                // Cập nhật lại bảng
                LoadDataToGrid();

                MessageBox.Show("Đã xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelM2_DanhSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboSortCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelM2_DanhSach_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelM2_DanhSach_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}

