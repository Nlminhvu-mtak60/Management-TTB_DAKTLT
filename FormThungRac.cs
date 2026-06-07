using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormThungRac : Form
    {
        public FormThungRac()
        {
            InitializeComponent();
        }

        private void FormThungRac_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            dgvThungRac.Rows.Clear();
            var list = DataStore.DsTTB;

            int stt = 1;
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                if (!item.IsDeleted) continue; // Chỉ hiển thị thiết bị ĐÃ BỊ XÓA

                dgvThungRac.Rows.Add(
                    stt++,
                    item.MaTTB,
                    item.Ten,
                    item.ChungLoai,
                    item.GhiChu,
                    item.TinhTrangHienTai()
                );
            }

            lblRecordCount.Text = (stt - 1) + " thiết bị trong thùng rác";
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dgvThungRac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trang thiết bị để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maTTB = dgvThungRac.SelectedRows[0].Cells[1].Value.ToString();
            int realIndex = DataStore.DsTTB.FindIndex(x => x.MaTTB == maTTB);
            if (realIndex >= 0)
            {
                DataStore.DsTTB[realIndex].IsDeleted = false; // Khôi phục lại
                DataStore.SaveData();
                LoadDataToGrid();
                MessageBox.Show("Đã khôi phục thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaVinhVien_Click(object sender, EventArgs e)
        {
            if (dgvThungRac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một trang thiết bị để xóa vĩnh viễn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "CẢNH BÁO: Hành động này sẽ xóa hoàn toàn thiết bị khỏi cơ sở dữ liệu và không thể khôi phục. Bạn có chắc chắn?",
                "Xác nhận Xóa Vĩnh Viễn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                string maTTB = dgvThungRac.SelectedRows[0].Cells[1].Value.ToString();
                int realIndex = DataStore.DsTTB.FindIndex(x => x.MaTTB == maTTB);
                if (realIndex >= 0)
                {
                    DataStore.DsTTB.RemoveAt(realIndex); // Hard Delete
                    DataStore.SaveData();
                    LoadDataToGrid();
                    MessageBox.Show("Đã xóa thiết bị vĩnh viễn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
