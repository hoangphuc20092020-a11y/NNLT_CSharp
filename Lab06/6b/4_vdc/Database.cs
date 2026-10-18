using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal static class Database
    {
        internal const string ConnectionString =
            "Server=localhost,1433;Database=QLCuaHang;User Id=sa;Password=YourStrong@Pass123;Encrypt=True;TrustServerCertificate=True;Connection Timeout=15;";

        internal static SqlConnection CreateConnection() => new(ConnectionString);

        internal static void ShowDatabaseError(Exception exception)
        {
            var message = exception is SqlException sqlException
                ? sqlException.Number switch
                {
                    2601 or 2627 => "Dữ liệu bị trùng khóa chính.",
                    547 => "Không thể thao tác vì dữ liệu đang được tham chiếu bởi bảng khác.",
                    _ => $"Không thể thực hiện thao tác với cơ sở dữ liệu: {sqlException.Message}"
                }
                : $"Không thể thực hiện thao tác: {exception.Message}";

            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
