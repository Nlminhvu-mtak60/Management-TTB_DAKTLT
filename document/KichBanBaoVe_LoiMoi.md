# Kế hoạch "Thả Mồi" (Bait Bugs) & Kịch bản Bảo vệ Đồ án

Dưới đây là một kế hoạch tạo ra các lỗi "nghiệp dư" có chủ đích. Những lỗi này được thiết kế để không làm sập (crash) toàn bộ chương trình ngay lập tức, nhưng sẽ gây ra sai lệch về mặt logic hoặc UI/UX – đúng chuẩn những lỗi mà sinh viên hay mắc phải. Khi thầy giáo chỉ ra, bạn có thể dễ dàng "sửa nóng" ngay lập tức để chứng minh sự hiểu biết về luồng dữ liệu của mình.

---

## Phần 1: Danh sách các lỗi đề xuất (Proposed Bugs)

### Lỗi 1: Tìm kiếm không ra kết quả nếu không gõ chính xác chữ hoa/thường (Logic Error)
- **Vị trí:** `FormTimKiem.cs` (Hàm tìm kiếm)
- **Cách thả mồi:** Thay vì dùng `Contains()` kết hợp với `ToLower()` để tìm kiếm linh hoạt (không phân biệt hoa thường), ta sẽ cố tình đổi thành toán tử `==` hoặc quên gọi `.ToLower()`. 
- **Biểu hiện:** Thầy giáo gõ "máy phát điện" sẽ không ra kết quả nếu tên lưu trong máy là "Máy phát điện". Thầy sẽ hỏi "Tại sao tìm không ra?".
- **Cách bạn sửa diễn:** "À, chỗ này em quên chuyển cả chuỗi tìm kiếm và chuỗi nguồn về chữ thường (`.ToLower()`) trước khi so sánh."

### Lỗi 2: Không xóa rỗng các ô nhập liệu sau khi thêm mới thành công (UI/UX Error)
- **Vị trí:** `FormThemMoi.cs` (Hàm `btnLuu_Click`)
- **Cách thả mồi:** Xóa đoạn code làm sạch các TextBox (ví dụ: `txtMaTTB.Text = ""; txtTen.Text = "";`) sau khi gọi `DataStore.SaveData()`.
- **Biểu hiện:** Khi thêm xong 1 thiết bị, thông báo "Thành công" hiện lên nhưng chữ trong form vẫn còn nguyên. Thầy giáo sẽ chê UX kém, bắt người dùng phải tự xóa tay nếu muốn thêm cái thứ 2.
- **Cách bạn sửa diễn:** Bạn mỉm cười và gõ nhanh một hàm `ClearForm()` để reset lại các giá trị `txt...Text = ""` là ăn điểm tuyệt đối.

### Lỗi 3: Cho phép nhập số lượng thiết bị là số âm (Validation Error)
- **Vị trí:** `FormThemMoi.cs` hoặc `FormDanhSach.cs` (chỗ Sửa)
- **Cách thả mồi:** Bỏ đi dòng `if (nudSoLuong.Value <= 0)` (hoặc tương tự) trước khi lưu.
- **Biểu hiện:** Thầy giáo sẽ cố tình nhập số lượng là `-5` để test xem bạn có bắt lỗi dữ liệu đầu vào (Validation) không. Và chương trình của bạn sẽ lưu luôn số `-5`.
- **Cách bạn sửa diễn:** "Chết thật, em quên bọc điều kiện kiểm tra (validate) giá trị của ô Số lượng. Để em thêm dòng `if (soLuong <= 0) { MessageBox.Show("Số lượng phải lớn hơn 0"); return; }` vào ngay ạ."

### Lỗi 4: Hiển thị nhầm cột dữ liệu trên Grid (Mapping Error)
- **Vị trí:** `FormDanhSach.cs` (Hàm `LoadDataToGrid`)
- **Cách thả mồi:** Khi `.Rows.Add(...)`, ta sẽ cố tình đảo ngược vị trí biến truyền vào. Ví dụ: Đổi chỗ `ttb.ChungLoai` và `ttb.NguonCap` cho nhau.
- **Biểu hiện:** Cột "Chủng loại" trên giao diện lại hiển thị "Bộ Quốc Phòng" (vốn dĩ là nguồn cấp), và ngược lại. Lỗi này rất trực quan và dễ nhận thấy.
- **Cách bạn sửa diễn:** "À em hiểu rồi, lúc add dữ liệu vào các cột của DataGridView, em bị nhầm thứ tự Index của 2 biến này. Đảo vị trí tham số lại là xong ngay ạ."

