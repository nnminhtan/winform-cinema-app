USE MASTER
GO
IF EXISTS ( SELECT * FROM SYS.DATABASES WHERE NAME = 'QUANLYRAPCHIEUPHIM')
	DROP DATABASE QUANLYRAPCHIEUPHIM
GO

CREATE DATABASE QUANLYRAPCHIEUPHIM
GO

USE QUANLYRAPCHIEUPHIM
ALTER DATABASE QUANLYRAPCHIEUPHIM COLLATE Vietnamese_CI_AS
--CREATE TABLE
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblLichChieu')
	DROP TABLE tblLichChieu
GO
CREATE TABLE tblLichChieu
(
	MaShow CHAR(11) NOT NULL,
	MaPhim CHAR(11),
	MaRap CHAR(21),
	MaPhong CHAR(11),
	NgayChieu DATE,
	MaGioChieu CHAR(11),
	GiaVe INT,
	SoVeDaBan INT,
	TongTien INT DEFAULT 0
)	

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblPhim')
	DROP TABLE tblPhim
GO
CREATE TABLE tblPhim
(
	MaPhim CHAR(11) NOT NULL,
	TenPhim NVARCHAR(40),
	MaTheLoai CHAR(6),
	NgayKhoiChieu DATE,
	NgayKetThuc DATE,
	MoTa NVARCHAR(200),
	ThoiLuong NVARCHAR(20),
	TongChiPhi INT,
	TongThu INT,
	Poster VARBINARY(MAX)
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblTheLoai')
	DROP TABLE tblTheLoai
GO
CREATE TABLE tblTheLoai
(
	MaTheLoai CHAR(6) NOT NULL,
	TenTheLoai NVARCHAR(30)
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblPhongChieu')
	DROP TABLE  tblPhongChieu
GO
CREATE TABLE tblPhongChieu
(
	MaPhong CHAR(11) NOT NULL,
	MaRap CHAR(21),
	TenPhong NVARCHAR(11),
	TongSoGhe INT
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblGhePhongChieu')
	DROP TABLE tblGhePhongChieu
GO
CREATE TABLE tblGhePhongChieu
(
	MaGhe CHAR(11) NOT NULL,
	MaRap CHAR(21),
	MaPhong CHAR(11),
	TrangThai BIT
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblVe')
	DROP TABLE tblVe
GO
CREATE TABLE tblVe
(
	MaVe INT NOT NULL,
	--MaGhe CHAR(11),
	--MaKhach INT,
	MaShow CHAR(11),
	--TenPhim  NVARCHAR(40),
	--NgayChieu DATETIME,
	--GioChieu TIME,
	--GiaVe INT,
	--HinhThucThanhToan NVARCHAR(40),
	--HinhThucDat bit
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblThongTinVe')
	DROP TABLE tblThongTinVe
GO
CREATE TABLE tblThongTinVe
(
	IdTTVe INT NOT NULL,
	MaVe INT,
	MaGhe CHAR(11),
	--MaKhach INT,
	MaShow CHAR(11),
	TenPhim  NVARCHAR(40),
	NgayChieu DATETIME,
	GioChieu CHAR(50),
	GiaVe INT,
	PhongChieu NVARCHAR(50),
	HinhThucThanhToan NVARCHAR(40),
	TrangThai bit
	--HinhThucDat bit
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblRap')
	DROP TABLE tblRap
GO
CREATE TABLE tblRap
(
	MaRap CHAR(21) NOT NULL,
	TenRap NVARCHAR(50),
	DiaChi NVARCHAR(50),
	DienThoai CHAR(11),
	SoPhong INT,
	--TongSoPhongChieu INT,
	--TongSoLoa INT,
	--TongSoBangChieu INT,
	--TongSoMayChieu INT,
	--TongSoDieuHoa INT,
	TongSoGhe INT	
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblGioChieu')
	DROP TABLE tblGioChieu
GO
CREATE TABLE tblGioChieu
(
	MaGioChieu CHAR(11) NOT NULL,
	MaRap CHAR(21),
	GioChieu TIME
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblNhanVien')
	DROP TABLE tblNhanVien
GO
CREATE TABLE tblNhanVien
(
	MaNV CHAR(11) NOT NULL,
	TenNV NVARCHAR(41),
	MatKhauNV CHAR(21),
	ChucVu NVARCHAR(31),
	Luong INT,
	MaRap CHAR(21) 
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblChucNang')
	DROP TABLE tblChucNang
GO
CREATE TABLE tblChucNang
(
	MaChucNang INT NOT NULL,
	TenChucNang NVARCHAR(21)
)

IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblQuyenHan')
	DROP TABLE tblQuyenHan
GO
CREATE TABLE tblQuyenHan
(
	 MaQuyen INT NOT NULL,
	 MaNV CHAR(11) NOT NULL,
	 MaChucNang INT NOT NULL
)

--IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME = 'tblKhach')
--	DROP TABLE tblKhach
--GO
--CREATE TABLE tblKhach
--(
--	MaKhach INT NOT NULL,
--	TenKhach NVARCHAR(51),
--	SDT INT,
--)

--ADD PRIMARY KEY
ALTER TABLE tblLichChieu 
	ADD CONSTRAINT PK_tblLichChieu PRIMARY KEY (MaShow)
ALTER TABLE tblPhim 
	ADD CONSTRAINT PK_tblPhim PRIMARY KEY (MaPhim)
ALTER TABLE tblTheLoai 
	ADD CONSTRAINT PK_tblTheLoai PRIMARY KEY (MaTheLoai)
ALTER TABLE tblPhongChieu 
	ADD CONSTRAINT PK_tblPhongChieu PRIMARY KEY (MaPhong)
ALTER TABLE tblGhePhongChieu 
	ADD CONSTRAINT PK_tblGhePhongChieu PRIMARY KEY (MaGhe)
ALTER TABLE tblVe 
	ADD CONSTRAINT PK_tblVe PRIMARY KEY (MaVe)
ALTER TABLE tblThongTinVe 
	ADD CONSTRAINT PK_tblThongTinVe PRIMARY KEY (IdTTVe)
ALTER TABLE tblRap 
	ADD CONSTRAINT PK_tblRap PRIMARY KEY (MaRap)
ALTER TABLE tblGioChieu 
	ADD CONSTRAINT PK_tblGioChieu PRIMARY KEY (MaGioChieu)
ALTER TABLE tblNhanVien
	ADD CONSTRAINT PK_tblNhanVien PRIMARY KEY (MaNV)
ALTER TABLE tblChucNang
	ADD CONSTRAINT PK_tblChucNang PRIMARY KEY(MaChucNang)
ALTER TABLE tblQuyenHan
	ADD CONSTRAINT PK_tblQuyenHan PRIMARY KEY(MaQuyen)
--ALTER TABLE tblKhach
--	ADD CONSTRAINT PK_tblKhach PRIMARY KEY(MaKhach)

--ADD FOREIGN KEY
ALTER TABLE tblLichChieu
	ADD CONSTRAINT FK_tblLichChieu_tblPhim FOREIGN KEY(MaPhim) REFERENCES tblPhim(MaPhim)
ALTER TABLE tblLichChieu
	ADD CONSTRAINT FK_tblLichChieu_tblPhongChieu FOREIGN KEY(MaPhong) REFERENCES tblPhongChieu(MaPhong)
ALTER TABLE tblLichChieu
	ADD CONSTRAINT FK_tblLichChieu_tblRap FOREIGN KEY(MaRap) REFERENCES tblRap(MaRap)
ALTER TABLE tblLichChieu
	ADD CONSTRAINT FK_tblLichChieu_tblGioChieu FOREIGN KEY(MaGioChieu) REFERENCES tblGioChieu(MaGioChieu)
ALTER TABLE tblPhim
	ADD CONSTRAINT FK_tblPhim FOREIGN KEY(MaTheLoai) REFERENCES tblTheLoai(MaTheLoai)
ALTER TABLE tblGioChieu
	ADD CONSTRAINT FK_tblGioChieu FOREIGN KEY(MaRap) REFERENCES tblRap(MaRap)
ALTER TABLE tblVe
	ADD CONSTRAINT FK_tblVe_tblLichChieu FOREIGN KEY(MaShow) REFERENCES tblLichChieu(MaShow)
ALTER TABLE tblThongTinVe
	ADD CONSTRAINT FK_tblThongTinVe_tblVe FOREIGN KEY(MaVe) REFERENCES tblVe(MaVe)
ALTER TABLE tblThongTinVe
	ADD CONSTRAINT FK_tblThongTinVe_tblGhePhongChieu FOREIGN KEY(MaGhe) REFERENCES tblGhePhongChieu(MaGhe)
--ALTER TABLE tblVe
--	ADD CONSTRAINT FK_tblVe_tblGhePhongChieu FOREIGN KEY(MaGhe) REFERENCES tblGhePhongChieu(MaGhe)
--ALTER TABLE tblVe
--	ADD CONSTRAINT FK_tblVe_tblKhach FOREIGN KEY(MaKhach) REFERENCES tblKhach(MaKhach)
ALTER TABLE tblPhongChieu
	ADD CONSTRAINT FK_tblPhongChieu_tblRap FOREIGN KEY(MaRap) REFERENCES tblRap(MaRap)
ALTER TABLE tblGhePhongChieu
	ADD CONSTRAINT FK_tblGhePhongChieu_tblPhongChieu FOREIGN KEY(MaPhong) REFERENCES tblPhongChieu(MaPhong)
ALTER TABLE tblGhePhongChieu
	ADD CONSTRAINT FK_tblGhePhongChieu_tblRap FOREIGN KEY(MaRap) REFERENCES tblRap(MaRap)
--ALTER TABLE tblGhePhongChieu
--	ADD CONSTRAINT FK_tblGhePhongChieu_tblVe FOREIGN KEY(MaGhe) REFERENCES tblVe(MaGhe)
ALTER TABLE tblNhanVien
	ADD CONSTRAINT FK_tblNhanVien FOREIGN KEY(MaRap) REFERENCES tblRap(MaRap)
ALTER TABLE tblQuyenHan
	ADD CONSTRAINT FK_tblQuyenHan_tblNhanVien FOREIGN KEY(MaNV) REFERENCES tblNhanVien(MaNV)
ALTER TABLE tblQuyenHan
	ADD CONSTRAINT FK_tblQuyenHan_tblChucNang FOREIGN KEY(MaChucNang) REFERENCES tblChucNang(MaChucNang)


--ADD CONSTRAINT
ALTER TABLE tblGhePhongChieu
	ADD CONSTRAINT CHK_TRANGTHAI CHECK (TrangThai=0 OR TrangThai=1), --0: ghe trong, 1: da chon
		CONSTRAINT DEF_TRANGTHAI DEFAULT 0 FOR TrangThai

--INSERT TABLE
SET DATEFORMAT DMY

INSERT INTO tblRap(MaRap,TenRap,DiaChi,DienThoai,SoPhong,TongSoGhe) VALUES('BTC1',N'B Talk cinema','Earth','0145447586',3,120)
INSERT INTO tblRap(MaRap,TenRap,DiaChi,DienThoai,SoPhong,TongSoGhe) VALUES('BTC2',N'B Talk cinema','Moon','0243578247',2,80)
--INSERT INTO tblRap(MaRap,TenRap,DiaChi,DienThoai,SoPhong,TongSoGhe) VALUES('BCI3','B Talk cinema','Mars','0384247284',5,225)
SELECT * FROM tblRap

INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL1', N'Hành động')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL2', N'Hài')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL3', N'Khoa học - viễn tưởng')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL4', N'Tình cảm')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL5', N'Kinh dị')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL6', N'Hoạt hình')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL7', N'Lịch sử')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL8', N'Chiến tranh')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL9', N'Trinh Thám')
INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES('TL10', N'Giật gân')
SELECT * FROM tblTheLoai

INSERT INTO tblPhim(MaPhim,TenPhim,MaTheLoai,NgayKhoiChieu,NgayKetThuc,MoTa,ThoiLuong,TongChiPhi,TongThu)
	VALUES('P1','Baking Bad','TL10','10/6/2023','30/10/2023',N'this is a great movie',N'120 Phút',100000000,500000000)
INSERT INTO tblPhim(MaPhim,TenPhim,MaTheLoai,NgayKhoiChieu,NgayKetThuc,MoTa,ThoiLuong,TongChiPhi,TongThu)
	VALUES('P2','Conan','TL1','20/09/2023','21/10/2023',N'...',N'90 Phút',100000000,500000000)
INSERT INTO tblPhim(MaPhim,TenPhim,MaTheLoai,NgayKhoiChieu,NgayKetThuc,MoTa,ThoiLuong,TongChiPhi,TongThu)
	VALUES('P3','Shin','TL6','5/10/2023','29/10/2023',N'...',N'96 Phút',100000000,500000000)
INSERT INTO tblPhim(MaPhim,TenPhim,MaTheLoai,NgayKhoiChieu,NgayKetThuc,MoTa,ThoiLuong,TongChiPhi,TongThu)
	VALUES('P4','Fast and Furious','TL1','16/09/2023','20/10/2023',N'...',N'69 Phút',100000000,500000000)
INSERT INTO tblPhim(MaPhim,TenPhim,MaTheLoai,NgayKhoiChieu,NgayKetThuc,MoTa,ThoiLuong,TongChiPhi,TongThu)
	VALUES('P5','Avengers','TL3','28/09/2023','25/10/2023',N'...',N'120 Phút',100000000,500000000)
INSERT INTO tblPhim(MaPhim,TenPhim,MaTheLoai,NgayKhoiChieu,NgayKetThuc,MoTa,ThoiLuong,TongChiPhi,TongThu)
	VALUES('P6','Your Name','TL4','28/09/2023','25/10/2023',N'...',N'120 Phút',100000000,500000000)
SELECT * FROM tblPhim

INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC1','BTC1','08:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC2','BTC1','09:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC3','BTC1','11:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC4','BTC1','12:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC5','BTC1','15:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC6','BTC1','16:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC7','BTC1','19:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC8','BTC1','20:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC9','BTC2','08:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC10','BTC2','09:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC11','BTC2','11:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC12','BTC2','12:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC13','BTC2','15:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC14','BTC2','16:00')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC15','BTC2','19:30')
INSERT INTO tblGioChieu(MaGioChieu,MaRap,GioChieu) VALUES('GC16','BTC2','20:30')
SELECT * FROM tblGioChieu

INSERT INTO tblPhongChieu(MaPhong,MaRap,TenPhong,TongSoGhe) VALUES('PC1','BTC1',N'Phòng 01',40)
INSERT INTO tblPhongChieu(MaPhong,MaRap,TenPhong,TongSoGhe) VALUES('PC2','BTC1',N'Phòng 02',40)
INSERT INTO tblPhongChieu(MaPhong,MaRap,TenPhong,TongSoGhe) VALUES('PC3','BTC1',N'Phòng 03',40)
INSERT INTO tblPhongChieu(MaPhong,MaRap,TenPhong,TongSoGhe) VALUES('PC4','BTC2',N'Phòng 01',40)
INSERT INTO tblPhongChieu(MaPhong,MaRap,TenPhong,TongSoGhe) VALUES('PC5','BTC2',N'Phòng 02',40)
SELECT * FROM tblPhongChieu

INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A1','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A2','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A3','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A4','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A5','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A6','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A7','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_A8','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B1','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B2','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B3','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B4','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B5','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B6','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B7','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_B8','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C1','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C2','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C3','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C4','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C5','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C6','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C7','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_C8','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D1','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D2','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D3','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D4','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D5','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D6','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D7','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_D8','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E1','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E2','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E3','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E4','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E5','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E6','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E7','BTC1','PC1','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC1_E8','BTC1','PC1','0')

INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A1','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A2','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A3','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A4','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A5','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A6','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A7','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_A8','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B1','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B2','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B3','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B4','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B5','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B6','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B7','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_B8','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C1','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C2','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C3','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C4','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C5','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C6','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C7','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_C8','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D1','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D2','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D3','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D4','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D5','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D6','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D7','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_D8','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E1','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E2','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E3','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E4','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E5','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E6','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E7','BTC1','PC2','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC2_E8','BTC1','PC2','0')

INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A1','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A2','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A3','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A4','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A5','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A6','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A7','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_A8','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B1','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B2','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B3','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B4','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B5','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B6','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B7','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_B8','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C1','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C2','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C3','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C4','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C5','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C6','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C7','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_C8','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D1','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D2','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D3','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D4','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D5','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D6','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D7','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_D8','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E1','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E2','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E3','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E4','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E5','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E6','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E7','BTC1','PC3','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC3_E8','BTC1','PC3','0')

INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A1','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A2','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A3','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A4','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A5','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A6','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A7','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_A8','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B1','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B2','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B3','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B4','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B5','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B6','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B7','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_B8','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C1','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C2','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C3','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C4','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C5','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C6','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C7','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_C8','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D1','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D2','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D3','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D4','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D5','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D6','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D7','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_D8','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E1','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E2','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E3','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E4','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E5','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E6','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E7','BTC2','PC4','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC4_E8','BTC2','PC4','0')

INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A1','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A2','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A3','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A4','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A5','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A6','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A7','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_A8','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B1','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B2','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B3','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B4','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B5','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B6','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B7','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_B8','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C1','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C2','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C3','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C4','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C5','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C6','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C7','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_C8','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D1','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D2','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D3','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D4','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D5','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D6','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D7','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_D8','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E1','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E2','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E3','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E4','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E5','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E6','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E7','BTC2','PC5','0')
INSERT INTO tblGhePhongChieu(MaGhe,MaRap,MaPhong,TrangThai) VALUES('PC5_E8','BTC2','PC5','0')
SELECT * FROM tblGhePhongChieu

INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S1','P1','BTC1','PC1','11/09/2023','GC1',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S2','P1','BTC1','PC1','11/09/2023','GC3',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S3','P2','BTC1','PC2','20/09/2023','GC4',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S4','P2','BTC1','PC2','20/09/2023','GC5',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S5','P3','BTC1','PC3','05/10/2023','GC6',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S6','P3','BTC1','PC3','05/10/2023','GC7',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S7','P4','BTC2','PC4','16/09/2023','GC12',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S8','P4','BTC2','PC4','16/09/2023','GC13',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S9','P5','BTC2','PC5','28/09/2023','GC14',50000,1000,50000000)
INSERT INTO tblLichChieu(MaShow,MaPhim,MaRap,MaPhong,NgayChieu,MaGioChieu,GiaVe,SoVeDaBan,TongTien)
	VALUES('S10','P5','BTC2','PC5','28/09/2023','GC16',50000,1000,50000000)
SELECT * FROM tblLichChieu

INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) VALUES('1',N'Lê Trường An','123',N'Quản Lý',100000000,'BTC1')
INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) VALUES('2',N'Châu Kiến Lương','123',N'Quản Lý',100000000,'BTC2')
INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) VALUES('3',N'Ngô Anh Khoa','123',N'Nhân Viên',5000000,'BTC1')
INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) VALUES('4',N'Nguyễn Đức Hải Bằng','123',N'Nhân Viên',5000000,'BTC1')
INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) VALUES('5',N'Nguyễn Ngọc Minh Tân','123',N'Nhân Viên',6000000,'BTC2')
INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) VALUES('6',N'Deez Nuts','123',N'Nhân Viên',6000000,'BTC2')
SELECT * FROM tblNhanVien

