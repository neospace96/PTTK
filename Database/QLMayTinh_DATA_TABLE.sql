USE [master]
GO
/****** Object:  Database [QLMayTinh]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE DATABASE [QLMayTinh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLMayTinh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLMayTinh.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLMayTinh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLMayTinh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLMayTinh] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLMayTinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLMayTinh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLMayTinh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLMayTinh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLMayTinh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLMayTinh] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLMayTinh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLMayTinh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLMayTinh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLMayTinh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLMayTinh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLMayTinh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLMayTinh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLMayTinh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLMayTinh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLMayTinh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLMayTinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLMayTinh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLMayTinh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLMayTinh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLMayTinh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLMayTinh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLMayTinh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLMayTinh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLMayTinh] SET  MULTI_USER 
GO
ALTER DATABASE [QLMayTinh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLMayTinh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLMayTinh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLMayTinh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLMayTinh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLMayTinh]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[TenDangNhapAdmin] [varchar](50) NULL,
	[MatKhauDangNhapAdmin] [varchar](50) NULL,
	[TenAdmin] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[FullName] [nvarchar](255) NOT NULL DEFAULT (''),
	[Address] [nvarchar](255) NOT NULL DEFAULT (''),
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonDatHang](
	[MaDonDatHang] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietDonDatHang_1] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[MaSanPham] [int] IDENTITY(4000,1) NOT NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDonDatHang] [int] IDENTITY(1000,1) NOT NULL,
	[MaTaiKhoan] [nvarchar](128) NULL,
	[NgayDatHang] [date] NULL,
	[ThanhTien] [float] NULL,
	[MaTinhTrang] [int] NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(2000,1) NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[MaThuongHieu] [int] NULL,
	[Thongtin] [nvarchar](200) NULL,
	[GiaBan] [float] NULL,
	[Hinh1] [varchar](100) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaThuongHieu] [int] IDENTITY(1000,1) NOT NULL,
	[TenThuongHieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinhTrang]    Script Date: 21/10/2017 11:02:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrang](
	[MaTinhTrang] [int] NOT NULL,
	[TenTinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinhTrang] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([TenDangNhapAdmin], [MatKhauDangNhapAdmin], [TenAdmin]) VALUES (N'admin', N'admin', N'admin')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [Address]) VALUES (N'a2023647-8a48-444d-a4c4-9fafb8418106', N'nguyendinhteki@gmail.com', 0, N'AFi73odAAbVBKhAex115dVJTe/6QMJHEbwFVK9zKg3ZMo7psMM8SKhxZJiB62MatZQ==', N'2fcbbf21-eb09-4806-8096-a38053cd9ce9', N'01205070996', 0, 0, NULL, 1, 0, N'nguyendinhteki@gmail.com', N'Nguyễn Trí Định', N'Ho Chi Minh')
INSERT [dbo].[ChiTietDonDatHang] ([MaDonDatHang], [MaSanPham], [SoLuong]) VALUES (1001, 2036, 1)
SET IDENTITY_INSERT [dbo].[DonDatHang] ON 

INSERT [dbo].[DonDatHang] ([MaDonDatHang], [MaTaiKhoan], [NgayDatHang], [ThanhTien], [MaTinhTrang]) VALUES (1001, N'a2023647-8a48-444d-a4c4-9fafb8418106', CAST(N'2017-10-21' AS Date), 24699000, 3)
SET IDENTITY_INSERT [dbo].[DonDatHang] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2000, N'ACER ES1 131 C4GV', 1000, N'<p>Acer ES1 131 C4GV (MYKSV.001) Intel&reg; Celeron&reg; N3060</p>', 4899000, N'2000.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2001, N'ACER AS ES1 533 C5TS', 1000, N'ACER AS ES1 533 C5TS (NX.MZ8SV.005) Intel® Celeron® N3350', 5799000, N'2001.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2002, N'Acer Aspire ES1 533 P9GZ', 1000, N'Acer Aspire ES1 533 P9GZ (NX.GFTSV.007) Intel® Pentium® N4200', 6699000, N'2002.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2003, N'ACER ES1 531 P6BT', 1000, N'ACER ES1 531 P6BT (MZ8SV.007) Intel® Pentium® N3710', 7100000, N'2003.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2004, N'ACER AS ES1 572 388E', 1000, N'ACER AS ES1 572 388E (NX.GD0SV.001) Intel® Skylake Core™ i3', 7790000, N'2004.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2005, N'ACER R3 131T P6NF', 1000, N'ACER R3 131T P6NF (G0YSV.002) Intel® Pentium® N3710', 8999000, N'2005.png')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2006, N'ACER F5 573 315B', 1000, N'ACER F5 573 315B (GHRSV.002) Intel® Kaby Lake Core™ i3', 9399000, N'2006.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2007, N'Acer R3-471T-3360', 1000, N'Acer R3-471T-3360 (NX.GH2SV.004) Core i3-5005U', 9999000, N'2007.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2008, N'ACER AS E5 575G 37WF', 1000, N'ACER AS E5 575G 37WF (NX.GDWSV.006) Intel® Kaby Lake Core™ i3', 1079900, N'2008.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2009, N'ACER AS SF514 51 72F8', 1000, N'ACER AS SF514 51 72F8 (GLDSV.003) Core™ i7', 22299000, N'2009.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2010, N'Acer Aspire V Nitro VN7', 1000, N'Acer Aspire V Nitro VN7 593G 782D (Q23SV.003) Intel® Kaby Lake Core™ i7', 30999000, N'2010.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2011, N'Macbook Air 13 (MMGF2ZP/A)', 1001, N'Macbook Air 13 (MMGF2ZP/A) Intel Core i5 (1.6GHz up to 2.7GHz)', 22850000, N'2011.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2012, N'MacBook Pro 13 Retina (MF839ZP/A)', 1001, N'MacBook Pro 13 Retina (MF839ZP/A) Intel Core i5 (2.7GHz up to 3.1GHz)', 29300000, N'2012.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2013, N'MACBOOK PRO MF839ZP/A', 1001, N'MACBOOK PRO MF839ZP/A | Core i5 (Up to 3.1GHz)', 30899000, N'2013.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2014, N'Macbook 12 MLH72SA/A Core M3', 1001, N'Macbook 12 MLH72SA/A Core M3 (Up to 2.2GHz)', 30899000, N'2014.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2015, N'Apple Macbook 12 (MNYF2SA/A)', 1001, N'Apple Macbook 12 (MNYF2SA/A) Intel core M3', 32000000, N'2015.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2016, N'Apple MacBook Pro 13 (MPXT2SA/A)', 1001, N'Apple MacBook Pro 13 (MPXT2SA/A) Intel Core i5', 37000000, N'2016.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2017, N'MacBook Pro 13 Retina (MLVP2SA/A)', 1001, N'MacBook Pro 13 Retina (MLVP2SA/A) Intel Core i5 (2.9GHz up to 3.3GHz)', 43000000, N'2017.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2018, N'MacBook Pro 15 Retina (MJLQ2ZP/A)', 1001, N'MacBook Pro 15 Retina (MJLQ2ZP/A) Intel Core i5 (2.2GHz up to 3.4GHz)', 46990000, N'2018.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2019, N'Apple Macbook Pro 15 (MPTR2SA/A)', 1001, N'Apple Macbook Pro 15 (MPTR2SA/A) Intel Core i7 (2.2GHz up to 3.4GHz)', 58800000, N'2019.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2020, N'Apple Macbook Pro 15 (MPTV2SA/A)', 1001, N'Apple Macbook Pro 15 (MPTV2SA/A) Intel Core i7 (2.9GHz up to 3.9GHz)', 68990000, N'2020.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2021, N'Asus S510UQ BQ001T', 1002, N'Asus S510UQ BQ001T Intel® Kaby Lake Core™ i5', 15299000, N'2021.png')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2022, N'Asus A556UR DM397T', 1002, N'Asus A556UR DM397T Intel® Kaby Lake Core™ i7', 15599000, N'2022.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2023, N'ASUS UX310UQ FC133T Core™ i5', 1002, N'ASUS UX310UQ FC133T Core™ i5', 17499000, N'2023.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2024, N'ASUS FX553VD DM304', 1002, N'ASUS FX553VD DM304 Intel® Core™ i5', 18499000, N'2024.png')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2025, N'ASUS GL552VX DM143D', 1002, N'ASUS GL552VX DM143D Intel® Skylake Core™ i5', 18899000, N'2025.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2026, N'ASUS UX390UA GS036T Core™ i7', 1002, N'ASUS UX390UA GS036T Core™ i7', 38799000, N'2026.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2027, N'ASUS UX390UA GS048T Core™ i7', 1002, N'ASUS UX390UA GS048T Core™ i7', 38799000, N'2027.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2028, N'ASUS GL702VM 235 | Core i7', 1002, N'ASUS GL702VM 235 | Core i7', 37880000, N'2028.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2029, N'Asus ROG G752VS BA263', 1002, N'Asus ROG G752VS BA263 Intel® Core™ i7', 53300000, N'2029.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2030, N'ASUS GX700VO GB012T Core i7', 1002, N'ASUS GX700VO GB012T Core i7', 11699000, N'2030.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2031, N'HP Pavilion 15 119TU', 1003, N'HP Pavilion 15 au119TU (Z6X65PA) Intel® Kaby Lake Core™ i5', 12699000, N'2031.png')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2032, N'HP Pavilion 15 014TU', 1003, N'HP Pavilion 15 cc014TU', 12799000, N'2032.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2033, N'HP Probook 440 G3', 1003, N'HP Probook 440 G3', 13100000, N'2033.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2034, N'HP Envy 15 ae130TX', 1003, N'HP Envy 15 ae130TX', 23499000, N'2034.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2035, N'HP Envy 15 as105TU', 1003, N'HP Envy 15 as105TU', 23799000, N'2035.png')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaThuongHieu], [Thongtin], [GiaBan], [Hinh1]) VALUES (2036, N'HP Envy 13 ad074TU', 1003, N'HP Envy 13 ad074TU', 24699000, N'2036.png')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
SET IDENTITY_INSERT [dbo].[ThuongHieu] ON 

INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1000, N'Acer')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1001, N'Macbook')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1002, N'Asus')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1003, N'HP')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1004, N'DELL')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1005, N'Toshiba')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1006, N'Microsoft')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenThuongHieu]) VALUES (1007, N'LG Gram')
SET IDENTITY_INSERT [dbo].[ThuongHieu] OFF
INSERT [dbo].[TinhTrang] ([MaTinhTrang], [TenTinhTrang]) VALUES (1, N'Đang xử lý')
INSERT [dbo].[TinhTrang] ([MaTinhTrang], [TenTinhTrang]) VALUES (2, N'Đang giao hàng')
INSERT [dbo].[TinhTrang] ([MaTinhTrang], [TenTinhTrang]) VALUES (3, N'Đã giao hàng')
INSERT [dbo].[TinhTrang] ([MaTinhTrang], [TenTinhTrang]) VALUES (4, N'Hủy bỏ')
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_RoleId]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserId]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 21/10/2017 11:02:05 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang] FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang]
GO
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSanPham_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietSanPham] CHECK CONSTRAINT [FK_ChiTietSanPham_SanPham]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_AspNetUsers] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_AspNetUsers]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_TinhTrang] FOREIGN KEY([MaTinhTrang])
REFERENCES [dbo].[TinhTrang] ([MaTinhTrang])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_TinhTrang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaThuongHieu])
REFERENCES [dbo].[ThuongHieu] ([MaThuongHieu])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
USE [master]
GO
ALTER DATABASE [QLMayTinh] SET  READ_WRITE 
GO
