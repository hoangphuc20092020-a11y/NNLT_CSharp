# Kiểm tra Lab05

Chạy từ gốc repo bằng `dotnet run --project Lab05/Tests/Check.csproj` trên Windows .NET 10. Thêm `-- --probe-sql` để thử kết nối SQL chỉ đọc bằng SELECT DB_NAME(), không thêm/xóa/sửa database.

Bộ kiểm tra mở form trong suốt, thay MessageBox/InputBox bằng phản hồi kiểm tra, kiểm tra chức năng và vị trí control, rồi render PNG. Kết quả mặc định nằm ở thư mục temp NNLT_CSharp-Lab05-check; có thể đặt biến LAB05_CHECK_OUTPUT để đổi nơi lưu.

SQL dùng ThucThi ghi đè để ghi nhận lệnh và tham số, không kết nối database trong các kiểm tra CRUD. Trạng thái sqlDatabaseExecuted=false trong check-results.json có nghĩa chưa kiểm thử CRUD thật. Kiểm tra bố cục không bảo đảm mọi DPI. Dữ liệu kiểm tra có phạm vi từng form, không chạm dữ liệu đang lưu của người dùng.
