# 📋 BÁO CÁO TUẦN 3 — CÀI ĐẶT CÁC THUẬT TOÁN SẮP XẾP

> **Dự án:** Quản lý Trang Thiết Bị (QUANLY_TTB)  
> **Tuần:** 3  
> **Nội dung:** Thực hiện các thuật toán sắp xếp  

---

## 📌 1. Yêu Cầu Tuần 3

Theo đề bài (Nội dung 3 - Cài đặt các thuật toán sắp xếp):

| STT | Yêu cầu | Trạng thái |
|-----|---------|------------|
| 1 | Thực hiện các thuật toán sắp xếp: Chọn (Selection Sort), Chèn (Insertion Sort), Nổi bọt (Bubble Sort), Nhanh (Quick Sort) | ✅ Hoàn thành |
| 2 | Cho phép người dùng lựa chọn thuật toán sắp xếp qua giao diện | ✅ Hoàn thành |
| 3 | Cho phép người dùng lựa chọn khóa sắp xếp (Mã TTB, Tên, Số lượng, Chủng loại) | ⚠️ Hoàn thành một phần |
| 4 | In danh sách sau khi sắp xếp | ✅ Hoàn thành |
| 5 | Hàm Compare hỗ trợ so sánh đầy đủ các tiêu chí | ⚠️ Chưa hoàn thành |
| 6 | Thiết lập mặc định ComboBox khi mở Form | ✅ Hoàn thành |
| 7 | Đánh dấu `DataStore.IsSorted` sau khi sắp xếp | ⚠️ Đã comment (chưa kích hoạt) |

---

## 📂 2. Chi Tiết Từng Phần Đã Làm

---

### 2.1. File `ThuatToan.cs` — Các thuật toán sắp xếp

📍 **Đường dẫn:** `QUANLY_TTB\ThuatToan.cs`

#### ✅ 2.1.1. Selection Sort (Sắp xếp Chọn) — Dòng 11–27

```csharp
public static List<TrangThietBi> SelectionSort(List<TrangThietBi> data, string key, bool ascending)
```

- **Trạng thái:** ✅ Đã hoàn thành đầy đủ (có sẵn từ tuần trước)
- **Mô tả:** Duyệt danh sách, tìm phần tử nhỏ nhất rồi đổi chỗ với phần tử đầu. Lặp lại cho phần còn lại.
- **Độ phức tạp:** O(n²)

---

#### ✅ 2.1.2. Insertion Sort (Sắp xếp Chèn) — Dòng 30–49

```csharp
public static List<TrangThietBi> InsertionSort(List<TrangThietBi> data, string key, bool ascending)
```

- **Trạng thái:** ✅ Đã hoàn thành đầy đủ
- **Mô tả:** Rút từng phần tử ra, so sánh ngược với các phần tử phía trước, dịch các phần tử lớn hơn sang phải rồi chèn vào đúng vị trí.
- **Chi tiết code:**
  - Tạo bản sao danh sách `new List<TrangThietBi>(data)` để không ảnh hưởng dữ liệu gốc
  - Duyệt từ `i = 1` đến hết
  - Dùng vòng `while` dịch phần tử lớn hơn sang phải
  - Chèn phần tử `current` vào vị trí `j + 1`

---

#### ✅ 2.1.3. Bubble Sort (Sắp xếp Nổi bọt) — Dòng 52–75

```csharp
public static List<TrangThietBi> BubbleSort(List<TrangThietBi> data, string key, bool ascending)
```

- **Trạng thái:** ✅ Đã hoàn thành đầy đủ
- **Mô tả:** So sánh từng cặp phần tử kề nhau, đổi chỗ nếu sai thứ tự. Có tối ưu bằng biến `swapped` để dừng sớm khi đã sắp xếp xong.
- **Chi tiết code:**
  - Vòng ngoài `i`: từ 0 đến n-2
  - Vòng trong `j`: từ 0 đến n-2-i (phần tử cuối đã đúng chỗ)
  - Biến `swapped`: nếu không đổi chỗ lần nào → `break` sớm
  - Đổi chỗ bằng biến `temp`

---

#### ✅ 2.1.4. Quick Sort (Sắp xếp Nhanh) — Dòng 78–115

```csharp
public static List<TrangThietBi> QuickSort(List<TrangThietBi> data, string key, bool ascending)
```

- **Trạng thái:** ✅ Đã hoàn thành đầy đủ (gồm 3 hàm)
- **Mô tả:** Chọn phần tử cuối làm chốt (pivot), phân hoạch danh sách thành 2 nửa, đệ quy sắp xếp từng nửa.
- **Các hàm liên quan:**

| Hàm | Dòng | Vai trò |
|-----|------|---------|
| `QuickSort()` | 78–83 | Hàm chính, tạo bản sao và gọi helper |
| `QuickSortHelper()` | 85–93 | Hàm đệ quy, phân hoạch và gọi lại 2 nửa |
| `Partition()` | 95–115 | Phân hoạch: đưa phần tử < pivot sang trái, > pivot sang phải |