INSERT INTO tblChucNang(MaChucNang, TenChucNang) VALUES(1,N'Quản lý rạp')
INSERT INTO tblChucNang(MaChucNang, TenChucNang) VALUES(2,N'Bán vé')
INSERT INTO tblChucNang(MaChucNang, TenChucNang) VALUES(3,N'Suspend')
SELECT * FROM tblChucNang

INSERT INTO tblQuyenHan(MaQuyen,MaNV,MaChucNang) VALUES('1','1','1')
INSERT INTO tblQuyenHan(MaQuyen,MaNV,MaChucNang) VALUES('2','2','1')
INSERT INTO tblQuyenHan(MaQuyen,MaNV,MaChucNang) VALUES('3','3','2')
INSERT INTO tblQuyenHan(MaQuyen,MaNV,MaChucNang) VALUES('4','4','2')
INSERT INTO tblQuyenHan(MaQuyen,MaNV,MaChucNang) VALUES('5','5','2')
INSERT INTO tblQuyenHan(MaQuyen,MaNV,MaChucNang) VALUES('6','6','3')
SELECT * FROM tblQuyenHan

--INSERT INTO tblVe(MaVe,MaGhe,MaShow) VALUEs(1,'PC1_A6','S1')
--INSERT INTO tblVe(MaVe,MaGhe,MaShow) VALUEs(2,'PC1_A7','S1')
--INSERT INTO tblVe(MaVe,MaGhe,MaShow) VALUEs(3,'PC1_A8','S1')
--select * from tblve

