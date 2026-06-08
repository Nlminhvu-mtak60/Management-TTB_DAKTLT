using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public static class DataStore
    {
        
        private static string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data.json");
        private static string indexPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data_index.json");

        public static List<TrangThietBi> DsTTB = new List<TrangThietBi>();

        // Phân quyền người dùng
        public static NguoiDung NguoiDungHienTai = null;

        public static bool CoQuyen(string chucNang)
        {
            if (NguoiDungHienTai == null) return false;
            string vaiTro = NguoiDungHienTai.VaiTro;

            if (vaiTro == "ADMIN") return true;

            if (vaiTro == "MANAGER")
            {
                if (chucNang == "BaoDuong") return true;
                if (chucNang == "Xoa" || chucNang == "Backup" || chucNang == "Import" || chucNang == "QuanLyTaiKhoan")
                    return false;
                return true;
            }

            if (vaiTro == "VIEWER")
            {
                if (chucNang == "BaoDuong") return false;
                if (chucNang == "Xem" || chucNang == "TimKiem")
                    return true;
                return false;
            }

            return false;
        }

        // Chỉ mục dữ liệu - xây dựng 1 lần, tra cứu O(1)
        public static ChiMuc ChiMuc = new ChiMuc();

        public static void LoadData()
        {
            DsTTB = FileHelper.LoadData(filePath);
            
            // Kiểm tra data_index.json có tồn tại không
            if (System.IO.File.Exists(indexPath))
            {
                // CÓ: Đọc file và nạp chỉ mục, KHÔNG cần xây dựng lại
                ChiMucData data = FileHelper.LoadIndex(indexPath);
                if (data != null)
                {
                    ChiMuc.ImportData(data, DsTTB);
                }
                else
                {
                    // Lỗi đọc file thì tự phục hồi bằng cách xây lại
                    ChiMuc.XayDungChiMuc(DsTTB);
                    FileHelper.SaveIndex(indexPath, ChiMuc);
                }
            }
            else
            {
                // KHÔNG CÓ: Xây dựng chỉ mục lần đầu
                ChiMuc.XayDungChiMuc(DsTTB);
                // Tạo file data_index.json
                FileHelper.SaveIndex(indexPath, ChiMuc);
            }
        }

        public static void SaveData()
        {
            FileHelper.SaveData(filePath, DsTTB);
            
            // Xây dựng lại chỉ mục sau khi dữ liệu thay đổi
            ChiMuc.XayDungChiMuc(DsTTB);
            
            // Ghi đè file data_index.json mới
            FileHelper.SaveIndex(indexPath, ChiMuc);
        }

        public static bool IsSorted = false;
    }
}