- **Độ phức tạp:** Trung bình O(n log n), tệ nhất O(n²)

---

#### ⚠️ 2.1.5. Hàm `Compare()` — Dòng 137–144

```csharp
private static bool Compare(TrangThietBi a, TrangThietBi b, string key, bool ascending)
```

- **Trạng thái:** ⚠️ **CHƯA HOÀN THÀNH** — Thiếu 2 tiêu chí so sánh
- **Hiện tại chỉ hỗ trợ:**
  - `"MaTTB"` → `string.Compare(a.MaTTB, b.MaTTB)` ✅
  - `"Ten"` → `string.Compare(a.Ten, b.Ten)` ✅
- **Còn thiếu:**
  - `"SoLuong"` → `a.SoLuong.CompareTo(b.SoLuong)` ❌
  - `"ChungLoai"` → `string.Compare(a.ChungLoai, b.ChungLoai)` ❌

> **Hậu quả:** Khi người dùng chọn sắp xếp theo "Số lượng" hoặc "Chủng loại", kết quả sẽ không thay đổi (vì `res` luôn = 0).

---

### 2.2. File `FormDanhSach.cs` — Giao diện sắp xếp

📍 **Đường dẫn:** `QUANLY_TTB\FormDanhSach.cs`

#### ✅ 2.2.1. Hàm `FormDanhSach_Load()` — Dòng 14–19

```csharp
private void FormDanhSach_Load(object sender, EventArgs e)
{
    LoadDataToGrid();
    if(cboSortCriteria != null) cboSortCriteria.SelectedIndex = 0;
    if(cboSortAlgorithm != null) cboSortAlgorithm.SelectedIndex = 0;
}
```

- **Trạng thái:** ✅ Hoàn thành
- **Mô tả:** Khi mở form, tự động chọn mục đầu tiên cho cả 2 ComboBox (Tiêu chí + Thuật toán).
- **Lưu ý:** Thứ tự hơi khác so với tài liệu hướng dẫn — `LoadDataToGrid()` được gọi **trước** khi set ComboBox, trong khi tài liệu yêu cầu set ComboBox **trước**. Tuy nhiên không ảnh hưởng chức năng.

---

#### ✅ 2.2.2. Hàm `btnPerformSort_Click()` — Dòng 21–52

```csharp
private void btnPerformSort_Click(object sender, EventArgs e)
```

- **Trạng thái:** ✅ Hoàn thành (có 1 điểm cần sửa nhỏ)
- **Luồng xử lý:**
  1. Kiểm tra danh sách trống → return
  2. Xác định khóa sắp xếp từ `cboSortCriteria.SelectedIndex` (0=MaTTB, 1=Ten, 2=SoLuong, 3=ChungLoai)
  3. Gọi thuật toán tương ứng từ `cboSortAlgorithm.SelectedIndex` (0=Selection, 1=Insertion, 2=Bubble, 3=Quick)
  4. Cập nhật bảng `LoadDataToGrid()`
  5. Hiện `MessageBox` thông báo

- **⚠️ Điểm cần lưu ý:**
  - **Dòng 44:** `DataStore.IsSorted = true;` đang bị **comment** → chưa đánh dấu trạng thái đã sắp xếp. Điều này sẽ ảnh hưởng đến Tuần 4 khi cần kiểm tra để chọn tìm kiếm nhị phân.

---

### 2.3. File `FormDanhSach.Designer.cs` — Giao diện ComboBox

📍 **Đường dẫn:** `QUANLY_TTB\FormDanhSach.Designer.cs`

#### ⚠️ 2.3.1. ComboBox `cboSortCriteria` — Dòng 135–146

- **Trạng thái:** ⚠️ **Chỉ có 2 mục**, thiếu 2 mục
- **Hiện tại:**
  ```
  Items: "Theo Mã TTB", "Theo Tên"
  ```
- **Cần thêm:**
  ```
  Items: "Theo Mã TTB", "Theo Tên", "Theo Số lượng", "Theo Chủng loại"
  ```

#### ✅ 2.3.2. ComboBox `cboSortAlgorithm` — Dòng 120–133

- **Trạng thái:** ✅ Đầy đủ 4 mục
- **Items:**
  ```
  "Sắp xếp Chọn", "Sắp xếp Chèn", "Sắp xếp Nổi bọt", "Sắp xếp Nhanh"
  ```

#### ✅ 2.3.3. Nút `btnPerformSort` — Dòng 106–118

- **Trạng thái:** ✅ Đã có nút "Sắp xếp" và đã gắn sự kiện `Click`

---

### 2.4. Các File Hỗ Trợ (Từ tuần trước, vẫn hoạt động tốt)

