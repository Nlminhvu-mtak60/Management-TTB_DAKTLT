# 📌 Tuần 5 — Thống Kê & Báo Cáo

> [!NOTE]
> Tài liệu này chỉ chứa phần **code bên trong** các khung hàm đã có sẵn.
> Bạn chỉ cần copy và paste vào đúng vị trí.

---

## 1. File: `FormThongKe.cs`

### 1.1. Cập nhật `using` — Thêm thư viện cần thiết

```csharp
// THÊM VÀO ĐẦU FILE (sau dòng using System.Windows.Forms;)

using System.Collections.Generic;
using System.Linq;
using System.Drawing;
```

> **Giải thích:**
> - `System.Collections.Generic`: Để dùng `List<>` và `Dictionary<>`.
> - `System.Linq`: Để dùng các hàm tiện ích như `.Sum()`, `.GroupBy()`.
> - `System.Drawing`: Để vẽ biểu đồ (màu sắc, font chữ, hình chữ nhật).

---

### 1.2. Thêm hàm khởi tạo Load — Gắn sự kiện

```csharp
// SỬA constructor FormThongKe() thành:

public FormThongKe()
{
    InitializeComponent();
    this.Load += FormThongKe_Load;
}

// THÊM hàm FormThongKe_Load:
private void FormThongKe_Load(object sender, EventArgs e)
{
    RenderThongKe();
}
```

> **Giải thích:** Khi mở FormThongKe, tự động gọi `RenderThongKe()` để tính toán và hiển thị số liệu.

---

### 1.3. Hàm `RenderThongKe` — Tính toán và hiển thị thống kê

```csharp
// THAY THẾ TOÀN BỘ hàm RenderThongKe()

private void RenderThongKe()
{
    var list = DataStore.DsTTB;
    if (list.Count == 0)
    {
        lblStatTotal.Text = "0";
        lblStatTypes.Text = "0";
        lblStatRecords.Text = "0 bản ghi";
        return;
    }

    // --- THỐNG KÊ TỔNG QUAN ---

    // Tổng số lượng tất cả TTB
    int tongSoLuong = 0;
    for (int i = 0; i < list.Count; i++)
    {
        tongSoLuong += list[i].SoLuong;
    }
    lblStatTotal.Text = tongSoLuong.ToString();

    // Đếm số chủng loại khác nhau
    List<string> dsChungLoai = new List<string>();
    for (int i = 0; i < list.Count; i++)
    {
        if (!dsChungLoai.Contains(list[i].ChungLoai))
        {
            dsChungLoai.Add(list[i].ChungLoai);
        }
    }
    lblStatTypes.Text = dsChungLoai.Count.ToString();

    // Tổng số bản ghi
    lblStatRecords.Text = list.Count + " bản ghi";

    // --- VẼ BIỂU ĐỒ THEO CHỦNG LOẠI ---
    VeBieuDoTheoChungLoai(list, dsChungLoai);

    // --- VẼ BIỂU ĐỒ THEO CẤP ---
    VeBieuDoTheoCap(list);
}
```

> **Giải thích:**
> - Duyệt qua danh sách TTB để tính tổng số lượng, đếm chủng loại.
> - Gán kết quả vào 3 label thống kê trên giao diện.
> - Gọi 2 hàm vẽ biểu đồ cho 2 tab (Theo chủng loại & Theo cấp).

---

### 1.4. Hàm `VeBieuDoTheoChungLoai` — Biểu đồ cột theo chủng loại

```csharp
// THÊM MỚI hàm này vào class FormThongKe

private void VeBieuDoTheoChungLoai(List<TrangThietBi> list, List<string> dsChungLoai)
{
    panelChartLoai.Controls.Clear();

    // Đếm số lượng theo từng chủng loại
    Dictionary<string, int> thongKe = new Dictionary<string, int>();
    for (int i = 0; i < dsChungLoai.Count; i++)
    {
        thongKe[dsChungLoai[i]] = 0;
    }
    for (int i = 0; i < list.Count; i++)
    {
        thongKe[list[i].ChungLoai] += list[i].SoLuong;
    }

    // Tìm giá trị lớn nhất để tính tỉ lệ
    int maxVal = 0;
    foreach (var pair in thongKe)
    {
        if (pair.Value > maxVal) maxVal = pair.Value;
    }
    if (maxVal == 0) maxVal = 1;

    // Mảng màu sắc cho các cột
    Color[] colors = new Color[]
    {
        Color.FromArgb(61, 92, 58),
        Color.FromArgb(76, 132, 72),
        Color.FromArgb(120, 170, 116),
        Color.FromArgb(160, 200, 156),
        Color.FromArgb(43, 66, 41),
        Color.FromArgb(100, 150, 96)
    };

    int y = 10;
    int colorIdx = 0;
    foreach (var pair in thongKe)
    {
        // Tên chủng loại
        Label lblName = new Label();
        lblName.Text = pair.Key;
        lblName.Location = new Point(10, y);
        lblName.Size = new Size(120, 20);
        lblName.Font = new Font("Segoe UI", 9);
        panelChartLoai.Controls.Add(lblName);

        // Thanh biểu đồ (Panel)
        int barWidth = (int)((double)pair.Value / maxVal * 400);
        if (barWidth < 5) barWidth = 5;

        Panel bar = new Panel();
        bar.BackColor = colors[colorIdx % colors.Length];
        bar.Location = new Point(140, y);
        bar.Size = new Size(barWidth, 20);
        panelChartLoai.Controls.Add(bar);

        // Số lượng bên cạnh thanh
        Label lblVal = new Label();
        lblVal.Text = pair.Value.ToString();
        lblVal.Location = new Point(140 + barWidth + 5, y);
        lblVal.Size = new Size(80, 20);
        lblVal.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        lblVal.ForeColor = Color.FromArgb(43, 66, 41);
        panelChartLoai.Controls.Add(lblVal);

        y += 30;
        colorIdx++;
    }
}
```

