create DATABASE ThietBiMayTinh

CREATE TABLE tblNhanVien (
iMaNV INT PRIMARY KEY NOT NULL,
sTen NVARCHAR(30) NOT NULL,
sSDT VARCHAR(20) NOT NULL
)

CREATE TABLE tblMatHang (
iMaMH INT PRIMARY KEY NOT NULL,
sTenLH NVARCHAR(30) NOT NULL,
sMauSac NVARCHAR(30) NOT NULL,
iSoLuong INT DEFAULT(0) NOT NULL
)

CREATE TABLE tblHoaDonNhap(
iMaHD INT PRIMARY KEY NOT NULL,
iMaNV INT NOT NULL,
sNCC NVARCHAR(30) NOT NULL,
dNgayTao DATE NOT NULL,
fTongTien FLOAT DEFAULT(0)
)

CREATE TABLE tblHoaDonBan (
iMaHD INT PRIMARY KEY NOT NULL,
iMaNV INT NOT NULL,
dNgayTao DATE NOT NULL,
fTongTien FLOAT DEFAULT(0)
)


CREATE TABLE tblCTHoaDonNhap (
iMaHD INT NOT NULL,
iMaMH INT NOT NULL,
iSoLuong INT NOT NULL,
fDonGia FLOAT NOT NULL,
fThanhTien FLOAT DEFAULT(0)
)

CREATE TABLE tblCTHoaDonBan (
iMaHD INT NOT NULL,
iMaMH INT NOT NULL,
iSoLuong INT NOT NULL,
fGiaBan FLOAT NOT NULL,
iThoiGianBaoHanh INT NOT NULL,
sGhiChu NVARCHAR(30) NOT NULL,
fThanhTien FLOAT DEFAULT(0),
sNguoiNhan NVARCHAR(50) NOT NULL,
sDiaChiGiaoHang NVARCHAR(50) NOT NULL
)
SELECT * FROM dbo.tblMatHang
SELECT * FROM dbo.tblCTHoaDonNhap

CREATE TRIGGER trThemCTHDNhap
ON tblCTHoaDonNhap
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaHD INT, @MaMH INT, @SoLuong INT, @DonGia FLOAT, @ThanhTien FLOAT
	SELECT @MaHD = iMaHD, @MaMH = iMaMH, @SoLuong = iSoLuong, @DonGia = fDonGia FROM inserted
	SELECT @ThanhTien = @DonGia * @SoLuong 
	UPDATE dbo.tblCTHoaDonNhap SET fThanhTien = @ThanhTien WHERE iMaHD = @MaHD AND iMaMH = @MaMH
	UPDATE dbo.tblHoaDonNhap SET fTongTien = (SELECT SUM(fThanhTien) FROM dbo.tblCTHoaDonNhap WHERE iMaHD = @MaHD) WHERE tblHoaDonNhap.iMaHD = @MaHD
	UPDATE dbo.tblMatHang SET iSoLuong = iSoLuong + @SoLuong WHERE iMaMH = @MaMH
END

ALTER TRIGGER tr_xoaCTHDN
ON tblCTHoaDonNhap
AFTER DELETE
AS 
BEGIN
    DECLARE @MaHD INT
	DECLARE @SL INT
	DECLARE @DG FLOAT
	DECLARE @ThanhTien FLOAT
	DECLARE @MaMH INT
	SELECT @MaMH = iMaMH FROM deleted
	SELECT @MaHD = iMaHD FROM deleted
	SELECT @SL = iSoLuong FROM deleted
	SELECT @DG = fDonGia FROM deleted
	SELECT @ThanhTien = @SL*@DG
	UPDATE dbo.tblHoaDonNhap SET fTongTien = fTongTien - @ThanhTien WHERE iMaHD = @MaHD
	UPDATE dbo.tblMatHang SET iSoLuong = iSoLuong - @SL WHERE iMaMH = @MaMH
	IF NOT EXISTS (SELECT * FROM dbo.tblCTHoaDonNhap)
	BEGIN
	    UPDATE dbo.tblHoaDonNhap SET fTongTien = 0
		UPDATE dbo.tblMatHang SET iSoLuong = 0
	END