--INSERT INTO tblKhach(MaKhach,TenKhach,SDT,HinhThucThanhToan,MaVe,MaGhe,TenPhim,NgayChieu,GioChieu,GiaVe,HinhThucDat) 
--	VALUEs(1,N'Nguyễn Văn A','09374385245',N'Tại quầy',1,'PC1_A6')


-- Cập nhật tổng số phòng một rạp khi có phòng mới
GO
CREATE TRIGGER CapNhatSoPhongRap 
ON tblPhongChieu 
AFTER INSERT
AS BEGIN
	UPDATE tblRap
	SET SoPhong = SoPhong + (SELECT COUNT(MaPhong) FROM inserted WHERE MaRap = tblRap.MaRap) FROM 
		tblRap JOIN inserted ON tblRap.MaRap = inserted.MaRap
END

-- Cập nhật tổng số ghế một rạp khi có phòng mới
GO
CREATE TRIGGER CapNhatTongSoGheRap 
ON tblPhongChieu 
AFTER INSERT
AS BEGIN
	UPDATE tblRap
	SET TongSoGhe = tblRap.TongSoGhe + (SELECT TongSoGhe FROM inserted WHERE MaRap =
		tblRap.MaRap) FROM tblRap JOIN inserted ON tblRap.MaRap = inserted.MaRap
