using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal sealed partial class ProductForm : Form
    {
        internal ProductForm()
        {
            InitializeComponent();
        }

        private async void AddButton_Click(object? sender, EventArgs e)
        {
            var productName = productNameTextBox.Text.Trim();
            var productCode = productCodeTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(productCode) || string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Vui lòng nhập mã và tên sản phẩm.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var today = DateTime.Today;
                using var connection = Database.CreateConnection();
                await connection.OpenAsync();
                using var transaction = (SqlTransaction)await connection.BeginTransactionAsync();

                try
                {
                    const string insertProductSql = "INSERT INTO SANPHAM (MaSP, TenSP) VALUES (@MaSP, @TenSP);";
                    using var productCommand = new SqlCommand(insertProductSql, connection, transaction);
                    productCommand.Parameters.AddWithValue("@MaSP", productCode);
                    productCommand.Parameters.AddWithValue("@TenSP", productName);
                    await productCommand.ExecuteNonQueryAsync();

                    const string insertStockSql = "INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan) VALUES (@MaSP, @NgayTon, 0, 0, 0)";
                    using var stockCommand = new SqlCommand(insertStockSql, connection, transaction);
                    stockCommand.Parameters.AddWithValue("@MaSP", productCode);
                    stockCommand.Parameters.AddWithValue("@NgayTon", today);
                    await stockCommand.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();

                    MessageBox.Show($"Đã thêm sản phẩm. Mã sản phẩm: {productCode}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productCodeTextBox.Clear();
                    productNameTextBox.Clear();
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
            catch (Exception ex)
            {
                Database.ShowDatabaseError(ex);
            }
        }

        private void CloseButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
