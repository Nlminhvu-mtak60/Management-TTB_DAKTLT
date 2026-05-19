using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public static class ThuatToan
    {
        // --- CÁC THUẬT TOÁN SẮP XẾP ---

        // 1. Sắp xếp chọn (Selection Sort)
        public static List<TrangThietBi> SelectionSort(List<TrangThietBi> data, string key, bool ascending)
        {
            List<TrangThietBi> list = new List<TrangThietBi>(data);
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Compare(list[j], list[minIdx], key, ascending)) minIdx = j;
                }
                var temp = list[minIdx];
                list[minIdx] = list[i];
                list[i] = temp;
            }
            return list;
        }

        // 2. Sắp xếp chèn (Insertion Sort) - Khung chương trình
        public static List<TrangThietBi> InsertionSort(List<TrangThietBi> data, string key, bool ascending)
        {
            
            return SelectionSort(data, key, ascending); 
        }

        // 3. Sắp xếp nổi bọt (Bubble Sort) - Khung chương trình
        public static List<TrangThietBi> BubbleSort(List<TrangThietBi> data, string key, bool ascending)
        {
            
            return SelectionSort(data, key, ascending);
        }

        // 4. Sắp xếp nhanh (QuickSort) - Khung chương trình
        public static List<TrangThietBi> QuickSort(List<TrangThietBi> data, string key, bool ascending)
        {
            
            return SelectionSort(data, key, ascending);
        }

        // --- CÁC THUẬT TOÁN TÌM KIẾM ---

        // 1. Tìm kiếm tuần tự (Linear Search)
        public static List<TrangThietBi> LinearSearch(List<TrangThietBi> data, string key, string keyword)
        {
            List<TrangThietBi> result = new List<TrangThietBi>();
            foreach (var item in data)
            {
                
            }
            return result;
        }

        // 2. Tìm kiếm nhị phân (Binary Search) - Khung chương trình
        public static List<TrangThietBi> BinarySearch(List<TrangThietBi> data, string key, string keyword)
        {
            
            return new List<TrangThietBi>();
        }

        // Hàm hỗ trợ so sánh dữ liệu
        private static bool Compare(TrangThietBi a, TrangThietBi b, string key, bool ascending)
        {
            int res = 0;
            if (key == "MaTTB") res = string.Compare(a.MaTTB, b.MaTTB);
            else if (key == "Ten") res = string.Compare(a.Ten, b.Ten);
    

            return ascending ? res < 0 : res > 0;
        }
    }
}
