using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public static class DataStore
    {
        // Đường dẫn file dữ liệu (Sẽ nằm cùng thư mục với file .exe)
        private static string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
        private static string filePath1 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nhanvien.json");

        // Danh sách lưu trữ trong bộ nhớ (Dùng chung cho các Form)
        public static List<TrangThietBi> DsTTB = new List<TrangThietBi>();
        
        public static bool IsSorted = false; // Cờ đánh dấu đã sắp xếp hay chưa

        // Tuần 2: Cài đặt các hàm nạp và lưu dữ liệu
        public static void LoadData()
        {
            DsTTB = FileHelper.LoadData(filePath);
            DsNhanVien = FileHelper.LoadData(filePath1);
        }

        public static void SaveData()
        {
            FileHelper.SaveData(filePath, DsTTB);
        }
    }
}
