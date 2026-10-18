USE QLSinhVien;
GO

IF OBJECT_ID(N'dbo.MonHoc', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MonHoc
    (
        MaMonHoc VARCHAR(10) PRIMARY KEY,
        TenMonHoc NVARCHAR(100) NOT NULL
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.MonHoc)
BEGIN
    INSERT INTO dbo.MonHoc (MaMonHoc, TenMonHoc)
    VALUES
        ('CSDL', N'Cơ sở dữ liệu'),
        ('LTCS', N'Lập trình C#'),
        ('CTDL', N'Cấu trúc dữ liệu'),
        ('MMT',  N'Mạng máy tính'),
        ('HDH',  N'Hệ điều hành');
END;
GO

SELECT * FROM dbo.MonHoc;