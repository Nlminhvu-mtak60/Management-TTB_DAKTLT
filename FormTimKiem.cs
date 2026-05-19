using System;
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

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("panelSidebar")) this.Controls["panelSidebar"].Visible = false;
            if (this.Controls.ContainsKey("panelToolbar")) this.Controls["panelToolbar"].Visible = false;
            if (this.Controls.ContainsKey("panelTitleBar")) this.Controls["panelTitleBar"].Visible = false;
            if (this.Controls.ContainsKey("panelStatus")) this.Controls["panelStatus"].Visible = false;

            panelM4_TimKiem.Dock = DockStyle.Fill;
            if (cboSearchType != null) cboSearchType.SelectedIndex = 0;
            if (cboSearchKey != null) cboSearchKey.SelectedIndex = 1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSearchType.SelectedIndex == 1 && !DataStore.IsSorted)
            {
                MessageBox.Show("Cảnh báo: Bạn chưa sắp xếp dữ liệu. Theo yêu cầu, phải sắp xếp mới được tìm kiếm nhị phân. Vui lòng sử dụng tìm kiếm tuần tự hoặc qua mục Danh sách để sắp xếp trước!", 
                    "Yêu cầu hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSearchType.SelectedIndex = 0; // Tự động chuyển về tìm tuần tự
                return;
            }

            MessageBox.Show(string.Format("Đang tìm kiếm bằng thuật toán: {0} (Sẽ hoàn thiện ở Tuần 4)", 
                cboSearchType.SelectedItem), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaTim_Click(object sender, EventArgs e)
        {
            if (txtSearch != null) txtSearch.Clear();
            dgvTimKiem.Rows.Clear();
        }

        private void panelM4_TimKiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