END

-- Cập nhật tổng số phòng một rạp sau khi một phòng bị xóa
GO
CREATE TRIGGER XoaSoPhongRap 
ON tblPhongChieu 
FOR DELETE
AS BEGIN
	UPDATE tblRap
	SET SoPhong = SoPhong - (SELECT COUNT(MaPhong) FROM deleted WHERE MaRap = tblRap.MaRap) FROM
		tblRap JOIN deleted ON tblRap.MaRap = deleted.MaRap
END 

-- Cập nhật tổng số ghế một rạp sau khi một phòng bị xóa
GO
CREATE TRIGGER XoaTongSoGheRap 
ON tblPhongChieu 
FOR DELETE
AS BEGIN
	UPDATE tblRap
	SET TongSoGhe = tblRap.TongSoGhe - (SELECT TongSoGhe FROM deleted WHERE MaRap = tblRap.MaRap)
	FROM tblRap JOIN deleted ON tblRap.MaRap = deleted.MaRap
END

-- Cập nhật tổng số ghế một rạp sau khi sửa số liệu một phòng
GO
CREATE TRIGGER SuaTongSoGhe
ON tblPhongChieu 
AFTER UPDATE
AS BEGIN
	UPDATE tblRap
	SET TongSoGhe = tblRap.TongSoGhe + (SELECT TongSoGhe FROM inserted WHERE MaRap = tblRap.MaRap
		) - (SELECT TongSoGhe FROM deleted WHERE MaRap = tblRap.MaRap) FROM tblRap JOIN deleted ON
		tblRap.MaRap = deleted.MaRap
