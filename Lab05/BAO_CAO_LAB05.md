# Báo cáo thực hành Lab05

TH5C và TH5D - Rà soát code và giải thích các bài thực hành

Ngày kiểm tra 11/10/2026

## 1 Phạm vi và kết quả kiểm tra

Lab05 được tổ chức thành hai project Windows Forms .NET 10: TH5C cho các bài 5c và TH5D cho bài 5d. TH5D dùng MenuStrip để mở bài 5d và menu TH5C. Giao diện mới dùng Tahoma, control chuẩn và file Designer riêng, theo cách tổ chức hiện có.

Đề 5d có 17 trang: phần WinForms ở trang 1-9 và phần tương tác cơ sở dữ liệu ở trang 10-17. Không tích hợp các bài mẫu 5d về đồng hồ hệ thống, ListView đơn giản, mở/lưu văn bản hoặc form Khoa. Các bài mẫu TH5C đã có vẫn được giữ và kiểm tra.

| Nội dung kiểm tra | Kết quả |
|---|---|
| Build solution gồm TH5C, TH5D và project kiểm tra | 0 lỗi, 0 cảnh báo |
| TH5C | 81 kiểm tra chức năng, 284 kiểm tra bố cục vượt qua |
| TH5D | 74 kiểm tra chức năng, 354 kiểm tra bố cục vượt qua |
| Tổng | 155 kiểm tra chức năng và 638 kiểm tra bố cục, tổng 793 |
| Giao diện | Render và xem 20 cửa sổ gồm các bài, form nhập và menu |
| SQL Server | Kết nối thử theo cấu hình mặc định thất bại; chưa kiểm thử CRUD với database thật |

Kiểm tra chức năng gọi các sự kiện của form. Hộp thoại được thay bằng câu trả lời giả định; phần SQL dùng bộ thực thi giả để kiểm tra lệnh và tham số. Vì vậy kết quả SQL xác nhận kiểm tra đầu vào và cách tạo lệnh, không chứng minh dữ liệu đã được lưu. Kiểm tra bố cục đối chiếu vị trí các control đang hiển thị ở môi trường Windows hiện tại, không bao phủ mọi mức DPI.

## 2 Các bài TH5C

### 2.1 Mẫu 1 Hai ListBox

**Mục tiêu:** Chuyển dữ liệu giữa hai ListBox và hiểu lựa chọn một hoặc nhiều mục.

**Hoạt động:** Danh sách trái có sáu loại quả. Các nút chuyển một mục, tất cả hoặc các mục được chọn; khi đóng có xác nhận.

**Code quan trọng:** `ChuyenMot`, `ChuyenTatCa` và `btnTuyY_Click`. Khi chuyển nhiều mục, thêm theo thứ tự rồi xóa chỉ số giảm dần để tránh lệch vị trí.

**Kết quả:** Kiểm tra chuyển một, nhiều, toàn bộ, chưa chọn và trả lời No khi đóng đều vượt qua. Form dùng hộp thoại chung của `LabForm`.

### 2.2 Mẫu 2 ComboBox dân tộc

**Mục tiêu:** Nạp dữ liệu và xử lý lựa chọn trong ComboBox.

**Hoạt động:** Nút Load nạp năm dân tộc; chọn mục hiện thông báo; nút Hiển thị ghi lựa chọn lên Label.

**Code quan trọng:** `btnLoad_Click` xóa danh sách cũ trước AddRange; `cboDanToc_SelectedIndexChanged` bỏ qua chỉ số -1.

**Kết quả:** Nạp hai lần vẫn có năm mục; chọn Hoa cập nhật đúng thông báo và Label; nạp lại đặt về chưa chọn.

### 2.3 Mẫu 3 Phòng ban và nhân viên

**Mục tiêu:** Kết hợp TreeView và ComboBox quản lý phòng ban.

