CREATE DATABASE QL_SHOPGIAY
USE QL_SHOPGIAY
----------------------------------
CREATE TABLE THUONGHIEU
(
IDTHUONGHIEU char(50) not null,
LOGO char(50),
constraint PK_THUONGHIEU  primary key (IDTHUONGHIEU)
)
-------------------------
CREATE TABLE NHACC(
	IDNCC char(20) not null,
	TENNCC nvarchar(255),
	DIACHI nvarchar(255),
	SDT char(15),
	constraint PK_NHACC  primary key (IDNCC)
)

CREATE TABLE KHACHHANG(
	MAKH	char(20) not null,	
	HOTEN	nvarchar(50),
	EMAIL   varchar(100),--
	DCHI	nvarchar(255),
	SDT	varchar(20),
	NGSINH	datetime,
	constraint pk_kh primary key(MAKH)
)
---------------------------------------------
--USERS
CREATE TABLE USERS(
	IDUSER char(20) not null,
	USERNAME char(40) not null,
	MATKHAU char(40) not null,
	POSITION nvarchar(50) not null,
	MANV	char(20) ,
	constraint pk_USER primary key(IDUSER)
)
---------------------------------------------
-- NHANVIEN
CREATE TABLE NHANVIEN(
	MANV	char(20) not null,
	HOTEN	nvarchar(40) not null,
	EMAIL   varchar(100) not null,---
	DCHI	nvarchar(50) not null,----
	SODT	char(20) not null,
	NGSINH  datetime not null,
	NGVL	datetime not null,	
	HS_LUONG float not null,
	GioLV float not null

	constraint pk_nv primary key(MANV)
)
--------------------------------------------

-- SANPHAM
CREATE TABLE SANPHAM(
	MASP  char(20) not null,
	IDTHUONGHIEU char(50) NOT NULL,
	TENSP	nvarchar(255),	
	SIZE    int,
	LOAI nvarchar(10),--
	GIABAN	int,
	SOLUONG int,
	HINHANHSP char(255),--	
	MOTA    nvarchar(255),		
	constraint pk_sp primary key(MASP)	
)
--------------------------------------------
--PHIEUNHAP
CREATE TABLE PHIEUNHAP(
	IDPHIEUNHAP CHAR(50) NOT NULL,
	NGAYNHAP datetime not null,
	IDNCC char(20),
	constraint PK_PHIEUNHAP  primary key (IDPHIEUNHAP)
)
--CTPHIEUNHAP
CREATE TABLE CTPHIEUNHAP(
   IDPHIEUNHAP CHAR(50) NOT NULL,
   MASP	char(20) not null,
   DONGIANHAP int,
   SLNHAP INT,
   constraint PK_CTPHIEUNHAP  primary key (IDPHIEUNHAP,MASP)
   )
---------------------------------------------
-- HOADON
CREATE TABLE HOADON(
	SOHD	char(10) not null,
	NGLAPHD 	datetime,
	MAKH 	char(20),
	MANV 	char(20),
	constraint pk_hd primary key(SOHD)
)
---------------------------------------------
-- CTHD
   CREATE TABLE CTHD(
	SOHD	char(10) NOT NULL,
	MASP	char(20) NOT NULL,
	SL	int,
	DONGIA int,
	constraint pk_cthd primary key(SOHD,MASP)
)
-- Khoa ngoai cho bang Users
ALTER TABLE USERS ADD CONSTRAINT fk01_users FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
-- Khoa ngoai cho bang sp
ALTER TABLE SANPHAM ADD CONSTRAINT fk01_SP FOREIGN KEY(IDTHUONGHIEU) REFERENCES THUONGHIEU(IDTHUONGHIEU)
-- Khoa ngoai cho bang PHIEUNHAP 
ALTER TABLE PHIEUNHAP ADD CONSTRAINT fk01_PN FOREIGN KEY(IDNCC) REFERENCES NHACC(IDNCC)
-- khoa ngoai cho bang CTPHIEUNHAP
ALTER TABLE CTPHIEUNHAP ADD CONSTRAINT fk01_CTPN FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)
ALTER TABLE CTPHIEUNHAP ADD CONSTRAINT fk02_CTPN FOREIGN KEY(IDPHIEUNHAP) REFERENCES PHIEUNHAP(IDPHIEUNHAP)
-- Khoa ngoai cho bang HOADON
ALTER TABLE HOADON ADD CONSTRAINT fk01_HD FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
ALTER TABLE HOADON ADD CONSTRAINT fk02_HD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
-- Khoa ngoai cho bang CTHD
ALTER TABLE CTHD ADD CONSTRAINT fk01_CTHD FOREIGN KEY(SOHD) REFERENCES HOADON(SOHD)
ALTER TABLE CTHD ADD CONSTRAINT fk02_CTHD FOREIGN KEY(MASP) REFERENCES SANPHAM(MASP)

