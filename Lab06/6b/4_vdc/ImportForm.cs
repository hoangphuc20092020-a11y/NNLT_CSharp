using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal sealed partial class ImportForm : Form
    {
        internal ImportForm()
        {
            InitializeComponent();
        }

        private async void ImportForm_Load(object? sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                using var connection = Database.CreateConnection();
                using var command = new SqlCommand("SELECT MaSP, TenSP FROM SanPham ORDER BY MaSP", connection);
                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();
                var products = new List<ProductItem>();
                while (await reader.ReadAsync())
                {
                    products.Add(new ProductItem(reader.GetString(0), reader.GetString(1)));
                }
                productComboBox.DataSource = products;
                productComboBox.DisplayMember = nameof(ProductItem.DisplayName);
                productComboBox.ValueMember = nameof(ProductItem.Id);
            }
            catch (Exception ex)
            {
                Database.ShowDatabaseError(ex);
            }
        }

        private async void ImportButton_Click(object? sender, EventArgs e)
        {
            if (productComboBox.SelectedValue is not string productId)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var connection = Database.CreateConnection();
                using var command = new SqlCommand("UPDATE TONKHO SET SLNhap = SLNhap + @SoLuong WHERE MaSP = @MaSP AND NgayTon = @NgayTon", connection);
                command.Parameters.AddWithValue("@SoLuong", (int)quantityInput.Value);
                command.Parameters.AddWithValue("@MaSP", productId);
                command.Parameters.AddWithValue("@NgayTon", DateTime.Today);
                await connection.OpenAsync();
                if (await command.ExecuteNonQueryAsync() == 0)
                {
                    MessageBox.Show("Chưa tạo tồn kho hôm nay. Hãy tạo tồn kho trước khi nhập hàng.", "Không thể nhập hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Nhập hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Database.ShowDatabaseError(ex);
            }
        }

        private sealed record ProductItem(string Id, string Name)
        {
            public string DisplayName => $"{Id} - {Name}";
        }
    }
}
