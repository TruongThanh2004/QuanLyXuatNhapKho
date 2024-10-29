DROP DATABASE QLHangHoa

CREATE DATABASE QLHangHoa

GO

USE QLHangHoa

GO

CREATE TABLE NGUOIDUNG
(
	TaiKhoan nvarchar(50) NOT NULL,
	MatKhau nvarchar(50) NOT NULL
);

CREATE TABLE SANPHAM
(
	MaSP nvarchar(10) NOT NULL,
	MaNhaCungCap nvarchar(10),
	TenSP nvarchar(50),
	SoLuong float,
	DonGia float

	PRIMARY KEY(MaSP)
);

CREATE TABLE NHACUNGCAP
(
	MaNhaCungCap nvarchar(10) NOT NULL,
	TenNhaCungCap nvarchar(50),
	DiaChiNhaCungCap nvarchar(50),
	SoDienThoai nvarchar(10)

	PRIMARY KEY(MaNhaCungCap)
);

CREATE TABLE NHANVIEN
(
	MaNV nvarchar(10) NOT NULL,
	HoTenNV nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3),
	DiaChi nvarchar(50),
	SoDienThoai nvarchar(10)

	PRIMARY KEY(MaNV)
);

CREATE TABLE NHAPKHO
(
	SoPhieuNhap nvarchar(10) NOT NULL,
	MaSP nvarchar(10),
	TenSP nvarchar(50),
	SoLuongNhap float,
	NgayNhap date,
	MaNV nvarchar(10)

	PRIMARY KEY(SoPhieuNhap)
);

CREATE TABLE XUATKHO
(
	SoPhieuXuat nvarchar(10),
	MaSP nvarchar(10),
	TenSP nvarchar(50),
	SoLuongSP float,
	SoLuongXuat float,
	NgayXuat date,
	MaNV nvarchar(10)

	PRIMARY KEY(SoPhieuXuat)
)

GO

/* KHÓA NGOẠI */

ALTER TABLE SANPHAM
	ADD CONSTRAINT FK_SanPham_MaNhaCungCap FOREIGN KEY(MaNhaCungCap)
	REFERENCES NHACUNGCAP(MaNhaCungCap)

ALTER TABLE SANPHAM
    ADD CONSTRAINT FK_SanPham_MaSPNhapKho FOREIGN KEY(MaSP)
    REFERENCES NHAPKHO(MaSP)

ALTER TABLE NHAPKHO
	ADD CONSTRAINT FK_NhapKho_MaNV FOREIGN KEY(MaNV)
	REFERENCES NHANVIEN(MaNV)
	
/* PROC CRUD */

GO

CREATE PROC InsertNguoiDung(@sTaiKhoan nvarchar(50), @sMatKhau nvarchar(50))
AS
	INSERT INTO NGUOIDUNG(TaiKhoan, MatKhau) VALUES (@sTaiKhoan, @sMatKhau)

CREATE PROC SelectNguoiDung
AS
	SELECT * FROM NGUOIDUNG

exec SelectNguoiDung
exec InsertNguoiDung '1','1'

/* NHÂN VIÊN */

CREATE PROC SelectNhanVien
AS
	SELECT MaNV AS 'Mã nhân viên', HoTenNV AS 'Họ tên nhân viên', NgaySinh AS 'Ngày sinh', GioiTinh AS 'Giới tính', DiaChi AS 'Địa chỉ', SoDienThoai AS 'Số điện thoại'
	FROM NHANVIEN

