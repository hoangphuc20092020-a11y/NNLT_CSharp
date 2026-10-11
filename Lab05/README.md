# Lab 05 - Windows Forms nâng cao

Triển khai đủ chín bài trong tài liệu `NNLTCS - Thuc Hanh 05c - BT WinForm Nang Cao.pdf` (13 trang). README giữ nhật ký thực hiện, lỗi đã gặp, cách sửa và phần giải thích để đọc hiểu code.

## Tổng quan sau khi tích hợp TH5D

- TH5C: đủ chín bài 5c đã làm và menu chọn bài.
- TH5D: hai bài tại lớp, chuyển lớp kèm form nhập, đếm ngược, menu chính và bốn bài SQL ở phần cuối đề 5d. Không tích hợp bài mẫu 5d.
- Mở Lab05.slnx; đặt TH5D làm Startup Project để dùng menu liên kết cả 5c và 5d. TH5C vẫn chạy độc lập.
- Solution có project Tests để kiểm tra lại; các file khởi tạo Lab05 cũ được giữ trong Legacy với đuôi .txt.
- Build cuối: 0 lỗi, 0 cảnh báo. TH5C: 81 kiểm tra chức năng + 284 bố cục. TH5D: 74 chức năng + 354 bố cục. Tổng 793 kiểm tra vượt qua.
- SQL: đã kiểm tra tạo lệnh/tham số và đầu vào bằng bộ thực thi giả; kết nối thực tế chưa thành công, chưa xác nhận CRUD/database thật.
- Báo cáo: BAO_CAO_LAB05.md và BaoCaoLab05.pdf. Thiết lập SQL: TH5D/README.md và TH5D/Database/QLSinhVien.sql.

## Mở và chạy riêng TH5C

Mở `Lab05.slnx` bằng Visual Studio, chọn project `TH5C` làm Startup Project, rồi nhấn F5. Solution tham chiếu `TH5C/TH5C.csproj`, dùng .NET 10 Windows Forms.

```csharp
ApplicationConfiguration.Initialize();
Application.Run(new fmChonBai());
```

Màn hình đầu có chín nút chọn bài. Đóng cửa sổ bài để quay lại menu; nút Thoát trên menu đóng ứng dụng. Khi cần debug riêng một bài, có thể thay fmChonBai bằng tên lớp của bài đó trong Program.cs.

## Danh sách bài và file code

| Phần | Trang đề | Form / file xử lý | Nội dung |
|---|---:|---|---|
| Mẫu 1 | 1–3 | fmMauListBox.cs | Chuyển một, tất cả hoặc các mục đang chọn giữa hai ListBox; xác nhận đóng |
| Mẫu 2 | 3–4 | fmMauDantoc.cs | Nạp dân tộc; hiện lựa chọn bằng Label và MessageBox |
| Mẫu 3 | 5–8 | fmMauPhongBan.cs | Phòng ban và nhân viên; thêm/xóa, chống trùng, đồng bộ ComboBox |
| Tại lớp 1 | 8 | fmUocSo.cs | Nhập số; tìm ước; tổng, đếm ước chẵn/nguyên tố; phím truy cập; xác nhận đóng |
| Tại lớp 2 | 9–10 | fmSinhVien.cs | Lớp, sinh viên; ẩn/hiện nhóm thêm lớp; kiểm tra mã trùng; chọn/xóa đúng node |
| Nâng cao | 10–11 | fmChuoi.cs | Thêm 50 tên ngẫu nhiên; xóa theo họ/tên; đổi kiểu chữ; InputBox sửa tên |
| Về nhà 1 | 11 | fmTuDien.cs | Tab Anh–Việt / Việt–Anh; dò tiền tố; Enter và double click tra nghĩa |
| Về nhà 2 | 11–12 | fmListSo.cs | Nhập số tự nhiên; tổng, xóa, cộng 2, bình phương, chọn chẵn/lẻ |
| Về nhà 3 | 12–13 | fmDanhBa.cs | 26 nhóm A–Z; thêm tên vào nhóm chữ cái đầu |

Mỗi form có file `.Designer.cs` cùng tên chứa InitializeComponent và khai báo control. `fmChonBai.cs` là menu; `LabForm.cs` chứa các hộp thoại dùng chung. Các form mới được khai báo SubType=Form trong project để Visual Studio nhận dạng form.