END

-- Cập nhật tổng số ghế một phòng sau khi một ghế được thêm
GO
CREATE TRIGGER TongSoGhePC 
ON tblGhePhongChieu
AFTER INSERT 
AS BEGIN
	UPDATE tblPhongChieu
	SET TongSoGhe = tblPhongChieu.TongSoGhe + (SELECT COUNT (MaGhe) FROM inserted WHERE MaPhong
	= tblPhongChieu.MaPhong) FROM tblPhongChieu JOIN inserted ON tblPhongChieu.MaPhong = inserted.MaPhong
END

-- Cập nhật tổng số ghế một phòng sau khi một ghế bị xóa
GO
CREATE TRIGGER XoaTongSoGhePC
ON tblGhePhongChieu
FOR DELETE
AS BEGIN
	UPDATE tblPhongChieu
	SET TongSoGhe = tblPhongChieu.TongSoGhe -(SELECT COUNT (MaGhe) FROM deleted WHERE MaPhong
	= tblPhongChieu.MaPhong) FROM tblPhongChieu JOIN deleted ON tblPhongChieu.MaPhong = deleted.MaPhong
END

--GO
--CREATE TRIGGER DatVe
--ON tblVe 
--AFTER INSERT 
--AS BEGIN 
--	UPDATE tblGhePhongChieu
--	SET TrangThai = 1
--	FROM tblGhePhongChieu JOIN inserted ON tblGhePhongChieu.MaGhe = inserted.MaGhe
--	WHERE tblGhePhongChieu.MaGhe = inserted.MaGhe
--END