**Hoạt động:** Nạp bốn phòng ban, thêm phòng không trùng và thêm nhân viên vào phòng đã chọn. Xóa phòng cần xác nhận và đồng bộ ComboBox.

**Code quan trọng:** `btnThemPB_Click`, `btnXoaPB_Click`, `btnThemNV_Click`; record `NhanVien` lưu trong Tag, dùng kiểm tra mã trùng.

**Kết quả:** Thêm phòng/nhân viên, chống trùng, hủy xóa và từ chối xóa node nhân viên như một phòng ban đều vượt qua.

### 2.4 Tại lớp 1 Ước số

**Mục tiêu:** Tìm và thống kê các ước của số nguyên dương.

**Hoạt động:** Nhập số vào ComboBox, chọn số để nạp ListBox; các nút tính tổng, đếm ước chẵn và ước nguyên tố.

**Code quan trọng:** `TimUoc` duyệt đến căn bậc hai, dùng `i <= n / i` để tránh tràn số; `LaNguyenTo` loại n nhỏ hơn 2; tổng dùng long.

**Kết quả:** Số 12 có các ước 1, 2, 3, 4, 6, 12; tổng 28, bốn ước chẵn và hai ước nguyên tố. Số 0, số âm, chuỗi sai và số vượt Int32 bị từ chối.

### 2.5 Tại lớp 2 Lớp và sinh viên

**Mục tiêu:** Quản lý dữ liệu phân cấp lớp, sinh viên và địa chỉ.

**Hoạt động:** TreeView có gốc Danh sách lớp; checkbox hiện nhóm thêm lớp. Cập nhật thêm sinh viên; chọn sinh viên điền thông tin; xóa đúng node sau xác nhận.

**Code quan trọng:** Record `SinhVien` trong Tag phân biệt sinh viên với node lớp/địa chỉ. `btnCapNhat_Click` kiểm tra mã trên tất cả lớp; `trvLop_AfterSelect` nạp thông tin.

**Kết quả:** Kiểm tra lớp trùng, sinh viên trùng mã, thiếu dữ liệu, chọn sinh viên và xóa sai cấp node đều vượt qua. Nút Cập nhật dùng để thêm, không sửa sinh viên đã có.

### 2.6 Nâng cao Xử lý họ tên

**Mục tiêu:** Thao tác chuỗi và lựa chọn nhiều mục trong ListBox.

**Hoạt động:** Mỗi lần nhấn thêm 50 tên từ ba mảng HO, TENLOT, TEN. Có xóa theo tên Sơn/họ Lê, đổi kiểu chữ, xóa mục chọn và nhấp đúp sửa tên.

**Code quan trọng:** `TachTu`, `XoaTheo`, `DoiTenChon`; xóa từ cuối; đổi chữ theo culture vi-VN; `IndexFromPoint` xác định mục sửa bằng InputBox.

**Kết quả:** Thêm 50 tên, xóa theo từ đầu/cuối, đổi hoa/thường/hoa đầu từ, sửa đúng chỉ số và giữ tên khi InputBox rỗng đều vượt qua.

### 2.7 Về nhà 1 Từ điển hai chiều

**Mục tiêu:** Tra từ bằng ComboBox, ListBox và TabControl.

**Hoạt động:** Có 17 cặp từ trong List. Nhập tiền tố chọn gợi ý; nút tra, Enter hoặc nhấp đúp trả nghĩa. Tab Việt-Anh gom nhiều nghĩa.

**Code quan trọng:** `DoTu`, `Tra`, `XuLyEnter`, `TraTuDoubleClick`. So sánh không phân biệt hoa/thường, có phân biệt dấu.

**Kết quả:** stu trả sinh viên; nhà trả house và home; Enter với giáo trả teacher; nhấp đúp cat trả mèo; từ không có nhận thông báo không tìm thấy.

### 2.8 Về nhà 2 ListBox số

**Mục tiêu:** Thống kê và biến đổi danh sách số tự nhiên.

