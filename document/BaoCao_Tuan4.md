# 📋 BÁO CÁO TUẦN 4 — TÌM KIẾM DỮ LIỆU

> **Dự án:** Quản lý Trang Thiết Bị (QUANLY_TTB)  
> **Tuần:** 4  
> **Nội dung:** Thực hiện thuật toán tìm kiếm (đã tùy chỉnh theo yêu cầu: Chỉ tìm chính xác theo Mã TTB)

---

## 📌 1. Yêu Cầu Tuần 4 & Tùy Chỉnh

Theo đề bài gốc: Thực hiện thuật toán tìm kiếm tuần tự và nhị phân, cho phép chọn khóa tìm kiếm (Mã, Tên, Chủng loại).
**Tuy nhiên, theo yêu cầu đặc biệt của bạn, phần tìm kiếm đã được tinh gọn lại:**
- **Chỉ tìm kiếm chính xác theo Mã Thiết Bị (Mã TTB).**
- Loại bỏ việc chọn khóa rườm rà.
- Vẫn giữ nguyên 2 tùy chọn thuật toán: **Tìm tuần tự** và **Tìm nhị phân**.
- Cải tiến UX: Khi chọn tìm nhị phân nhưng dữ liệu chưa được sắp xếp, chương trình sẽ không báo lỗi chặn người dùng mà **tự động chuyển sang tìm tuần tự** và ghi chú ở kết quả.

---

## 📂 2. Chi Tiết Thực Hiện Từng Phần

### 2.1. File `FormTimKiem.cs` — Logic Giao Diện Tìm Kiếm

📍 **Đường dẫn:** `QUANLY_TTB\FormTimKiem.cs`

- **Nút Tìm Kiếm (`btnTim_Click`):**
  - Đã hardcode khóa tìm kiếm `key = "MaTTB"` để luôn tìm theo mã.
  - Xử lý thông minh: 
    ```csharp
    if (cboSearchType.SelectedIndex == 1 && DataStore.IsSorted)
    {
        // Dùng nhị phân nếu đã sắp xếp
        results = ThuatToan.BinarySearch(DataStore.DsTTB, key, keyword);
        usedAlgo = "Tìm nhị phân";
    }
    else
    {
        // Dùng tuần tự trong mọi trường hợp khác
        results = ThuatToan.LinearSearch(DataStore.DsTTB, key, keyword);
        usedAlgo = "Tìm tuần tự";
        // Ghi chú nếu tự chuyển
        if (cboSearchType.SelectedIndex == 1 && !DataStore.IsSorted)
            usedAlgo = "Tìm tuần tự (chưa sắp xếp, tự động chuyển)";
    }
    ```
  - Kết quả được đổ vào `DataGridView` và hiển thị câu thông báo dưới cùng kèm theo tên thuật toán thực tế đã chạy.

- **Nút Xóa Tìm (`btnXoaTim_Click`):**
  - Xóa trắng ô nhập từ khóa.
  - Xóa dữ liệu trong bảng kết quả.
  - Reset dòng thông báo về mặc định.

### 2.2. File `ThuatToan.cs` — Các thuật toán tìm kiếm

📍 **Đường dẫn:** `QUANLY_TTB\ThuatToan.cs`

#### ✅ Thuật toán Tìm Tuần Tự (Linear Search)
- **Cách hoạt động:** Duyệt qua từng thiết bị trong danh sách từ đầu đến cuối.
- **Tiêu chí khớp:** Sử dụng `.Equals(keyword, StringComparison.OrdinalIgnoreCase)` thay vì `IndexOf`. Điều này đảm bảo chỉ những thiết bị có mã **trùng khớp hoàn toàn** (không phân biệt chữ hoa/thường) mới được trả về.

#### ✅ Thuật toán Tìm Nhị Phân (Binary Search)
- **Cách hoạt động:** Chỉ hoạt động đúng khi danh sách đã được sắp xếp. Chia đôi danh sách để tìm kiếm, giúp tăng tốc độ tìm kiếm lên mức `O(log n)`.
- **Cơ chế:** Khi tìm thấy phần tử khớp ở vị trí `mid`, thuật toán sẽ kiểm tra mở rộng ra hai bên (trái và phải) để lấy toàn bộ các kết quả trùng mã (nếu có). 

---

## 🚀 3. Hướng Dẫn Sử Dụng Bảng Tìm Kiếm

1. **Khởi động:** Nhấn vào menu **Tìm kiếm**.
2. **Nhập từ khóa:** Nhập chính xác Mã thiết bị cần tìm vào ô TextBox (VD: `TTB01`, `ttb01`).
3. **Chọn thuật toán:**
   - Chọn **Tìm tuần tự**: Luôn ra kết quả đúng dù bạn đã sắp xếp danh sách hay chưa.
   - Chọn **Tìm nhị phân**: Sẽ ra kết quả nhanh hơn, NHƯNG trước đó bạn phải qua trang **Danh sách**, chọn Sắp xếp theo "Mã TTB". Nếu bạn quên sắp xếp, nó sẽ tự lùi về tìm tuần tự cho bạn.
4. **Xem kết quả:** Danh sách thiết bị khớp chính xác mã sẽ hiện ra trên bảng.
5. **Xóa:** Nhấn **Xóa tìm** để reset lại trang tìm kiếm.

---

## 🎯 4. Đánh Giá Trạng Thái

| Tiêu chí | Đánh giá |
|----------|----------|
| Thuật toán Tìm Tuần Tự (Chính xác) | ✅ Đã hoàn thành |
| Thuật toán Tìm Nhị Phân | ✅ Đã hoàn thành |
| Giao diện người dùng thân thiện | ✅ Xử lý tốt, không chặn lỗi bực mình |
| Chỉ tìm theo Mã TTB | ✅ Đã khóa cứng khóa tìm kiếm |

Mọi thứ về tính năng Tìm Kiếm ở tuần 4 đã hoàn tất, mã nguồn sạch sẽ, đáp ứng đúng đắn các yêu cầu bạn đặt ra!
