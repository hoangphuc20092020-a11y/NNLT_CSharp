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
│   │   └── Bai1_1/
│   │       ├── Bai1_1.cs
│   │       └── Bai1_1.csproj
│   ├── MyLib/
│   │   ├── MyLib.csproj
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

### 4. MyLib

- Là project Class Library.
- Chứa logic nghiệp vụ và các lớp dữ liệu.
- Ví dụ: `SinhVien.cs`

### 5. MyLib.Tests

- Là project kiểm thử đơn vị (unit tests).
- Dùng để test các chức năng trong `MyLib`.
- File chính: `SinhVienTests.cs`

## Ý nghĩa của cấu trúc

Cấu trúc này theo mô hình chia tách rõ ràng:

- `MyLib`: chứa logic nghiệp vụ
- `Buoi01/Bai1_1`: chứa chương trình chạy
- `MyLib.Tests`: chứa kiểm thử
- `NNLTCSharp.slnx`: quản lý toàn bộ solution

## Kết luận

Dự án đang ở trạng thái tổ chức theo mô hình học tập C# chuẩn, dễ mở rộng và dễ kiểm thử hơn khi tách riêng logic, giao diện và test.