```text
Lab05/
├── README.md
├── Lab05.slnx
└── TH5C/
    ├── TH5C.csproj
    ├── Program.cs
    ├── LabForm.cs
    ├── fmChonBai.cs / .Designer.cs
    ├── fmMauListBox.cs / .Designer.cs / .resx
    ├── fmMauDantoc.cs / .Designer.cs / .resx
    ├── fmMauPhongBan.cs / .Designer.cs
    ├── fmUocSo.cs / .Designer.cs
    ├── fmSinhVien.cs / .Designer.cs
    ├── fmChuoi.cs / .Designer.cs
    ├── fmTuDien.cs / .Designer.cs
    ├── fmListSo.cs / .Designer.cs
    └── fmDanhBa.cs / .Designer.cs
```

Cây này liệt kê file phục vụ bài học. Các file project khởi tạo cũ được lưu trong Legacy dưới dạng .txt; mở Lab05.slnx để dùng các project TH5C và TH5D hiện hành.

## Trạng thái và giới hạn dữ liệu

- Cả chín bài đã có giao diện và code xử lý. Mẫu 1 và 2 giữ code đã làm; bảy bài còn lại mới được bổ sung.
- Dữ liệu nằm trong bộ nhớ theo phạm vi đề. Khi đóng một bài và mở lại, form bắt đầu với dữ liệu ban đầu; không có yêu cầu lưu file/cơ sở dữ liệu.
- Bài ước số nhận số nguyên dương Int32; số 0 không dùng vì có vô số ước dương. Bài ListBox số nhận số nguyên không âm gồm 0 và dùng BigInteger để bình phương không tràn số.
- Mã sinh viên được kiểm tra trùng trên tất cả các lớp. Phòng ban/tên lớp so sánh không phân biệt hoa/thường và bỏ khoảng trắng đầu/cuối.
- Từ điển có 17 cặp từ trong List. Dò theo tiền tố, không phân biệt hoa/thường, có phân biệt dấu tiếng Việt; tra ngược gom nhiều nghĩa khi cùng một từ Việt.
- Danh bạ lấy First Name làm tên để phân nhóm; dấu tiếng Việt được chuẩn hóa, ví dụ Ánh vào A, Đức vào D.

## Kết quả kiểm tra TH5C trước khi tích hợp TH5D

- Build project/solution: **0 lỗi, 0 cảnh báo**.
- **68 kiểm tra chức năng** của bảy bài mới và menu vượt qua: dữ liệu hợp lệ/không hợp lệ, chống trùng, xử lý chưa chọn, xóa đúng cấp node, thống kê ước số, biến đổi tên/số, tra từ hai chiều và phân nhóm tên có dấu.
- **253 kiểm tra bố cục** đối chiếu các cặp control đang hiển thị để phát hiện chồng lấn: vượt qua.
- Đã render và xem 10 cửa sổ gồm menu và chín bài. Các kiểm tra này thực hiện ở môi trường Windows hiện tại; không thay cho kiểm tra mọi mức DPI hoặc mọi kích thước màn hình.
- Khi kiểm tra tự động form mới, hộp thoại được ghi đè để ghi nhận thông báo hoặc trả lời Yes/No/Input. Logic xác nhận được kiểm tra, nhưng không tuyên bố đã thao tác trực tiếp mọi MessageBox/InputBox. Cần chạy F5 để quan sát các hộp thoại.

## Nhật ký ngày 11/10/2026

1. Tạo solution Lab05 và project TH5C. Project ban đầu nằm ở cấp gốc repo, cùng cấp với thư mục Lab05.
2. Dựng giao diện Mẫu 1 với hai ListBox và các nút chuyển một mục, chuyển tất cả, chuyển các mục đang chọn.
3. Thêm dữ liệu ban đầu Cóc, Ổi, Xoài, Me, Bưởi, Cam vào ListBox trái.
4. Gặp lỗi Visual Studio không tìm thấy TH5C.exe. Kiểm tra thấy namespace và tên lớp trong file code chính không khớp với Designer.
5. Xóa sự kiện cũ button2_Click và dòng nối trùng sự kiện của nút chuyển tất cả sang trái trong Designer.
6. Đồng bộ namespace thành TH5C; lớp và constructor thành fmMauListBox; tên handler FormClosing cũng được đồng bộ. Program.cs dùng new fmMauListBox().
7. Build solution thành công, 0 lỗi và 0 cảnh báo; xác nhận đã tạo TH5C.exe.
8. Chuyển toàn bộ thư mục TH5C vào Lab05/TH5C. Sửa tham chiếu trong Lab05.slnx từ ../TH5C/TH5C.csproj thành TH5C/TH5C.csproj.
9. Build solution tại vị trí mới thành công, 0 lỗi và 0 cảnh báo. Khi Visual Studio báo solution bị sửa bên ngoài, chọn Reload để tải đường dẫn mới.
10. Bắt đầu Mẫu 2: kiểm tra hai file fmMauDantoc.cs và fmMauDantoc.Designer.cs đều khai báo lớp M_Bai2 trong namespace TH5C. Tại thời điểm ghi nhật ký, form chưa có control và chưa có xử lý dân tộc.
11. Kiểm tra lại khi được yêu cầu sửa lỗi: chạy `dotnet build Lab05.slnx` trên solution hiện tại, kết quả 0 lỗi và 0 cảnh báo. Hai phần của lớp M_Bai2 vẫn khớp namespace TH5C. Bản Mẫu 2 đã lưu chỉ có InitializeComponent, chưa có control hoặc handler. Program.cs vẫn chạy fmMauListBox. Chưa có lỗi biên dịch mới được tái hiện trên bản đã lưu.


