using System;
using System.Globalization;

namespace QUANLY_TTB
{
    public class TrangThietBi
    {
        public string MaTTB { get; set; }
        public string SoHieu { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime NgaySD { get; set; }
        public string NguonCap { get; set; }
        public int SoLuong { get; set; }
        public string ChungLoai { get; set; }
        public int Cap { get; set; }
        public string GhiChu { get; set; }

        public DateTime NgayBaoDuongCuoi { get; set; } = DateTime.MinValue;
        public DateTime NgayBaoDuongTiep { get; set; } = DateTime.MinValue;
        public int ChuKyBaoDuong { get; set; } = 0;
        public string TinhTrang { get; set; } = null;
        public string LichSuBaoDuong { get; set; } = "";
        public bool IsDeleted { get; set; } = false;

        public TrangThietBi() { }

        public string TinhTrangHienTai()
        {
            // Xử lý dữ liệu cũ (Backward compatibility)
            // Nếu ChuKyBaoDuong == 0 (do data.json cũ không có), gán mặc định
            if (ChuKyBaoDuong <= 0)
            {
                ChuKyBaoDuong = 6;
                NgayBaoDuongCuoi = NgaySD;
                NgayBaoDuongTiep = NgaySD.AddMonths(ChuKyBaoDuong);
                TinhTrang = "Tốt";
            }

            // Nếu đang sửa chữa hoặc thanh lý thì giữ nguyên không đổi
            if (TinhTrang == "Đang sửa chữa" || TinhTrang == "Thanh lý")
            {
                return TinhTrang;
            }

            TimeSpan timeToMaintenance = NgayBaoDuongTiep - DateTime.Now;

            if (timeToMaintenance.TotalDays < 0)
            {
                return "Quá hạn bảo dưỡng";
            }
            else if (timeToMaintenance.TotalDays <= 30)
            {
                return "Cần bảo dưỡng";
            }
            else
            {
                return "Tốt";
            }
        }
    }
}
