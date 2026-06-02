# 📌 Tuần 4 — Tìm Kiếm Dữ Liệu

> [!NOTE]
> Tài liệu này chỉ chứa phần **code bên trong** các khung hàm đã có sẵn.
> Bạn chỉ cần copy và paste vào đúng vị trí.

---

## 1. File: `FormTimKiem.cs`

### 1.1. Hàm `FormTimKiem_Load` — Thiết lập mặc định

```csharp
// PASTE VÀO BÊN TRONG: FormTimKiem_Load()

// Thiết lập mặc định cho ComboBox thuật toán tìm kiếm
if (cboSearchType != null) cboSearchType.SelectedIndex = 0;
// Thiết lập mặc định cho ComboBox khóa tìm kiếm
if (cboSearchKey != null) cboSearchKey.SelectedIndex = 0;
```

> **Giải thích:** Khi mở Form Tìm kiếm, tự động chọn sẵn:
> - `cboSearchType`: Mục đầu tiên = "Tìm tuần tự"
> - `cboSearchKey`: Mục đầu tiên = "Mã TTB"

---

### 1.2. Hàm `btnTim_Click` — Xử lý nút "Tìm"

```csharp
// PASTE VÀO BÊN TRONG: btnTim_Click()

// Bước 1: Lấy từ khóa người dùng nhập
string keyword = txtSearch.Text.Trim();
if (string.IsNullOrEmpty(keyword))
{
    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!",
        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return;
}

// Bước 2: Xác định khóa tìm kiếm (tìm theo trường nào)
string key = "MaTTB";
if (cboSearchKey.SelectedIndex == 1) key = "Ten";
else if (cboSearchKey.SelectedIndex == 2) key = "ChungLoai";

// Bước 3: Chọn thuật toán tìm kiếm
List<TrangThietBi> results;
if (cboSearchType.SelectedIndex == 0)
{
    // Tìm tuần tự — luôn dùng được, không cần sắp xếp trước
    results = ThuatToan.LinearSearch(DataStore.DsTTB, key, keyword);
}
else
{
    // Tìm nhị phân — CHỈ dùng được khi đã sắp xếp theo đúng khóa
    if (!DataStore.IsSorted)
    {
        MessageBox.Show(
            "Dữ liệu chưa được sắp xếp!\nVui lòng sắp xếp trước khi tìm nhị phân.",
            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }
    results = ThuatToan.BinarySearch(DataStore.DsTTB, key, keyword);
}

// Bước 4: Hiển thị kết quả lên bảng
dgvTimKiem.Rows.Clear();
for (int i = 0; i < results.Count; i++)
{
    var item = results[i];
    dgvTimKiem.Rows.Add(
        i + 1,
        item.MaTTB,
        item.Ten,
        item.ChungLoai,
        item.SoLuong,
        item.Cap
    );
}

// Bước 5: Hiện thông báo kết quả
lblSearchMessage.Text = string.Format(
    "Tìm thấy {0} kết quả cho \"{1}\" (Thuật toán: {2})",
    results.Count, keyword, cboSearchType.SelectedItem);
```

> **Giải thích từng bước:**
> - `txtSearch.Text.Trim()`: Lấy nội dung ô nhập và xóa khoảng trắng thừa.
> - `cboSearchKey.SelectedIndex`: Xác định tìm theo trường nào (0=Mã, 1=Tên, 2=Chủng loại).
> - `DataStore.IsSorted`: Kiểm tra cờ đánh dấu. Nếu chưa sắp xếp → không cho dùng nhị phân.
> - `dgvTimKiem`: Bảng DataGridView trên FormTimKiem để hiển thị kết quả tìm kiếm.

---

### 1.3. Hàm `btnXoaTim_Click` — Xử lý nút "Xóa tìm"

```csharp
// PASTE VÀO BÊN TRONG: btnXoaTim_Click()

// Xóa nội dung ô tìm kiếm
txtSearch.Text = "";

// Xóa kết quả trên bảng
dgvTimKiem.Rows.Clear();

// Đặt lại thông báo mặc định
lblSearchMessage.Text = "Nhập từ khóa và nhấn Tìm";
```

> **Giải thích:** Nút này dùng để đưa form tìm kiếm về trạng thái ban đầu (reset).

---

## 2. File: `ThuatToan.cs`

### 2.1. Hàm `LinearSearch` — Tìm kiếm tuần tự

```csharp
// THAY THẾ TOÀN BỘ code bên trong hàm LinearSearch()

List<TrangThietBi> result = new List<TrangThietBi>();
foreach (var item in data)
{
    // Lấy giá trị của trường cần tìm
    string value = "";
    if (key == "MaTTB") value = item.MaTTB;
    else if (key == "Ten") value = item.Ten;
    else if (key == "ChungLoai") value = item.ChungLoai;

    // So sánh: nếu giá trị CHỨA từ khóa (không phân biệt hoa/thường) → thêm vào kết quả
    if (value != null && value.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
    {
        result.Add(item);
    }
}
return result;
```

> **Giải thích thuật toán Linear Search (Tìm tuần tự):**
> - Duyệt qua **từng phần tử** trong danh sách, từ đầu đến cuối.
> - Với mỗi phần tử, lấy giá trị trường cần tìm và kiểm tra xem nó có chứa từ khóa hay không.
> - `IndexOf(..., OrdinalIgnoreCase)`: Tìm vị trí của từ khóa trong chuỗi, **không phân biệt chữ hoa/thường**. Trả về -1 nếu không tìm thấy.
> - **Ưu điểm:** Không cần sắp xếp trước, tìm được kết quả gần đúng (chứa từ khóa).
> - **Nhược điểm:** Chậm khi danh sách lớn (phải duyệt hết toàn bộ).