12. Sau khi code Mẫu 2 được lưu, build tái hiện lỗi CS0115 tại fmMauDantoc.Dispose(bool). Code chính vẫn khai báo M_Bai2 trong khi Designer và Program.cs đã dùng fmMauDantoc. Đồng bộ tên lớp và constructor trong code chính thành fmMauDantoc, giữ namespace TH5C.
13. Phát hiện InitializeComponent tạo 5 control nhưng thiếu phần gắn control vào form và thiết lập cửa sổ. Bổ sung Controls.Add cho cả 5 control, AutoScaleMode, ClientSize, Name, StartPosition, Text, SuspendLayout/ResumeLayout/PerformLayout; giữ nguyên vị trí control đã thiết kế. Sửa chữ nút Hiện thị thành Hiển thị.
14. Build solution sau sửa thành công: 0 lỗi, 0 cảnh báo. Chương trình kiểm tra không mở cửa sổ xác nhận: form chứa đúng 5 control, ComboBox dùng DropDownList, nút Hiển thị xử lý được trường hợp chưa chọn, Load thêm đúng 5 mục, Load nhiều lần không trùng, Label hiện Hoa khi đã chọn, nạp lại sau lựa chọn không gây lỗi. Hộp MessageBox khi chọn dân tộc và bố cục hiển thị vẫn cần tự kiểm tra bằng F5.

15. Theo yêu cầu triển khai toàn bộ phần còn lại của đề, thêm Mẫu 3, hai bài tại lớp, bài xử lý chuỗi và ba bài về nhà vào cùng project TH5C. Hai bài mẫu đã làm được giữ nguyên.
16. Thêm fmChonBai để mở cả chín bài từ menu. Mỗi bài mở bằng ShowDialog; đóng bài quay lại menu. Program.cs chạy fmChonBai thay vì phải sửa dòng chạy form mỗi lần đổi bài.
17. Tách giao diện của mỗi form mới vào file .Designer.cs; code xử lý ở file .cs. Thêm LabForm làm lớp chung cho hộp thoại thông báo, xác nhận và InputBox.
18. Trong quá trình triển khai, gặp cảnh báo CS8669 ở file Designer do dùng kiểu nullable trong mã được compiler coi là sinh tự động. Bổ sung #nullable enable cho các Designer mới. Gặp bố cục bị cắt chữ/co giãn không đồng đều trong ảnh render; đặt font trước khi dựng control, dùng AutoScaleMode.Dpi và kích thước thiết kế 96 DPI, sau đó kiểm tra lại.
19. Kiểm tra chức năng các bài mới: 68 kiểm tra vượt qua; thêm 253 kiểm tra các cặp control để phát hiện chồng lấn, tổng 321 kiểm tra vượt qua. Render 10 form gồm menu và 9 bài để xem bố cục. Build bản cuối không có lỗi hoặc cảnh báo. Các hộp thoại xác nhận/thông báo của form mới được thay bằng phản hồi kiểm tra khi chạy tự động; cần F5 để quan sát trực tiếp hộp thoại trên máy.

20. Khi đưa bản đầy đủ vào repo, build gặp MSB3026/MSB3027/MSB3021 vì ứng dụng TH5C đang chạy và khóa TH5C.exe. Build code thực tế sang thư mục kiểm tra riêng thành công, 0 lỗi và 0 cảnh báo; kiểm tra lại vẫn vượt qua 321 kiểm tra. Sau khi tiến trình khóa file kết thúc, build lại Lab05.slnx vào thư mục bin mặc định thành công, 0 lỗi và 0 cảnh báo. Khi gặp lại tình huống này, dùng Shift+F5 để dừng debug và đóng cửa sổ TH5C trước khi build.


