-- Chạy SQL_QL_Lop.sql trước. Dữ liệu hiện có được giữ nguyên.
USE QLSinhVien;
GO
SET XACT_ABORT ON;
IF OBJECT_ID(N'dbo.Lop', N'U') IS NULL
    THROW 50001, N'Hãy chạy SQL_QL_Lop.sql trước.', 1;

BEGIN TRANSACTION;
IF OBJECT_ID(N'dbo.SinhVien', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SinhVien
    (
        MaSinhVien VARCHAR(10) NOT NULL PRIMARY KEY,
        HoTen NVARCHAR(100) NOT NULL,
        NgaySinh DATE NOT NULL,
        MaLop VARCHAR(10) NOT NULL,
        CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop) REFERENCES dbo.Lop(MaLop)
    );
END;

INSERT INTO dbo.SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop)
SELECT m.MaSinhVien, m.HoTen, CONVERT(DATE, m.NgaySinh, 112), m.MaLop
FROM (VALUES
    ('SV001', N'Nguyễn Văn An', '20050115', 'L01'),
    ('SV002', N'Trần Thị Bình', '20050220', 'L02'),
    ('SV003', N'Lê Minh Châu', '20050325', 'L03'),
    ('SV004', N'Phạm Ngọc Dung', '20050410', 'L04'),
    ('SV005', N'Hoàng Quốc Huy', '20050505', 'L05')
) AS m(MaSinhVien, HoTen, NgaySinh, MaLop)
WHERE NOT EXISTS (SELECT 1 FROM dbo.SinhVien sv WHERE sv.MaSinhVien = m.MaSinhVien);

COMMIT TRANSACTION;
GO
SELECT MaSinhVien, HoTen, NgaySinh, MaLop FROM dbo.SinhVien ORDER BY MaSinhVien;
