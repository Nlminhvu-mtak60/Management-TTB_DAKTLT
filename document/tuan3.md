# 📌 Tuần 3 — Sắp Xếp Dữ Liệu

> [!NOTE]
> Tài liệu này chỉ chứa phần **code bên trong** các khung hàm đã có sẵn. Bạn chỉ cần copy và paste vào đúng vị trí.

---

## 1. File: `FormDanhSach.cs`

### 1.1. Hàm `FormDanhSach_Load` — Thêm thiết lập mặc định cho ComboBox

```csharp
// PASTE VÀO BÊN TRONG: FormDanhSach_Load()
// (Đặt TRƯỚC dòng LoadDataToGrid();)

if (cboSortCriteria != null) cboSortCriteria.SelectedIndex = 0;
if (cboSortAlgorithm != null) cboSortAlgorithm.SelectedIndex = 0;
```

> **Giải thích:** Khi mở Form lên, tự động chọn sẵn mục đầu tiên cho 2 ô chọn "Tiêu chí" và "Thuật toán" để tránh lỗi nếu người dùng bấm Sắp xếp mà chưa chọn gì.

---

### 1.2. Hàm `btnPerformSort_Click` — Xử lý nút "Sắp xếp"

```csharp
// PASTE VÀO BÊN TRONG: btnPerformSort_Click()

// Kiểm tra: Nếu danh sách trống thì dừng, không cần sắp xếp
if (DataStore.DsTTB.Count == 0) return;

// Bước 1: Xác định tiêu chí sắp xếp dựa trên lựa chọn của người dùng
string key = "MaTTB"; // Mặc định sắp xếp theo Mã TTB
if (cboSortCriteria.SelectedIndex == 1) key = "Ten";
else if (cboSortCriteria.SelectedIndex == 2) key = "SoLuong";
else if (cboSortCriteria.SelectedIndex == 3) key = "ChungLoai";

// Bước 2: Gọi thuật toán sắp xếp tương ứng
int algoIdx = cboSortAlgorithm.SelectedIndex;
switch (algoIdx)
{
    case 0: DataStore.DsTTB = ThuatToan.SelectionSort(DataStore.DsTTB, key, true); break;
    case 1: DataStore.DsTTB = ThuatToan.InsertionSort(DataStore.DsTTB, key, true); break;
    case 2: DataStore.DsTTB = ThuatToan.BubbleSort(DataStore.DsTTB, key, true); break;
    case 3: DataStore.DsTTB = ThuatToan.QuickSort(DataStore.DsTTB, key, true); break;
}

// Bước 3: Đánh dấu dữ liệu đã được sắp xếp (dùng cho Tuần 4 - Tìm kiếm nhị phân)
DataStore.IsSorted = true;

// Bước 4: Cập nhật lại bảng hiển thị
LoadDataToGrid();

// Bước 5: Hiện thông báo cho người dùng biết
MessageBox.Show(
    string.Format("Đã sắp xếp bằng thuật toán: {0}", cboSortAlgorithm.SelectedItem),
    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
```

> **Giải thích từng bước:**
> - `cboSortCriteria.SelectedIndex`: Lấy vị trí mục đang chọn trong ô "Tiêu chí" (0 = Mã, 1 = Tên, 2 = Số lượng, 3 = Chủng loại).
> - `switch (algoIdx)`: Dựa vào ô "Thuật toán" đang chọn mục nào → gọi hàm sắp xếp tương ứng.
> - `ascending = true`: Sắp xếp tăng dần (A→Z, nhỏ→lớn).

---

## 2. File: `ThuatToan.cs`

### 2.1. Hàm `Compare` — Bổ sung so sánh theo SoLuong và ChungLoai

Hàm `Compare` hiện tại chỉ so sánh được theo `MaTTB` và `Ten`. Cần bổ sung thêm 2 tiêu chí nữa:

```csharp
// THAY THẾ TOÀN BỘ hàm Compare() hiện tại

private static bool Compare(TrangThietBi a, TrangThietBi b, string key, bool ascending)
{
    int res = 0;
    if (key == "MaTTB") res = string.Compare(a.MaTTB, b.MaTTB);
    else if (key == "Ten") res = string.Compare(a.Ten, b.Ten);
    else if (key == "SoLuong") res = a.SoLuong.CompareTo(b.SoLuong);
    else if (key == "ChungLoai") res = string.Compare(a.ChungLoai, b.ChungLoai);

    return ascending ? res < 0 : res > 0;
}
```

> **Giải thích:**
> - `string.Compare(a, b)`: So sánh 2 chuỗi theo thứ tự bảng chữ cái. Trả về số âm nếu a < b, 0 nếu bằng, số dương nếu a > b.
> - `a.SoLuong.CompareTo(b.SoLuong)`: So sánh 2 số nguyên. Tương tự như trên nhưng dành cho kiểu `int`.

---

### 2.2. Hàm `InsertionSort` — Sắp xếp chèn

```csharp
// THAY THẾ TOÀN BỘ code bên trong hàm InsertionSort()

List<TrangThietBi> list = new List<TrangThietBi>(data);
int n = list.Count;

for (int i = 1; i < n; i++)
{
    // Lấy phần tử hiện tại ra làm "chìa khóa"
    TrangThietBi current = list[i];
    int j = i - 1;

    // Dịch các phần tử lớn hơn "chìa khóa" sang phải 1 vị trí
    while (j >= 0 && Compare(current, list[j], key, ascending))
    {
        list[j + 1] = list[j];
        j--;
    }

    // Chèn "chìa khóa" vào đúng vị trí
    list[j + 1] = current;
}

return list;
```

> **Giải thích thuật toán Insertion Sort:**
> - Duyệt từ phần tử thứ 2 đến cuối danh sách.
> - Với mỗi phần tử, rút nó ra, so sánh ngược lại với các phần tử phía trước.
> - Dịch các phần tử lớn hơn sang phải, rồi chèn phần tử hiện tại vào đúng chỗ.
> - Giống như cách bạn xếp bài trên tay: rút 1 lá, tìm vị trí đúng rồi chèn vào.

---

### 2.3. Hàm `BubbleSort` — Sắp xếp nổi bọt

```csharp
// THAY THẾ TOÀN BỘ code bên trong hàm BubbleSort()

List<TrangThietBi> list = new List<TrangThietBi>(data);
int n = list.Count;

for (int i = 0; i < n - 1; i++)
{
    bool swapped = false;

    // So sánh từng cặp phần tử kề nhau
    for (int j = 0; j < n - 1 - i; j++)
    {
        // Nếu phần tử sau "nhỏ hơn" phần tử trước → đổi chỗ
        if (Compare(list[j + 1], list[j], key, ascending))
        {
            var temp = list[j];
            list[j] = list[j + 1];
            list[j + 1] = temp;
            swapped = true;
        }
    }

    // Nếu không có lần đổi chỗ nào → danh sách đã sắp xếp xong → dừng sớm
    if (!swapped) break;
}

return list;
```

> **Giải thích thuật toán Bubble Sort:**
> - Lặp đi lặp lại việc so sánh 2 phần tử kề nhau và đổi chỗ nếu sai thứ tự.
> - Sau mỗi lượt, phần tử lớn nhất sẽ "nổi lên" cuối danh sách (giống bọt nước nổi lên mặt nước).
> - Biến `swapped`: Nếu 1 lượt mà không đổi chỗ lần nào → danh sách đã đúng thứ tự → dừng luôn cho nhanh.

---

### 2.4. Hàm `QuickSort` — Sắp xếp nhanh

Quick Sort phức tạp hơn vì cần thêm 1 hàm phụ (đệ quy). Bạn cần viết 2 phần:

**Phần A — Hàm chính `QuickSort`:**

