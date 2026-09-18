# NNLT_CSharp

Dự án học tập C# với cấu trúc solution chia theo từng buổi thực hành.

## Cấu trúc thư mục hiện tại

```text
NNLT_CSharp/
├── README.md
├── Tuan02/
│   ├── .keep
│   ├── NNLTCSharp.slnx
│   ├── Buoi01/
│   │   ├── Bai1_1/
│   │   │   ├── Bai1_1.cs
│   │   │   └── Bai1_1.csproj
│   │   └── Bai1_2/
│   │       ├── Bai1_2.cs
│   │       └── Bai1_2.csproj
│   ├── MyLib/
│   │   ├── MyLib.csproj
│   │   ├── Point.cs
│   │   ├── SinhVien.cs
│   │   ├── bin/
│   │   └── obj/
│   └── MyLib.Tests/
│       ├── MyLib.Tests.csproj
│       ├── SinhVienTests.cs
│       ├── bin/
│       └── obj/
└── ...
```

## Mô tả từng thành phần

### 1. Tuan02

- Là thư mục chính chứa bài tập tuần 2.
- Bao gồm solution, project console, thư viện và project test.

### 2. NNLTCSharp.slnx

- File solution tổng để quản lý các project trong dự án.

### 3. Buoi01/Bai1_1

- Là project Console Application.
- Chứa chương trình chính để chạy demo hoặc bài tập đầu tiên.
- File chính: `Bai1_1.cs`
- File cấu hình: `Bai1_1.csproj`

### 4. Buoi01/Bai1_2

- Là project Console Application thứ hai trong buổi 1.
- Có tham chiếu đến project `MyLib` để sử dụng các lớp dùng chung.
- File chính: `Bai1_2.cs`
- File cấu hình: `Bai1_2.csproj`

### 5. MyLib

- Là project Class Library.
- Chứa logic nghiệp vụ và các lớp dữ liệu.
- Các file chính: `Point.cs`, `SinhVien.cs`
- File cấu hình: `MyLib.csproj`

### 6. MyLib.Tests

- Là project kiểm thử đơn vị (unit tests).
- Dùng để test các chức năng trong `MyLib`.
- File chính: `SinhVienTests.cs`

## Ý nghĩa của cấu trúc

Cấu trúc này theo mô hình chia tách rõ ràng:

- `MyLib`: chứa logic nghiệp vụ
- `Buoi01/Bai1_1`: chứa chương trình chạy
- `MyLib.Tests`: chứa kiểm thử
- `NNLTCSharp.slnx`: quản lý toàn bộ solution
- cd Tuan02/Buoi01/Bai1_2
- dotnet add reference ../../MyLib/MyLib.csproj
- $ dotnet sln add Buoi01/Bai1_4/Bai1_4.csproj

## Kết luận

Dự án đang ở trạng thái tổ chức theo mô hình học tập C# chuẩn, dễ mở rộng và dễ kiểm thử hơn khi tách riêng logic, giao diện và test.
