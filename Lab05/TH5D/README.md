# TH5D Windows Forms nâng cao

Project dùng .NET 10, font Tahoma và control chuẩn, tách code xử lý khỏi Designer theo TH5C. Không đưa ba bài mẫu Timer Demo, ListView đơn giản, SaveFileDialog và bài SQL mẫu Khoa vào project.

## Chạy

Mở ../Lab05.slnx, đặt TH5D làm Startup Project rồi F5. Program.cs chạy fmMain. Menu TH5C gọi menu các bài 5c qua ProjectReference.

## Đối chiếu bài làm đã gửi

| Bản gửi | Code tích hợp | Nội dung |
|---|---|---|
| formBaitap1 | fmHoSoSinhVien | Hồ sơ sinh viên với ListView và menu chuột phải |
| formBaitap2 | fmTaiKhoan | Thêm/Hủy/Lưu, xóa, STT và tổng tiền |
| Chưa có | fmChuyenLop và fmNhapHocVien | Menu chuyển lớp, xóa học viên, nhập ở form riêng |
| Chưa có | fmDemNguoc | Đếm ngược mặc định 30 phút |
| Chưa có | fmMain | Menu mở các bài và liên kết TH5C |
| QLMonHoc | fmMonHoc | Thêm, xóa, sửa môn học |
| QLSinhVien | fmSinhVienSql | Thêm, xóa và sửa một phần thông tin sinh viên |
| QuanLyDiem | fmDiem | Điểm theo cặp mã sinh viên/môn học |
| frmLop | fmLop | Lớp theo khoa, hỗ trợ sửa một phần |

## Thiết lập SQL Server

1. Có SQL Server đang chạy; dùng instance thực tế của máy. Mặc định cấu hình .\SQLEXPRESS, Windows Authentication, database QLSinhVien, timeout kết nối 5 giây.
2. Mở Database/QLSinhVien.sql trong SQL Server Management Studio. Đối chiếu schema nếu database đã tồn tại; script dùng dbo và tên cột đúng PDF. Chạy thủ công để tạo schema và dữ liệu mẫu, mỗi bảng năm dòng; chương trình không tự chạy script.
3. Sửa database.config.json trong project và build lại. File được chép vào thư mục chạy. Biến TH5D_SQL_CONNECTION nếu có sẽ được ưu tiên.
4. Thử thêm MH10 với tên môn học; sửa tên; xóa chỉ nhập MH10. Thử sinh viên với mã lớp có thật. Khi xóa sinh viên, nhập mã và họ tên, để mã lớp trống và bỏ chọn ngày sinh.
5. Thử điểm với cặp mã có thật, dùng 8,5. Thử xóa dòng điểm trước khi xóa sinh viên/môn học được tham chiếu. Lỗi khóa ngoại phải được xử lý bằng thông báo.

Đã kiểm tra input, lệnh và kiểu tham số SQL bằng bộ thực thi giả. Kết nối thực tế tại lần review chưa thành công, nên chưa xác nhận CRUD hoặc script trên SQL Server thật. SqlForm dùng using cho connection/command; lỗi không tìm thấy dữ liệu dựa trên số dòng bị tác động.

## Quy ước nhập liệu

- Số tiền không âm, tối đa hai chữ số thập phân, dấu phẩy; không nhập dấu phân nhóm. Lưu decimal trong Tag, hiển thị N2; không cộng từ chuỗi hiển thị.
- Điểm từ 0 đến 10, tối đa hai chữ số thập phân, dấu phẩy. Tham số SQL dùng Decimal(4,2).
- Mã SQL tối đa 20 ký tự; tên tối đa 100. Không nhập dữ liệu ở các trường mà đề yêu cầu để trống khi xóa.
- Đếm ngược cho chọn 1-180 phút, mặc định 30 phút. Dừng rồi Bắt đầu sẽ chạy lại từ thời lượng chọn.

## Review

Build solution 0 lỗi, 0 cảnh báo. TH5D vượt qua 74 kiểm tra chức năng và 354 kiểm tra bố cục. Xem ../BAO_CAO_LAB05.md để đọc mục tiêu, hoạt động, code quan trọng, kết quả và giới hạn từng bài.