**Hoạt động:** Nhập số gồm 0; tính tổng; xóa đầu/cuối hoặc mục chọn; cộng 2, bình phương và chọn chẵn/lẻ.

**Code quan trọng:** BigInteger giữ giá trị số; `btnXoaDauCuoi_Click` xử lý danh sách rỗng/một mục; `BienDoi` và `ChonTheo` áp dụng phép biến đổi hoặc lựa chọn.

**Kết quả:** Tổng, xóa nhiều mục, chọn chẵn/lẻ và bình phương số lớn đều vượt qua. Số âm không được nhận.

### 2.9 Về nhà 3 Danh bạ A đến Z

**Mục tiêu:** Phân nhóm tên theo chữ cái đầu bằng TreeView.

**Hoạt động:** Tạo 26 nhóm; nhập First Name là tên và Last Name là họ/tên đệm. Node hiển thị tên, họ/tên đệm.

**Code quan trọng:** `ChuCaiDau` chuẩn hóa dấu Unicode, chuyển Đ thành D; `btnAdd_Click` kiểm tra tên và chọn node vừa thêm.

**Kết quả:** Bình vào B, Ánh vào A, Đức vào D. Thiếu tên hoặc tên bắt đầu bằng số bị từ chối.

## 3 Các bài TH5D

### 3.1 Tại lớp 1 Hồ sơ sinh viên

**Mục tiêu:** Thêm, sửa, xóa hồ sơ nhiều cột trong ListView.

**Hoạt động:** Nhập họ tên, mã, giới tính, ngoại ngữ và dân tộc. Chọn dòng điền lại dữ liệu, khóa mã; nút Xóa và menu chuột phải cùng xử lý xóa có xác nhận.

**Code quan trọng:** `FindStudent` kiểm tra mã không phân biệt hoa/thường; `lstv1_SelectedIndexChanged` khóa mã; `DeleteSelectedItem` dùng chung cho hai đường xóa.

**Kết quả:** Thêm, chống trùng, sửa giữ mã, hủy xóa, xóa từ menu chuột phải và xác nhận đóng đều vượt qua. ListView dùng Details và FullRowSelect.

### 3.2 Tại lớp 2 Tài khoản ngân hàng

**Mục tiêu:** Quản lý trạng thái nhập, đánh STT và tính tổng tiền.

**Hoạt động:** Thêm chuyển thành Hủy, bật Lưu và làm rỗng ô nhập. Lưu thêm dòng; chọn dòng hiện thông tin; xóa đánh lại STT và tính lại tổng.

**Code quan trọng:** `dangThem` điều khiển trạng thái; decimal lưu trong `ListViewItem.Tag`; `CapNhatTong` cộng giá trị gốc, không phân tích chuỗi đã định dạng. Hiển thị N2 theo vi-VN.

**Kết quả:** 10,50 cộng 2,25 cho tổng 12,75. Kiểm tra hủy nhập, trùng tài khoản, số âm, quá hai số thập phân và tổng vượt decimal đều vượt qua.

### 3.3 Nâng cao Chuyển học viên giữa hai lớp

**Mục tiêu:** Dùng MenuStrip, hai ListBox và form nhập riêng.

**Hoạt động:** Menu chuyển các mục chọn giữa A/B hoặc xóa mục chọn ở cả hai lớp. Menu nhập mở `fmNhapHocVien`; cập nhật đưa tên vào lớp tương ứng.

**Code quan trọng:** `Chuyen` chụp chỉ số và xóa ngược; event `HocVienDaNhap` gửi tên/lớp về form chính; `ThemHocVien` cập nhật ListBox.

**Kết quả:** Chuyển nhiều tên giữ thứ tự, xử lý chưa chọn, xóa ở cả hai lớp và nhập qua event đều vượt qua. Form nhập này được bổ sung vì bản gửi chưa có.

### 3.4 Về nhà 1 Đếm ngược

**Mục tiêu:** Hiển thị thời gian giảm dần với Timer.

