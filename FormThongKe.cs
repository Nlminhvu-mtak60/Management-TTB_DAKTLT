using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

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
            RenderThongKe();
        }

        private void RenderThongKe()
        {
            var list = new List<TrangThietBi>();
            for (int i = 0; i < DataStore.DsTTB.Count; i++)
            {
                if (!DataStore.DsTTB[i].IsDeleted)
                {
                    list.Add(DataStore.DsTTB[i]);
                }
            }
            
            // Tổng số lượng
            int tongSoLuong = 0;
            for (int i = 0; i < list.Count; i++)
            {
                tongSoLuong += list[i].SoLuong;
            }
            lblStatTotal.Text = tongSoLuong.ToString();

            // Số chủng loại
            List<string> dsChungLoai = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!dsChungLoai.Contains(list[i].ChungLoai))
                {
                    dsChungLoai.Add(list[i].ChungLoai);
                }
            }
            lblStatTypes.Text = dsChungLoai.Count.ToString();

            // Tổng bản ghi
            lblStatRecords.Text = list.Count + " bản ghi";

            Panel pnlNguon = panelChartNguon;

            // Danh sách nguồn cấp
            List<string> dsNguonCap = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!dsNguonCap.Contains(list[i].NguonCap))
                {
                    dsNguonCap.Add(list[i].NguonCap);
                }
            }

            // Vẽ biểu đồ
            VeBieuDoTheoChungLoai(list, dsChungLoai, tongSoLuong);
            VeBieuDoTheoCap(list, tongSoLuong);
            VeBieuDoTheoNguonCap(list, dsNguonCap, tongSoLuong, pnlNguon);
        }

        private void VeBieuDoTheoChungLoai(List<TrangThietBi> list, List<string> dsChungLoai, int tongSoLuong)
        {
            if (dsChungLoai.Count == 0 || tongSoLuong == 0) return;

            // Đếm số lượng
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            for (int i = 0; i < dsChungLoai.Count; i++) thongKe[dsChungLoai[i]] = 0;
            for (int i = 0; i < list.Count; i++) thongKe[list[i].ChungLoai] += list[i].SoLuong;

            // Chart
            chartLoai.Series[0].Points.Clear();
            chartLoai.Palette = ChartColorPalette.None;
            chartLoai.PaletteCustomColors = new Color[] {
                Color.FromArgb(61, 92, 58), Color.FromArgb(33, 115, 70), Color.FromArgb(52, 152, 100),
                Color.FromArgb(26, 82, 118), Color.FromArgb(125, 60, 60), Color.FromArgb(150, 100, 30)
            };

            foreach (var key in dsChungLoai)
            {
                chartLoai.Series[0].Points.AddXY(key, thongKe[key]);
            }

            // DataGridView
            dgvLoai.Rows.Clear();
            if (dgvLoai.Columns.Count == 0)
            {
                dgvLoai.Columns.Add("Ten", "Tên chủng loại");
                dgvLoai.Columns.Add("SL", "Số lượng");
                dgvLoai.Columns.Add("TiLe", "Tỉ lệ (%)");
            }

            foreach (var key in dsChungLoai)
            {
                int val = thongKe[key];
                double phanTram = tongSoLuong > 0 ? ((double)val / tongSoLuong) * 100 : 0;
                dgvLoai.Rows.Add(key, val, Math.Round(phanTram, 1) + "%");
            }
        }

        private void VeBieuDoTheoCap(List<TrangThietBi> list, int tongSoLuong)
        {
            if (tongSoLuong == 0) return;

            Dictionary<int, int> thongKe = new Dictionary<int, int>();
            List<int> dsCap = new List<int>();
            for (int c = 1; c <= 5; c++)
            {
                thongKe[c] = 0;
                dsCap.Add(c);
            }

            for (int i = 0; i < list.Count; i++)
            {
                int cap = list[i].Cap;
                if (cap >= 1 && cap <= 5)
                {
                    thongKe[cap] += list[i].SoLuong;
                }
            }

            // Chart
            chartCap.Series[0].Points.Clear();
            chartCap.Palette = ChartColorPalette.None;
            chartCap.PaletteCustomColors = new Color[] {
                Color.FromArgb(61, 92, 58), Color.FromArgb(33, 115, 70), Color.FromArgb(52, 152, 100),
                Color.FromArgb(26, 82, 118), Color.FromArgb(125, 60, 60), Color.FromArgb(150, 100, 30)
            };

            foreach (var cap in dsCap)
            {
                chartCap.Series[0].Points.AddXY("Cấp " + cap, thongKe[cap]);
            }

            // DataGridView
            dgvCap.Rows.Clear();
            if (dgvCap.Columns.Count == 0)
            {
                dgvCap.Columns.Add("Ten", "Tên cấp");
                dgvCap.Columns.Add("SL", "Số lượng");
                dgvCap.Columns.Add("TiLe", "Tỉ lệ (%)");
            }

            foreach (var cap in dsCap)
            {
                int val = thongKe[cap];
                double phanTram = tongSoLuong > 0 ? ((double)val / tongSoLuong) * 100 : 0;
                dgvCap.Rows.Add("Cấp " + cap, val, Math.Round(phanTram, 1) + "%");
            }
        }

        private void VeBieuDoTheoNguonCap(List<TrangThietBi> list, List<string> dsNguonCap, int tongSoLuong, Panel panelChartNguon)
        {
            if (dsNguonCap.Count == 0 || tongSoLuong == 0) return;

            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            for (int i = 0; i < dsNguonCap.Count; i++) thongKe[dsNguonCap[i]] = 0;
            for (int i = 0; i < list.Count; i++) thongKe[list[i].NguonCap] += list[i].SoLuong;

            // Chart
            chartNguon.Series[0].Points.Clear();
            chartNguon.Palette = ChartColorPalette.None;
            chartNguon.PaletteCustomColors = new Color[] {
                Color.FromArgb(61, 92, 58), Color.FromArgb(33, 115, 70), Color.FromArgb(52, 152, 100),
                Color.FromArgb(26, 82, 118), Color.FromArgb(125, 60, 60), Color.FromArgb(150, 100, 30)
            };

            foreach (var key in dsNguonCap)
            {
                chartNguon.Series[0].Points.AddXY(key, thongKe[key]);
            }

            // DataGridView
            dgvNguon.Rows.Clear();
            if (dgvNguon.Columns.Count == 0)
            {
                dgvNguon.Columns.Add("Ten", "Tên nguồn cấp");
                dgvNguon.Columns.Add("SL", "Số lượng");
                dgvNguon.Columns.Add("TiLe", "Tỉ lệ (%)");
            }

            foreach (var key in dsNguonCap)
            {
                int val = thongKe[key];
                double phanTram = tongSoLuong > 0 ? ((double)val / tongSoLuong) * 100 : 0;
                dgvNguon.Rows.Add(key, val, Math.Round(phanTram, 1) + "%");
            }
        }

        private void chartNguon_Click(object sender, EventArgs e)
        {

        }
    }
}