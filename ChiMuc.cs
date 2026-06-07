using System;
using System.Collections.Generic;

namespace QUANLY_TTB
{
    /// <summary>
    /// Lớp lưu trữ cấu trúc chỉ mục dùng để serialize/deserialize ra file JSON.
    /// </summary>
    public class ChiMucData
    {
        public Dictionary<string, List<int>> MaTTB { get; set; }
        public Dictionary<string, List<int>> Ten { get; set; }
        public Dictionary<string, List<int>> ChungLoai { get; set; }
        public Dictionary<string, List<int>> NguonCap { get; set; }
    }

    /// <summary>
    /// Lớp ChiMuc (Index) - Xây dựng bảng tra cứu để tìm kiếm nhanh O(1)
    /// thay vì duyệt tuần tự O(n).
    /// 
    /// Hỗ trợ đánh chỉ mục cho mọi trường: MaTTB, Ten, ChungLoai, NguonCap.
    /// Mỗi trường có một Dictionary riêng, ánh xạ từ khóa → danh sách vị trí.
    /// </summary>
    public class ChiMuc
    {
        // Chỉ mục cho từng trường dữ liệu
        // Key = từ khóa (lowercase), Value = danh sách vị trí trong mảng gốc
        private Dictionary<string, List<int>> indexMaTTB;
        private Dictionary<string, List<int>> indexTen;
        private Dictionary<string, List<int>> indexChungLoai;
        private Dictionary<string, List<int>> indexNguonCap;

        // Tham chiếu đến danh sách dữ liệu gốc
        private List<TrangThietBi> danhSachGoc;

        public ChiMuc()
        {
            indexMaTTB = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
            indexTen = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
            indexChungLoai = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
            indexNguonCap = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
            danhSachGoc = new List<TrangThietBi>();
        }

        /// <summary>
        /// Xây dựng toàn bộ chỉ mục từ danh sách dữ liệu.
        /// Gọi mỗi khi dữ liệu thay đổi (thêm, sửa, xóa).
        /// </summary>
        public void XayDungChiMuc(List<TrangThietBi> dsTTB)
        {
            indexMaTTB.Clear();
            indexTen.Clear();
            indexChungLoai.Clear();
            indexNguonCap.Clear();
            danhSachGoc = dsTTB;

            for (int i = 0; i < dsTTB.Count; i++)
            {
                TrangThietBi ttb = dsTTB[i];
                if (ttb.IsDeleted) continue; // Bỏ qua thiết bị đã bị xóa mềm

                // Chỉ mục theo Mã TTB
                ThemVaoChiMuc(indexMaTTB, ttb.MaTTB, i, false);

                // Chỉ mục theo Tên (tách từ khóa)
                ThemVaoChiMuc(indexTen, ttb.Ten, i, true);

                // Chỉ mục theo Chủng loại
                ThemVaoChiMuc(indexChungLoai, ttb.ChungLoai, i, true);

                // Chỉ mục theo Nguồn cấp
                ThemVaoChiMuc(indexNguonCap, ttb.NguonCap, i, true);
            }
        }

