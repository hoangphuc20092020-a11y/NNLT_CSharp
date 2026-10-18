using Microsoft.Data.SqlClient;

namespace WinFormsApp1._6b
{
    public partial class Form_3_1 : Form
    {
        private readonly string connectionString =
            "Server=localhost,1433;Database=QLSinhVien;User Id=sa;Password=YourStrong@Pass123;Encrypt=True;TrustServerCertificate=True;Connection Timeout=15;";

        public Form_3_1()
        {
            InitializeComponent();
        }

        private async void buttonHienThi_Click(object sender, EventArgs e)
        {
            await LoadClassesAsync();
        }

        private async Task LoadClassesAsync()
        {
            var listViewUpdating = false;
            try
            {
                using var connection = new SqlConnection(connectionString);
                using var command = new SqlCommand(
                    "SELECT MaLop, TenLop, MaKhoa FROM Lop ORDER BY MaLop",
                    connection);
                await connection.OpenAsync();

                using var reader = await command.ExecuteReaderAsync();
                listView1.BeginUpdate();
                listViewUpdating = true;
                listView1.Items.Clear();

                var sequence = 1;
                while (await reader.ReadAsync())
                {
                    var item = new ListViewItem(sequence.ToString());
                    item.SubItems.Add(reader["MaLop"].ToString() ?? string.Empty);
                    item.SubItems.Add(reader["TenLop"].ToString() ?? string.Empty);
                    item.SubItems.Add(reader["MaKhoa"].ToString() ?? string.Empty);
                    listView1.Items.Add(item);
                    sequence++;
                }

                listView1.EndUpdate();
                listViewUpdating = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    $"Không thể tải danh sách lớp từ cơ sở dữ liệu: {ex.Message}",
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (listViewUpdating)
                {
                    listView1.EndUpdate();
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}