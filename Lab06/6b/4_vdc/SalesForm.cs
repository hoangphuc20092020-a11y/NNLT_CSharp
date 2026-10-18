using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal sealed partial class SalesForm : Form
    {
        private string? invoiceId;

        internal SalesForm()
        {
            InitializeComponent();
            SetEditingEnabled(false);
        }

        private async void SalesForm_Load(object? sender, EventArgs e)
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

        private async void NewInvoiceButton_Click(object? sender, EventArgs e)
        {
            try
            {
                using var connection = Database.CreateConnection();
                await connection.OpenAsync();
                using var transaction = (SqlTransaction)await connection.BeginTransactionAsync();
                try
                {
                    using var nextIdCommand = new SqlCommand("SELECT ISNULL(MAX(TRY_CONVERT(int, MaHD)), 0) + 1 FROM HOADON WITH (TABLOCKX)", connection, transaction);
                    var nextId = Convert.ToInt32(await nextIdCommand.ExecuteScalarAsync());
                    invoiceId = nextId.ToString();
                    using var command = new SqlCommand("INSERT INTO HOADON (MaHD, NgayTao, TinhTrangThanhToan) VALUES (@MaHD, @NgayTao, 0)", connection, transaction);
                    command.Parameters.AddWithValue("@MaHD", invoiceId);
                    command.Parameters.AddWithValue("@NgayTao", DateTime.Today);
                    await command.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
                invoiceTextBox.Text = invoiceId;
                detailsListView.Items.Clear();
                SetEditingEnabled(true);
                newInvoiceButton.Enabled = false;
            }
            catch (Exception ex)
            {
                Database.ShowDatabaseError(ex);
            }
        }

        private async void AddButton_Click(object? sender, EventArgs e)
        {
            if (invoiceId is null || productComboBox.SelectedValue is not string productId)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn và chọn sản phẩm.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quantity = (int)quantityInput.Value;
            try
            {
                using var connection = Database.CreateConnection();
                await connection.OpenAsync();
                using var transaction = (SqlTransaction)await connection.BeginTransactionAsync();
                try
                {
                    const string stockSql = "SELECT SLDau + SLNhap - SLBan FROM TONKHO WITH (UPDLOCK) WHERE MaSP = @MaSP AND NgayTon = @NgayTon";
                    using var stockCommand = new SqlCommand(stockSql, connection, transaction);
                    stockCommand.Parameters.AddWithValue("@MaSP", productId);
                    stockCommand.Parameters.AddWithValue("@NgayTon", DateTime.Today);
                    var stockValue = await stockCommand.ExecuteScalarAsync();
                    if (stockValue is null || stockValue == DBNull.Value)
                    {
                        MessageBox.Show("Chưa có tồn kho hôm nay cho sản phẩm này.", "Không thể bán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        await transaction.RollbackAsync();
                        return;
                    }

                    var available = Convert.ToInt32(stockValue);
                    if (quantity <= 0 || quantity > available)
                    {
                        MessageBox.Show($"Số lượng bán phải lớn hơn 0 và không vượt quá tồn kho ({available}).", "Số lượng không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        await transaction.RollbackAsync();
                        return;
                    }

                    const string detailSql = "INSERT INTO CHITIET_HOADON (MaHD, MaSP, SoLuong) VALUES (@MaHD, @MaSP, @SoLuong)";
                    using var detailCommand = new SqlCommand(detailSql, connection, transaction);
                    detailCommand.Parameters.AddWithValue("@MaHD", invoiceId);
                    detailCommand.Parameters.AddWithValue("@MaSP", productId);
                    detailCommand.Parameters.AddWithValue("@SoLuong", quantity);
                    await detailCommand.ExecuteNonQueryAsync();

                    using var updateStockCommand = new SqlCommand("UPDATE TONKHO SET SLBan = SLBan + @SoLuong WHERE MaSP = @MaSP AND NgayTon = @NgayTon", connection, transaction);
                    updateStockCommand.Parameters.AddWithValue("@SoLuong", quantity);
                    updateStockCommand.Parameters.AddWithValue("@MaSP", productId);
                    updateStockCommand.Parameters.AddWithValue("@NgayTon", DateTime.Today);
                    await updateStockCommand.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();

                    var product = (ProductItem)productComboBox.SelectedItem;
                    var item = new ListViewItem(productId.ToString());
                    item.SubItems.Add(product.Name);
                    item.SubItems.Add(quantity.ToString());
                    detailsListView.Items.Add(item);
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

        private async void CancelButton_Click(object? sender, EventArgs e)
        {
            if (invoiceId is null)
            {
                return;
            }

            try
            {
                using var connection = Database.CreateConnection();
                await connection.OpenAsync();
                using var transaction = (SqlTransaction)await connection.BeginTransactionAsync();
                try
                {
                    const string restoreStockSql = """
                        UPDATE stock
                        SET stock.SLBan = stock.SLBan - details.TotalQuantity
                        FROM TONKHO AS stock
                        INNER JOIN
                        (
                            SELECT MaSP, SUM(SoLuong) AS TotalQuantity
                            FROM CHITIET_HOADON
                            WHERE MaHD = @MaHD
                            GROUP BY MaSP
                        ) AS details ON details.MaSP = stock.MaSP
                        WHERE stock.NgayTon = @NgayTon
                        """;
                    using var restoreCommand = new SqlCommand(restoreStockSql, connection, transaction);
                    restoreCommand.Parameters.AddWithValue("@MaHD", invoiceId);
                    restoreCommand.Parameters.AddWithValue("@NgayTon", DateTime.Today);
                    await restoreCommand.ExecuteNonQueryAsync();

                    using var detailCommand = new SqlCommand("DELETE FROM CHITIET_HOADON WHERE MaHD = @MaHD", connection, transaction);
                    detailCommand.Parameters.AddWithValue("@MaHD", invoiceId);
                    await detailCommand.ExecuteNonQueryAsync();
                    using var invoiceCommand = new SqlCommand("DELETE FROM HOADON WHERE MaHD = @MaHD AND TinhTrangThanhToan = 0", connection, transaction);
                    invoiceCommand.Parameters.AddWithValue("@MaHD", invoiceId);
                    await invoiceCommand.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();
                    ResetInvoice();
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

        private async void PaymentButton_Click(object? sender, EventArgs e)
        {
            if (invoiceId is null || detailsListView.Items.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có sản phẩm.", "Không thể thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var connection = Database.CreateConnection();
                using var command = new SqlCommand("UPDATE HOADON SET TinhTrangThanhToan = 1 WHERE MaHD = @MaHD AND TinhTrangThanhToan = 0", connection);
                command.Parameters.AddWithValue("@MaHD", invoiceId);
                await connection.OpenAsync();
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetInvoice();
                }
            }
            catch (Exception ex)
            {
                Database.ShowDatabaseError(ex);
            }
        }

        private void SetEditingEnabled(bool enabled)
        {
            productComboBox.Enabled = enabled;
            quantityInput.Enabled = enabled;
            addButton.Enabled = enabled;
            cancelButton.Enabled = enabled;
            paymentButton.Enabled = enabled;
        }

        private void ResetInvoice()
        {
            invoiceId = null;
            invoiceTextBox.Clear();
            detailsListView.Items.Clear();
            SetEditingEnabled(false);
            newInvoiceButton.Enabled = true;
        }

        private sealed record ProductItem(string Id, string Name)
        {
            public string DisplayName => $"{Id} - {Name}";
        }
    }
}