        /// <summary>
        /// Thêm một giá trị vào chỉ mục.
        /// Nếu tachTu = true: tách chuỗi thành các từ riêng lẻ, mỗi từ là 1 key.
        /// Nếu tachTu = false: dùng nguyên chuỗi làm key.
        /// </summary>
        private void ThemVaoChiMuc(Dictionary<string, List<int>> index, string giaTriGoc, int viTri, bool tachTu)
        {
            if (string.IsNullOrEmpty(giaTriGoc)) return;

            string lower = giaTriGoc.ToLower().Trim();

            // Luôn thêm chuỗi đầy đủ làm key
            ThemKey(index, lower, viTri);

            // Nếu cần tách từ, thêm từng từ riêng lẻ
            if (tachTu)
            {
                string[] cacTu = lower.Split(
                    new char[] { ' ', ',', '.', ';', ':', '-', '_' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                for (int j = 0; j < cacTu.Length; j++)
                {
                    ThemKey(index, cacTu[j], viTri);
                }
            }
        }

        /// <summary>
        /// Thêm 1 key → vị trí vào Dictionary, tránh trùng lặp.
        /// </summary>
        private void ThemKey(Dictionary<string, List<int>> index, string key, int viTri)
        {
            if (!index.ContainsKey(key))
            {
                index[key] = new List<int>();
            }
            if (!index[key].Contains(viTri))
            {
                index[key].Add(viTri);
            }
        }

        /// <summary>
        /// Tìm kiếm bằng chỉ mục. Tra bảng Dictionary O(1) thay vì duyệt O(n).
        /// Hỗ trợ tìm theo: MaTTB, Ten, ChungLoai, NguonCap.
        /// </summary>
        public List<TrangThietBi> TimTheoChiMuc(string key, string keyword)
        {
            List<TrangThietBi> ketQua = new List<TrangThietBi>();
            if (string.IsNullOrEmpty(keyword) || danhSachGoc.Count == 0)
                return ketQua;

            // Chọn đúng bảng chỉ mục theo trường tìm kiếm
            Dictionary<string, List<int>> index;
            if (key == "MaTTB") index = indexMaTTB;
            else if (key == "Ten") index = indexTen;
            else if (key == "ChungLoai") index = indexChungLoai;
            else if (key == "NguonCap") index = indexNguonCap;
            else return ketQua;

            string keywordLower = keyword.ToLower().Trim();

            // Bước 1: Tìm khớp chính xác trong chỉ mục → O(1)
            if (index.ContainsKey(keywordLower))
            {
                List<int> viTriList = index[keywordLower];
                for (int i = 0; i < viTriList.Count; i++)
                {
                    ketQua.Add(danhSachGoc[viTriList[i]]);
                }
                return ketQua;
            }

            // Bước 2: Nếu không khớp chính xác, duyệt các key chứa từ khóa
            // Vẫn nhanh hơn duyệt dữ liệu gốc vì số key << số bản ghi
            HashSet<int> daThem = new HashSet<int>();
            foreach (var entry in index)
            {
                if (entry.Key.Contains(keywordLower))
                {
                    for (int i = 0; i < entry.Value.Count; i++)
                    {
                        int viTri = entry.Value[i];
                        if (!daThem.Contains(viTri))
                        {
                            daThem.Add(viTri);
                            ketQua.Add(danhSachGoc[viTri]);
                        }
                    }
                }
            }

            return ketQua;
        }

        /// <summary>
        /// Tìm kiếm TUẦN TỰ trên chỉ mục: duyệt lần lượt tất cả các key trong Dictionary.
        /// Vẫn dùng chỉ mục nhưng thuật toán duyệt key là tuần tự O(k), k = số key.
        /// </summary>
        public List<TrangThietBi> TimTuanTuChiMuc(string field, string keyword)
        {
            List<TrangThietBi> ketQua = new List<TrangThietBi>();
            if (string.IsNullOrEmpty(keyword) || danhSachGoc.Count == 0)
                return ketQua;

            Dictionary<string, List<int>> index = LayChiMuc(field);
            if (index == null) return ketQua;

            string keywordLower = keyword.ToLower().Trim();
            HashSet<int> daThem = new HashSet<int>();

            // Duyệt tuần tự từng key trong chỉ mục
            foreach (var entry in index)
            {
                // So sánh chính xác hoặc chứa từ khóa
                if (entry.Key.Equals(keywordLower, StringComparison.OrdinalIgnoreCase)
                    || entry.Key.Contains(keywordLower))
                {
                    for (int i = 0; i < entry.Value.Count; i++)
                    {
                        int viTri = entry.Value[i];
                        if (!daThem.Contains(viTri))
                        {
                            daThem.Add(viTri);
                            ketQua.Add(danhSachGoc[viTri]);
                        }
                    }
                }
            }

            return ketQua;
        }

        /// <summary>
        /// Tìm kiếm NHỊ PHÂN trên chỉ mục: sắp xếp các key rồi dùng Binary Search.
        /// Vẫn dùng chỉ mục nhưng thuật toán tìm key là nhị phân O(log k), k = số key.
        /// Chỉ tìm khớp chính xác (exact match).
        /// </summary>
        public List<TrangThietBi> TimNhiPhanChiMuc(string field, string keyword)
        {
            List<TrangThietBi> ketQua = new List<TrangThietBi>();
            if (string.IsNullOrEmpty(keyword) || danhSachGoc.Count == 0)
                return ketQua;

            Dictionary<string, List<int>> index = LayChiMuc(field);
            if (index == null) return ketQua;

            string keywordLower = keyword.ToLower().Trim();

            // Bước 1: Lấy danh sách key và sắp xếp
            List<string> sortedKeys = new List<string>(index.Keys);
            sortedKeys.Sort(StringComparer.OrdinalIgnoreCase);

            // Bước 2: Tìm nhị phân trên danh sách key đã sắp
            HashSet<int> daThem = new HashSet<int>();

            int left = 0;
            int right = sortedKeys.Count - 1;
            int foundIndex = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int cmp = string.Compare(keywordLower, sortedKeys[mid], StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                {
                    foundIndex = mid;
                    break;
                }
                else if (cmp < 0)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            // Nếu tìm thấy key khớp chính xác → lấy các vị trí từ chỉ mục
            if (foundIndex >= 0)
            {
                string foundKey = sortedKeys[foundIndex];
                List<int> viTriList = index[foundKey];
                for (int i = 0; i < viTriList.Count; i++)
                {
                    if (!daThem.Contains(viTriList[i]))
                    {
                        daThem.Add(viTriList[i]);
                        ketQua.Add(danhSachGoc[viTriList[i]]);
                    }
                }

                // Mở rộng sang trái tìm key trùng
                int k = foundIndex - 1;
                while (k >= 0 && string.Compare(keywordLower, sortedKeys[k], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    List<int> vt = index[sortedKeys[k]];
                    for (int i = 0; i < vt.Count; i++)
                    {
                        if (!daThem.Contains(vt[i]))
                        {
                            daThem.Add(vt[i]);
                            ketQua.Add(danhSachGoc[vt[i]]);
                        }
                    }
                    k--;
                }

                // Mở rộng sang phải tìm key trùng
                k = foundIndex + 1;
                while (k < sortedKeys.Count && string.Compare(keywordLower, sortedKeys[k], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    List<int> vt = index[sortedKeys[k]];
                    for (int i = 0; i < vt.Count; i++)
                    {
                        if (!daThem.Contains(vt[i]))
                        {
                            daThem.Add(vt[i]);
                            ketQua.Add(danhSachGoc[vt[i]]);
                        }
                    }
                    k++;
                }
            }
            else
            {
                // Không tìm thấy khớp chính xác → duyệt key chứa từ khóa (fallback)
                foreach (var entry in index)
                {
                    if (entry.Key.Contains(keywordLower))
                    {
                        for (int i = 0; i < entry.Value.Count; i++)
                        {
                            int viTri = entry.Value[i];
                            if (!daThem.Contains(viTri))
                            {
                                daThem.Add(viTri);
                                ketQua.Add(danhSachGoc[viTri]);
                            }
                        }
                    }
                }
            }

            return ketQua;
        }

        /// <summary>
        /// Lấy bảng chỉ mục theo tên trường.
        /// </summary>
        private Dictionary<string, List<int>> LayChiMuc(string field)
        {
            if (field == "MaTTB") return indexMaTTB;
            if (field == "Ten") return indexTen;
            if (field == "ChungLoai") return indexChungLoai;
            if (field == "NguonCap") return indexNguonCap;
            return null;
        }

        /// <summary>
        /// Xuất dữ liệu chỉ mục nội bộ ra đối tượng ChiMucData để lưu trữ.
        /// </summary>
        public ChiMucData ExportData()
        {
            return new ChiMucData
            {
                MaTTB = new Dictionary<string, List<int>>(this.indexMaTTB, StringComparer.OrdinalIgnoreCase),
                Ten = new Dictionary<string, List<int>>(this.indexTen, StringComparer.OrdinalIgnoreCase),
                ChungLoai = new Dictionary<string, List<int>>(this.indexChungLoai, StringComparer.OrdinalIgnoreCase),
                NguonCap = new Dictionary<string, List<int>>(this.indexNguonCap, StringComparer.OrdinalIgnoreCase)
            };
        }

        /// <summary>
        /// Nạp dữ liệu chỉ mục từ đối tượng ChiMucData đọc từ file JSON.
        /// Có null-check đầy đủ cho từng dictionary.
        /// </summary>
        public void ImportData(ChiMucData data, List<TrangThietBi> dsTTB)
        {
            this.danhSachGoc = dsTTB;
            
            if (data != null)
            {
                if (data.MaTTB != null) 
                    this.indexMaTTB = new Dictionary<string, List<int>>(data.MaTTB, StringComparer.OrdinalIgnoreCase);
                else 
                    this.indexMaTTB.Clear();

                if (data.Ten != null) 
                    this.indexTen = new Dictionary<string, List<int>>(data.Ten, StringComparer.OrdinalIgnoreCase);
                else 
                    this.indexTen.Clear();

                if (data.ChungLoai != null) 
                    this.indexChungLoai = new Dictionary<string, List<int>>(data.ChungLoai, StringComparer.OrdinalIgnoreCase);
                else 
                    this.indexChungLoai.Clear();

                if (data.NguonCap != null) 
                    this.indexNguonCap = new Dictionary<string, List<int>>(data.NguonCap, StringComparer.OrdinalIgnoreCase);
                else 
                    this.indexNguonCap.Clear();
            }
            else
            {
                // Nếu data null, xóa sạch chỉ mục
                this.indexMaTTB.Clear();
                this.indexTen.Clear();
                this.indexChungLoai.Clear();
                this.indexNguonCap.Clear();
            }
        }

        /// <summary>
        /// Thống kê số lượng key đã đánh chỉ mục cho từng trường.
        /// </summary>
        public int SoLuongChiMucMa { get { return indexMaTTB.Count; } }
        public int SoLuongChiMucTen { get { return indexTen.Count; } }
        public int SoLuongChiMucChungLoai { get { return indexChungLoai.Count; } }
        public int SoLuongChiMucNguonCap { get { return indexNguonCap.Count; } }
    }
}
