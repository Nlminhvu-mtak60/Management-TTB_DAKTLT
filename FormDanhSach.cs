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
            cboSortCriteria.SelectedIndex = 0;
        }

        private void FormDanhSach_Load(object sender, EventArgs e)
        {
            btnXoa.Visible = DataStore.CoQuyen("Xoa");
            btnSua.Visible = DataStore.CoQuyen("Sua");
            btnBaoDuong.Visible = DataStore.CoQuyen("BaoDuong");
            
            if (btnThungRac != null)
            {
                btnThungRac.Visible = DataStore.CoQuyen("Xoa");
            }
            LoadDataToGrid();
            if(cboSortCriteria != null) cboSortCriteria.SelectedIndex = 0;
            if(cboSortAlgorithm != null) cboSortAlgorithm.SelectedIndex = 0;
        }

        private void btnPerformSort_Click(object sender, EventArgs e)
        {
            if (DataStore.DsTTB.Count == 0) return;

            string key = "MaTTB";
            if (cboSortCriteria.SelectedIndex == 1) key = "Ten";
            if (cboSortCriteria.SelectedIndex == 2) key = "SoLuong";
            if (cboSortCriteria.SelectedIndex == 3) key = "ChungLoai";
            if (cboSortCriteria.SelectedIndex == 4) key = "Cap";


            int algoIdx = cboSortAlgorithm.SelectedIndex;

            switch (algoIdx)
            {
                case 0: DataStore.DsTTB = ThuatToan.SelectionSort(DataStore.DsTTB, key, false);
                    break;
                case 1: DataStore.DsTTB = ThuatToan.InsertionSort(DataStore.DsTTB, key, true);
                    break;
                case 2: DataStore.DsTTB = ThuatToan.BubbleSort(DataStore.DsTTB, key, true);
                    break;
                case 3: DataStore.DsTTB = ThuatToan.QuickSort(DataStore.DsTTB, key, true);
                    break;
                case 4: DataStore.DsTTB = ThuatToan.MergeSort(DataStore.DsTTB, key, true);
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

            int stt = 1;
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                if (item.IsDeleted) continue; // Bỏ qua thiết bị đã bị xóa mềm

                dgvDanhSach.Rows.Add(
                    stt++,
                    item.MaTTB,
                    item.SoHieu,
                    item.Ten,
                    item.ChungLoai,
                    item.NguonCap,
                    item.SoLuong,
                    item.Cap,
                    item.NgaySX.ToString("dd/MM/yyyy"),
                    item.NgaySD.ToString("dd/MM/yyyy"),
                    item.GhiChu,
                    item.NgayBaoDuongTiep.ToString("dd/MM/yyyy"),
                    item.TinhTrangHienTai()
                );
            }

            lblRecordCount.Text = (stt - 1) + " bản ghi";
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

            string maTTB = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
            int realIndex = DataStore.DsTTB.FindIndex(x => x.MaTTB == maTTB);
            if (realIndex < 0) return;

            FormThemMoi formSua = new FormThemMoi(realIndex);
            formSua.ShowDialog();

            LoadDataToGrid();
        }

        private void dgvDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DataStore.CoQuyen("Sua"))
            {
                string maTTB = dgvDanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                int realIndex = DataStore.DsTTB.FindIndex(x => x.MaTTB == maTTB);
                if (realIndex >= 0)
                {
                    FormThemMoi formSua = new FormThemMoi(realIndex);
                    formSua.ShowDialog();
                    LoadDataToGrid();
                }
            }
        }

        // Xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!DataStore.CoQuyen("Xoa"))
            {
                MessageBox.Show("Bạn không có quyền Xóa thiết bị!", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trang thiết bị để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa trang thiết bị này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string maTTB = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
                int realIndex = DataStore.DsTTB.FindIndex(x => x.MaTTB == maTTB);
                if (realIndex >= 0)
                {
                    DataStore.DsTTB[realIndex].IsDeleted = true; // Thực hiện Soft Delete
                    DataStore.SaveData();
                    LoadDataToGrid();
                    MessageBox.Show("Đã xóa thiết bị thành công (bạn có thể khôi phục trong Thùng Rác)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThungRac_Click(object sender, EventArgs e)
        {
            if (!DataStore.CoQuyen("Xoa"))
            {
                MessageBox.Show("Bạn không có quyền xem Thùng rác!", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormThungRac frm = new FormThungRac();
            frm.ShowDialog();

            // Load lại danh sách sau khi đóng thùng rác (trường hợp user khôi phục thiết bị)
            LoadDataToGrid();
        }

        private void btnBaoDuong_Click(object sender, EventArgs e)
        {
            if (!DataStore.CoQuyen("BaoDuong"))
            {
                MessageBox.Show("Bạn không có quyền cập nhật bảo dưỡng!", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trang thiết bị để cập nhật bảo dưỡng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maTTB = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
            int realIndex = DataStore.DsTTB.FindIndex(x => x.MaTTB == maTTB);
            if (realIndex < 0) return;

            FormBaoDuong frm = new FormBaoDuong(realIndex);
            frm.ShowDialog();

            LoadDataToGrid();
        }


    }
}