21. Tích hợp bài làm 5d từ thư mục được cung cấp, đổi namespace thành TH5D, chuẩn hóa tên form và Designer. Thêm ProjectReference đến TH5C để menu 5d có thể mở menu bài 5c; bổ sung TH5D và Tests vào Lab05.slnx.
22. Loại các bài mẫu 5d khỏi phạm vi tích hợp. Bổ sung phần bản gửi chưa có: chuyển lớp, form nhập học viên, đếm ngược và menu chung.
23. Sửa ContextMenuStrip chưa gắn ListView; thiết lập FullRowSelect/SingleSelect; giữ mã sinh viên không sửa. Sửa cách tính tổng tài khoản bằng decimal trong Tag, kiểm tra số âm, số lẻ quá hai chữ số, tài khoản trùng và tổng tràn.
24. Chuẩn hóa bốn form SQL dùng QLSinhVien/dbo và tên cột theo đề. Điểm truyền tham số Decimal, ngày sinh dùng Date; thêm cấu hình kết nối chung và script schema/dữ liệu mẫu. Chưa chạy script hoặc CRUD vì kết nối SQL Server thực tế chưa thành công.
25. Rà soát lại cả TH5C, tái sử dụng LabForm cho hai form mẫu đầu và kiểm tra các chức năng. Giữ ba file project khởi tạo cũ trong Legacy dạng .txt để tránh gọi Form1 không tồn tại hoặc gom code các project con.
26. Build solution cuối 0 lỗi, 0 cảnh báo. 155 kiểm tra chức năng và 638 kiểm tra bố cục vượt qua; render/xem 20 cửa sổ. Báo cáo giải thích từng bài nằm ở BAO_CAO_LAB05.md và BaoCaoLab05.pdf; phân biệt rõ kết quả kiểm tra giả lập SQL với việc lưu database thật.

## Mẫu 1 - Kiến thức cần hiểu

- `Items` là tập hợp dữ liệu của ListBox. `Add` thêm một mục; `AddRange` thêm nhiều mục; `RemoveAt` xóa theo chỉ số; `Clear` xóa toàn bộ.
- `SelectedIndex` là chỉ số của mục đang chọn; giá trị -1 nghĩa là chưa chọn.
- `SelectionMode.MultiExtended` cho phép chọn nhiều mục với Ctrl hoặc Shift.
- Khi chuyển nhiều mục, chụp các chỉ số thành một mảng trước. Thêm sang ListBox đích theo thứ tự, rồi xóa khỏi nguồn theo chỉ số giảm dần để không bị lệch vị trí.
- `FormClosing` xử lý xác nhận đóng cửa sổ. Đặt `e.Cancel = true` giữ cửa sổ mở khi người dùng không đồng ý.
- Các file code chính và Designer dùng `partial` để ghép thành một lớp. Namespace và tên lớp phải khớp; constructor phải mang tên lớp.

### Tình huống tự kiểm tra Mẫu 1

| Thao tác | Kết quả mong đợi |
|---|---|
| Chọn Ổi bên trái, bấm > | Ổi sang phải và bị xóa khỏi trái |
| Chọn Ổi bên phải, bấm < | Ổi sang trái và bị xóa khỏi phải |
| Bấm >> rồi << | Toàn bộ danh sách chuyển qua lại |
| Ctrl chọn Cóc, Xoài, Cam rồi bấm Chuyển tùy ý | Chỉ ba mục được chọn chuyển sang phải |
| Bấm > hoặc < khi chưa chọn | Có thông báo, ứng dụng vẫn hoạt động |
| Đóng cửa sổ và chọn No | Form vẫn mở |

## Các lỗi đã gặp và cách sửa

