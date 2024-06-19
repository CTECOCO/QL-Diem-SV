USE [QuanLySinhVien]
drop database QuanLySinhVien;
GO
/****** Object:  Table [dbo].[DiemThi]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemThi](
	[maSV] [varchar](10) NOT NULL,
	[maMH] [varchar](10) NOT NULL,
	[lanThi] [int] NULL,
	[diemThi] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGV] [varchar](10) NOT NULL,
	[tenGV] [nvarchar](50) NULL,
	[chuyenNganh] [nvarchar](50) NULL,
	[maKhoa] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[maKhoa] [varchar](10) NOT NULL,
	[tenKhoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [nchar](10) NOT NULL,
	[tenLop] [nvarchar](50) NULL,
	[maKhoa] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonCuaKhoa]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonCuaKhoa](
	[maKhoa] [varchar](10) NOT NULL,
	[maMH] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[maMH] [varchar](10) NOT NULL,
	[tenMH] [nvarchar](50) NULL,
	[soTiet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSV] [nchar](10) NOT NULL,
	[tenSV] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[ngaySinh] [date] NULL,
	[noiSinh] [nvarchar](50) NULL,
	[maLop] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 06/09/2022 14:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tenDangNhap] [varchar](30) NOT NULL,
	[matKhau] [varchar](30) NOT NULL,
	[hoTen] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[tenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD FOREIGN KEY([maMH])
REFERENCES [dbo].[MonHoc] ([maMH])
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD FOREIGN KEY([maSV])
REFERENCES [dbo].[SinhVien] ([maSV])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[MonCuaKhoa]  WITH CHECK ADD FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[MonCuaKhoa]  WITH CHECK ADD FOREIGN KEY([maMH])
REFERENCES [dbo].[MonHoc] ([maMH])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([maLop])
GO