> **Giải thích:**
> - Dùng `Dictionary<string, int>` để nhóm và đếm số lượng theo từng chủng loại.
> - Tạo biểu đồ cột ngang bằng cách tạo các `Panel` có chiều rộng tỉ lệ với giá trị.
> - Mỗi cột có: Tên chủng loại (trái) + Thanh màu (giữa) + Số lượng (phải).

---

### 1.5. Hàm `VeBieuDoTheoCap` — Biểu đồ cột theo cấp

```csharp
// THÊM MỚI hàm này vào class FormThongKe

private void VeBieuDoTheoCap(List<TrangThietBi> list)
{
    panelChartCap.Controls.Clear();

    // Đếm số lượng theo từng cấp (1-5)
    Dictionary<int, int> thongKeCap = new Dictionary<int, int>();
    for (int cap = 1; cap <= 5; cap++)
    {
        thongKeCap[cap] = 0;
    }
    for (int i = 0; i < list.Count; i++)
    {
        int cap = list[i].Cap;
        if (cap >= 1 && cap <= 5)
        {
            thongKeCap[cap] += list[i].SoLuong;
        }
    }

    // Tìm giá trị lớn nhất
    int maxVal = 0;
    foreach (var pair in thongKeCap)
    {
        if (pair.Value > maxVal) maxVal = pair.Value;
    }
    if (maxVal == 0) maxVal = 1;

    Color[] colors = new Color[]
    {
        Color.FromArgb(43, 66, 41),
        Color.FromArgb(61, 92, 58),
        Color.FromArgb(76, 132, 72),
        Color.FromArgb(120, 170, 116),
        Color.FromArgb(160, 200, 156)
    };

    int y = 10;
    foreach (var pair in thongKeCap)
    {
        // Tên cấp
        Label lblName = new Label();
        lblName.Text = "Cấp " + pair.Key;
        lblName.Location = new Point(10, y);
        lblName.Size = new Size(80, 20);
        lblName.Font = new Font("Segoe UI", 9);
        panelChartCap.Controls.Add(lblName);

        // Thanh biểu đồ
        int barWidth = (int)((double)pair.Value / maxVal * 400);
        if (barWidth < 5) barWidth = 5;

        Panel bar = new Panel();
        bar.BackColor = colors[(pair.Key - 1) % colors.Length];
        bar.Location = new Point(100, y);
        bar.Size = new Size(barWidth, 20);
        panelChartCap.Controls.Add(bar);

        // Số lượng
        Label lblVal = new Label();
        lblVal.Text = pair.Value.ToString();
        lblVal.Location = new Point(100 + barWidth + 5, y);
        lblVal.Size = new Size(80, 20);
        lblVal.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        lblVal.ForeColor = Color.FromArgb(43, 66, 41);
        panelChartCap.Controls.Add(lblVal);

        y += 30;
    }
}
```

> **Giải thích:**
> - Tương tự biểu đồ chủng loại, nhưng nhóm theo Cấp (1→5).
> - Dùng vòng lặp cố định từ 1 đến 5 (vì đề bài quy định cấp 1-5).
> - Mỗi cấp có 1 thanh biểu đồ với màu sắc riêng.

---

## 2. Tóm Tắt Các File Cần Sửa

| File | Vị trí cần sửa | Nội dung |
|------|----------------|----------|
| `FormThongKe.cs` | Đầu file | Thêm `using` cho List, Linq, Drawing |
| `FormThongKe.cs` | Constructor | Gắn sự kiện `Load` |
| `FormThongKe.cs` | `FormThongKe_Load()` | Thêm mới, gọi `RenderThongKe()` |
| `FormThongKe.cs` | `RenderThongKe()` | Tính toán thống kê tổng quan |
| `FormThongKe.cs` | *(Thêm mới)* | Hàm `VeBieuDoTheoChungLoai()` |
| `FormThongKe.cs` | *(Thêm mới)* | Hàm `VeBieuDoTheoCap()` |

## 3. Thứ Tự Thực Hiện Đề Xuất

> [!TIP]
> Nên làm theo thứ tự sau:

1. ✅ Thêm các `using` cần thiết vào đầu file
2. ✅ Sửa constructor và thêm `FormThongKe_Load()`
3. ✅ Viết hàm `RenderThongKe()` (phần thống kê số liệu trước)
4. 🧪 Chạy thử — kiểm tra 3 label hiển thị đúng số liệu
5. ✅ Viết hàm `VeBieuDoTheoChungLoai()`
6. 🧪 Chạy thử — kiểm tra tab "Theo chủng loại" có biểu đồ
7. ✅ Viết hàm `VeBieuDoTheoCap()`
8. 🧪 Chạy thử — kiểm tra tab "Theo cấp trang bị" có biểu đồ

> [!IMPORTANT]
> **Lưu ý:** Biểu đồ được vẽ bằng cách tạo các control (Panel, Label) động.
> Mỗi lần gọi `RenderThongKe()`, nó sẽ xóa các control cũ rồi vẽ lại từ đầu.
> Đây là cách vẽ biểu đồ đơn giản nhất mà không cần thư viện bên ngoài.