| Hiện tượng | Nguyên nhân đã xác định | Cách sửa | Điều cần nhớ |
|---|---|---|---|
| Debug executable TH5C.exe does not exist | Project chưa build được do code chính và Designer khai báo hai lớp khác nhau | Sửa namespace và tên lớp, rồi build lại; đã xác nhận tạo được exe | Kiểm tra lỗi Build trong Output/Error List khi chưa có file chạy |
| fmMauListBox.Dispose(bool): no suitable method found to override | Designer khai báo TH5C.fmMauListBox, còn code chính khai báo TH05c.frmMauListBox : Form | Đồng bộ hai phần thành TH5C.fmMauListBox | Giữ hàm Dispose do Designer sinh; sửa chỗ khai báo lớp |
| Designer còn nối button2_Click | File Designer giữ sự kiện cũ, trong khi code được thay không còn hàm này | Xóa dòng nối sự kiện cũ | Khi thay code, kiểm tra các handler đang nối trong Designer |
| Nút << được nối ở hai nơi | Designer và constructor cùng nối btnTraiAll_Click | Giữ nối trong constructor, bỏ dòng trong Designer | Mỗi handler chỉ nối một lần |
| TH5C nằm ngoài Lab05 | Vị trí lưu project được đặt ở gốc repo | Chuyển TH5C vào Lab05, sửa Project Path của solution | Tên solution và Location của project là hai thiết lập riêng |
| File Modification Detected | Solution được sửa trên đĩa khi Visual Studio đang mở | Chọn Reload | Reload tải phiên bản mới từ đĩa |
| CS0115 ở fmMauDantoc.Dispose(bool) của Mẫu 2 | Code chính khai báo M_Bai2, còn Designer khai báo fmMauDantoc | Đồng bộ lớp và constructor thành TH5C.fmMauDantoc; Program.cs cũng dùng tên đó | Hai phần partial phải có cùng namespace và tên lớp |
| Designer tạo control nhưng chưa gắn vào form | InitializeComponent thiếu Controls.Add và phần thiết lập form | Thêm cả 5 control vào Controls, khôi phục thiết lập cửa sổ và layout | Tạo đối tượng control chưa đủ; phải đưa nó vào cây control của form |
| CS8669 trong Designer mới | File được compiler xem là mã sinh tự động có dùng kiểu nullable nhưng chưa bật ngữ cảnh nullable | Thêm #nullable enable đầu các Designer mới | Nullable trong code chính và mã sinh tự động cần có ngữ cảnh phù hợp |
| Nhãn/nút bị cắt chữ hoặc chồng lấn trong ảnh render | Font và hệ số tự co giãn chưa thống nhất với kích thước thiết kế | Đặt font trước control, dùng AutoScaleMode.Dpi với mốc 96 DPI và tăng kích thước nút | Build thành công chưa đảm bảo giao diện dễ dùng; phải xem bố cục thực tế |
| MSB3026, MSB3027, MSB3021: không chép được TH5C.exe | Tiến trình TH5C đang chạy và khóa file đích | Shift+F5 dừng debug, đóng TH5C rồi build lại; bản cuối đã build thành công | Đọc tên tiến trình khóa file trong Output; lỗi này không phải lỗi cú pháp C# |

## Mẫu 2 - Cách thực hiện và kiến thức

Đề yêu cầu: nhấn Load để đưa 5 dân tộc vào ComboBox; nhấn Hiển thị để hiện lựa chọn trong Label/TextBox; khi thay đổi lựa chọn thì hiện MessageBox.

Form hiện dùng tên lớp `fmMauDantoc`, namespace `TH5C`. File code chính, Designer và Program.cs đã thống nhất tên này. Tên cũ M_Bai2 được ghi trong nhật ký để giải thích lỗi đã gặp.

### Control đang dùng

| Control | (Name) | Thiết lập |
|---|---|---|
| Button | btnLoad | Text: Load dữ liệu ComboBox |
| Label | lblDanToc | Text: Dân tộc |
| ComboBox | cboDanToc | DropDownStyle: DropDownList; Items để trống |
| Button | btnHienThi | Text: Hiển thị |
| Label | lblKetQua | AutoSize: True; Text: Chưa chọn dân tộc |

Nối Button.Click và ComboBox.SelectedIndexChanged trong constructor sau InitializeComponent, theo cách đã dùng ở Mẫu 1. Không nối lại cùng handler trong Designer.

### Thứ tự làm

1. Dựng giao diện và đặt đúng (Name) cho từng control.
2. Tạo handler btnLoad_Click: Clear các Items cũ, AddRange 5 dân tộc Kinh, Hoa, K’Me, H’Mong, Khác. Reset Label kết quả khi nạp lại.
3. Tạo handler btnHienThi_Click: nếu SelectedIndex là -1, hiện thông báo chưa chọn trong Label; nếu đã chọn, hiện SelectedItem.
4. Tạo handler cboDanToc_SelectedIndexChanged: kiểm tra SelectedIndex trước khi hiện MessageBox. Clear danh sách có thể làm lựa chọn trở về -1 và phát sinh sự kiện này.
5. Mở Mẫu 2 từ menu chọn bài. Khi cần chạy riêng để debug, có thể dùng `Application.Run(new fmMauDantoc());`.
6. Build rồi chạy kiểm tra. Chỉ đánh dấu hoàn thành sau khi đã quan sát kết quả.

### Các khái niệm

