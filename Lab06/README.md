# Lab06 — Thực hành 6a

Mở `Lab06.slnx` trong Visual Studio. Các project cùng nằm trong nhóm `TH06a`:

```text
Lab06/
├── Lab06.slnx
├── bai6amau/        # Bài mẫu: Quản lý khoa
├── bai6atrenlop/    # Bài tại lớp: Quản lý môn học
├── bai6avenha/      # Bài về nhà: Quản lý lớp
├── bai6anangcao/    # Bài nâng cao: Quản lý sinh viên và Quản lý điểm
├── SQLQuery1.sql
├── SQL_QL_Mon_Hoc.sql
├── SQL_QL_Lop.sql
├── SQL_QL_Sinh_Vien.sql
└── SQL_QL_Diem.sql
```

Form mới giữ cách tách file `TenForm.cs` và `TenForm.Designer.cs`: file đầu chứa các sự kiện và SQL, file Designer chứa vị trí, kích thước và thuộc tính các điều khiển. Có thể mở giao diện bằng View Designer (Shift + F7).

## Chuẩn bị và chạy

1. Mở Docker Desktop, đợi Engine chạy rồi dùng PowerShell: `docker start sql-baitap`.
2. SQL Server lắng nghe tại `tcp:127.0.0.1,14330`; database dùng chung là `QLSinhVien`.
3. Khi cần khởi tạo trên database mới, chạy lần lượt `SQL_QL_Lop.sql`, `SQL_QL_Sinh_Vien.sql`, `SQL_QL_Diem.sql`. Script tạo bảng còn thiếu và thêm dữ liệu mẫu theo khóa chưa có, không ghi đè các dòng hiện tại.
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
