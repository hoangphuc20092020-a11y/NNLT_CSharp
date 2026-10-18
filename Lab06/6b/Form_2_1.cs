using Microsoft.Data.SqlClient;
/*
CREATE DATABASE QLSinhVien;
GO

USE QLSinhVien;
GO

CREATE TABLE Lop (
    MaLop NVARCHAR(20) PRIMARY KEY
);
GO

CREATE TABLE SinhVien (
    MaSV NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    MaLop NVARCHAR(20) NOT NULL,
    FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);
GO

INSERT INTO Lop (MaLop)
VALUES
    ('CNTT01'),
    ('CNTT02'),
    ('CNTT03'),
    ('KTPM01');
GO

SELECT * FROM Lop;
SELECT * FROM SinhVien;
 */
namespace WinFormsApp1._6b
{
    public partial class Form_2_1 : Form
    {

        private readonly string ConnectionString =
            "Server=localhost,1433;" +
            "Database=QLSinhVien;" +
            "User Id=sa;" +
            "Password=YourStrong@Pass123;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;" +
            "Connection Timeout=15;";


        public Form_2_1()
        {
            InitializeComponent();
            dateTimePickerNgaySinh.MaxDate = DateTime.Today;
        }

        private async void Form_2_1_Load(object sender, EventArgs e)
        {
            await LoadClassesAsync();
        }

        private async Task LoadClassesAsync()
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand("SELECT MaLop FROM Lop ORDER BY MaLop", connection);
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                var classes = new List<string>();
                while (await reader.ReadAsync())
                {
                    classes.Add(reader["MaLop"].ToString()!);
                }

                comboBoxLop.DataSource = classes;
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (!TryReadStudent(out var maSinhVien, out var hoTen, out var ngaySinh, out var maLop))
            {
                return;
            }

            try
            {
                using var connection = new SqlConnection(ConnectionString);
                await connection.OpenAsync();

                const string checkSql = "SELECT COUNT(1) FROM SinhVien WHERE MaSV = @MaSV";
                using (var checkCommand = new SqlCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@MaSV", maSinhVien);
                    if ((int)await checkCommand.ExecuteScalarAsync()! > 0)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                const string insertSql = """
                    INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, MaLop)
                    VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)
                    """;
                using var insertCommand = new SqlCommand(insertSql, connection);
                AddStudentParameters(insertCommand, maSinhVien, hoTen, ngaySinh, maLop);
                await insertCommand.ExecuteNonQueryAsync();

                MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearStudentFields();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async void buttonXoaSua_Click(object sender, EventArgs e)
        {
            await UpdateStudentAsync();
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            var maSinhVien = textBoxMaSinhVien.Text.Trim();
            if (string.IsNullOrWhiteSpace(maSinhVien))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await DeleteStudentAsync(maSinhVien);
        }

        private async Task DeleteStudentAsync(string maSinhVien)
        {
            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên {maSinhVien} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand("DELETE FROM SinhVien WHERE MaSV = @MaSV", connection);
                command.Parameters.AddWithValue("@MaSV", maSinhVien);
                await connection.OpenAsync();
                var affectedRows = await command.ExecuteNonQueryAsync();

                MessageBox.Show(
                    affectedRows == 0 ? "Không tìm thấy mã sinh viên cần xóa." : "Xóa sinh viên thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    affectedRows == 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
                if (affectedRows > 0)
                {
                    ClearStudentFields();
                }
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async Task UpdateStudentAsync()
        {
            if (!TryReadStudent(out var maSinhVien, out var hoTen, out var ngaySinh, out var maLop))
            {
                return;
            }

            try
            {
                using var connection = new SqlConnection(ConnectionString);
                const string updateSql = """
                    UPDATE SinhVien
                    SET HoTen = @HoTen, NgaySinh = @NgaySinh, MaLop = @MaLop
                    WHERE MaSV = @MaSV
                    """;
                using var command = new SqlCommand(updateSql, connection);
                AddStudentParameters(command, maSinhVien, hoTen, ngaySinh, maLop);
                await connection.OpenAsync();
                var affectedRows = await command.ExecuteNonQueryAsync();

                MessageBox.Show(
                    affectedRows == 0 ? "Không tìm thấy mã sinh viên cần sửa." : "Sửa sinh viên thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    affectedRows == 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private bool TryReadStudent(out string maSinhVien, out string hoTen, out DateTime ngaySinh, out string maLop)
        {
            maSinhVien = textBoxMaSinhVien.Text.Trim();
            hoTen = textBoxHoTen.Text.Trim();
            ngaySinh = dateTimePickerNgaySinh.Value.Date;
            maLop = comboBoxLop.SelectedValue?.ToString() ?? comboBoxLop.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSinhVien) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(maLop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (DateTime.Today.Year - ngaySinh.Year < 17)
            {
                MessageBox.Show("Sinh viên phải từ 17 tuổi trở lên (tính theo năm sinh).", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static void AddStudentParameters(SqlCommand command, string maSinhVien, string hoTen, DateTime ngaySinh, string maLop)
        {
            command.Parameters.AddWithValue("@MaSV", maSinhVien);
            command.Parameters.AddWithValue("@HoTen", hoTen);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@MaLop", maLop);
        }

        private void ClearStudentFields()
        {
            textBoxMaSinhVien.Clear();
            textBoxHoTen.Clear();
            if (comboBoxLop.Items.Count > 0)
            {
                comboBoxLop.SelectedIndex = 0;
            }
            dateTimePickerNgaySinh.Value = DateTime.Today.AddYears(-18);
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            var message = ex.Number switch
            {
                2601 or 2627 => "Mã sinh viên bị trùng khóa chính.",
                547 => "Không thể thao tác vì dữ liệu đang được tham chiếu bởi bảng khác (vi phạm khóa ngoại).",
                _ => $"Không thể thực hiện thao tác với cơ sở dữ liệu: {ex.Message}"
            };
            MessageBox.Show(message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}