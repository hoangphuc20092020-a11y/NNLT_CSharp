-- Chạy SQL_QL_Lop.sql và SQL_QL_Sinh_Vien.sql trước.
USE QLSinhVien;
GO
SET XACT_ABORT ON;
IF OBJECT_ID(N'dbo.SinhVien', N'U') IS NULL
    THROW 50002, N'Hãy chạy SQL_QL_Sinh_Vien.sql trước.', 1;

BEGIN TRANSACTION;
IF OBJECT_ID(N'dbo.MonHoc', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MonHoc
    (
        MaMonHoc VARCHAR(10) NOT NULL PRIMARY KEY,
        TenMonHoc NVARCHAR(100) NOT NULL
    );
END;

INSERT INTO dbo.MonHoc (MaMonHoc, TenMonHoc)
SELECT m.MaMonHoc, m.TenMonHoc
FROM (VALUES
    ('CSDL', N'Cơ sở dữ liệu'),
    ('LTCS', N'Lập trình C#'),
    ('CTDL', N'Cấu trúc dữ liệu'),
    ('MMT', N'Mạng máy tính'),
    ('HDH', N'Hệ điều hành')
) AS m(MaMonHoc, TenMonHoc)
WHERE NOT EXISTS (SELECT 1 FROM dbo.MonHoc mh WHERE mh.MaMonHoc = m.MaMonHoc);

IF OBJECT_ID(N'dbo.Diem', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Diem
    (
        MaSinhVien VARCHAR(10) NOT NULL,
        MaMonHoc VARCHAR(10) NOT NULL,
        Diem DECIMAL(5,2) NOT NULL,
        CONSTRAINT PK_Diem PRIMARY KEY (MaSinhVien, MaMonHoc),
        CONSTRAINT FK_Diem_SinhVien FOREIGN KEY (MaSinhVien) REFERENCES dbo.SinhVien(MaSinhVien),
        CONSTRAINT FK_Diem_MonHoc FOREIGN KEY (MaMonHoc) REFERENCES dbo.MonHoc(MaMonHoc)
    );
END;

INSERT INTO dbo.Diem (MaSinhVien, MaMonHoc, Diem)
SELECT m.MaSinhVien, m.MaMonHoc, m.Diem
FROM (VALUES
    ('SV001', 'CSDL', 8.50),
    ('SV002', 'LTCS', 7.25),
    ('SV003', 'CTDL', 9.00),
    ('SV004', 'MMT', 6.75),
    ('SV005', 'HDH', 8.00)
) AS m(MaSinhVien, MaMonHoc, Diem)
WHERE NOT EXISTS
(
    SELECT 1 FROM dbo.Diem d
    WHERE d.MaSinhVien = m.MaSinhVien AND d.MaMonHoc = m.MaMonHoc
);

COMMIT TRANSACTION;
GO
SELECT MaSinhVien, MaMonHoc, Diem FROM dbo.Diem ORDER BY MaSinhVien, MaMonHoc;
