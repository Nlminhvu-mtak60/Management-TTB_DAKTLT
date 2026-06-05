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

        // Quick Sort
        public static List<TrangThietBi> QuickSort(List<TrangThietBi> data, string key, bool ascending)
        {
            List<TrangThietBi> list = new List<TrangThietBi>(data);
            QuickSortHelper(list, 0, list.Count - 1, key, ascending);
            return list;
        }
        // Ham de quy
        private static void QuickSortHelper(List<TrangThietBi> list, int low, int high, string key,bool ascending)
        {
            if(low >= high) return;
            
            int pivotIndex = Partition(list, low, high, key, ascending);
            QuickSortHelper(list, low, pivotIndex -1, key, ascending);
            QuickSortHelper(list, pivotIndex + 1, high, key, ascending);
            
        }
        // Ham Phan Hoach
        private static int Partition(List<TrangThietBi> list, int low, int high, string key, bool ascending)
        {
            TrangThietBi pivot = list[high];
            int i = low -1;
            for(int j = low; j < high; j ++)
            {
                if(Compare(list[j], pivot, key, ascending))
                {
                    i++;
                    var temp = list[j];
                    list[j] = list[i];
                    list[i] = temp;
                }
            }
            i++;
            var temp2 = list[i];
            list[i] = list[high];
            list[high] = temp2;

            return i;
        }

        // MergeSort

        public static List<TrangThietBi> MergeSort(List<TrangThietBi> data, string key, bool ascending)
        {
            List<TrangThietBi> list = new List<TrangThietBi>(data);
            if (list.Count <= 1) return list;

            return MergeSortHelper(list, key, ascending);
        }
        // De quy + gop

        private static List<TrangThietBi> MergeSortHelper(List<TrangThietBi> list, string key, bool ascending)
        {
            if(list.Count <= 1) return list;
            // chia doi ds
            int mid = list.Count / 2;
            List<TrangThietBi> left = list.GetRange(0, mid);
            List<TrangThietBi> right = list.GetRange(mid, list.Count - mid);
            // de quy sort tung dua
            left = MergeSortHelper(left, key, ascending);
            right = MergeSortHelper(right, key, ascending);
            // Gop 2 nua da sap xep
            return Merge(left, right, key, ascending);

        }
        // Gop 2 ds da sap xep
        private static List<TrangThietBi> Merge (List<TrangThietBi> left, List<TrangThietBi> right, string key, bool ascending)
        {
            List<TrangThietBi> result = new List<TrangThietBi>();
            int i = 0, j = 0;
            while (i < left.Count && j < right.Count)
            {
                if(Compare(left[i], right[j], key, ascending))
                result.Add(left[i++]);
                else
                result.Add(right[j++]);
                
            }
            // Them phan tu con du cua moi nua
            while(i < left.Count) result.Add(left[i++]);
            while(j < right.Count) result.Add(right[j++]);

            return result;
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
                

                // Tìm kiếm gần đúng 
                if(value != null && value.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
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
            else if (key == "Ten") res = string.Compare(a.Ten, b.Ten);
            else if (key == "SoLuong") res = a.SoLuong.CompareTo(b.SoLuong);
            else if (key == "ChungLoai") res = string.Compare(a.ChungLoai, b.ChungLoai);
            else if (key == "Cap") res = a.Cap.CompareTo(b.Cap);

            return ascending ? res > 0 : res < 0;
        }
    }
}
