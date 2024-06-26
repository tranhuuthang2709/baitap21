USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[Giaovien]    Script Date: 22/04/2024 8:32:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giaovien](
	[MaGV] [nvarchar](20) NOT NULL,
	[HotenGV] [nvarchar](100) NULL,
	[DOB] [date] NULL,
	[gioitinh] [bit] NULL,
	[diachi] [nvarchar](200) NULL,
	[tel] [nvarchar](20) NULL,
	[mobile] [nvarchar](20) NULL,
	[email] [nvarchar](100) NULL,
	[emailDCT] [nvarchar](100) NULL,
	[maDV] [nvarchar](20) NULL,
	[hocvi] [nvarchar](50) NULL,
	[chucdanh] [nvarchar](50) NULL,
	[chucvu] [nvarchar](50) NULL,
	[password] [nvarchar](100) NULL,
	[website] [nvarchar](100) NULL,
	[tenviet] [nvarchar](100) NULL,
	[status] [nvarchar](50) NULL,
	[accright] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopSH]    Script Date: 22/04/2024 8:32:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopSH](
	[maLSH] [nvarchar](20) NOT NULL,
	[tenLSH] [nvarchar](100) NULL,
	[manganh] [nvarchar](20) NULL,
	[SISO] [int] NULL,
	[SLTT] [int] NULL,
	[Makhoa] [nvarchar](20) NULL,
	[maGVCN] [nvarchar](20) NULL,
	[SLNam] [int] NULL,
	[status] [nvarchar](50) NULL,
	[ghichu] [nvarchar](200) NULL,
	[khoahoc] [int] NULL,
	[maloptruong] [nvarchar](20) NULL,
	[maloppho] [nvarchar](20) NULL,
	[mabithu] [nvarchar](20) NULL,
	[HKhienhanh] [int] NULL,
	[heDT0] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maLSH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LSH_SV]    Script Date: 22/04/2024 8:32:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LSH_SV](
	[MaLSH] [nvarchar](20) NOT NULL,
	[MaSV] [nvarchar](20) NULL,
	[curSem] [int] NULL,
	[tichluy] [int] NULL,
	[GCP] [int] NULL,
	[ECP] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[ghichu] [nvarchar](200) NULL,
	[CN2] [bit] NULL,
 CONSTRAINT [PK_LSH_SV] PRIMARY KEY CLUSTERED 
(
	[MaLSH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sinhvien]    Script Date: 22/04/2024 8:32:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sinhvien](
	[Masv] [nvarchar](20) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[TenViet] [nvarchar](100) NULL,
	[DOB] [date] NULL,
	[Noisinh] [nvarchar](200) NULL,
	[goitinh] [bit] NULL,
	[diachi] [nvarchar](200) NULL,
	[tel] [nvarchar](20) NULL,
	[mobile] [nvarchar](20) NULL,
	[email] [nvarchar](100) NULL,
	[emailDCT] [nvarchar](100) NULL,
	[diemTS] [int] NULL,
	[accno] [nvarchar](20) NULL,
	[password] [nvarchar](100) NULL,
	[status] [nvarchar](50) NULL,
	[ghichu] [nvarchar](200) NULL,
	[makh] [nvarchar](20) NULL,
	[scmnd] [nvarchar](20) NULL,
	[tenKD] [nvarchar](50) NULL,
	[special] [nvarchar](50) NULL,
	[diemRl] [int] NULL,
	[QDTT] [int] NULL,
	[CDRTH] [int] NULL,
	[SCMND_IMG] [nvarchar](100) NULL,
	[CapDT] [nvarchar](50) NULL,
	[ks] [int] NULL,
	[dantoc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LopSH]  WITH CHECK ADD  CONSTRAINT [FK_LopSH_Giaovien] FOREIGN KEY([maGVCN])
REFERENCES [dbo].[Giaovien] ([MaGV])
GO
ALTER TABLE [dbo].[LopSH] CHECK CONSTRAINT [FK_LopSH_Giaovien]
GO
ALTER TABLE [dbo].[LSH_SV]  WITH CHECK ADD  CONSTRAINT [FK_LSH_SV_LopSH] FOREIGN KEY([MaLSH])
REFERENCES [dbo].[LopSH] ([maLSH])
GO
ALTER TABLE [dbo].[LSH_SV] CHECK CONSTRAINT [FK_LSH_SV_LopSH]
GO
ALTER TABLE [dbo].[LSH_SV]  WITH CHECK ADD  CONSTRAINT [FK_LSH_SV_Sinhvien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[Sinhvien] ([Masv])
GO
ALTER TABLE [dbo].[LSH_SV] CHECK CONSTRAINT [FK_LSH_SV_Sinhvien]
GO