**Hoạt động:** Ban đầu 30:00; Bắt đầu đếm theo thời lượng đã chọn. Hết giờ dừng và báo; Dừng cho phép bắt đầu lại từ thời lượng chọn.

**Code quan trọng:** Stopwatch đo thời gian đã qua; Timer gọi `CapNhatDongHo`; `HienThi` đưa phút và giây lên Label. Timer được giải phóng cùng components.

**Kết quả:** Giả lập 61 giây cho 28:59; 30 phút cho 00:00 và dừng. Kiểm tra khởi động lại ở một phút và nút Dừng vượt qua; không phải thử chờ đủ 30 phút thật.

### 3.5 Về nhà 2 Menu chính

**Mục tiêu:** Mở các bài trong tuần từ MenuStrip.

**Hoạt động:** `fmMain` là form khởi động TH5D. Menu mở bốn bài WinForms, bốn form SQL và menu TH5C; đóng bài quay về main.

**Code quan trọng:** `MoBai` dùng ShowDialog và using để giải phóng form sau khi đóng. ProjectReference cho phép gọi các form TH5C mà không chép trùng code.

**Kết quả:** Chín mục mở form đều trỏ đúng lớp trong kiểm tra. Bản gửi chỉ khởi động QLMonHoc; menu tổng được bổ sung.

### 3.6 SQL Tại lớp Quản lý môn học

**Mục tiêu:** Thêm, sửa tên, xóa môn học theo mã.

**Hoạt động:** Thêm/sửa cần mã và tên; xóa chỉ nhận mã. Kết quả dựa trên số dòng bị tác động.

**Code quan trọng:** `fmMonHoc.XuLy` tạo lệnh cho dbo.MonHoc với MaMonHoc, TenMonHoc; `SqlForm.Chuoi` tạo tham số NVarChar có kích thước.

**Kết quả:** Kiểm tra đầu vào, lệnh tham số với tên có dấu nháy, không tìm thấy bản ghi và lỗi cấu hình vượt qua. Chưa xác nhận thay đổi bảng thật.

### 3.7 SQL Nâng cao Quản lý sinh viên

**Mục tiêu:** Thêm/xóa/sửa sinh viên, cho phép sửa riêng từng trường.

**Hoạt động:** Thêm cần đủ bốn trường. Xóa cần mã và họ tên, để trống mã lớp và bỏ chọn ngày sinh. Sửa cần mã và ít nhất một trường mới.

**Code quan trọng:** `fmSinhVienSql.XuLy` dùng CASE giữ trường không nhập; tham số Date và Bit phân biệt có/không cập nhật ngày sinh.

**Kết quả:** Kiểm tra trường bắt buộc, kiểu ngày, cập nhật một phần và điều kiện xóa theo mã kèm họ tên vượt qua. Chưa kiểm thử với database thật.

### 3.8 SQL Nâng cao Quản lý điểm

**Mục tiêu:** Quản lý điểm theo cặp mã sinh viên và mã môn học.

**Hoạt động:** Thêm/sửa nhận đủ cặp mã và điểm; xóa chỉ nhận cặp mã. Điểm từ 0 đến 10, tối đa hai chữ số thập phân, dấu phẩy theo vi-VN.

**Code quan trọng:** `fmDiem.XuLy` dùng hai mã trong WHERE; tham số điểm là Decimal với Precision 4, Scale 2, thay cho truyền chuỗi số.

**Kết quả:** abc, -1, 11 và 8,555 bị từ chối; 8,5 tạo tham số decimal 8.5. Lệnh sửa/xóa dùng đủ hai khóa. Chưa xác nhận lưu điểm thật.

### 3.9 SQL Về nhà Quản lý lớp

**Mục tiêu:** Thêm/xóa/sửa lớp gắn với khoa.

**Hoạt động:** Thêm cần mã lớp, tên lớp, mã khoa. Xóa chỉ nhập mã lớp. Sửa cần mã lớp và ít nhất tên hoặc mã khoa mới.

