# NNLT_CSharp

Dự án bài tập môn Ngôn ngữ lập trình C#, tổ chức theo tuần thực hành.

## Cấu trúc dự án

```text
NNLT_CSharp/
├── README.md
├── Tuan02/
│   ├── NNLTCSharp.slnx
│   ├── MyLib/                 # Thư viện các lớp C# dùng chung
│   ├── MyLib.Tests/           # Unit test cho thư viện
│   └── ThucHanh02/             # Các project bài tập console
└── Tuan03/
	├── README.md              # Đề bài thực hành LINQ
	└── BaiThucHanhLINQ/       # Project console .NET 10
```

## Nội dung đã thực hiện

### Tuần 2

- Tổ chức solution và các project bài tập console trong `Tuan02/ThucHanh02`.
- Xây dựng thư viện `MyLib` với các lớp làm việc với điểm, phân số, mảng, ma trận, thông tin cá nhân và sinh viên.
- Tạo project `MyLib.Tests` và bài kiểm thử cho `SinhVien`.

### Tuần 3: Thực hành LINQ

Project `Tuan03/BaiThucHanhLINQ` hiện có các bài sau:

- **Bài 2.1 (`Bai21.cs`):** lọc số chia hết cho 4 và 3, lọc số không lớn hơn 3, và biến đổi số chẵn thành một nửa giá trị. Có ví dụ Query Syntax và Method Syntax.
- **Bài 2.2 (`Bai22.cs`):** truy vấn mảng chuỗi theo độ dài, chuyển chữ thường/chữ hoa, tìm chuỗi chứa `u`, và chọn từ bắt đầu bằng chữ in hoa. Có ví dụ Query Syntax và Method Syntax.
- **Bài 3.1 (`Bai31.cs`):** đếm phần tử chẵn/lẻ, tính tổng/min/max, đếm giá trị khác nhau và nhóm số theo số dư khi chia cho 5.
- **Bài 3.2 (`Bai32.cs`):** tìm tên món ăn ngắn/dài nhất, nhóm món theo từ đầu tiên và đếm món bắt đầu bằng “Bánh”.

`Program.cs` hiện gọi `Bai31.chay()` và `Bai32.chay()`, nên đây là hai bài được thực thi khi chạy project. `Bai21` và `Bai22` đã có mã nhưng chưa được gọi từ `Main`.

## Trạng thái

- Các bài 2.1, 2.2, 3.1 và 3.2 có mã nguồn trong project LINQ.
- Các phần truy vấn danh sách môn học và kết hợp dữ liệu bằng `join`/`GroupJoin` trong đề Tuần 3 chưa được triển khai trong project.

## Chạy project LINQ

```sh
cd Tuan03/BaiThucHanhLINQ
dotnet run
```
