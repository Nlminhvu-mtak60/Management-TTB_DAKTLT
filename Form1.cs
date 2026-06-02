using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataStore.LoadData();
            OpenChildForm(new FormThemMoi());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            childForm.Show();
            
            lblStatusLeft.Text = "Đang xem: " + childForm.Text;
        }

        private void btnNav_ThemMoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemMoi() { Text = "Thêm mới" });
        }

        private void btnNav_DanhSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSach() { Text = "Danh sách" });
        }

        private void btnNav_TimKiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTimKiem() { Text = "Tìm kiếm" });
        }

        private void btnNav_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe() { Text = "Thống kê" });
        }

        private void btnNav_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
