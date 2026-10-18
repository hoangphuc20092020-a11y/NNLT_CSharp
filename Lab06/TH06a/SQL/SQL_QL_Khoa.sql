-- Tạo database nếu chưa có.
IF DB_ID(N'QLSinhVien') IS NULL
    CREATE DATABASE QLSinhVien;
GO

USE QLSinhVien;
GO

-- Tạo bảng nếu chưa có.
IF OBJECT_ID(N'dbo.Khoa', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Khoa
    (
        MaKhoa VARCHAR(10) PRIMARY KEY,
        TenKhoa NVARCHAR(100) NOT NULL
    );
END;
GO

-- Thêm 5 dòng mẫu nếu bảng đang trống.
IF NOT EXISTS (SELECT 1 FROM dbo.Khoa)
BEGIN
    INSERT INTO dbo.Khoa (MaKhoa, TenKhoa)
    VALUES
        ('CNTT', N'Công nghệ thông tin'),
        ('KT',   N'Kinh tế'),
        ('NN',   N'Ngoại ngữ'),
        ('DL',   N'Du lịch'),
        ('CK',   N'Cơ khí');
END;
GO

SELECT * FROM dbo.Khoa;