-------------------------------
--NHACC
insert into NHACC values('NCC01',N'Giày Nam Việt',N'D17/4A Đinh Đức Thiện, Ấp 4, X. Bình Chánh, H. Bình Chánh, Tp. Hồ Chí Minh (TPHCM)','0987838689')
insert into NHACC values('NCC02',N'Giày Quốc Định',N'9/42 Thống Nhất, P. 15, Q. Gò Vấp, Tp. Hồ Chí Minh (TPHCM)','0933167373')
insert into NHACC values('NCC03',N'Giày Dép Thái Long',N'929/20/2 Nguyễn Văn Tạo, Xã Hiệp Phước, Huyện Nhà Bè Tp. Hồ Chí Minh (TPHCM)','0903602368')
insert into NHACC values('NCC04',N'Giày Dép Xuất Khẩu',N'Số 1186/3E, Đường An Phú Đông 25, P. An Phú Đông, Q. 12, Tp. Hồ Chí Minh (TPHCM)','0933167373')
insert into NHACC values('NCC05',N'EVASHOES',N'Số 26, Đường Nguyễn Phong Sắc, P. Dịch Vọng, Q. Cầu Giấy, Hà Nội','0935868666')
--------------------------------

-- KHACHHANG
set dateformat dmy
insert into khachhang values('KH01',N'Nguyễn Văn An','vananh123@gmail.com',N'731 Trần Hưng Đạo, Q5, TpHCM','8823451','22/10/1960')
insert into khachhang values('KH02',N'Trần Ngọc Hân','ngocanh456@gmail.com',N'23/5 Nguyễn Trãi, Q5, TpHCM','908256478','03/04/1974')

-------------------------------
-- NHANVIEN
insert into nhanvien values('NV01',N'Nguyễn Lê Nhựt','nhut@gmail.com',N'34/34B Nguyễn Tri Phương, Q7, TpHCM','927345678','13/04/2000','18/02/2020',200000,60)
insert into nhanvien values('NV02',N'Lê Thị Phi Yến','yen@gmail.com',N'322 Lý Tự Trọng, Q1, TpHCM','987567390','21/04/2000','11/07/2020',200000,50)
insert into nhanvien values('NV03',N'Nguyễn Văn Bằng','bang@gmail.com',N'111 Nguyễn Trãi, Q1, TpHCM','997047382','27/04/2000','15/05/2020',200000,75)
insert into nhanvien values('NV04',N'Ngô Thành Tuấn','tuan@gmail.com',N'34 Nguyễn Hữu Cầu, Q2, TpHCM','913758498','24/06/2000','11/08/2020',250000,100)
insert into nhanvien values('NV05',N'Trần Xuân Sơn','son@gmail.com',N'777 Nguyễn Trãi, Q1, TpHCM','918590387','20/07/2006','11/09/2020',250000,200)
------------------------------
--USER
insert into USERS values('0001','NguyenNhut','99945678',N'Bán hàng','NV01')
insert into USERS values('0002','LeYen','92798228',N'Bán hàng','NV02')
insert into USERS values('0003','NguyenBang','92645678',N'Thu ngân','NV03')
insert into USERS values('0004','NgoTuan','925545678',N'Quản lý','NV04')
insert into USERS values('0005','TranSon','988888878',N'Nhập kho','NV05')

-------------------------------
--THUONGHIEU
insert into THUONGHIEU values('Jordan','Jordan.PNG')
insert into THUONGHIEU values('Nike','Nike.png')
insert into THUONGHIEU values('Adidas','Adidas.PNG')
insert into THUONGHIEU values('Vans','Vans.png')
insert into THUONGHIEU values('Converse','Converse.PNG')
insert into THUONGHIEU values('Puma','puma.png')
insert into THUONGHIEU values('Asics','Asics.PNG')
-------------------------------

-- SANPHAM

insert into sanpham values('SP01N39J','Jordan','Jordan MAX 720 01',39,'Nam',300000,10,'img-6827.jpg_v=1596895096000.jpg',N'Hàng chất lượng cao')
insert into sanpham values('SP01N37J','Jordan','Jordan MAX 720 02',37,'Nam',300000,10,'119549718-1698416293656862-8026301910009318647-o.jpg_v=1600668558000.jpg',N'Hàng chất lượng cao')
insert into sanpham values('SP01N38J','Jordan','Jordan MAX 720 03',38,'Nam',350000,10,'125185374-1749526221879202-1018442684144882496-o.jpg_v=1605695505000.jpg',N'Hàng chất lượng cao')


-------------------------------


-------------------------------
--PHIEUNHAP

insert into PHIEUNHAP values('PN01','23/07/2020','NCC01')

--CTPHIEUNHAP

insert into CTPHIEUNHAP values('PN01','SP01N39J',150000,11)
insert into CTPHIEUNHAP values('PN01','SP01N37J',200000,10)
insert into CTPHIEUNHAP values('PN01','SP01N38J',180000,10)
------------------------------------
-- HOADON
insert into hoadon values('HD01','23/07/2020','KH01','NV01')
insert into hoadon values('HD02','12/08/2020','KH02','NV02')
--------------------------------------------------------------
-- CTHD
insert into cthd values('HD01','SP01N39J',1,300000)


select*from CTPHIEUNHAP
