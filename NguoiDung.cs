using System;

namespace QUANLY_TTB
{
    public class NguoiDung
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }
        public string HoTen { get; set; }

        public NguoiDung() { }

        public NguoiDung(string tenDangNhap, string matKhau, string vaiTro, string hoTen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            VaiTro = vaiTro;
            HoTen = hoTen;
        }
    }
}