**Code quan trọng:** `fmLop.XuLy` tạo câu lệnh cho dbo.Lop; CASE giữ tên/mã khoa nếu ô nhập trống.

**Kết quả:** Kiểm tra thiếu dữ liệu, sửa một phần và điều kiện xóa vượt qua. Khóa ngoại phải được kiểm tra lại trên SQL Server thật.

## 4 Các lỗi đã sửa khi tích hợp và review

| Vấn đề thấy trong bản gửi hoặc cấu trúc cũ | Xử lý trong bản hiện tại |
|---|---|
| ContextMenuStrip sinh viên chưa gắn vào ListView | Gắn ContextMenuStrip, chọn đúng dòng khi nhấn phải và nối cùng hàm xóa |
| Tài khoản định dạng N0 trước khi tính tổng, làm mất phần thập phân | Lưu decimal trong Tag; cộng giá trị gốc; hiển thị N2; kiểm tra tràn tổng |
| Thiếu bài chuyển lớp, form nhập, đếm ngược và menu tổng | Bổ sung các form và nối menu theo phần bài tập trong đề |
| SQL dùng MaSV/MaMh, schema QLSinhVien và database QLDiem không thống nhất với đề | Dùng QLSinhVien, schema dbo, MaSinhVien và MaMonHoc; tập trung cấu hình kết nối |
| Điểm đã kiểm tra số nhưng vẫn truyền chuỗi vào SQL | Truyền SqlParameter Decimal; ngày sinh dùng Date |
| Handler bản gửi có cảnh báo nullable CS8622 | Cho sender nhận object?; build cuối không còn cảnh báo |
| Project Lab05 cũ gọi Form1 không tồn tại và có thể gom code con | Chuyển ba file khởi tạo cũ sang Legacy dưới dạng .txt; solution chỉ dùng các project hiện hành |

Hai form mẫu đầu của TH5C dùng lại lớp hộp thoại chung; sửa chữ tiêu đề Sử dụng ListBox. Các chức năng của chúng đã được kiểm tra lại. Những lỗi CS0115 và đường dẫn project của các lần trước vẫn được lưu trong nhật ký README, không coi là lỗi mới của lần review này.

## 5 Chạy chương trình và kiểm tra tiếp

Mở Lab05/Lab05.slnx, chọn Reload nếu Visual Studio báo thay đổi bên ngoài. Chọn TH5D làm Startup Project rồi F5 để dùng menu chung; chọn TH5C nếu chỉ chạy bài 5c. Project Tests dùng để chạy bộ kiểm tra, không dùng làm form bài học.

Phần SQL cần SQL Server đang chạy và database đúng schema. File TH5D/Database/QLSinhVien.sql chuẩn bị năm bảng và năm mẫu tin mỗi bảng theo yêu cầu của đề; chưa chạy script trên máy này. Sửa TH5D/database.config.json theo instance thực tế, hoặc dùng biến môi trường TH5D_SQL_CONNECTION. Cần kiểm tra cấu trúc database cũ trước khi chạy script.

Dữ liệu ListBox/ListView/TreeView của các bài WinForms nằm trong bộ nhớ và mất khi đóng form. Chỉ các bài SQL có đường lưu database. Chưa kiểm thử trực tiếp mọi hộp thoại, chưa kiểm thử CRUD/khóa ngoại với SQL Server và chưa kiểm tra tất cả mức DPI.

## 6 Nguồn đối chiếu

- NNLTCS - Thuc Hanh 05c - BT WinForm Nang Cao.pdf và code TH5C hiện có.
- NNLTCS - Thuc Hanh 05d - BT WinForm Nang Cao (1).pdf, 17 trang.
- Các file .cs và .Designer.cs trong thư mục Lab05d - WinformAdvanced được cung cấp.
- Code hiện tại trong Lab05/TH5C, Lab05/TH5D và kết quả từ Lab05/Tests.
