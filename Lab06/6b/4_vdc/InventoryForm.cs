using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal sealed partial class InventoryForm : Form
    {
        internal InventoryForm()
        {
            InitializeComponent();
        }

        private async void CreateButton_Click(object? sender, EventArgs e)
        {
            var today = DateTime.Today;
            try
            {
                using var connection = Database.CreateConnection();
                await connection.OpenAsync();
                using var transaction = (SqlTransaction)await connection.BeginTransactionAsync();
                try
                {
                    using var existsCommand = new SqlCommand("SELECT COUNT(1) FROM TONKHO WHERE NgayTon = @NgayTon", connection, transaction);
                    existsCommand.Parameters.AddWithValue("@NgayTon", today);
                    if ((int)await existsCommand.ExecuteScalarAsync()! > 0)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show("Tồn kho của ngày hôm nay đã được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    const string insertSql = """
                        INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                        SELECT p.MaSP, @NgayTon,
                               COALESCE(previousStock.SLDau + previousStock.SLNhap - previousStock.SLBan, 0),
                               0, 0
                        FROM SanPham AS p
                        OUTER APPLY
                        (
                            SELECT TOP (1) t.SLDau, t.SLNhap, t.SLBan
                            FROM TONKHO AS t
                            WHERE t.MaSP = p.MaSP AND t.NgayTon < @NgayTon
                            ORDER BY t.NgayTon DESC
                        ) AS previousStock
                        """;
                    using var insertCommand = new SqlCommand(insertSql, connection, transaction);
                    insertCommand.Parameters.AddWithValue("@NgayTon", today);
                    var count = await insertCommand.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();

                    statusLabel.Text = $"Đã tạo tồn kho cho {count} sản phẩm.";
                    MessageBox.Show(statusLabel.Text, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    createButton.Enabled = false;
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
    }
}