CREATE PROC InsertNhanVien(@sMaNV nvarchar(10), @sHoTenNV nvarchar(50), @sNgaySinh date, @sGioiTinh nvarchar(3), @sDiaChiNV nvarchar(50), @sSoDTNV nvarchar(10))
AS
	INSERT INTO NHANVIEN (MaNV, HoTenNV, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES (@sMaNV, @sHoTenNV, @sNgaySinh, @sGioiTinh, @sDiaChiNV, @sSoDTNV)

CREATE PROC UpdateNhanVien(@sMaNV nvarchar(10), @sHoTenNV nvarchar(50), @sNgaySinh date, @sGioiTinh nvarchar(3), @sDiaChiNV nvarchar(50), @sSoDTNV nvarchar(10))
AS
	UPDATE NHANVIEN SET HoTenNV = @sHoTenNV, NgaySinh = @sNgaySinh, GioiTinh = @sGioiTinh, DiaChi = @sDiaChiNV, SoDienThoai = @sSoDTNV WHERE MaNV = @sMaNV

CREATE PROC DeleteNhanVien(@sMaNV nvarchar(10))
AS
	DELETE NHANVIEN WHERE MaNV = @sMaNV

exec SelectNhanVien
exec InsertNhanVien 'NV01', N'Nguyễn Thành Tài', '10/05/2004', N'Nam', N'146 Nguyễn Huệ', '0123456789'
exec InsertNhanVien 'NV02', N'Trịnh Viết Ký', '10/05/2004', N'Nam', N'146 Nguyễn Huệ', '0123456789'

/* SẢN PHẨM */

CREATE PROC InsertSanPham(@sMaSP nvarchar(10), @sMaNhaCungCap nvarchar(10), @sTenSP nvarchar(50), @sSoLuong float, @sDonGia float)
AS
	INSERT INTO SANPHAM (MaSP, MaNhaCungCap, TenSP, SoLuong, DonGia) VALUES (@sMaSP, @sMaNhaCungCap,@sTenSP, @sSoLuong, @sDonGia)

CREATE PROC SelectSanPham
AS
	SELECT MaSP AS 'Mã sản phẩm', MaNhaCungCap AS 'Mã nhà cung cấp', TenSP AS 'Tên sản phẩm', SoLuong AS 'Số lượng', DonGia AS 'Đơn giá'
	FROM SANPHAM

CREATE PROC DeleteSanPham(@sMaSP nvarchar(10))
AS
	DELETE SANPHAM WHERE MaSP = @sMaSP

CREATE PROC UpdateSanPham(@sMaSP nvarchar(10), @sMaNhaCungCap nvarchar(10), @sTenSP nvarchar(50), @sSoLuong float, @sDonGia float)
AS
	UPDATE SANPHAM SET MaNhaCungCap = @sMaNhaCungCap, TenSP = @sTenSP, SoLuong = @sSoLuong, DonGia = @sDonGia WHERE MaSP = @sMaSP

CREATE PROCEDURE sp_updateSoLuongSanPham
    @MaSP NVARCHAR(10),
    @SoLuongMoi FLOAT
AS
BEGIN
    UPDATE SANPHAM
    SET SoLuong = SANPHAM.SoLuong + @SoLuongMoi
    WHERE MaSP = @MaSP;
END;

CREATE PROCEDURE sp_updateTruSoLuongSanPham
    @MaSP NVARCHAR(10),
    @SoLuongMoi FLOAT
AS
BEGIN
    UPDATE SANPHAM
    SET SoLuong = SANPHAM.SoLuong - @SoLuongMoi
    WHERE MaSP = @MaSP;
END;

exec SelectSanPham
exec InsertSanPham '004','NCC01',N'Thịt cá',0,5000
exec InsertSanPham '002','NCC01',N'Nước ngọt',0,5000
exec InsertSanPham '003','NCC01',N'Rau củ',0,5000
exec InsertSanPham '001','NCC01',N'Bánh kẹo',0,5000
exec DeleteSanPham '001'

/* NHÀ CUNG CẤP */

CREATE PROC InsertNhaCungCap(@sMaNCC nvarchar(10), @sTenNCC nvarchar(50), @sDiaChiNCC nvarchar(50), @sSoDT nvarchar(10))
AS
	INSERT INTO NHACUNGCAP (MaNhaCungCap, TenNhaCungCap, DiaChiNhaCungCap, SoDienThoai) VALUES (@sMaNCC, @sTenNCC, @sDiaChiNCC, @sSoDT)

CREATE PROC SelectNhaCungCap
AS
	SELECT MaNhaCungCap AS 'Mã nhà cung cấp', TenNhaCungCap 'Tên nhà cung cấp', DiaChiNhaCungCap 'Địa chỉ nhà cung cấp', SoDienThoai 'Số điện thoại'  
	FROM NHACUNGCAP

CREATE PROC UpdateNhaCungCap(@sMaNCC nvarchar(10), @sTenNCC nvarchar(50), @sDiaChiNCC nvarchar(50), @sSoDT nvarchar(10))
AS
	UPDATE NHACUNGCAP SET TenNhaCungCap = @sTenNCC, DiaChiNhaCungCap = @sDiaChiNCC, SoDienThoai = @sSoDT

CREATE PROC DeleteNhaCungCap(@sMaNCC nvarchar(10))
AS
	DELETE NHACUNGCAP WHERE MaNhaCungCap = @sMaNCC

exec SelectNhaCungCap
exec InsertNhaCungCap 'NCC01', N'Nguyễn Thành Tài', N'146 Kha Vạn Cân', '0956321456'
exec InsertNhaCungCap 'NCC02', N'Trịnh Viết Ký', N'146 Kha Vạn Cân', '0956321456'
exec InsertNhaCungCap 'NCC03', N'Đỗ Trường Thạnh', N'146 Kha Vạn Cân', '0956321456'

/* NHAP KHO */

CREATE PROC InsertNhapKho(@sSoPhieuNhap nvarchar(10), @sMaSP nvarchar(10),@sTenSP nvarchar(50), @sSoLuongNhap float, @sNgayNhap date, @sMaNV nvarchar(10))
AS
	INSERT INTO NHAPKHO (SoPhieuNhap, MaSP, TenSP, SoLuongNhap, NgayNhap, MaNV) VALUES (@sSoPhieuNhap, @sMaSP,@sTenSP, @sSoLuongNhap, @sNgayNhap, @sMaNV)

CREATE PROC SelectNhapKho
AS
	SELECT SoPhieuNhap AS 'Số phiếu nhập', MaSP AS 'Mã sản phẩm',TenSP AS 'Tên sản phẩm', SoLuongNhap AS 'Số lượng nhập', NgayNhap AS 'Ngày nhập', MaNV AS 'Mã nhân viên'
	FROM NHAPKHO

CREATE PROC DeleteNhapKho(@sSoPhieuNhap nvarchar(10))
AS
	DELETE NHAPKHO WHERE SoPhieuNhap = @sSoPhieuNhap

CREATE PROC UpdateNhapKho(@sSoPhieuNhap nvarchar(10), @sMaSP nvarchar(10), @sTenSP nvarchar(50), @sSoLuongNhap float, @sNgayNhap date, @sMaNV nvarchar(10))
AS
	UPDATE NHAPKHO SET MaSP = @sMaSP,TenSP = @sTenSP, SoLuongNhap = @sSoLuongNhap, NgayNhap = @sNgayNhap, MaNV = @sMaNV WHERE SoPhieuNhap = @sSoPhieuNhap

exec SelectNhapKho
exec DeleteNhapKho 'SPN04'

/* XUẤT KHO */

CREATE PROC SelectXuatKho
AS
	SELECT SoPhieuXuat AS 'Số phiếu xuất', MaSP AS 'Mã sản phẩm', TenSP AS 'Tên sản phẩm', SoLuongSP AS 'Số lượng đang có', SoLuongXuat AS 'Số lượng xuất' , NgayXuat AS 'Ngày xuất', MaNV AS 'Mã nhân viên'
	FROM XUATKHO

CREATE PROC InsertXuatKho(@sSoPhieuXuat nvarchar(10), @sMaSP nvarchar(10), @sTenSP nvarchar(10), @sSoLuongSP float, @sSoLuongXuat float, @sNgayXuat date, @sMaNV nvarchar(10))
AS
	INSERT INTO XUATKHO (SoPhieuXuat, MaSP, TenSP, SoLuongSP, SoLuongXuat, NgayXuat, MaNV)
	VALUES (@sSoPhieuXuat, @sMaSP, @sTenSP, @sSoLuongSP, @sSoLuongXuat, @sNgayXuat, @sMaNV)

CREATE PROC DeleteXuatKho(@sSoPhieuXuat nvarchar(10))
AS
	DELETE XUATKHO WHERE SoPhieuXuat = @sSoPhieuXuat

CREATE PROC UpdateXuatKho(@sSoPhieuXuat nvarchar(10), @sMaSP nvarchar(10), @sTenSP nvarchar(10), @sSoLuongSP float, @sSoLuongXuat float, @sNgayXuat date, @sMaNV nvarchar(10))
AS
	UPDATE XUATKHO SET MaSP = @sMaSP, TenSP = @sTenSP, SoLuongSP = @sSoLuongSP, SoLuongXuat = @sSoLuongXuat, NgayXuat = @sNgayXuat, MaNV = MaNV 
	WHERE SoPhieuXuat = @sSoPhieuXuat

exec SelectXuatKho
exec InsertXuatKho 'SPX01','001','Banh',20,10,'01-01-2023','NV01'; 


exec InsertNhapKho 'SPN01','001','Banh',20,'01-01-2023','NV01'; 

CREATE PROC sp_ThongKe
AS
	SELECT sp.MaSP,sp.TenSP,sp.SoLuong,sp.DonGia,nhap.SoLuongNhap,nhap.NgayNhap,xuat.SoLuongXuat,NgayXuat FROM SANPHAM AS sp JOIN NHAPKHO AS nhap 
	ON sp.MaSP=nhap.MaSP  JOIN XUATKHO as xuat ON sp.MaSP=xuat.MaSP
	



exec sp_ThongKe