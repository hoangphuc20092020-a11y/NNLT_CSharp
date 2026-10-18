-- Thực hành 6a: chuẩn bị Khoa và Lop. Chạy lại không xóa dữ liệu cũ.
IF DB_ID(N'QLSinhVien') IS NULL
    CREATE DATABASE QLSinhVien;
GO
USE QLSinhVien;
GO
SET XACT_ABORT ON;
BEGIN TRANSACTION;

IF OBJECT_ID(N'dbo.Khoa', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Khoa
    (
        MaKhoa VARCHAR(10) NOT NULL PRIMARY KEY,
        TenKhoa NVARCHAR(100) NOT NULL
    );
END;

INSERT INTO dbo.Khoa (MaKhoa, TenKhoa)
SELECT m.MaKhoa, m.TenKhoa
FROM (VALUES
    ('CNTT', N'Công nghệ thông tin'),
    ('KT', N'Kinh tế'),
    ('NN', N'Ngoại ngữ'),
    ('DL', N'Du lịch'),
    ('CK', N'Cơ khí')
) AS m(MaKhoa, TenKhoa)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Khoa k WHERE k.MaKhoa = m.MaKhoa);

IF OBJECT_ID(N'dbo.Lop', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Lop
    (
        MaLop VARCHAR(10) NOT NULL PRIMARY KEY,
        TenLop NVARCHAR(100) NOT NULL,
        MaKhoa VARCHAR(10) NOT NULL,
        CONSTRAINT FK_Lop_Khoa FOREIGN KEY (MaKhoa) REFERENCES dbo.Khoa(MaKhoa)
    );
END;

INSERT INTO dbo.Lop (MaLop, TenLop, MaKhoa)
SELECT m.MaLop, m.TenLop, m.MaKhoa
FROM (VALUES
    ('L01', N'Công nghệ thông tin 01', 'CNTT'),
    ('L02', N'Kinh tế 01', 'KT'),
    ('L03', N'Ngoại ngữ 01', 'NN'),
    ('L04', N'Du lịch 01', 'DL'),
    ('L05', N'Cơ khí 01', 'CK')
) AS m(MaLop, TenLop, MaKhoa)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Lop l WHERE l.MaLop = m.MaLop);

COMMIT TRANSACTION;
GO
SELECT MaLop, TenLop, MaKhoa FROM dbo.Lop ORDER BY MaLop;