### Lỗi 5: Đếm sai số thiết bị cần bảo dưỡng (Off-by-one Error)
- **Vị trí:** `FormThongKe.cs` (Hàm đếm thiết bị)
- **Cách thả mồi:** Sửa logic điều kiện đếm. Thay vì `if (soNgayConLai <= 30)`, ta sửa thành `if (soNgayConLai < 0)` (làm cho những máy "cần bảo dưỡng" biến mất, chỉ còn máy "quá hạn" mới được đếm).
- **Biểu hiện:** Báo cáo Thống kê tổng quan sẽ báo có 0 máy cần bảo dưỡng, dù trong danh sách rõ ràng có máy chỉ còn vài ngày nữa là hết hạn.
- **Cách bạn sửa diễn:** Bạn chỉ ra đúng dòng code điều kiện bị sai và sửa thành `soNgayConLai <= 30`.

---

## Phần 2: Kịch bản Bảo vệ (Defense Scenarios) - Các câu hỏi kiểm tra tư duy

Giáo viên thường không chỉ bắt lỗi, mà còn yêu cầu bạn sửa/xóa code tại chỗ để chứng minh bạn thực sự viết và hiểu luồng hoạt động (Data Flow) cùng thuật toán (Algorithms). Dưới đây là các câu hỏi rất phổ biến đối với cấu trúc đồ án này và cách bạn "thể hiện":

### Kịch bản 1: Thử thách Thuật toán (Thuật toán Sắp xếp)
- **Giáo viên hỏi:** "Trong chức năng hiển thị danh sách, em đang sắp xếp (Sort) dữ liệu như thế nào? Thầy không muốn em dùng hàm có sẵn (`OrderBy` / `Sort()` của C#). Em thử comment hàm có sẵn đi và viết một thuật toán Bubble Sort (Sắp xếp nổi bọt) thủ công tại chỗ cho thầy xem."
- **Mục đích:** Kiểm tra kiến thức Kỹ thuật lập trình cơ bản và hiểu biết về `List<T>`.
- **Cách bạn vượt qua:** Vào file `FormDanhSach.cs` (phần `btnPerformSort_Click`), bạn comment đoạn `.OrderBy()` lại. Sau đó gõ nhanh thuật toán Bubble Sort thao tác trực tiếp trên `DataStore.DsTTB`.

### Kịch bản 2: Truy vết Luồng Dữ Liệu (Data Flow)
- **Giáo viên hỏi:** "Khi em nhấn nút Lưu ở `FormThemMoi`, làm sao `FormDanhSach` biết mà cập nhật lại bảng (Grid) ngay lập tức? Thử xóa đi dòng lệnh cập nhật đó xem chương trình bị lỗi gì?"
- **Mục đích:** Kiểm tra hiểu biết về OOP, biến static (`DataStore`), và cách các Form giao tiếp với nhau.
- **Cách bạn vượt qua:** Bạn mở `FormThemMoi.cs`, chỉ vào đoạn gọi `DataStore.SaveData()` để lưu xuống file JSON. Sau đó giải thích: "Dạ vì form Danh Sách luôn gọi hàm `LoadDataToGrid()` ở hàm Form_Load, nên mỗi khi mở lại Form Danh sách nó đều lấy dữ liệu mới nhất từ biến toàn cục `DataStore.DsTTB`." 

### Kịch bản 3: Sửa đổi Logic Tìm Kiếm (Searching)
- **Giáo viên hỏi:** "Hiện tại chức năng tìm kiếm của em đang tìm theo Tên. Giờ thầy muốn tìm theo cả MÃ THIẾT BỊ nữa, em hãy sửa code tại chỗ cho thầy xem."
- **Mục đích:** Kiểm tra kỹ năng đọc hiểu và thao tác với câu lệnh điều kiện `if`.
- **Cách bạn vượt qua:** Mở `FormTimKiem.cs`, tìm đến hàm chứa vòng lặp `.Contains(keyword)` và thêm điều kiện `OR`: 
  `if (ttb.Ten.ToLower().Contains(keyword) || ttb.MaTTB.ToLower().Contains(keyword))`
  Chỉ 1 dòng duy nhất là bạn đã chứng minh được kỹ năng của mình.

### Kịch bản 4: Thay đổi Cấu trúc Dữ liệu (Phân quyền)
- **Giáo viên hỏi:** "Trong luồng Phân quyền (`DataStore.cs`), nếu giờ thầy muốn thêm một cấp quyền mới là `KHO` (chỉ được Xem và Xuất thống kê, không được Thêm/Sửa/Xóa), em cần sửa ở đâu?"
- **Mục đích:** Kiểm tra khả năng mở rộng (Scalability) của project.
- **Cách bạn vượt qua:** Bạn mở file `DataStore.cs`, di chuyển đến hàm `CoQuyen()`, thêm một khối `if (vaiTro == "KHO")` và return true cho các chức năng "Xem", "ThongKe", return false cho phần còn lại. Rất nhanh và dứt khoát!
