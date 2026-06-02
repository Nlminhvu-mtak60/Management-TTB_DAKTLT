using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    public static class ThuatToan
    {
        //sắp xếp 

        //Selection Sort
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

        // Insertion Sort
        public static List<TrangThietBi> InsertionSort(List<TrangThietBi> data, string key, bool ascending)
        {
             List<TrangThietBi> list = new List<TrangThietBi>(data);
             int n = list.Count;

             for(int i = 1; i < n; i++)
             {
                TrangThietBi current = list[i];
                int j  = i - 1;

                while(j >= 0 && Compare(current,list[j], key,ascending))
                {
                    list[j+1] = list[j];
                    j--;
                }

                list[j+1] = current;
             }
             return list;
        }

        // Bubble Sort
        public static List<TrangThietBi> BubbleSort(List<TrangThietBi> data, string key, bool ascending)
        {
            List<TrangThietBi> list = new List<TrangThietBi>(data);
            int n = list.Count;

            for(int i = 0; i < n-1; i++)
            {
                    bool swapped = false;
                    for(int j = 0; j < n-1-i; j++)
                    {
                        if(Compare(list[j +1], list[j], key, ascending))
                        {
                            var temp = list[j];
                            list[j] = list[j + 1];
                            list[j+1] = temp;
                            swapped = true;
                        }
                    }
                if (!swapped) break;
            }
            
            
            return list;
        }

        //Tìm kiếm 

        // 1. Tìm kiếm tuần tự (Linear Search)
        public static List<TrangThietBi> LinearSearch(List<TrangThietBi> data, string key, string keyword)
        {
            List<TrangThietBi> result = new List<TrangThietBi>();
            foreach (var item in data)
            {
                
                string value = "";
                if (key == "MaTTB") value = item.MaTTB;
                else if (key == "Ten") value = item.Ten;
                

                // So sánh chính xác (không phân biệt hoa/thường)
                if (value != null && value.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // 2. Tìm kiếm nhị phân (Binary Search)
        public static List<TrangThietBi> BinarySearch(List<TrangThietBi> data, string key, string keyword)
        {
            List<TrangThietBi> result = new List<TrangThietBi>();

            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                string midValue = "";
                if (key == "MaTTB") midValue = data[mid].MaTTB;
                else if (key == "Ten") midValue = data[mid].Ten;
               

                int cmp = string.Compare(keyword, midValue, StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                {
                    result.Add(data[mid]);

                    int i = mid - 1;
                    while (i >= 0)
                    {
                        string val = "";
                        if (key == "MaTTB") val = data[i].MaTTB;
                        else if (key == "Ten") val = data[i].Ten;

                        if (string.Compare(keyword, val, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            result.Insert(0, data[i]);
                            i--;
                        }
                        else break;
                    }

                    
                    int j = mid + 1;
                    while (j < data.Count)
                    {
                        string val = "";
                        if (key == "MaTTB") val = data[j].MaTTB;
                        else if (key == "Ten") val = data[j].Ten;

                        if (string.Compare(keyword, val, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            result.Add(data[j]);
                            j++;
                        }
                        else break;
                    }

                    break;
                }
                else if (cmp < 0)
                {
                    
                    right = mid - 1;
                }
                else
                {
                    
                    left = mid + 1;
                }
            }

            return result;
        }

        // Hàm hỗ trợ so sánh dữ liệu
        private static bool Compare(TrangThietBi a, TrangThietBi b, string key, bool ascending)
        {
            int res = 0;
            if (key == "MaTTB") res = string.Compare(a.MaTTB, b.MaTTB);
            else if (key == "SoLuong") res = a.SoLuong.CompareTo(b.SoLuong);
            

            return ascending ? res < 0 : res > 0;
        }
    }
}
