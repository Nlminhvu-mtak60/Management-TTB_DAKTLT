using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public static class DataStore
    {
        
        private static string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data.json");

        public static List<TrangThietBi> DsTTB = new List<TrangThietBi>();


        public static void LoadData()
        {
            DsTTB = FileHelper.LoadData(filePath);
           
        }

        public static void SaveData()
        {
            FileHelper.SaveData(filePath, DsTTB);
        }

        public static bool IsSorted = false;
    }
}
