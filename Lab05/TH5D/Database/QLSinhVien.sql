-- Chay thu cong trong SQL Server Management Studio.
-- Du lieu mau phuc vu thuc hanh; script khong tu chay khi mo ung dung.
IF DB_ID(N'QLSinhVien') IS NULL
    CREATE DATABASE QLSinhVien;
GO
USE QLSinhVien;
GO
SET XACT_ABORT ON;
BEGIN TRY
BEGIN TRANSACTION;

IF OBJECT_ID(N'dbo.Khoa', N'U') IS NULL
CREATE TABLE dbo.Khoa (
    MaKhoa nvarchar(20) NOT NULL PRIMARY KEY,
    TenKhoa nvarchar(100) NOT NULL
);
IF OBJECT_ID(N'dbo.Lop', N'U') IS NULL
CREATE TABLE dbo.Lop (
    MaLop nvarchar(20) NOT NULL PRIMARY KEY,
    TenLop nvarchar(100) NOT NULL,
    MaKhoa nvarchar(20) NOT NULL REFERENCES dbo.Khoa(MaKhoa)
);
IF OBJECT_ID(N'dbo.SinhVien', N'U') IS NULL
CREATE TABLE dbo.SinhVien (
    MaSinhVien nvarchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(100) NOT NULL,
    NgaySinh date NOT NULL,
    MaLop nvarchar(20) NOT NULL REFERENCES dbo.Lop(MaLop)
);
IF OBJECT_ID(N'dbo.MonHoc', N'U') IS NULL
CREATE TABLE dbo.MonHoc (
    MaMonHoc nvarchar(20) NOT NULL PRIMARY KEY,
    TenMonHoc nvarchar(100) NOT NULL
);
IF OBJECT_ID(N'dbo.Diem', N'U') IS NULL
CREATE TABLE dbo.Diem (
    MaSinhVien nvarchar(20) NOT NULL REFERENCES dbo.SinhVien(MaSinhVien),
    MaMonHoc nvarchar(20) NOT NULL REFERENCES dbo.MonHoc(MaMonHoc),
    Diem decimal(4,2) NOT NULL CHECK (Diem BETWEEN 0 AND 10),
    PRIMARY KEY (MaSinhVien, MaMonHoc)
);

-- Bao loi neu database cu dang dung ten cot khac voi de.
IF COL_LENGTH(N'dbo.SinhVien', N'MaSinhVien') IS NULL
    OR COL_LENGTH(N'dbo.MonHoc', N'MaMonHoc') IS NULL
    OR COL_LENGTH(N'dbo.Diem', N'MaSinhVien') IS NULL
    OR COL_LENGTH(N'dbo.Diem', N'MaMonHoc') IS NULL
BEGIN
    ROLLBACK;
    THROW 50001, N'Cau truc database cu khong khop de. Kiem tra schema truoc khi nhap du lieu.', 1;
END;
-- Moi bang co 5 mau tin. Chi them ma chua ton tai, khong ghi de du lieu cu.
INSERT dbo.Khoa(MaKhoa,TenKhoa)
SELECT v.Ma,v.Ten FROM (VALUES
 (N'K01',N'Công nghệ thông tin'), (N'K02',N'Kinh tế'), (N'K03',N'Cơ khí'),
 (N'K04',N'Điện'), (N'K05',N'Ngoại ngữ')) v(Ma,Ten)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Khoa t WHERE t.MaKhoa=v.Ma);

INSERT dbo.Lop(MaLop,TenLop,MaKhoa)
SELECT v.Ma,v.Ten,v.Khoa FROM (VALUES
 (N'L01',N'Lớp công nghệ thông tin 1',N'K01'), (N'L02',N'Lớp kinh tế 1',N'K02'),
 (N'L03',N'Lớp cơ khí 1',N'K03'), (N'L04',N'Lớp điện 1',N'K04'), (N'L05',N'Lớp ngoại ngữ 1',N'K05')) v(Ma,Ten,Khoa)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Lop t WHERE t.MaLop=v.Ma);

INSERT dbo.SinhVien(MaSinhVien,HoTen,NgaySinh,MaLop)
SELECT v.Ma,v.Ten,CONVERT(date,v.Ngay),v.Lop FROM (VALUES
 (N'SV01',N'Nguyễn An','2005-01-10',N'L01'), (N'SV02',N'Trần Bình','2005-02-20',N'L02'),
 (N'SV03',N'Lê Chi','2005-03-15',N'L03'), (N'SV04',N'Phạm Dũng','2005-04-12',N'L04'),
 (N'SV05',N'Võ Hà','2005-05-18',N'L05')) v(Ma,Ten,Ngay,Lop)
WHERE NOT EXISTS (SELECT 1 FROM dbo.SinhVien t WHERE t.MaSinhVien=v.Ma);

INSERT dbo.MonHoc(MaMonHoc,TenMonHoc)
SELECT v.Ma,v.Ten FROM (VALUES
 (N'MH01',N'Lập trình C#'), (N'MH02',N'Cơ sở dữ liệu'), (N'MH03',N'Toán'),
 (N'MH04',N'Tiếng Anh'), (N'MH05',N'Tin học')) v(Ma,Ten)
WHERE NOT EXISTS (SELECT 1 FROM dbo.MonHoc t WHERE t.MaMonHoc=v.Ma);

INSERT dbo.Diem(MaSinhVien,MaMonHoc,Diem)
SELECT v.SV,v.MH,v.Diem FROM (VALUES
 (N'SV01',N'MH01',8.5), (N'SV02',N'MH02',7.0), (N'SV03',N'MH03',9.0),
 (N'SV04',N'MH04',6.5), (N'SV05',N'MH05',8.0)) v(SV,MH,Diem)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Diem t WHERE t.MaSinhVien=v.SV AND t.MaMonHoc=v.MH);
COMMIT;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK;
    THROW;
END CATCH;
GO