--GO
--CREATE TRIGGER HuyVe
--ON tblVe
--AFTER DELETE 
--AS BEGIN 
--	UPDATE tblGhePhongChieu
--	SET TrangThai= 0
--	FROM tblGhePhongChieu JOIN deleted ON tblGhePhongChieu.MaGhe = deleted.MaGhe
--	WHERE tblGhePhongChieu.MaGhe = deleted.MaGhe
--END

 -- Cập nhật tổng tiền khi có thêm vé được bán
GO
CREATE TRIGGER TongTienist 
ON tblVe 
AFTER INSERT 
AS BEGIN 
	UPDATE tblLichChieu
	SET TongTien = (GiaVe * SoVeDaBan) FROM tblLichChieu JOIN inserted 
	ON tblLichChieu.MaShow = inserted.MaShow
	WHERE tblLichChieu.MaShow = inserted.MaShow
END

-- Cập nhật tổng tiền khi có vé bị hủy
GO
CREATE TRIGGER TongTiendlt 
ON tblVe 
AFTER DELETE 
AS BEGIN 
	UPDATE tblLichChieu
	SET TongTien = (GiaVe * SoVeDaBan) FROM tblLichChieu JOIN deleted ON
		tblLichChieu.MaShow = deleted.MaShow WHERE tblLichChieu.MaShow = deleted.MaShow
