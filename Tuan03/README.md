```

```

# NGÔN NGỮ LẬP TRÌNH TRONG C#

## THỰC HÀNH LINQ CƠ BẢN

### Mục tiêu

- Hiểu cách sử dụng LINQ để truy vấn dữ liệu trong mảng và `List<T>`.
- Sử dụng các toán tử truy vấn cơ bản: `where`, `orderby`, `select`.
- Sử dụng các phương thức mở rộng: `Count`, `Sum`, `Average`, `Min`, `Max`, `Distinct` và `GroupBy`.
- Tạo dữ liệu đối tượng và truy vấn `List<MonHoc>`.
- Thực hiện truy vấn trên hai nguồn dữ liệu bằng `join`, `GroupJoin` và `DefaultIfEmpty`.

---

### Yêu cầu chung

- Tạo một Console App (.NET) tên `BaiThucHanhLINQ`.
- Mỗi bài viết thành một phương thức riêng để dễ kiểm tra.
- Ưu tiên viết cả Query Syntax và Method Syntax đối với các truy vấn cơ bản.
- Kết quả phải được in rõ ràng ra màn hình; không viết cứng kết quả.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main()
    {
        // Gọi lần lượt các hàm bài tập tại đây.
    }
}
```

---

### 2. Truy vấn LINQ trên mảng

#### Bài 2.1. Truy vấn mảng số nguyên

Cho mảng số nguyên:

```csharp
int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
```

- **a.** Liệt kê các phần tử chia hết cho 4 và 3.
- **b.** Liệt kê các phần tử nhỏ hơn hoặc bằng 3.
- **c.** Tạo một dãy mới: số chẵn chia đôi, số lẻ giữ nguyên giá trị.
  _Kết quả câu c dự kiến:_ 25, 21, 8, 3, 9, 4, 6, 7, 12, 0.

#### Bài 2.2. Truy vấn mảng chuỗi

Cho mảng chuỗi:

```csharp
string[] mangChuoi = { "đầu", "lòng", "hai", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thủy", "Vân" };
```

- **a.** Liệt kê các phần tử có 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên.
- **b.** Biến đổi mỗi phần tử thành dạng: `<chữ thường> - <CHỮ HOA>`.
- **c.** Liệt kê các phần tử có chứa ký tự “u”.
- **d.** Liệt kê các từ “Thúy Kiều Thúy Vân” bằng cách chọn các phần tử bắt đầu bằng chữ in hoa.

---

### 3. Truy vấn thống kê và phân nhóm

#### Bài 3.1. Thống kê mảng số

Cho mảng:

```csharp
int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
```

- **a.** Cho biết tổng số phần tử, số phần tử chẵn và số phần tử lẻ.
- **b.** Tính tổng các giá trị, giá trị lớn nhất và giá trị nhỏ nhất.
- **c.** Cho biết có bao nhiêu giá trị khác nhau trong mảng.
- **d.** Phân nhóm các phần tử theo số dư khi chia cho 5; in số dư và các phần tử thuộc từng nhóm.

#### Bài 3.2. Thống kê mảng chuỗi

```csharp
string[] monAn = {
    "Nước Cà phê", "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
    "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
    "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang"
};
```

- **a.** Tìm các phần tử có chiều dài ngắn nhất và dài nhất.
- **b.** Phân nhóm theo từ đầu tiên của tên món và liệt kê các phần tử trong từng nhóm.
- **c.** Đếm số phần tử có từ đầu tiên là “Bánh”.

---

### 4. Xây dựng nguồn dữ liệu đối tượng

#### Bài 4.1. Lớp MonHoc

Tạo lớp `MonHoc` gồm các thuộc tính:

- `MaMon`: string
- `TenMon`: string
- `He`: string
- `SoTiet`: byte

```csharp
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}
```

Tạo lớp `DuLieu` có phương thức tĩnh `DS_Mon()` trả về `List<MonHoc>`. Sử dụng dữ liệu sau:

| Mã môn | Tên môn                                   | Hệ  | Số tiết |
| :----- | :---------------------------------------- | :-- | :------ |
| HP2 1  | Nền tảng C#                               | KTV | 64      |
| HP2 2  | Công nghệ ADO.NET                         | KTV | 64      |
| HP3 1  | Lập trình Windows Forms                   | KTV | 64      |
| HP3 2  | Xây dựng ứng dụng Windows Forms           | KTV | 64      |
| HP4 1  | Lập trình Web với HTML, CSS và JavaScript | KTV | 64      |
| HP4 2  | Xây dựng ứng dụng Web với ASP.NET         | KTV | 64      |
| HP5 1  | Lập trình CSDL SQL Server căn bản         | KTV | 64      |
| HP5 2  | Lập trình CSDL SQL Server nâng cao        | KTV | 64      |
| JLCB   | Joomla cơ bản                             | CD  | 72      |
| LINQ   | Language-Integrated Query                 | CD  | 64      |
| DAWEB  | Đồ án thực tế Web với ASP.NET             | CD  | 40      |
| DAWIN  | Đồ án thực tế Windows Forms               | CD  | 40      |
| CC++   | Lập trình hướng đối tượng với C/C++       | CD  | 128     |
| JQUE   | JQuery                                    | CD  | 22      |
| XML    | Công nghệ XML                             | CD  | 32      |
| CRYS   | Crystal Report trong Visual Studio        | CD  | 32      |
| BWEB   | HTML, CSS và JavaScript                   | CD  | 32      |
| XYZ    | Chưa đặt tên môn                          |     | 0       |

---

### 5. Truy vấn List<MonHoc></monhoc>

#### Bài 5.1. Truy vấn cơ bản

- **a.** Liệt kê tên các môn học bắt đầu bằng “Lập trình”.
- **b.** Liệt kê các môn thuộc hệ “CD”, sắp xếp số tiết giảm dần rồi mã môn tăng dần.
- **c.** Liệt kê các môn có tên chứa từ “web”, chỉ lấy Tên môn và Hệ.
- **d.** Liệt kê các môn thuộc hệ “KTV”, sắp xếp tăng dần theo Mã môn.

#### Bài 5.2. Thống kê trên List<MonHoc></monhoc>

- **a.** Cho biết tổng số môn hiện có.
- **b.** Đếm số môn có tên bắt đầu bằng “Lập trình”.
- **c.** Tính tổng số tiết của hệ Kỹ thuật viên (KTV).
- **d.** Cho biết tổng số môn của mỗi hệ: Hệ, Tổng số môn.
- **e.** Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết.
- **f.** Cho biết thông tin môn học có số tiết cao nhất.
- **g.** Thống kê theo Hệ: tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất.
- **h.** Liệt kê các môn học được phân nhóm theo Hệ.
- **i.** Liệt kê các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết.
- **j.** Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn.
- **k.** Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn.

---

### 6. Truy vấn trên hai nguồn dữ liệu

#### Bài 6.1. Xây dựng lớp He

```csharp
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}
```

Tạo phương thức `DS_He()` trả về `List<He>` với dữ liệu:

| Mã hệ | Tên hệ            |
| :---- | :---------------- |
| KTV   | Kỹ thuật viên     |
| CD    | Chuyên đề         |
| OT    | Chứng chỉ quốc tế |

#### Bài 6.2. Join và các toán tử tập hợp

- **a.** Dùng `join` để liệt kê: Tên hệ, Mã môn, Tên môn.
- **b.** Liệt kê cả những hệ chưa có môn học (left outer join với `GroupJoin` + `DefaultIfEmpty`).
- **c.** Liệt kê cả hệ chưa có môn học và môn học chưa khai báo hệ.
- **d.** Chỉ liệt kê những hệ chưa có môn học và những môn học chưa khai báo hệ.
- **e.** Lấy 5 môn học đầu tiên có số tiết giảm dần; hiển thị Tên hệ, Mã môn, Tên môn, Số tiết.
- **f.** Cho biết tổng số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn.
- **g.** Cho biết có bao nhiêu loại Số tiết khác nhau trong danh sách môn học.
- **h.** Tìm môn học đầu tiên có tên bắt đầu bằng “Lập trình”.
- **i.** Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm.

---

### Gợi ý tổ chức chương trình

Có thể tổ chức chương trình theo các phương thức sau để dễ kiểm tra từng yêu cầu:

```csharp
static void Bai21() { /* LINQ trên mảng số */ }
static void Bai22() { /* LINQ trên mảng chuỗi */ }
static void Bai31() { /* Count, Sum, Min, Max, GroupBy */ }
static void Bai51() { /* Truy vấn List<MonHoc> */ }
static void Bai52() { /* Thống kê List<MonHoc> */ }
static void Bai62() { /* Join hai nguồn dữ liệu */ }
```

### Yêu cầu nộp bài

- Nộp toàn bộ project C#; project phải build và chạy được.
- Mỗi câu phải có nhãn kết quả rõ ràng trước khi in dữ liệu.
- Không dùng vòng lặp để thay thế cho truy vấn LINQ ở phần xử lý chính, trừ khi dùng `foreach` để xuất kết quả.
- Các câu có `GroupBy` hoặc `join` phải in được cấu trúc nhóm/kết quả đầy đủ.