```csharp
// THAY THẾ TOÀN BỘ code bên trong hàm QuickSort()

List<TrangThietBi> list = new List<TrangThietBi>(data);
QuickSortHelper(list, 0, list.Count - 1, key, ascending);
return list;
```

**Phần B — Thêm hàm phụ `QuickSortHelper` (đặt ngay bên dưới hàm QuickSort):**

```csharp
// THÊM MỚI hàm này vào class ThuatToan (đặt sau hàm QuickSort)

private static void QuickSortHelper(List<TrangThietBi> list, int low, int high, string key, bool ascending)
{
    if (low < high)
    {
        // Bước 1: Chọn phần tử chốt (pivot) và phân hoạch danh sách
        int pivotIndex = Partition(list, low, high, key, ascending);

        // Bước 2: Đệ quy sắp xếp nửa bên trái (các phần tử nhỏ hơn pivot)
        QuickSortHelper(list, low, pivotIndex - 1, key, ascending);

        // Bước 3: Đệ quy sắp xếp nửa bên phải (các phần tử lớn hơn pivot)
        QuickSortHelper(list, pivotIndex + 1, high, key, ascending);
    }
}

private static int Partition(List<TrangThietBi> list, int low, int high, string key, bool ascending)
{
    // Chọn phần tử cuối cùng làm chốt (pivot)
    TrangThietBi pivot = list[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        // Nếu phần tử hiện tại "nhỏ hơn" pivot → đưa nó sang vùng bên trái
        if (Compare(list[j], pivot, key, ascending))
        {
            i++;
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    // Đặt pivot vào đúng vị trí giữa
    var temp2 = list[i + 1];
    list[i + 1] = list[high];
    list[high] = temp2;

    return i + 1; // Trả về vị trí của pivot
}
```

> **Giải thích thuật toán Quick Sort:**
> - Chọn 1 phần tử làm "chốt" (pivot).
> - Phân hoạch: Đưa tất cả phần tử nhỏ hơn pivot sang trái, lớn hơn sang phải.
> - Đệ quy: Lặp lại quá trình trên cho nửa trái và nửa phải.
> - Đây là thuật toán sắp xếp **nhanh nhất** trong 4 thuật toán (trung bình O(n log n)).

---

## 3. Tóm Tắt Các File Cần Sửa

| File | Vị trí cần sửa | Nội dung |
|------|----------------|----------|
| `FormDanhSach.cs` | `FormDanhSach_Load()` | Thêm 2 dòng thiết lập mặc định ComboBox |
| `FormDanhSach.cs` | `btnPerformSort_Click()` | Thêm toàn bộ logic xử lý nút Sắp xếp |
| `ThuatToan.cs` | `Compare()` | Bổ sung so sánh theo SoLuong và ChungLoai |
| `ThuatToan.cs` | `InsertionSort()` | Viết code thuật toán Insertion Sort |
| `ThuatToan.cs` | `BubbleSort()` | Viết code thuật toán Bubble Sort |
| `ThuatToan.cs` | `QuickSort()` | Viết code thuật toán Quick Sort |
| `ThuatToan.cs` | *(Thêm mới)* | Thêm 2 hàm phụ `QuickSortHelper()` và `Partition()` |

## 4. Thứ Tự Thực Hiện Đề Xuất

> [!TIP]
> Nên làm theo thứ tự sau để test từng bước, tránh lỗi chồng lỗi:

1. ✅ Sửa hàm `Compare()` trước (vì tất cả thuật toán đều phụ thuộc vào nó)
2. ✅ Viết code cho `InsertionSort()` (đơn giản nhất)
3. ✅ Viết code cho `BubbleSort()`
4. ✅ Viết code cho `QuickSort()` + thêm 2 hàm phụ (phức tạp nhất)
5. ✅ Viết code cho `btnPerformSort_Click()` trong `FormDanhSach.cs`
6. ✅ Thêm 2 dòng thiết lập ComboBox trong `FormDanhSach_Load()`
7. 🧪 Chạy thử và test từng thuật toán