END

-- Cập nhật tổng tiền khi có vé thay đổi phim
GO
CREATE TRIGGER TongTienudt 
ON tblVe 
AFTER UPDATE 
AS BEGIN 
	UPDATE tblLichChieu
	SET TongTien = (GiaVe * SoVeDaBan) FROM tblLichChieu JOIN inserted  
	ON tblLichChieu.MaShow = inserted.MaShow 
	WHERE tblLichChieu.MaShow = inserted.MaShow
END

-- Cập nhật tổng thu khi show được cập nhật
GO
CREATE TRIGGER TongThuupdate on tblLichChieu AFTER UPDATE AS 
BEGIN UPDATE tblPhim
	SET TongThu = (SELECT SUM(TongTien) FROM tblPhim JOIN inserted 
	ON tblPhim.MaPhim = inserted.MaPhim
	GROUP BY tblPhim.MaPhim)
END

-- Cập nhật tổng tiền khi có một show bị hủy
GO
CREATE TRIGGER TongThudelete 
ON tblLichChieu 
AFTER DELETE 
AS BEGIN 
	UPDATE tblPhim
	SET TongThu = (SELECT SUM(TongTien) FROM tblPhim JOIN deleted 
	ON tblPhim.MaPhim = deleted.MaPhim
	GROUP BY tblPhim.MaPhim)