END
CREATE TRIGGER trThemCTHDBan 
ON tblCTHoaDonBan
AFTER INSERT, UPDATE
AS 
BEGIN
    DECLARE @MaHD INT, @MaMH INT, @SoLuong INT, @ThanhTien FLOAT, @Giaban FLOAT
	SELECT @MaMH = iMaMH, @SoLuong = iSoLuong, @MaHD = iMaHD FROM inserted
	SELECT @Giaban = fGiaBan FROM inserted
	SELECT @ThanhTien = @Giaban * @SoLuong 
	UPDATE dbo.tblCTHoaDonBan SET fThanhTien = @ThanhTien WHERE iMaMH = @MaMH AND iMaHD = @MaHD
	UPDATE dbo.tblHoaDonBan SET	 fTongTien = (SELECT SUM(fThanhTien) FROM dbo.tblCTHoaDonBan WHERE iMaHD = @MaHD) WHERE tblHoaDonBan.iMaHD = @MaHD
	UPDATE dbo.tblMatHang SET iSoLuong = iSoLuong - @SoLuong WHERE @MaMH = iMaMH
	
END

ALTER TRIGGER tr_Xoa_CTHDB
ON tblCTHoaDonBan
AFTER DELETE
AS 
BEGIN
    DECLARE @MaHD INT, @MaMH INT, @SoLuong INT, @ThanhTien FLOAT, @Giaban FLOAT
	SELECT @MaHD = iMaHD, @MaMH = iMaMH, @SoLuong = iSoLuong FROM deleted
	SELECT @Giaban = fGiaBan FROM deleted
	SELECT @ThanhTien = @Giaban * @SoLuong
	UPDATE dbo.tblHoaDonBan SET fTongTien = fTongTien - @ThanhTien WHERE iMaHD = @MaHD
	UPDATE dbo.tblMatHang SET iSoLuong = iSoLuong + @SoLuong WHERE iMaMH = @MaMH
	IF NOT EXISTS (SELECT * FROM dbo.tblCTHoaDonBan)
	BEGIN
	    UPDATE dbo.tblHoaDonBan SET fTongTien = 0
		
	END

END
SELECT * FROM dbo.tblMatHang
SELECT * FROM dbo.tblHoaDonNhap
SELECT * FROM dbo.tblCTHoaDonNhap
SELECT * FROM dbo.tblHoaDonBan
SELECT * FROM dbo.tblCTHoaDonBan
DELETE FROM dbo.tblCTHoaDonNhap
ALTER TABLE dbo.tblHoaDonNhap ADD FOREIGN KEY(iMaNV) REFERENCES dbo.tblNhanVien(iMaNV) ON DELETE CASCADE
ALTER TABLE dbo.tblHoaDonBan ADD FOREIGN KEY(iMaNV) REFERENCES dbo.tblNhanVien(iMaNV) ON DELETE CASCADE

ALTER TABLE dbo.tblCTHoaDonNhap ADD FOREIGN KEY (iMaMH) REFERENCES dbo.tblMatHang(iMaMH) ON DELETE CASCADE
ALTER TABLE dbo.tblCTHoaDonNhap ADD FOREIGN KEY (iMaHD) REFERENCES dbo.tblHoaDonNhap(iMaHD) ON DELETE CASCADE

ALTER TABLE dbo.tblCTHoaDonBan ADD FOREIGN KEY (iMaHD) REFERENCES dbo.tblHoaDonBan(iMaHD) ON DELETE CASCADE
ALTER TABLE dbo.tblCTHoaDonBan ADD FOREIGN KEY(iMaMH) REFERENCES dbo.tblMatHang(iMaMH) ON DELETE CASCADE
ALTER TABLE dbo.tblCTHoaDonNhap ADD CONSTRAINT PK_CTHDN PRIMARY KEY(iMaHD, iMaMH)
ALTER TABLE dbo.tblCTHoaDonBan ADD CONSTRAINT PK_CTHDB PRIMARY KEY(iMaHD, iMaMH)
CREATE VIEW v_NV
AS
SELECT iMaNV AS[Mã NV], sTen AS[Tên], sSDT AS[Số điện thoại] FROM dbo.tblNhanVien

