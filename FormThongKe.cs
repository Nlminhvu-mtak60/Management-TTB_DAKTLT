using System;
using System.Windows.Forms;

namespace QUANLY_TTB
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            this.Load += FormThongKe_Load;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("panelSidebar")) this.Controls["panelSidebar"].Visible = false;
            if (this.Controls.ContainsKey("panelToolbar")) this.Controls["panelToolbar"].Visible = false;
            if (this.Controls.ContainsKey("panelTitleBar")) this.Controls["panelTitleBar"].Visible = false;
            if (this.Controls.ContainsKey("panelStatus")) this.Controls["panelStatus"].Visible = false;

            panelM5_ThongKe.Dock = DockStyle.Fill;
            panelM5_ThongKe.BringToFront();
            panelM5_ThongKe.Visible = true;

            lblStatTotal.Text = "—";
            lblStatTypes.Text = "—";
            lblStatRecords.Text = "—";
        }

        private void RenderThongKe()
        {
        }
    }
}
