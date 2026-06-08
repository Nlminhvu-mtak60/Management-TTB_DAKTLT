using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Text;
using System.IO;

namespace QUANLY_TTB
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            this.Load += FormThongKe_Load;
            
            if (btnXemTruoc != null) btnXemTruoc.Click += btnXemTruoc_Click;
            if (btnXuatTXT != null) btnXuatTXT.Click += btnXuatTXT_Click;
            if (btnXuatCSV != null) btnXuatCSV.Click += btnXuatCSV_Click;
            if (rb_BaoCaoTong != null) rb_BaoCaoTong.CheckedChanged += (s, e) => { if(rb_BaoCaoTong.Checked) btnXemTruoc_Click(null, null); };
            if (rb_BaoCaoBD != null) rb_BaoCaoBD.CheckedChanged += (s, e) => { if(rb_BaoCaoBD.Checked) btnXemTruoc_Click(null, null); };
            if (rb_BaoCaoThanhLy != null) rb_BaoCaoThanhLy.CheckedChanged += (s, e) => { if(rb_BaoCaoThanhLy.Checked) btnXemTruoc_Click(null, null); };
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            RenderThongKe();
            // Default load preview
            if (rb_BaoCaoTong != null) rb_BaoCaoTong.Checked = true;
            btnXemTruoc_Click(null, null);
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

            // Vẽ biểu đồ cũ
            VeBieuDoTheoChungLoai(list, dsChungLoai, tongSoLuong);
            VeBieuDoTheoCap(list, tongSoLuong);
            VeBieuDoTheoNguonCap(list, dsNguonCap, tongSoLuong, pnlNguon);

            // TÍNH TOÁN 3 CARD MỚI (Lọc nghiêm ngặt)
            int countQuaHan = 0;
            int countCanBD = 0;
            int countDangSuaChua = 0;

            foreach (var ttb in list)
            {
                if (ttb.TinhTrang == null || ttb.NgayBaoDuongTiep <= DateTime.MinValue) continue;
                
                string tt = ttb.TinhTrangHienTai();
                if (tt == "Quá hạn bảo dưỡng") countQuaHan++;
                else if (tt == "Cần bảo dưỡng") countCanBD++;
                
                if (ttb.TinhTrang == "Đang sửa chữa") countDangSuaChua++;
            }

            if (lblStatQHBaoDuong != null) lblStatQHBaoDuong.Text = countQuaHan.ToString();
            if (lblStatCanBaoDuong != null) lblStatCanBaoDuong.Text = countCanBD.ToString();
            if (lblStatDangSuaChua != null) lblStatDangSuaChua.Text = countDangSuaChua.ToString();

            // Vẽ biểu đồ mới
            VeBieuDoTinhTrangBaoDuong(list);
            // VeBieuDoTinhTrangSuDung(list, tongSoLuong);
            // VeBieuDoTheoThoiGian(list);
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

        private void VeBieuDoTinhTrangBaoDuong(List<TrangThietBi> list)
        {
            if (chartTinhTrangBD == null || dgvTinhTrangBD == null) return;

            if (list.Count == 0)
            {
                chartTinhTrangBD.Visible = false;
                dgvTinhTrangBD.Visible = false;
                Label lblEmpty = new Label { Text = "Không có dữ liệu thiết bị.", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
                panelChartTinhTrangBD.Controls.Add(lblEmpty);
                lblEmpty.BringToFront();
                return;
            }

            string[] tinhTrangKeys = { "Tốt", "Cần bảo dưỡng", "Quá hạn bảo dưỡng", "Đang sửa chữa", "Thanh lý" };
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            foreach (var k in tinhTrangKeys) thongKe[k] = 0;

            foreach (var ttb in list)
            {
                if (ttb.TinhTrang == null || ttb.NgayBaoDuongTiep <= DateTime.MinValue) continue;
                string tt = ttb.TinhTrangHienTai();
                if (thongKe.ContainsKey(tt)) thongKe[tt]++;
            }

            // Chart (Trục Y = số bản ghi)
            chartTinhTrangBD.Series[0].Points.Clear();
            chartTinhTrangBD.Palette = ChartColorPalette.None;
            chartTinhTrangBD.PaletteCustomColors = new Color[] {
                Color.FromArgb(61, 92, 58),
                Color.FromArgb(200, 160, 40),
                Color.FromArgb(200, 100, 40),
                Color.FromArgb(160, 50, 50),
                Color.FromArgb(120, 120, 120)
            };

            foreach (var k in tinhTrangKeys)
            {
                chartTinhTrangBD.Series[0].Points.AddXY(k, thongKe[k]);
            }

            // DataGridView (Chỉ không Tốt)
            dgvTinhTrangBD.Rows.Clear();
            if (dgvTinhTrangBD.Columns.Count == 0)
            {
                dgvTinhTrangBD.Columns.Add("STT", "STT");
                dgvTinhTrangBD.Columns.Add("MaTTB", "Mã TTB");
                dgvTinhTrangBD.Columns.Add("TenTTB", "Tên TTB");
                dgvTinhTrangBD.Columns.Add("NgayBD", "Ngày BD tiếp theo");
                dgvTinhTrangBD.Columns.Add("ConLai", "Số ngày còn lại");
                dgvTinhTrangBD.Columns.Add("TinhTrang", "Tình trạng");
            }

            var dsCanChuY = list.Where(t => t.TinhTrang != null && t.NgayBaoDuongTiep > DateTime.MinValue && t.TinhTrangHienTai() != "Tốt").ToList();
            var sortedList = dsCanChuY.OrderBy(t => {
                string tt = t.TinhTrangHienTai();
                if (tt == "Quá hạn bảo dưỡng") return 1;
                if (tt == "Cần bảo dưỡng") return 2;
                if (tt == "Đang sửa chữa") return 3;
                return 4;
            }).ToList();

            int stt = 1;
            foreach (var ttb in sortedList)
            {
                string tt = ttb.TinhTrangHienTai();
                int soNgayConLai = (int)(ttb.NgayBaoDuongTiep.Date - DateTime.Now.Date).TotalDays;
                
                string formatNgay = soNgayConLai == 0 ? "Hôm nay" : (soNgayConLai > 0 ? $"Còn {soNgayConLai} ngày" : $"Quá {-soNgayConLai} ngày");

                int rowIndex = dgvTinhTrangBD.Rows.Add(stt++, ttb.MaTTB, ttb.Ten, ttb.NgayBaoDuongTiep.ToString("dd/MM/yyyy"), formatNgay, tt);
                
                DataGridViewRow row = dgvTinhTrangBD.Rows[rowIndex];
                if (tt == "Quá hạn bảo dưỡng") row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                else if (tt == "Cần bảo dưỡng") row.DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 200);
                else if (tt == "Đang sửa chữa") row.DefaultCellStyle.BackColor = Color.FromArgb(230, 220, 255);
                else if (tt == "Thanh lý") row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            }
        }



        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            if (txtPreview == null) return;
            txtPreview.Text = VeBaoCaoTongHop();
        }

        private string VeBaoCaoTongHop()
        {
            var list = DataStore.DsTTB.Where(t => !t.IsDeleted && t.TinhTrang != null).ToList();
            StringBuilder sb = new StringBuilder();
            
            string nguoiXuat = DataStore.NguoiDungHienTai != null ? DataStore.NguoiDungHienTai.TenDangNhap : "Unknown";
            string dateStr = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            if (rb_BaoCaoTong.Checked)
            {
                int tongSL = list.Sum(t => t.SoLuong);
                var dsChungLoai = list.GroupBy(t => t.ChungLoai).ToList();
                var dsCap = list.GroupBy(t => t.Cap).OrderBy(g => g.Key).ToList();
                
                int quaHan = list.Count(t => t.TinhTrangHienTai() == "Quá hạn bảo dưỡng");
                int canBD = list.Count(t => t.TinhTrangHienTai() == "Cần bảo dưỡng");
                int dangSC = list.Count(t => t.TinhTrang == "Đang sửa chữa");

                sb.AppendLine("════════════════════════════════════════════");
                sb.AppendLine("BÁO CÁO TRANG THIẾT BỊ");
                sb.AppendLine($"Ngày xuất  : {dateStr}");
                sb.AppendLine($"Người xuất : {nguoiXuat}");
                sb.AppendLine("════════════════════════════════════════════");
                sb.AppendLine("TỔNG QUAN:");
                sb.AppendLine($"Tổng số bản ghi    : {list.Count}");
                sb.AppendLine($"Tổng số lượng      : {tongSL}");
                sb.AppendLine($"Số chủng loại      : {dsChungLoai.Count}");
                sb.AppendLine("────────────────────────────────────────────");
                sb.AppendLine("THEO CHỦNG LOẠI:");
                foreach (var g in dsChungLoai)
                {
                    int sl = g.Sum(x => x.SoLuong);
                    double pt = tongSL > 0 ? ((double)sl / tongSL) * 100 : 0;
                    sb.AppendLine($"{g.Key,-18} : {sl} ({pt:0.0}%)");
                }
                sb.AppendLine("────────────────────────────────────────────");
                sb.AppendLine("THEO CẤP TRANG BỊ:");
                foreach (var g in dsCap)
                {
                    int sl = g.Sum(x => x.SoLuong);
                    double pt = tongSL > 0 ? ((double)sl / tongSL) * 100 : 0;
                    sb.AppendLine($"Cấp {g.Key,-14} : {sl} ({pt:0.0}%)");
                }
                sb.AppendLine("────────────────────────────────────────────");
                sb.AppendLine("TÌNH TRẠNG BẢO DƯỠNG:");
                sb.AppendLine($"Quá hạn bảo dưỡng  : {quaHan} thiết bị");
                sb.AppendLine($"Sắp đến hạn (30 ngày): {canBD} thiết bị");
                sb.AppendLine($"Đang sửa chữa      : {dangSC} thiết bị");
                sb.AppendLine("════════════════════════════════════════════");
            }
            else if (rb_BaoCaoBD.Checked || rb_BaoCaoThanhLy.Checked)
            {
                string type = rb_BaoCaoBD.Checked ? "CẦN BẢO DƯỠNG" : "THANH LÝ";
                sb.AppendLine("════════════════════════════════════════════");
                sb.AppendLine($"DANH SÁCH THIẾT BỊ {type}");
                sb.AppendLine($"Ngày xuất: {dateStr}");
                sb.AppendLine("════════════════════════════════════════════");
                sb.AppendLine("STT | Mã TTB  | Tên TTB          | Ngày BD    | Còn lại     | Tình trạng");
                sb.AppendLine("────┼─────────┼──────────────────┼────────────┼─────────────┼──────────────────");

                var dsFilter = list.Where(t => rb_BaoCaoBD.Checked 
                                          ? (t.TinhTrangHienTai() == "Quá hạn bảo dưỡng" || t.TinhTrangHienTai() == "Cần bảo dưỡng")
                                          : t.TinhTrangHienTai() == "Thanh lý").ToList();

                int stt = 1;
                foreach (var ttb in dsFilter)
                {
                    string tt = ttb.TinhTrangHienTai();
                    int conLai = (int)(ttb.NgayBaoDuongTiep.Date - DateTime.Now.Date).TotalDays;
                    string conLaiStr = conLai == 0 ? "Hôm nay" : (conLai > 0 ? $"Còn {conLai} ngày" : $"Quá {-conLai} ngày");
                    
                    string ma = ttb.MaTTB.PadRight(7);
                    string ten = ttb.Ten.Length > 16 ? ttb.Ten.Substring(0, 13) + "..." : ttb.Ten.PadRight(16);
                    string ngayBD = ttb.NgayBaoDuongTiep.ToString("dd/MM/yyyy").PadRight(8);
                    conLaiStr = conLaiStr.PadRight(10);
                    
                    sb.AppendLine($"{stt,-3} | {ma} | {ten} | {ngayBD} | {conLaiStr} | {tt}");
                    stt++;
                }
                sb.AppendLine("════════════════════════════════════════════");
                sb.AppendLine($"Tổng: {dsFilter.Count} thiết bị cần xử lý");
            }

            return sb.ToString();
        }

        private void btnXuatTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            sfd.Title = "Lưu báo cáo TXT";
            sfd.FileName = $"BaoCao_TTB_{DateTime.Now:yyyyMMdd}.txt";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, VeBaoCaoTongHop(), Encoding.UTF8);
                MessageBox.Show("Xuất file TXT thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File|*.csv";
            sfd.Title = "Lưu báo cáo CSV";
            sfd.FileName = $"BaoCao_TTB_{DateTime.Now:yyyyMMdd}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var list = DataStore.DsTTB.Where(t => !t.IsDeleted && t.TinhTrang != null).ToList();
                StringBuilder sb = new StringBuilder();

                // Dùng UTF-8 có BOM để Excel mở không lỗi font tiếng Việt
                byte[] bom = new byte[] { 0xEF, 0xBB, 0xBF };

                if (rb_BaoCaoTong.Checked)
                {
                    sb.AppendLine("BaoCaoTongHop");
                    sb.AppendLine("ChungLoai,SoLuong");
                    var dsChungLoai = list.GroupBy(t => t.ChungLoai).ToList();
                    foreach (var g in dsChungLoai) sb.AppendLine($"\"{g.Key}\",{g.Sum(x => x.SoLuong)}");
                }
                else
                {
                    var dsFilter = list.Where(t => rb_BaoCaoBD.Checked 
                                              ? (t.TinhTrangHienTai() == "Quá hạn bảo dưỡng" || t.TinhTrangHienTai() == "Cần bảo dưỡng")
                                              : t.TinhTrangHienTai() == "Thanh lý").ToList();

                    sb.AppendLine("MaTTB,TenTTB,NgayBDTiep,SoNgayConLai,TinhTrang");
                    foreach (var ttb in dsFilter)
                    {
                        int conLai = (int)(ttb.NgayBaoDuongTiep.Date - DateTime.Now.Date).TotalDays;
                        string conLaiStr = conLai == 0 ? "Hôm nay" : (conLai > 0 ? $"Còn {conLai} ngày" : $"Quá {-conLai} ngày");
                        sb.AppendLine($"\"{ttb.MaTTB}\",\"{ttb.Ten}\",{ttb.NgayBaoDuongTiep:dd/MM/yyyy},\"{conLaiStr}\",\"{ttb.TinhTrangHienTai()}\"");
                    }
                }
                
                using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(bom, 0, bom.Length);
                    byte[] data = Encoding.UTF8.GetBytes(sb.ToString());
                    fs.Write(data, 0, data.Length);
                }
                MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}