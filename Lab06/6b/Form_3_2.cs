using Microsoft.Data.SqlClient;

namespace WinFormsApp1._6b
{
    public partial class Form_3_2 : Form
    {
        private readonly string connectionString =
            "Server=localhost,1433;Database=QLSinhVien;User Id=sa;Password=YourStrong@Pass123;Encrypt=True;TrustServerCertificate=True;Connection Timeout=15;";

        public Form_3_2()
        {
            InitializeComponent();
        }

        private async void Form_3_2_Load(object sender, EventArgs e)
        {
            await LoadSubjectsAsync();
            await LoadScoresAsync(string.Empty);
        }

        private async Task LoadSubjectsAsync()
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand("SELECT MaMH FROM MonHoc ORDER BY MaMH", connection);
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                var subjects = new List<string> { string.Empty };
                while (await reader.ReadAsync())
                {
                    subjects.Add(reader["MaMH"].ToString() ?? string.Empty);
                }

                comboBoxMonHoc.DataSource = subjects;
                comboBoxMonHoc.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private async void buttonHienThi_Click(object sender, EventArgs e)
        {
            var maMonHoc = comboBoxMonHoc.SelectedItem?.ToString() ?? string.Empty;
            await LoadScoresAsync(maMonHoc);
        }

        private async Task LoadScoresAsync(string maMonHoc)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                const string query = """
                    SELECT sv.HoTen, sv.NgaySinh, mh.TenMH, d.Diem
                    FROM Diem AS d
                    INNER JOIN SinhVien AS sv ON sv.MaSV = d.MaSV
                    INNER JOIN MonHoc AS mh ON mh.MaMH = d.MaMH
                    WHERE @MaMH = N'' OR d.MaMH = @MaMH
                    ORDER BY sv.HoTen, mh.TenMH
                    """;
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMH", maMonHoc);
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                listViewDiem.BeginUpdate();
                try
                {
                    listViewDiem.Items.Clear();
                    decimal total = 0;
                    var sequence = 1;

                    while (await reader.ReadAsync())
                    {
                        var diem = Convert.ToDecimal(reader["Diem"]);
                        var item = new ListViewItem(sequence.ToString());
                        item.SubItems.Add(reader["HoTen"].ToString() ?? string.Empty);
                        item.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(reader["TenMH"].ToString() ?? string.Empty);
                        item.SubItems.Add(diem.ToString("0.##"));
                        listViewDiem.Items.Add(item);

                        total += diem;
                        sequence++;
                    }

                    textBoxTongDiem.Text = total.ToString("0.##");
                }
                finally
                {
                    listViewDiem.EndUpdate();
                }
            }
            catch (SqlException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private static void ShowDatabaseError(SqlException ex)
        {
            MessageBox.Show(
                $"Không thể tải dữ liệu điểm: {ex.Message}",
                "Lỗi cơ sở dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}