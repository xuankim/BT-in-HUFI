USE [master]
GO
/****** Object:  Database [QL_SHOPGIAY]    Script Date: 12/23/2020 11:51:47 PM ******/
CREATE DATABASE [QL_SHOPGIAY]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_SHOPGIAY', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_SHOPGIAY.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_SHOPGIAY_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_SHOPGIAY_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_SHOPGIAY] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_SHOPGIAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_SHOPGIAY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_SHOPGIAY] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_SHOPGIAY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_SHOPGIAY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_SHOPGIAY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_SHOPGIAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_SHOPGIAY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_SHOPGIAY] SET  MULTI_USER 
GO
ALTER DATABASE [QL_SHOPGIAY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_SHOPGIAY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_SHOPGIAY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_SHOPGIAY] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_SHOPGIAY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD](
	[SOHD] [char](10) NOT NULL,
	[MASP] [char](20) NOT NULL,
	[SL] [int] NULL,
	[DONGIA] [int] NULL,
 CONSTRAINT [pk_cthd] PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTPHIEUNHAP]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTPHIEUNHAP](
	[IDPHIEUNHAP] [char](50) NOT NULL,
	[MASP] [char](20) NOT NULL,
	[DONGIANHAP] [int] NULL,
	[SLNHAP] [int] NULL,
 CONSTRAINT [PK_CTPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[IDPHIEUNHAP] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[SOHD] [char](10) NOT NULL,
	[NGLAPHD] [datetime] NULL,
	[MAKH] [char](20) NULL,
	[MANV] [char](20) NULL,
 CONSTRAINT [pk_hd] PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [char](20) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[EMAIL] [varchar](100) NULL,
	[DCHI] [nvarchar](255) NULL,
	[SDT] [varchar](20) NULL,
	[NGSINH] [datetime] NULL,
 CONSTRAINT [pk_kh] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACC]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACC](
	[IDNCC] [char](20) NOT NULL,
	[TENNCC] [nvarchar](255) NULL,
	[DIACHI] [nvarchar](255) NULL,
	[SDT] [char](15) NULL,
 CONSTRAINT [PK_NHACC] PRIMARY KEY CLUSTERED 
(
	[IDNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [char](20) NOT NULL,
	[HOTEN] [nvarchar](40) NOT NULL,
	[EMAIL] [varchar](100) NOT NULL,
	[DCHI] [nvarchar](50) NOT NULL,
	[SODT] [char](20) NOT NULL,
	[NGSINH] [datetime] NOT NULL,
	[NGVL] [datetime] NOT NULL,
	[HS_LUONG] [float] NOT NULL,
	[GioLV] [float] NOT NULL,
 CONSTRAINT [pk_nv] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[IDPHIEUNHAP] [char](50) NOT NULL,
	[NGAYNHAP] [datetime] NOT NULL,
	[IDNCC] [char](20) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[IDPHIEUNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [char](20) NOT NULL,
	[IDTHUONGHIEU] [char](50) NOT NULL,
	[TENSP] [nvarchar](255) NULL,
	[SIZE] [int] NULL,
	[LOAI] [nvarchar](10) NULL,
	[GIABAN] [int] NULL,
	[SOLUONG] [int] NULL,
	[HINHANHSP] [char](255) NULL,
	[MOTA] [nvarchar](255) NULL,
 CONSTRAINT [pk_sp] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THUONGHIEU]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THUONGHIEU](
	[IDTHUONGHIEU] [char](50) NOT NULL,
	[LOGO] [char](50) NULL,
 CONSTRAINT [PK_THUONGHIEU] PRIMARY KEY CLUSTERED 
(
	[IDTHUONGHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 12/23/2020 11:51:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USERS](
	[IDUSER] [char](20) NOT NULL,
	[USERNAME] [char](40) NOT NULL,
	[MATKHAU] [char](40) NOT NULL,
	[POSITION] [nvarchar](50) NOT NULL,
	[MANV] [char](20) NULL,
 CONSTRAINT [pk_USER] PRIMARY KEY CLUSTERED 
(
	[IDUSER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CTHD] ([SOHD], [MASP], [SL], [DONGIA]) VALUES (N'HD01      ', N'SP01N39J            ', 1, 300000)
INSERT [dbo].[CTPHIEUNHAP] ([IDPHIEUNHAP], [MASP], [DONGIANHAP], [SLNHAP]) VALUES (N'PN01                                              ', N'SP01N37J            ', 200000, 10)
INSERT [dbo].[CTPHIEUNHAP] ([IDPHIEUNHAP], [MASP], [DONGIANHAP], [SLNHAP]) VALUES (N'PN01                                              ', N'SP01N38J            ', 180000, 10)
INSERT [dbo].[CTPHIEUNHAP] ([IDPHIEUNHAP], [MASP], [DONGIANHAP], [SLNHAP]) VALUES (N'PN01                                              ', N'SP01N39J            ', 150000, 11)
INSERT [dbo].[CTPHIEUNHAP] ([IDPHIEUNHAP], [MASP], [DONGIANHAP], [SLNHAP]) VALUES (N'ttt                                               ', N'SP01N38J            ', 12, 11)
INSERT [dbo].[CTPHIEUNHAP] ([IDPHIEUNHAP], [MASP], [DONGIANHAP], [SLNHAP]) VALUES (N'ttt                                               ', N'SP01N39J            ', 11, 11)
INSERT [dbo].[HOADON] ([SOHD], [NGLAPHD], [MAKH], [MANV]) VALUES (N'HD01      ', CAST(0x0000AC0100000000 AS DateTime), N'KH01                ', N'NV01                ')
INSERT [dbo].[HOADON] ([SOHD], [NGLAPHD], [MAKH], [MANV]) VALUES (N'HD02      ', CAST(0x0000AC1500000000 AS DateTime), N'KH02                ', N'NV02                ')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [EMAIL], [DCHI], [SDT], [NGSINH]) VALUES (N'KH01                ', N'Nguyễn Văn An', N'vananh123@gmail.com', N'731 Trần Hưng Đạo, Q5, TpHCM', N'8823451', CAST(0x000056C100000000 AS DateTime))
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [EMAIL], [DCHI], [SDT], [NGSINH]) VALUES (N'KH02                ', N'Trần Ngọc Hân', N'ngocanh456@gmail.com', N'23/5 Nguyễn Trãi, Q5, TpHCM', N'908256478', CAST(0x000069F000000000 AS DateTime))
INSERT [dbo].[NHACC] ([IDNCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC01               ', N'Giày Nam Việt', N'D17/4A Đinh Đức Thiện, Ấp 4, X. Bình Chánh, H. Bình Chánh, Tp. Hồ Chí Minh (TPHCM)', N'0987838689     ')
INSERT [dbo].[NHACC] ([IDNCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC02               ', N'Giày Quốc Định', N'9/42 Thống Nhất, P. 15, Q. Gò Vấp, Tp. Hồ Chí Minh (TPHCM)', N'0933167373     ')
INSERT [dbo].[NHACC] ([IDNCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC03               ', N'Giày Dép Thái Long', N'929/20/2 Nguyễn Văn Tạo, Xã Hiệp Phước, Huyện Nhà Bè Tp. Hồ Chí Minh (TPHCM)', N'0903602368     ')
INSERT [dbo].[NHACC] ([IDNCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC04               ', N'Giày Dép Xuất Khẩu', N'Số 1186/3E, Đường An Phú Đông 25, P. An Phú Đông, Q. 12, Tp. Hồ Chí Minh (TPHCM)', N'0933167373     ')
INSERT [dbo].[NHACC] ([IDNCC], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC05               ', N'EVASHOES', N'Số 26, Đường Nguyễn Phong Sắc, P. Dịch Vọng, Q. Cầu Giấy, Hà Nội', N'0935868666     ')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [DCHI], [SODT], [NGSINH], [NGVL], [HS_LUONG], [GioLV]) VALUES (N'NV01                ', N'Nguyễn Lê Nhựt', N'nhut@gmail.com', N'34/34B Nguyễn Tri Phương, Q7, TpHCM', N'927345678           ', CAST(0x00008F1300000000 AS DateTime), CAST(0x0000AB6500000000 AS DateTime), 200000, 60)
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [DCHI], [SODT], [NGSINH], [NGVL], [HS_LUONG], [GioLV]) VALUES (N'NV02                ', N'Lê Thị Phi Yến', N'yen@gmail.com', N'322 Lý Tự Trọng, Q1, TpHCM', N'987567390           ', CAST(0x00008F1B00000000 AS DateTime), CAST(0x0000ABF500000000 AS DateTime), 200000, 50)
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [DCHI], [SODT], [NGSINH], [NGVL], [HS_LUONG], [GioLV]) VALUES (N'NV03                ', N'Nguyễn Văn Bằng', N'bang@gmail.com', N'111 Nguyễn Trãi, Q1, TpHCM', N'997047382           ', CAST(0x00008F2100000000 AS DateTime), CAST(0x0000ABBC00000000 AS DateTime), 200000, 75)
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [DCHI], [SODT], [NGSINH], [NGVL], [HS_LUONG], [GioLV]) VALUES (N'NV04                ', N'Ngô Thành Tuấn', N'tuan@gmail.com', N'34 Nguyễn Hữu Cầu, Q2, TpHCM', N'913758498           ', CAST(0x00008F5B00000000 AS DateTime), CAST(0x0000AC1400000000 AS DateTime), 250000, 100)
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [DCHI], [SODT], [NGSINH], [NGVL], [HS_LUONG], [GioLV]) VALUES (N'NV05                ', N'Trần Xuân Sơn', N'son@gmail.com', N'777 Nguyễn Trãi, Q1, TpHCM', N'918590387           ', CAST(0x0000980400000000 AS DateTime), CAST(0x0000AC3300000000 AS DateTime), 250000, 200)
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [EMAIL], [DCHI], [SODT], [NGSINH], [NGVL], [HS_LUONG], [GioLV]) VALUES (N'tt                  ', N'tt', N'rr@gmail.com', N'tt', N'2222                ', CAST(0x0000AC9600000000 AS DateTime), CAST(0x0000AC9A0182C87C AS DateTime), 2222, 2222)
INSERT [dbo].[PHIEUNHAP] ([IDPHIEUNHAP], [NGAYNHAP], [IDNCC]) VALUES (N'PN01                                              ', CAST(0x0000AC0100000000 AS DateTime), N'NCC01               ')
INSERT [dbo].[PHIEUNHAP] ([IDPHIEUNHAP], [NGAYNHAP], [IDNCC]) VALUES (N'ttt                                               ', CAST(0x0000AC9600000000 AS DateTime), N'NCC01               ')
INSERT [dbo].[SANPHAM] ([MASP], [IDTHUONGHIEU], [TENSP], [SIZE], [LOAI], [GIABAN], [SOLUONG], [HINHANHSP], [MOTA]) VALUES (N'SP01N37J            ', N'Jordan                                            ', N'Jordan MAX 720 02', 37, N'Nam', 300000, 10, N'119549718-1698416293656862-8026301910009318647-o.jpg_v=1600668558000.jpg                                                                                                                                                                                       ', N'Hàng chất lượng cao')
INSERT [dbo].[SANPHAM] ([MASP], [IDTHUONGHIEU], [TENSP], [SIZE], [LOAI], [GIABAN], [SOLUONG], [HINHANHSP], [MOTA]) VALUES (N'SP01N38J            ', N'Jordan                                            ', N'Jordan MAX 720 03', 38, N'Nam', 350000, 10, N'125185374-1749526221879202-1018442684144882496-o.jpg_v=1605695505000.jpg                                                                                                                                                                                       ', N'Hàng chất lượng cao')
INSERT [dbo].[SANPHAM] ([MASP], [IDTHUONGHIEU], [TENSP], [SIZE], [LOAI], [GIABAN], [SOLUONG], [HINHANHSP], [MOTA]) VALUES (N'SP01N39J            ', N'Jordan                                            ', N'Jordan MAX 720 01', 39, N'Nam', 300000, 10, N'img-6827.jpg_v=1596895096000.jpg                                                                                                                                                                                                                               ', N'Hàng chất lượng cao')
INSERT [dbo].[SANPHAM] ([MASP], [IDTHUONGHIEU], [TENSP], [SIZE], [LOAI], [GIABAN], [SOLUONG], [HINHANHSP], [MOTA]) VALUES (N'SP02Nu37A           ', N'Adidas                                            ', N'Adidas MAX 200 37', 37, N'Nữ', 400000, 11, N'62020335-1261364830695346-6204323878206963712-n.jpg_v=1559972689000.jpg                                                                                                                                                                                        ', N'Chất lượng cao')
INSERT [dbo].[SANPHAM] ([MASP], [IDTHUONGHIEU], [TENSP], [SIZE], [LOAI], [GIABAN], [SOLUONG], [HINHANHSP], [MOTA]) VALUES (N'tt                  ', N'Adidas                                            ', N'tt', 39, N'Nam', 101, 1, N'58751206-1224528651045631-2740601434528546816-n.jpg_v=1556432791000.jpg                                                                                                                                                                                        ', N'Chất lượng')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Adidas                                            ', N'Adidas.PNG                                        ')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Asics                                             ', N'Asics.PNG                                         ')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Converse                                          ', N'Converse.PNG                                      ')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Jordan                                            ', N'Jordan.PNG                                        ')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Nike                                              ', N'Nike.png                                          ')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Puma                                              ', N'puma.png                                          ')
INSERT [dbo].[THUONGHIEU] ([IDTHUONGHIEU], [LOGO]) VALUES (N'Vans                                              ', N'Vans.png                                          ')
INSERT [dbo].[USERS] ([IDUSER], [USERNAME], [MATKHAU], [POSITION], [MANV]) VALUES (N'0001                ', N'NguyenNhut                              ', N'99945678                                ', N'Bán hàng', N'NV01                ')
INSERT [dbo].[USERS] ([IDUSER], [USERNAME], [MATKHAU], [POSITION], [MANV]) VALUES (N'0002                ', N'LeYen                                   ', N'92798228                                ', N'Bán hàng', N'NV02                ')
INSERT [dbo].[USERS] ([IDUSER], [USERNAME], [MATKHAU], [POSITION], [MANV]) VALUES (N'0003                ', N'NguyenBang                              ', N'92645678                                ', N'Thu ngân', N'NV03                ')
INSERT [dbo].[USERS] ([IDUSER], [USERNAME], [MATKHAU], [POSITION], [MANV]) VALUES (N'0004                ', N'NgoTuan                                 ', N'925545678                               ', N'Quản lý', N'NV04                ')
INSERT [dbo].[USERS] ([IDUSER], [USERNAME], [MATKHAU], [POSITION], [MANV]) VALUES (N'0005                ', N'TranSon                                 ', N'988888878                               ', N'Nhập kho', N'NV05                ')
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [fk01_CTHD] FOREIGN KEY([SOHD])
REFERENCES [dbo].[HOADON] ([SOHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [fk01_CTHD]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [fk02_CTHD] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [fk02_CTHD]
GO
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk01_CTPN] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP] CHECK CONSTRAINT [fk01_CTPN]
GO
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk02_CTPN] FOREIGN KEY([IDPHIEUNHAP])
REFERENCES [dbo].[PHIEUNHAP] ([IDPHIEUNHAP])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP] CHECK CONSTRAINT [fk02_CTPN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk01_HD] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk01_HD]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk02_HD] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk02_HD]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk01_PN] FOREIGN KEY([IDNCC])
REFERENCES [dbo].[NHACC] ([IDNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [fk01_PN]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [fk01_SP] FOREIGN KEY([IDTHUONGHIEU])
REFERENCES [dbo].[THUONGHIEU] ([IDTHUONGHIEU])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [fk01_SP]
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [fk01_users] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [fk01_users]
GO
USE [master]
GO
ALTER DATABASE [QL_SHOPGIAY] SET  READ_WRITE 
GO
