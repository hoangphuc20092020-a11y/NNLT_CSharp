# Lab06 — Thực hành 6a và 6b

Mở `Lab06.slnx` trong Visual Studio. Các project nằm trong các thư mục thật `TH06a` và `TH06b`, đồng thời hiển thị theo hai nhóm tương ứng trong solution:

```text
Lab06/
├── Lab06.slnx
├── README.md
├── TH06a/
│   ├── bai6amau/         # Quản lý khoa
│   ├── bai6atrenlop/     # Quản lý môn học
│   ├── bai6avenha/       # Quản lý lớp
│   ├── bai6anangcao/     # Quản lý sinh viên và điểm
│   └── SQL/             # Script khởi tạo QLSinhVien
└── TH06b/
    ├── bai6btrenlop/     # Quản lý sinh viên và điểm bằng ComboBox
    ├── bai6bnangcao/     # Danh sách lớp và điểm bằng ListView
    └── bai6bvenha/       # Sản phẩm, tồn kho, nhập hàng và bán hàng
```

Form mới giữ cách tách file `TenForm.cs` và `TenForm.Designer.cs`: file đầu chứa các sự kiện và SQL, file Designer chứa vị trí, kích thước và thuộc tính các điều khiển. Có thể mở giao diện bằng View Designer (Shift + F7).

## Chuẩn bị và chạy

1. Mở Docker Desktop, đợi Engine chạy rồi dùng PowerShell: `docker start sql-baitap`.
2. SQL Server lắng nghe tại `tcp:127.0.0.1,14330`; database dùng chung là `QLSinhVien`.
3. Khi cần khởi tạo trên database mới, mở các script trong `TH06a/SQL`, chạy lần lượt `SQL_QL_Khoa.sql`, `SQL_QL_Mon_Hoc.sql`, `SQL_QL_Lop.sql`, `SQL_QL_Sinh_Vien.sql`, `SQL_QL_Diem.sql`. Script tạo bảng còn thiếu và thêm dữ liệu mẫu theo khóa chưa có, không ghi đè các dòng hiện tại.
4. Chọn project cần học, chuột phải → Set as Startup Project, nhấn F5. Không cần mở SSMS trong lúc dùng Form; chỉ cần container SQL Server chạy.

`bai6avenha` giữ chuỗi kết nối của bài đang làm. Project `bai6anangcao` đặt cấu hình dùng chung trong `KetNoiCSDL.cs`. Nếu đổi server, database hoặc mật khẩu SQL Server, cập nhật đúng cấu hình tương ứng.

## Bài về nhà — Quản lý lớp

- Thêm: nhập mã khoa, mã lớp và tên lớp. Mã khoa phải có trong `Khoa`.
- Xóa: chỉ nhập mã lớp, để trống hai ô còn lại. Lớp đang có sinh viên tham chiếu sẽ không xóa được.
- Sửa: nhập mã lớp và ít nhất một giá trị mới ở mã khoa hoặc tên lớp. Ô để trống giữ nguyên dữ liệu cũ.

## Bài nâng cao 1 — Quản lý sinh viên

Chạy `bai6anangcao`, chọn **Bài 1 - Quản lý sinh viên**.

- Thêm: nhập đủ mã lớp, mã sinh viên, họ tên và ngày sinh.
- Ngày sinh dùng MaskedTextBox với dạng `dd/MM/yyyy`; ngày không tồn tại như `31/02/2005` sẽ bị từ chối.
- Xóa: nhập cả mã sinh viên và đúng họ tên, để trống mã lớp và ngày sinh. Không xóa sinh viên đang có điểm tham chiếu.
- Sửa: nhập mã sinh viên và ít nhất một giá trị mới ở mã lớp, họ tên hoặc ngày sinh. Những ô trống giữ nguyên dữ liệu cũ. Với ngày sinh, xóa hết các chữ số nếu không muốn cập nhật ngày.

## Bài nâng cao 2 — Quản lý điểm

Chọn **Bài 2 - Quản lý điểm** trong cửa sổ chọn bài.

- Thêm/Sửa: nhập mã sinh viên, mã môn học và điểm dạng số. Chấp nhận `8,5` hoặc `8.5`.
- Điểm được lưu bằng `DECIMAL(5,2)`, tối đa hai chữ số thập phân. Đề không quy định thang điểm 0–10 nên chương trình không áp đặt giới hạn này.
- Xóa: nhập mã sinh viên và mã môn học, để trống ô điểm.
- Một sinh viên chỉ có một dòng điểm cho mỗi môn học; dùng Sửa nếu cặp mã đó đã tồn tại.

## Đọc code

Mỗi nút có hàm `btnThem_Click`, `btnXoa_Click`, `btnSua_Click`. Trình tự là đọc TextBox → kiểm tra dữ liệu → chuẩn bị SQL và tham số → `conn.Open()` → `cmd.ExecuteNonQuery()` → thông báo số dòng bị tác động. `using` giải phóng kết nối sau khi thực hiện.

`CASE` giữ cột cũ khi chuỗi mới trống. `COALESCE(@NgaySinh, NgaySinh)` giữ ngày cũ khi tham số ngày là NULL. Các câu SQL đều dùng tham số, không ghép nội dung người dùng vào câu lệnh.

## Thực hành 6b

Mỗi project có `Program.cs` và Form `ChonBai` để mở từng bài. Các Form vẫn tách `.cs`, `.Designer.cs` và `.resx` để chỉnh giao diện trong Visual Studio.

| Project | Tên Form mới | Tên file cũ |
| --- | --- | --- |
| bai6btrenlop | QuanLySinhVien | Form_2_1 |
| bai6btrenlop | QuanLyDiem | Form_2_2 |
| bai6bnangcao | DanhSachLop | Form_3_1 |
| bai6bnangcao | DanhSachDiem | Form_3_2 |
| bai6bvenha | QuanLySanPham | 4_vdc/ProductForm |
| bai6bvenha | TaoTonKho | 4_vdc/InventoryForm |
| bai6bvenha | NhapHang | 4_vdc/ImportForm |
| bai6bvenha | BanHang | 4_vdc/SalesForm |

`4_vdc/Database.cs` đổi thành `bai6bvenha/KetNoiCSDL.cs`. Namespace, tên lớp, constructor và sự kiện Load đã đổi đồng bộ với tên file.

### Cấu hình dữ liệu của mã 6b hiện có

Các câu SQL và chuỗi kết nối của mã 6b được giữ theo bản gốc: server `localhost,1433`; bài trên lớp/nâng cao dùng `QLSinhVien` với các cột `MaSV`, `MaMH`, `TenMH`; bài về nhà dùng `QLCuaHang`. Chúng chưa cùng cấu hình/cột với các script 6a (`127.0.0.1,14330`, `MaSinhVien`, `MaMonHoc`, `TenMonHoc`). Cần đồng bộ cấu hình và cơ sở dữ liệu trước khi thao tác dữ liệu bằng Form 6b. Việc sắp xếp này kiểm tra biên dịch; không xác nhận các thao tác dữ liệu 6b trên Docker hiện tại.

## Đưa cấu trúc mới lên Git

Git lưu các đường dẫn file thật. Trong thư mục repository `D:\NNLT_CSharp`, chạy:

```powershell
git add -A -- Lab06
git diff --cached --stat
git commit -m "Organize Lab06 into TH06a and TH06b"
git push
```

`git add -A -- Lab06` ghi nhận cả đường dẫn cũ bị xóa và đường dẫn mới. Các thư mục `bin`, `obj`, `.vs` tiếp tục được bỏ qua theo `.gitignore`.