- `Items`: toàn bộ danh sách. Sau khi Load có 5 mục.
- `SelectedIndex`: vị trí chọn tính từ 0. Kinh là 0, Hoa là 1, Khác là 4; -1 là chưa chọn.
- `SelectedItem`: đối tượng đang được chọn, ví dụ chuỗi Hoa. Khi chưa chọn có thể là null.
- `DropDownList`: chỉ cho chọn dữ liệu đã nạp. Người dùng không nhập một dân tộc tùy ý.
- `Click`: chỉ chạy khi nhấn nút. `SelectedIndexChanged`: chạy khi vị trí lựa chọn thay đổi, kể cả thay đổi do code.
- `InitializeComponent()`: tạo control và đặt thuộc tính do Designer sinh. Nối sự kiện hoặc dùng control sau lệnh này.
- `object? sender`: đối tượng phát sinh sự kiện, có thể null theo khai báo. `EventArgs e`: dữ liệu sự kiện. Chúng là tham số của handler, không phải dữ liệu dân tộc.
- `$"Dân tộc được chọn: {cboDanToc.SelectedItem}"`: chuỗi nội suy; biểu thức trong dấu ngoặc nhọn được đưa vào chuỗi hiển thị.

### Tình huống tự kiểm tra Mẫu 2

| Thao tác | Kết quả mong đợi |
|---|---|
| Mở form | ComboBox rỗng, Label báo chưa chọn |
| Bấm Hiển thị trước khi chọn | Label báo chưa chọn; không có lỗi |
| Bấm Load | Có đúng 5 dân tộc |
| Chọn Hoa | MessageBox xuất hiện với dân tộc Hoa |
| Đóng MessageBox, bấm Hiển thị | Label hiện Dân tộc được chọn: Hoa |
| Bấm Load nhiều lần | Vẫn chỉ có 5 mục; không báo lỗi khi lựa chọn bị xóa |
| Chọn lại mục đang chọn | SelectedIndex không thay đổi; không kỳ vọng có MessageBox mới |

## Kết quả lần sửa Mẫu 2 trước khi thêm menu

- Solution được kiểm tra: `Lab05.slnx`; project được build: `TH5C/TH5C.csproj`.
- Lỗi trước khi sửa: **CS0115**, tên lớp của hai phần partial không khớp.
- Kết quả build sau sửa: **0 lỗi, 0 cảnh báo**.
- Trong lần sửa này, file code chính và Designer được đồng bộ thành `TH5C.fmMauDantoc`; constructor cùng tên. Lúc đó Program.cs chạy new fmMauDantoc(); hiện tại ứng dụng khởi động bằng menu chọn bài.
- Form đã gắn 5 control: lblDanToc, btnLoad, btnHienThi, cboDanToc, lblKetQua.

### Kết quả kiểm tra chức năng không mở cửa sổ

| Kiểm tra đã thực hiện | Kết quả |
|---|---|
| Khởi tạo form, kiểm tra cây Controls | Có đủ 5 control |
| Kiểm tra DropDownStyle | DropDownList |
| Gọi sự kiện Click của Hiển thị khi chưa chọn | Label báo Bạn chưa chọn dân tộc |
| Gọi sự kiện Click của Load | Có 5 mục |
| Gọi Load lần nữa | Vẫn có 5 mục |
| Chọn Hoa và gọi Hiển thị | Label hiện Dân tộc được chọn: Hoa |
| Nạp lại khi đang có lựa chọn | Lựa chọn trở về -1, danh sách có 5 mục, không phát sinh lỗi |

Kiểm tra Label khi chọn Hoa tạm tháo handler MessageBox để không mở hộp thoại trong chương trình kiểm tra. Do đó kết quả trên không xác nhận MessageBox hoặc bố cục đã được quan sát trực tiếp. Chạy F5, chọn dân tộc và kiểm tra giao diện theo bảng tự kiểm tra Mẫu 2.

### Vì sao sửa hai phần này

`partial` cho phép chia một lớp thành nhiều file. Code chính cung cấp `: Form`; Designer cung cấp các control và InitializeComponent. Nếu hai file dùng tên lớp khác nhau, chúng trở thành hai lớp riêng. Lớp Designer không còn kế thừa Form nên override Dispose bị lỗi CS0115.

`new Label()` hoặc `new Button()` chỉ tạo đối tượng. `Controls.Add(...)` gắn đối tượng đó vào form để nó thuộc giao diện. Bổ sung phần này xử lý vấn đề control đã được tạo nhưng chưa được gắn vào cửa sổ.

### Lưu code trước khi nhờ kiểm tra

Các thay đổi chưa lưu trong editor có thể khác nội dung file trên đĩa. Nhấn Ctrl+Shift+S trước khi build hoặc nhờ kiểm tra repo. Nếu Visual Studio hỏi tải lại file đã sửa bên ngoài, chọn Reload để dùng nội dung mới.


## Đọc hiểu các bài còn lại

### Mẫu 3 - Phòng ban và nhân viên

