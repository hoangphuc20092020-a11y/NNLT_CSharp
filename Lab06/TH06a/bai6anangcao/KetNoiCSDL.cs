namespace bai6anangcao
{
    internal static class KetNoiCSDL
    {
        // Dùng chung SQL Server trong Docker với các bài 6a trước.
        public static readonly string ChuoiKetNoi = "Data Source=tcp:127.0.0.1,14330;" +
            "Initial Catalog=QLSinhVien;" +
            "User ID=sa;" +
            "Password=HocSQL@2026!;" +
            "Encrypt=True;TrustServerCertificate=True;";
    }
}
