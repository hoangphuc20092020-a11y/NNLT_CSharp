using System.Globalization;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1._6b
{
    public partial class Form_2_2 : Form
    {
        private readonly string connectionString =
            "Server=localhost,1433;Database=QLSinhVien;User Id=sa;Password=YourStrong@Pass123;Encrypt=True;TrustServerCertificate=True;Connection Timeout=15;";

        public Form_2_2()
        {
            InitializeComponent();
        }

        private async void Form_2_2_Load(object sender, EventArgs e)
        {
            await LoadStudentsAsync();
            await LoadSubjectsAsync();
        }

        private async Task LoadStudentsAsync()
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand("SELECT MaSV FROM SinhVien ORDER BY MaSV", connection);
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                var students = new List<string>();
                while (await reader.ReadAsync())
                {
                    students.Add(reader["MaSV"].ToString()!);
                }

                comboBoxSinhVien.DataSource = students;
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async Task LoadSubjectsAsync()
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand("SELECT MaMH FROM MonHoc ORDER BY MaMH", connection);
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                var subjects = new List<string>();
                while (await reader.ReadAsync())
                {
                    subjects.Add(reader["MaMH"].ToString()!);
                }

                comboBoxMonHoc.DataSource = subjects;
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (!TryReadScore(out var maSinhVien, out var maMonHoc, out var diem))
            {
                return;
            }

            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                const string foreignKeySql = """
                    SELECT
                        CASE WHEN EXISTS (SELECT 1 FROM SinhVien WHERE MaSV = @MaSV) THEN 1 ELSE 0 END,
                        CASE WHEN EXISTS (SELECT 1 FROM MonHoc WHERE MaMH = @MaMH) THEN 1 ELSE 0 END
                    """;
                using (var foreignKeyCommand = new SqlCommand(foreignKeySql, connection))
                {
                    foreignKeyCommand.Parameters.AddWithValue("@MaSV", maSinhVien);
                    foreignKeyCommand.Parameters.AddWithValue("@MaMH", maMonHoc);
                    using var reader = await foreignKeyCommand.ExecuteReaderAsync();
                    await reader.ReadAsync();
                    if (reader.GetInt32(0) == 0 || reader.GetInt32(1) == 0)
                    {
                        MessageBox.Show("Mã sinh viên hoặc mã môn học không tồn tại.", "Khóa ngoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                const string duplicateSql = "SELECT COUNT(1) FROM Diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                using (var duplicateCommand = new SqlCommand(duplicateSql, connection))
                {
                    duplicateCommand.Parameters.AddWithValue("@MaSV", maSinhVien);
                    duplicateCommand.Parameters.AddWithValue("@MaMH", maMonHoc);
                    if ((int)await duplicateCommand.ExecuteScalarAsync()! > 0)
                    {
                        MessageBox.Show("Điểm của sinh viên và môn học này đã tồn tại.", "Trùng khóa chính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                const string insertSql = "INSERT INTO Diem (MaSV, MaMH, Diem) VALUES (@MaSV, @MaMH, @Diem)";
                using var insertCommand = new SqlCommand(insertSql, connection);
                AddScoreParameters(insertCommand, maSinhVien, maMonHoc, diem);
                await insertCommand.ExecuteNonQueryAsync();

                MessageBox.Show("Thêm điểm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDiem.Clear();
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async void buttonSua_Click(object sender, EventArgs e)
        {
            if (!TryReadScore(out var maSinhVien, out var maMonHoc, out var diem))
            {
                return;
            }

            try
            {
                using var connection = new SqlConnection(connectionString);
                const string updateSql = "UPDATE Diem SET Diem = @Diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                using var command = new SqlCommand(updateSql, connection);
                AddScoreParameters(command, maSinhVien, maMonHoc, diem);
                await connection.OpenAsync();
                var affectedRows = await command.ExecuteNonQueryAsync();

                MessageBox.Show(
                    affectedRows == 0 ? "Không tìm thấy điểm cần sửa." : "Sửa điểm thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    affectedRows == 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            if (!TryReadKeys(out var maSinhVien, out var maMonHoc))
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa điểm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand("DELETE FROM Diem WHERE MaSV = @MaSV AND MaMH = @MaMH", connection);
                command.Parameters.AddWithValue("@MaSV", maSinhVien);
                command.Parameters.AddWithValue("@MaMH", maMonHoc);
                await connection.OpenAsync();
                var affectedRows = await command.ExecuteNonQueryAsync();

                MessageBox.Show(
                    affectedRows == 0 ? "Không tìm thấy điểm cần xóa." : "Xóa điểm thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    affectedRows == 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
                if (affectedRows > 0)
                {
                    textBoxDiem.Clear();
                }
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private bool TryReadKeys(out string maSinhVien, out string maMonHoc)
        {
            maSinhVien = comboBoxSinhVien.SelectedValue?.ToString() ?? comboBoxSinhVien.Text.Trim();
            maMonHoc = comboBoxMonHoc.SelectedValue?.ToString() ?? comboBoxMonHoc.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSinhVien) || string.IsNullOrWhiteSpace(maMonHoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã sinh viên và mã môn học.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool TryReadScore(out string maSinhVien, out string maMonHoc, out decimal diem)
        {
            diem = 0;
            if (!TryReadKeys(out maSinhVien, out maMonHoc))
            {
                return false;
            }

            if (!decimal.TryParse(textBoxDiem.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out diem) &&
                !decimal.TryParse(textBoxDiem.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out diem))
            {
                MessageBox.Show("Điểm phải là một số.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static void AddScoreParameters(SqlCommand command, string maSinhVien, string maMonHoc, decimal diem)
        {
            command.Parameters.AddWithValue("@MaSV", maSinhVien);
            command.Parameters.AddWithValue("@MaMH", maMonHoc);
            command.Parameters.AddWithValue("@Diem", diem);
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            var message = ex.Number switch
            {
                2601 or 2627 => "Dữ liệu bị trùng khóa chính.",
                547 => "Không thể thao tác vì vi phạm khóa ngoại.",
                _ => $"Không thể thực hiện thao tác với cơ sở dữ liệu: {ex.Message}"
            };
            MessageBox.Show(message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}