| File | Chức năng | Trạng thái |
|------|-----------|------------|
| `TrangThietBi.cs` | Cấu trúc dữ liệu trang thiết bị (10 thuộc tính) | ✅ OK |
| `DataStore.cs` | Quản lý danh sách chung + đọc/ghi file + cờ `IsSorted` | ✅ OK |
| `FileHelper.cs` | Đọc/ghi file JSON bằng Newtonsoft.Json | ✅ OK |
| `Form1.cs` | Form chính, menu điều hướng 5 chức năng | ✅ OK |
| `data.json` | Dữ liệu mẫu | ✅ OK |

---

## 📊 3. Tổng Kết Tiến Độ

### ✅ Đã hoàn thành (5/7 hạng mục):

| # | Hạng mục | File | Vị trí |
|---|----------|------|--------|
| 1 | Thuật toán Selection Sort | `ThuatToan.cs` | Dòng 11–27 |
| 2 | Thuật toán Insertion Sort | `ThuatToan.cs` | Dòng 30–49 |
| 3 | Thuật toán Bubble Sort | `ThuatToan.cs` | Dòng 52–75 |
| 4 | Thuật toán Quick Sort + QuickSortHelper + Partition | `ThuatToan.cs` | Dòng 78–115 |
| 5 | Xử lý nút "Sắp xếp" (btnPerformSort_Click) | `FormDanhSach.cs` | Dòng 21–52 |
| 6 | Thiết lập mặc định ComboBox | `FormDanhSach.cs` | Dòng 14–19 |
| 7 | Giao diện chọn thuật toán (4 mục) | `FormDanhSach.Designer.cs` | Dòng 120–133 |

### ⚠️ Cần sửa/bổ sung (3 điểm):

| # | Vấn đề | File | Chi tiết |
|---|--------|------|----------|
| 1 | Hàm `Compare()` thiếu so sánh `SoLuong` và `ChungLoai` | `ThuatToan.cs` dòng 137–144 | Cần thêm 2 dòng `else if` cho `SoLuong` và `ChungLoai` |
| 2 | ComboBox `cboSortCriteria` chỉ có 2 mục (thiếu "Theo Số lượng", "Theo Chủng loại") | `FormDanhSach.Designer.cs` dòng 140–142 | Cần thêm 2 items vào ComboBox |
| 3 | `DataStore.IsSorted = true` bị comment | `FormDanhSach.cs` dòng 44 | Cần bỏ comment `//` để kích hoạt (chuẩn bị cho Tuần 4) |

---

## 🔧 4. Hướng Dẫn Sửa Nhanh

### Sửa 1: Bổ sung hàm `Compare()` trong `ThuatToan.cs` (dòng 137–144)

**Thay thế từ:**
```csharp
private static bool Compare(TrangThietBi a, TrangThietBi b, string key, bool ascending)
{
    int res = 0;
    if (key == "MaTTB") res = string.Compare(a.MaTTB, b.MaTTB);
    else if (key == "Ten") res = string.Compare(a.Ten, b.Ten);

    return ascending ? res < 0 : res > 0;
}
```

**Thành:**
```csharp
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

---

### Sửa 2: Thêm items vào `cboSortCriteria` trong `FormDanhSach.Designer.cs` (dòng 140–142)

**Thay thế từ:**
```csharp
this.cboSortCriteria.Items.AddRange(new object[] {
    "Theo Mã TTB",
    "Theo Tên"});
```

**Thành:**
```csharp
this.cboSortCriteria.Items.AddRange(new object[] {
    "Theo Mã TTB",
    "Theo Tên",
    "Theo Số lượng",
    "Theo Chủng loại"});
```

---

### Sửa 3: Bỏ comment `DataStore.IsSorted` trong `FormDanhSach.cs` (dòng 44)

**Thay thế từ:**
```csharp
// DataStore.IsSorted = true;
```

**Thành:**
```csharp
DataStore.IsSorted = true;
```

---

## 📈 5. Đánh Giá Chung

| Tiêu chí | Đánh giá |
|----------|----------|
| Hoàn thành 4 thuật toán sắp xếp | ✅ Đầy đủ và đúng logic |
| Giao diện chọn thuật toán | ✅ Có ComboBox + nút Sắp xếp |
| Giao diện chọn khóa sắp xếp | ⚠️ Thiếu 2 tiêu chí (SoLuong, ChungLoai) |
| In danh sách sau sắp xếp | ✅ Có LoadDataToGrid() + MessageBox |
| Hàm so sánh đa tiêu chí | ⚠️ Thiếu 2 tiêu chí |
| Chuẩn bị cho Tuần 4 (IsSorted) | ⚠️ Đã comment |

> **Kết luận:** Đã hoàn thành phần lớn yêu cầu Tuần 3. Chỉ cần sửa **3 điểm nhỏ** (bổ sung hàm Compare, thêm items ComboBox, bỏ comment IsSorted) là đạt 100%.