1. Đọc InitializeComponent để biết vị trí TreeView, ComboBox và các TextBox.
2. Đọc constructor: Load và Click được nối với các handler đúng một lần.
3. Load thêm bốn phòng ban vào cả TreeView và ComboBox. Phòng ban là node gốc, nhân viên là node con.
4. Thêm phòng ban: Trim tên, kiểm tra rỗng/trùng, rồi thêm vào cả hai control.
5. Xóa phòng ban: SelectedNode phải là node gốc. Sau khi xác nhận, xóa node và mục ComboBox tương ứng. Nếu hết phòng ban, SelectedIndex được đặt -1.
6. Thêm nhân viên: tìm node theo phòng ban đang chọn; lưu mã, tên, địa chỉ trong Tag. Hiển thị node theo mẫu “Họ tên (Mã số)”. Có kiểm tra mã nhân viên trùng để tránh nhập lặp.

### Tại lớp 1 - Ước số

ComboBox lưu int, không lưu chuỗi. SelectedIndexChanged đọc số đã chọn và cập nhật ListBox. TimUoc duyệt tới căn bậc hai: nếu i là ước thì n/i cũng là ước; khi hai số bằng nhau chỉ thêm một lần. Sau đó sắp xếp tăng dần.

Ba nút thống kê tính trực tiếp từ Items của ListBox. Tổng dùng long; đếm nguyên tố loại 1 và thử chia tới căn bậc hai. Điều kiện i <= n/i tránh phép nhân i*i bị tràn số.

Phím truy cập dùng ký tự &: Alt+C cập nhật, Alt+T tính tổng, Alt+H đếm chẵn, Alt+N đếm nguyên tố, Alt+O thoát. FormClosing dùng xác nhận cho cả nút Thoát và dấu X.

### Tại lớp 2 - Lớp và sinh viên

Cấu trúc TreeView:

```text
Danh sách lớp
└── 05DHTH1
    └── SV01, Nguyễn Văn A
        └── TP HCM
```

Tag của node sinh viên chứa đối tượng SinhVien; node lớp và địa chỉ không có Tag loại này. Nút Xóa kiểm tra Tag trước khi xóa, vì thế không xóa nhầm lớp hoặc địa chỉ. AfterSelect đọc Tag để điền các TextBox và ComboBox lớp. Mã sinh viên là chuỗi để giữ số 0 ở đầu nếu có.

CheckedChanged của checkbox đặt Visible cho cả GroupBox; các control con nằm trong nhóm nên cùng ẩn/hiện. Nút Cập nhật thực hiện thêm sinh viên như yêu cầu đề, không sửa bản ghi cũ.

### Nâng cao - Xử lý họ tên

Random chọn độc lập một phần tử của mỗi mảng HO, TENLOT, TEN; mỗi lần bấm thêm 50 tên, có thể có tên trùng vì đề không yêu cầu duy nhất. Xóa tên Sơn so sánh từ cuối, xóa họ Lê so sánh từ đầu, thay vì tìm chuỗi con.

Khi xóa nhiều mục, chụp SelectedIndices thành mảng rồi xóa giảm dần. Khi đổi kiểu chữ, chụp chỉ số và khôi phục lựa chọn để có thể đổi tiếp. ToTitleCase áp dụng sau ToLower với culture vi-VN. Double click dùng IndexFromPoint để xác định đúng tên được bấm; InputBox rỗng/Cancel giữ tên cũ.

### Về nhà 1 - Từ điển

TabControl chứa hai chiều tra cứu. Cùng một List cặp từ được dùng cho cả hai chiều. TextChanged của ComboBox tìm mục bắt đầu bằng phần vừa nhập rồi cuộn ListBox tới mục đó. Không ghi ngược vào ComboBox trong TextChanged để tránh làm con trỏ nhập nhảy hoặc tạo vòng lặp sự kiện.

Nút Enter, phím Enter và double click gọi cùng logic tra từ. Tra ưu tiên khớp đầy đủ; nếu đang nhập tiền tố thì dùng mục gợi ý. Việt–Anh có thể trả nhiều từ, ví dụ nhà -> house; home.

### Về nhà 2 - ListBox số

ListBox chứa BigInteger. Các nút thay đổi dữ liệu đều thao tác với giá trị số: tổng, cộng 2, bình phương. Xóa đầu/cuối xử lý riêng danh sách rỗng hoặc chỉ có một mục. Chọn chẵn/lẻ gọi ClearSelected trước, rồi SetSelected cho từng mục đúng điều kiện. Số 0 là số chẵn.

### Về nhà 3 - Danh bạ