CREATE VIEW v_HDB 
AS
SELECT iMaHD AS [Mã Hoá Đơn], (SELECT sTen FROM dbo.tblNhanVien WHERE dbo.tblHoaDonBan.iMaNV = dbo.tblNhanVien.iMaNV) AS[Tên Nhân Viên], dNgayTao AS[Ngày tạo], fTongTien AS[Tổng tiền] FROM dbo.tblHoaDonBan 

CREATE VIEW v_CTHDB
As
SELECT iMaHD AS [Mã HD], iMaMH AS[Mã MH], iSoLuong AS [Số Lượng], fGiaBan AS[Giá bán], iThoiGianBaoHanh AS[TGBaoHanh], sGhiChu AS[Ghi chú],  fThanhTien AS [Thành Tiền], (SELECT DATEADD(DAY, 3, dNgayTao) FROM dbo.tblHoaDonBan WHERE dbo.tblCTHoaDonBan.iMaHD = dbo.tblHoaDonBan.iMaHD) AS [Ngày nhận hàng dự kiến] FROM dbo.tblCTHoaDonBan


CREATE VIEW v_MatHang
AS
SELECT iMaMH AS[Mã mặt hàng], sTenLH AS[Tên loại hàng], sMauSac AS[Màu sắc], iSoLuong AS[Số lượng] FROM dbo.tblMatHang
CREATE VIEW v_HoaDonNhap
AS
SELECT iMaHD AS[Mã hoá đơn], (SELECT sTen FROM dbo.tblNhanVien WHERE dbo.tblNhanVien.iMaNV = dbo.tblHoaDonNhap.iMaNV) AS[Tên nhân viên], sNCC AS[Nhà cung cấp], dNgayTao AS[Ngày tạo], fTongTien AS[Tổng tiền] FROM dbo.tblHoaDonNhap

CREATE VIEW v_CTHDN
AS
SELECT iMaHD AS[Mã hoá đơn], iMaMH AS[Mã mặt hàng], iSoLuong AS[Số lượng], fDonGia AS[Đơn giá], fThanhTien AS[Thành tiền] FROM dbo.tblCTHoaDonNhap

CREATE TRIGGER tr_sl1
ON tblCTHoaDonBan 
FOR INSERT, UPDATE 
AS 
BEGIN
    DECLARE @MaHD INT, @MaMH INT, @SLB INT, @SLT INT
	SELECT @MaHD = iMaHD, @MaMH = iMaMH, @SLB = iSoLuong FROM inserted 
	SELECT @SLT= iSoLuong FROM dbo.tblMatHang WHERE iMaMH = @MaMH
	IF @SLB > @SLT
	BEGIN
	ROLLBACK TRAN
	END
END

CREATE TRIGGER tg_SL_Nhap
ON tblCTHoaDonNhap
FOR INSERT, UPDATE
AS 
BEGIN
    DECLARE  @SL INT
	SELECT @SL = iSoLuong FROM inserted 
	IF @SL <=0 
	BEGIN
	    ROLLBACK TRAN
	END
END

CREATE TRIGGER tg_GiaNhap
ON tblCTHoaDonNhap 
FOR INSERT, UPDATE
AS 
BEGIN
    DECLARE @GiaNhap FLOAT
	SELECT @GiaNhap = fDonGia FROM inserted
	IF @GiaNhap <=0
	BEGIN
	    ROLLBACK TRAN
	END
END

CREATE TRIGGER tg_GiaBan
ON tblCTHoaDonBan
FOR INSERT, UPDATE
AS 
BEGIN
    DECLARE @GiaBan FLOAT
	SELECT @GiaBan = fGiaBan FROM inserted
	IF @GiaBan <=0
	BEGIN
	    ROLLBACK TRAN
	END
END

CREATE PROC xemTTHH (@MaHD int, @MaMH int)
AS