---

### 2.2. Hàm `BinarySearch` — Tìm kiếm nhị phân

```csharp
// THAY THẾ TOÀN BỘ code bên trong hàm BinarySearch()

List<TrangThietBi> result = new List<TrangThietBi>();

// Danh sách BẮT BUỘC phải được sắp xếp trước khi dùng nhị phân
int left = 0;
int right = data.Count - 1;

while (left <= right)
{
    // Tìm phần tử ở giữa
    int mid = (left + right) / 2;

    // Lấy giá trị trường cần tìm của phần tử giữa
    string midValue = "";
    if (key == "MaTTB") midValue = data[mid].MaTTB;
    else if (key == "Ten") midValue = data[mid].Ten;
    else if (key == "ChungLoai") midValue = data[mid].ChungLoai;

    // So sánh từ khóa với giá trị ở giữa
    int cmp = string.Compare(keyword, midValue, StringComparison.OrdinalIgnoreCase);

    if (cmp == 0)
    {
        // Tìm thấy! Thêm vào kết quả
        result.Add(data[mid]);

        // Mở rộng tìm các phần tử giống nhau ở bên trái
        int i = mid - 1;
        while (i >= 0)
        {
            string val = "";
            if (key == "MaTTB") val = data[i].MaTTB;
            else if (key == "Ten") val = data[i].Ten;
            else if (key == "ChungLoai") val = data[i].ChungLoai;

            if (string.Compare(keyword, val, StringComparison.OrdinalIgnoreCase) == 0)
            {
                result.Insert(0, data[i]);
                i--;
            }
            else break;
        }

        // Mở rộng tìm các phần tử giống nhau ở bên phải
        int j = mid + 1;
        while (j < data.Count)
        {
            string val = "";
            if (key == "MaTTB") val = data[j].MaTTB;
            else if (key == "Ten") val = data[j].Ten;
            else if (key == "ChungLoai") val = data[j].ChungLoai;

            if (string.Compare(keyword, val, StringComparison.OrdinalIgnoreCase) == 0)
            {
                result.Add(data[j]);
                j++;
            }
            else break;
        }

        break; // Đã tìm xong, thoát vòng lặp
    }
    else if (cmp < 0)
    {
        // Từ khóa NHỎ HƠN giá trị giữa → tìm ở nửa bên trái
        right = mid - 1;
    }
    else
    {
        // Từ khóa LỚN HƠN giá trị giữa → tìm ở nửa bên phải
        left = mid + 1;
    }
}

return result;
```

> **Giải thích thuật toán Binary Search (Tìm nhị phân):**
> - **Yêu cầu:** Danh sách PHẢI được sắp xếp trước (theo đúng khóa tìm kiếm).
> - Chia danh sách làm đôi, so sánh từ khóa với phần tử ở giữa:
>   - Nếu **bằng** → Tìm thấy! Mở rộng tìm thêm các phần tử trùng ở 2 bên.
>   - Nếu **nhỏ hơn** → Bỏ nửa phải, tìm tiếp ở nửa trái.
>   - Nếu **lớn hơn** → Bỏ nửa trái, tìm tiếp ở nửa phải.
> - **Ưu điểm:** Rất nhanh (O(log n)), mỗi lần loại bỏ được nửa danh sách.
> - **Nhược điểm:** Chỉ tìm chính xác (khớp hoàn toàn), phải sắp xếp trước.

---

## 3. Tóm Tắt Các File Cần Sửa

| File | Vị trí cần sửa | Nội dung |
|------|----------------|----------|
| `FormTimKiem.cs` | `FormTimKiem_Load()` | Thiết lập mặc định ComboBox |
| `FormTimKiem.cs` | `btnTim_Click()` | Logic xử lý nút Tìm kiếm |
| `FormTimKiem.cs` | `btnXoaTim_Click()` | Logic xử lý nút Xóa tìm |
| `ThuatToan.cs` | `LinearSearch()` | Thuật toán tìm kiếm tuần tự |
| `ThuatToan.cs` | `BinarySearch()` | Thuật toán tìm kiếm nhị phân |

## 4. Thứ Tự Thực Hiện Đề Xuất

> [!TIP]
> Nên làm theo thứ tự sau để test từng bước:

1. ✅ Viết `LinearSearch()` trong `ThuatToan.cs` (đơn giản hơn)
2. ✅ Viết `BinarySearch()` trong `ThuatToan.cs`
3. ✅ Viết `btnTim_Click()` trong `FormTimKiem.cs`
4. ✅ Viết `btnXoaTim_Click()` trong `FormTimKiem.cs`
5. ✅ Thêm thiết lập mặc định trong `FormTimKiem_Load()`
6. 🧪 Test tìm tuần tự trước (không cần sắp xếp)
7. 🧪 Sắp xếp dữ liệu (Tuần 3) rồi test tìm nhị phân

> [!IMPORTANT]
> **Lưu ý quan trọng về tìm nhị phân:**
> - Tìm nhị phân chỉ hoạt động khi dữ liệu đã sắp xếp theo đúng khóa tìm kiếm.
> - Ví dụ: Nếu muốn tìm nhị phân theo "Tên", phải sắp xếp theo "Tên" trước.
> - Biến `DataStore.IsSorted` được đặt = `true` khi sắp xếp ở Tuần 3.
