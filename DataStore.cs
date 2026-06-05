using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public static class DataStore
    {
        
        private static string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data.json");

        public static List<TrangThietBi> DsTTB = new List<TrangThietBi>();

        // Chỉ mục dữ liệu - xây dựng 1 lần, tra cứu O(1)
        public static ChiMuc ChiMuc = new ChiMuc();

        public static void LoadData()
        {
            DsTTB = FileHelper.LoadData(filePath);
            // Xây dựng chỉ mục ngay sau khi load dữ liệu
            ChiMuc.XayDungChiMuc(DsTTB);
        }

        public static void SaveData()
        {
            FileHelper.SaveData(filePath, DsTTB);
            // Xây dựng lại chỉ mục sau khi dữ liệu thay đổi
            ChiMuc.XayDungChiMuc(DsTTB);
        }

        public static bool IsSorted = false;
    }
}