SELECT dbo.tblCTHoaDonBan.iMaHD AS[Mã HD], dbo.tblCTHoaDonBan.iMaMH AS[Mã MH], sTenLH AS[Tên hàng], tblCTHoaDonBan.iSoLuong AS[Số lượng đã bán], tblMatHang.iSoLuong AS[Số lượng hàng tồn]
FROM  dbo.tblCTHoaDonBan INNER JOIN dbo.tblMatHang ON tblMatHang.iMaMH = tblCTHoaDonBan.iMaMH WHERE @MaHD = iMaHD AND @MaMH = tblCTHoaDonBan.iMaMH

EXEC xemTTHH 1, 1
CREATE PROC xemCT(@MaHD int )
AS
SELECT * FROM dbo.v_CTHDN WHERE @MaHD = [Mã hoá đơn]
EXEC xemCT 1 -- int


EXEC dbo.xemCTHDB 2 -- int
CREATE PROC xemCTHDB (@MaHD int)
AS
SELECT * FROM dbo.v_CTHDB WHERE [Mã HD] = @MaHD
EXEC xemCTHDB 1



CREATE PROC RP_CT_HDB (@MaHD int)
AS
SELECT tblCTHoaDonBan.iMaHD AS [Mã Hoá Đơn], (SELECT sTen FROM dbo.tblNhanVien WHERE dbo.tblHoaDonBan.iMaNV = dbo.tblNhanVien.iMaNV) AS [Người lập], sTenLH AS[Tên loại hàng], tblCTHoaDonBan.iSoLuong AS[Số lượng], fGiaBan AS [Giá bán], iThoiGianBaoHanh AS[TGBH], fThanhTien AS[Thành tiền]
FROM dbo.tblCTHoaDonBan INNER JOIN dbo.tblHoaDonBan ON tblHoaDonBan.iMaHD = tblCTHoaDonBan.iMaHD 
INNER JOIN dbo.tblMatHang ON tblMatHang.iMaMH = tblCTHoaDonBan.iMaMH WHERE @MaHD = tblCTHoaDonBan.iMaHD


EXEC RP_CT_HDB 1

CREATE PROC RP_GiaBan(@a float, @b float)
AS
SELECT * FROM dbo.v_CTHDB WHERE [Giá bán] > @a AND [Giá bán] <@b
EXEC RP_GiaBan 400, 1000

CREATE PROC TestRPVIDU2 (@thang int, @nam int)
AS
SELECT * FROM dbo.v_HDB WHERE @thang = MONTH([Ngày tạo]) AND @nam = YEAR([Ngày tạo])
EXEC TestRPVIDU2 4, 2023

ALTER VIEW v_DSNVP
AS
SELECT NHANVIEN.iMaPhong AS[Mã phòng], sTenPhong AS [Tên phòng], iMaNV AS[Mã nhân viên], sTenNV AS[Họ tên], sGioiTinh AS [Giới tính] FROM dbo.NHANVIEN INNER JOIN dbo.PHONG ON PHONG.iMaPhong = NHANVIEN.iMaPhong

CREATE PROC pr_DS (@MaPhong int)
AS
SELECT * FROM v_DSNVP WHERE @MaPhong = [Mã phòng]

EXEC pr_DS 1



--Thực hành crystal report
ALTER VIEW v_tamchamhai
AS
SELECT sTenPhong AS[Tên phòng], COUNT(*) AS[Số nhân viên] FROM dbo.NHANVIEN INNER JOIN dbo.PHONG ON PHONG.iMaPhong = NHANVIEN.iMaPhong GROUP BY sTenPhong

SELECT * FROM v_tamchamhai

ALTER TABLE dbo.NHANVIEN ADD dNgaySinh DATE

CREATE PROC pr_Bai10 (@Thang int )
AS
SELECT iMaNV AS[Mã nhân viên],sTenNV AS[Tên nhân viên], sGioiTinh AS[Giới tính], iMaPhong AS[Mã phòng], dNgaySinh AS[Ngày sinh] FROM dbo.NHANVIEN WHERE @Thang = MONTH(dNgaySinh)