END
--GO 
--CREATE TRIGGER XoaNhanVien
--ON tblNhanVien
--AFTER DELETE
--AS BEGIN DECLARE 
--    @MaNV CHAR(11),
--    @TenNV VARCHAR(41),
--    @MatKhauNV CHAR(21),
--    @ChucVu VARCHAR(31),
--    @Luong INT,
--    @MaRap CHAR(21); 
--    SELECT @MaNV = del.MaNV FROM deleted del;
--    SELECT @TenNV = del.TenNV FROM deleted del;
--    SELECT @MatKhauNV = del.MatKhauNV FROM deleted del;
--    SELECT @ChucVu = del.ChucVu FROM deleted del;
--    SELECT @Luong = del.Luong FROM deleted del;
--    SELECT @MaRap = del.MaRap FROM deleted del;
--    INSERT INTO tblNhanVien(MaNV,TenNV,MatKhauNV,ChucVu,Luong,MaRap) 
--        VALUES(@MaNV,@TenNV,@MatKhauNV,@ChucVu,@Luong,@MaRap);
--END
--SELECT * FROM tblNhanVien

GO
CREATE PROCEDURE CheckIDNV
(
@ISTK BIT OUTPUT
, @ISMK BIT OUTPUT
, @TK VARCHAR(50)
, @MK CHAR(50)
, @ACCESSKEY INT OUTPUT
)

AS 
BEGIN 
SET @ISTK = 0
SET @ISMK = 0
IF EXISTS(SELECT * FROM tblNhanVien NV FULL OUTER JOIN tblQuyenHan QH
ON NV.MaNV = QH.MaNV 
WHERE NV.MaNV = @TK AND MatKhauNV = @MK AND QH.MaChucNang = 1)
BEGIN
SET @ISTK = 1
SET @ISMK = 1
SET @ACCESSKEY = 1
END
ELSE IF EXISTS(SELECT * FROM tblNhanVien NV FULL OUTER JOIN tblQuyenHan QH
ON NV.MaNV = QH.MaNV 
WHERE NV.MaNV = @TK AND MatKhauNV = @MK AND QH.MaChucNang = 2)
BEGIN
SET @ISTK = 1
SET @ISMK = 1
SET @ACCESSKEY = 2
END
ELSE IF EXISTS(SELECT * FROM tblNhanVien NV FULL OUTER JOIN tblQuyenHan QH
ON NV.MaNV = QH.MaNV 
WHERE NV.MaNV = @TK AND MatKhauNV = @MK AND QH.MaChucNang = 3)
BEGIN
SET @ISTK = 1
SET @ISMK = 1
SET @ACCESSKEY = 3
END
ELSE 
	BEGIN
	IF EXISTS(SELECT * FROM tblNhanVien 
	WHERE MaNV = @TK)
	BEGIN
	SET @ISTK = 1
	END
	END
END

select * from tblVe
select * from tblThongTinVe
DELETE from tblVe
DELETE from tblThongTinVe