Load tạo 26 node có key A tới Z. Khi thêm, chuẩn hóa chữ cái đầu của First Name rồi tìm node theo key. Ví dụ First Name=Bình, Last Name=Ngô Thanh tạo “Bình, Ngô Thanh” trong node B. Normalize(FormD) tách dấu khỏi chữ, riêng Đ chuyển thành D.

### Vai trò của LabForm

LabForm kế thừa Form và cung cấp ThongBao, XacNhan, NhapChuoi. Form bài tập mới kế thừa LabForm để dùng chung các hộp thoại. Các phương thức virtual cho phép chương trình kiểm tra thay hộp thoại bằng kết quả giả định; ứng dụng bình thường vẫn dùng MessageBox/InputBox.

## Dữ liệu tự chạy kiểm tra

| Bài | Thao tác | Kết quả mong đợi |
|---|---|---|
| Phòng ban | Thêm Nghiên cứu, thêm NGHIÊN CỨU lần nữa | Chỉ có một phòng; TreeView và ComboBox khớp |
| Phòng ban | Chọn node nhân viên rồi Xóa phòng ban | Báo phải chọn phòng ban |
| Ước số | Nhập 12 | Ước 1,2,3,4,6,12; tổng 28; chẵn 4; nguyên tố 2 |
| Ước số | Nhập 1 hoặc 36 | 1 không là nguyên tố; ước 6 của 36 chỉ xuất hiện một lần |
| Sinh viên | Thêm SV01 rồi thêm SV01 vào lớp khác | Báo trùng mã; không thêm lần hai |
| Sinh viên | Chọn node mã sinh viên | Điền lại đủ mã, họ tên, địa chỉ và lớp |
| Chuỗi | Thêm 50 tên; chọn nhiều mục để đổi HOA/thường/hoa đầu | Chỉ các mục chọn thay đổi |
| Chuỗi | Double click một tên | InputBox cho thay tên đúng vị trí |
| Từ điển | Anh–Việt nhập stu rồi Enter | sinh viên |
| Từ điển | Việt–Anh nhập nhà rồi Enter | house; home |
| List số | Nhập 0,1,2,3; tính tổng, chọn chẵn/lẻ | Tổng 6; chẵn 0,2; lẻ 1,3 |
| List số | Xóa đầu/cuối rồi tăng 2, bình phương | 1,2 -> 3,4 -> 9,16 |
| Danh bạ | Bình / Ngô Thanh; Ánh / Nguyễn; Đức / Trần | Vào nhóm B, A, D tương ứng |

## Ghi chú khi chỉnh code

- Namespace, tên lớp và constructor của hai phần partial phải khớp. Đừng sửa Dispose để xử lý lỗi CS0115 do tên lớp khác nhau.
- Dùng đúng (Name) của control; Text chỉ là chữ hiển thị.
- Các form mới nối sự kiện trong constructor. Tránh nối lại cùng handler trong Designer.
- File Designer mới có #nullable enable để khai báo IContainer? không phát sinh CS8669.
- Các form mới dùng co giãn theo DPI. Nếu sửa bố cục, chạy lại để kiểm tra nhãn dài, nút và các control trong GroupBox.
- Các bài dùng dữ liệu trong bộ nhớ. Bổ sung lưu file là công việc khác nếu cần giữ dữ liệu qua các lần chạy.

## Cách duy trì nhật ký

Sau mỗi phần bài làm, bổ sung: đã làm gì, tại sao chọn cách xử lý đó, lỗi gặp thực tế, cách sửa, kết quả kiểm tra đã quan sát. Ghi rõ phần chỉ mới được hướng dẫn hoặc chưa chạy thử; không coi bảng kết quả mong đợi là kết quả đã kiểm tra.

## Báo cáo Word và lần rà soát lại toàn bộ Lab05

Ngày 11/10/2026: đọc lại code TH5C/TH5D, kiểm tra các sự kiện và chạy lại bộ kiểm tra trên solution hiện tại. Build đạt **0 lỗi, 0 cảnh báo**; **155 kiểm tra chức năng và 638 kiểm tra bố cục**, tổng **793**, đều vượt qua. Chưa phát hiện lỗi mới trong phạm vi đã kiểm tra.

[Báo cáo Word định dạng .doc](BaoCaoLab05.doc) có 8 trang, trình bày trắng đen. Mỗi bài gồm nội dung, code chính trích từ bản hiện tại, giải thích và kết quả. Báo cáo ghi lại các lỗi đã xử lý trước đó và giới hạn kiểm tra.

Kết nối SQL chỉ đọc vẫn thất bại (lỗi -1). Kiểm tra SQL dùng bộ thực thi giả để đối chiếu lệnh/tham số; chưa kiểm thử thêm, sửa, xóa với database thật và chưa chạy script tạo database.
