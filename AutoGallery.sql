USE [master]
GO
/****** Object:  Database [EF_DbAutoGallery]    Script Date: 21.11.2022 13:18:56 ******/
CREATE DATABASE [EF_DbAutoGallery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EF_DbAutoGallery', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERCANKURBAN\MSSQL\DATA\EF_DbAutoGallery.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EF_DbAutoGallery_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERCANKURBAN\MSSQL\DATA\EF_DbAutoGallery_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EF_DbAutoGallery] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EF_DbAutoGallery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EF_DbAutoGallery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET ARITHABORT OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EF_DbAutoGallery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EF_DbAutoGallery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EF_DbAutoGallery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EF_DbAutoGallery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET RECOVERY FULL 
GO
ALTER DATABASE [EF_DbAutoGallery] SET  MULTI_USER 
GO
ALTER DATABASE [EF_DbAutoGallery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EF_DbAutoGallery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EF_DbAutoGallery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EF_DbAutoGallery] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EF_DbAutoGallery] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EF_DbAutoGallery] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EF_DbAutoGallery', N'ON'
GO
ALTER DATABASE [EF_DbAutoGallery] SET QUERY_STORE = OFF
GO
USE [EF_DbAutoGallery]
GO
/****** Object:  Table [dbo].[TBLARAC]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLARAC](
	[Arac_ID] [int] IDENTITY(1,1) NOT NULL,
	[Arac_Plaka] [varchar](50) NULL,
	[Arac_Marka] [varchar](50) NULL,
	[Arac_Model] [varchar](50) NULL,
	[Arac_Renk] [varchar](50) NULL,
	[Arac_UretimYili] [int] NULL,
	[Arac_Vites] [varchar](50) NULL,
	[Arac_Yakit] [varchar](50) NULL,
	[Arac_Fiyat] [decimal](18, 2) NULL,
	[Arac_Fotograf] [varchar](500) NULL,
	[Arac_Durum] [varchar](50) NULL,
	[Sube_ID] [int] NOT NULL,
 CONSTRAINT [PK_TBLARAC] PRIMARY KEY CLUSTERED 
(
	[Arac_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLKIRA]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLKIRA](
	[Kira_ID] [int] IDENTITY(1,1) NOT NULL,
	[Kira_Ucreti] [decimal](18, 2) NULL,
	[Kira_Gun] [int] NULL,
	[Kira_AlimTarihi] [date] NULL,
	[Kira_TeslimTarihi] [date] NULL,
	[Kira_Tutar] [decimal](18, 2) NULL,
	[Musteri_ID] [int] NOT NULL,
	[Arac_ID] [int] NOT NULL,
	[Personel_ID] [int] NOT NULL,
 CONSTRAINT [PK_TBLKIRA] PRIMARY KEY CLUSTERED 
(
	[Kira_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLKULLANICI]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLKULLANICI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Adi] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL,
	[Sifre_Tekrar] [varchar](20) NULL,
 CONSTRAINT [PK_TBLKULLANICI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLMUSTERI]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLMUSTERI](
	[Musteri_ID] [int] IDENTITY(1,1) NOT NULL,
	[Musteri_TCNO] [varchar](11) NULL,
	[Musteri_AdiSoyadi] [varchar](60) NULL,
	[Musteri_DogumTarihi] [date] NULL,
	[Musteri_Mail] [varchar](100) NULL,
	[Musteri_Telefon] [varchar](15) NULL,
	[Musteri_EhliyetNo] [varchar](50) NULL,
	[Musteri_EhliyetTarihi] [date] NULL,
	[Musteri_Adresi] [varchar](200) NULL,
	[Musteri_Fotograf] [varchar](500) NULL,
 CONSTRAINT [PK_TBLMUSTERI] PRIMARY KEY CLUSTERED 
(
	[Musteri_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLPERSONEL]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLPERSONEL](
	[Personel_ID] [int] IDENTITY(1,1) NOT NULL,
	[Personel_TCNO] [varchar](11) NULL,
	[Personel_AdiSoyadi] [varchar](60) NULL,
	[Personel_DogumTarihi] [date] NULL,
	[Personel_Mail] [varchar](100) NULL,
	[Personel_Telefon] [varchar](15) NULL,
	[Personel_Adresi] [varchar](200) NULL,
	[Personel_Fotograf] [varchar](500) NULL,
	[Sube_ID] [int] NOT NULL,
 CONSTRAINT [PK_TBLPERSONEL] PRIMARY KEY CLUSTERED 
(
	[Personel_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSUBE]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSUBE](
	[Sube_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sube_Adi] [varchar](50) NULL,
	[Sube_Adresi] [varchar](200) NULL,
 CONSTRAINT [PK_TBLSUBE] PRIMARY KEY CLUSTERED 
(
	[Sube_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLARAC] ON 

INSERT [dbo].[TBLARAC] ([Arac_ID], [Arac_Plaka], [Arac_Marka], [Arac_Model], [Arac_Renk], [Arac_UretimYili], [Arac_Vites], [Arac_Yakit], [Arac_Fiyat], [Arac_Fotograf], [Arac_Durum], [Sube_ID]) VALUES (1, N'34 ABC 123', N'Audi', N'TT', N'asdas', 1999, N'Otomatik', N'Dizel', CAST(2000000.00 AS Decimal(18, 2)), N'C:\Users\user\OneDrive\Masaüstü\Oto Galeri Projesi\images\910602979bda92b9f88144d313f52725.png', N'DOLU', 1)
INSERT [dbo].[TBLARAC] ([Arac_ID], [Arac_Plaka], [Arac_Marka], [Arac_Model], [Arac_Renk], [Arac_UretimYili], [Arac_Vites], [Arac_Yakit], [Arac_Fiyat], [Arac_Fotograf], [Arac_Durum], [Sube_ID]) VALUES (2, N'34 ABC 124', N'Audi', N'A8', N'asdas', 1999, N'Manuel', N'Benzin', CAST(2500000.00 AS Decimal(18, 2)), N'C:\Users\user\OneDrive\Masaüstü\Oto Galeri Projesi\images\910602979bda92b9f88144d313f52725.png', N'DOLU', 1)
INSERT [dbo].[TBLARAC] ([Arac_ID], [Arac_Plaka], [Arac_Marka], [Arac_Model], [Arac_Renk], [Arac_UretimYili], [Arac_Vites], [Arac_Yakit], [Arac_Fiyat], [Arac_Fotograf], [Arac_Durum], [Sube_ID]) VALUES (3, N'34 CBA 123', N'Aston Martin', N'V7', N'asdas', 2000, N'Otomatik', N'Benzin+LPG', CAST(3500000.00 AS Decimal(18, 2)), N'C:\Users\user\OneDrive\Masaüstü\Oto Galeri Projesi\images\images.jpg', N'BOŞ', 2)
INSERT [dbo].[TBLARAC] ([Arac_ID], [Arac_Plaka], [Arac_Marka], [Arac_Model], [Arac_Renk], [Arac_UretimYili], [Arac_Vites], [Arac_Yakit], [Arac_Fiyat], [Arac_Fotograf], [Arac_Durum], [Sube_ID]) VALUES (4, N'34 CBA 124', N'Cadillac', N'Fleetwood', N'asdas', 1960, N'Manuel', N'Benzin', CAST(10000000.00 AS Decimal(18, 2)), N'C:\Users\user\OneDrive\Masaüstü\Oto Galeri Projesi\images\incredible-two-story-auto-gallery-is-a-library-of-automotive-treasures-a-dream-man-cave_1.jpg', N'BOŞ', 2)
SET IDENTITY_INSERT [dbo].[TBLARAC] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLKIRA] ON 

INSERT [dbo].[TBLKIRA] ([Kira_ID], [Kira_Ucreti], [Kira_Gun], [Kira_AlimTarihi], [Kira_TeslimTarihi], [Kira_Tutar], [Musteri_ID], [Arac_ID], [Personel_ID]) VALUES (1, CAST(300.00 AS Decimal(18, 2)), 3, CAST(N'2022-11-18' AS Date), CAST(N'2022-11-21' AS Date), CAST(900.00 AS Decimal(18, 2)), 1, 4, 1)
INSERT [dbo].[TBLKIRA] ([Kira_ID], [Kira_Ucreti], [Kira_Gun], [Kira_AlimTarihi], [Kira_TeslimTarihi], [Kira_Tutar], [Musteri_ID], [Arac_ID], [Personel_ID]) VALUES (2, CAST(500.00 AS Decimal(18, 2)), 2, CAST(N'2022-11-19' AS Date), CAST(N'2022-11-21' AS Date), CAST(1000.00 AS Decimal(18, 2)), 1, 3, 1)
SET IDENTITY_INSERT [dbo].[TBLKIRA] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLKULLANICI] ON 

INSERT [dbo].[TBLKULLANICI] ([ID], [Kullanici_Adi], [Sifre], [Sifre_Tekrar]) VALUES (1, N'sercan', N'1', N'1')
SET IDENTITY_INSERT [dbo].[TBLKULLANICI] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLMUSTERI] ON 

INSERT [dbo].[TBLMUSTERI] ([Musteri_ID], [Musteri_TCNO], [Musteri_AdiSoyadi], [Musteri_DogumTarihi], [Musteri_Mail], [Musteri_Telefon], [Musteri_EhliyetNo], [Musteri_EhliyetTarihi], [Musteri_Adresi], [Musteri_Fotograf]) VALUES (1, N'42874105832', N'Sercan KURBAN', CAST(N'1996-01-18' AS Date), N'asdsadsa', N'(231) 231-2312', N'1231', CAST(N'2021-12-28' AS Date), N'asdasdsadasdas', N'C:\Users\user\OneDrive\Masaüstü\Oto Galeri Projesi\images\22193_client_icon.ico')
SET IDENTITY_INSERT [dbo].[TBLMUSTERI] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLPERSONEL] ON 

INSERT [dbo].[TBLPERSONEL] ([Personel_ID], [Personel_TCNO], [Personel_AdiSoyadi], [Personel_DogumTarihi], [Personel_Mail], [Personel_Telefon], [Personel_Adresi], [Personel_Fotograf], [Sube_ID]) VALUES (1, N'42889105322', N'asdsa adasd', CAST(N'2004-06-17' AS Date), N'adasd', N'(213) 124-2142', N'asdsadsa', N'C:\Users\user\OneDrive\Masaüstü\Oto Galeri Projesi\images\61842_business_business man_client_clients_professional_icon.ico', 1)
SET IDENTITY_INSERT [dbo].[TBLPERSONEL] OFF
GO
SET IDENTITY_INSERT [dbo].[TBLSUBE] ON 

INSERT [dbo].[TBLSUBE] ([Sube_ID], [Sube_Adi], [Sube_Adresi]) VALUES (1, N'Şube-1', N'deneme')
INSERT [dbo].[TBLSUBE] ([Sube_ID], [Sube_Adi], [Sube_Adresi]) VALUES (2, N'Şube-2', N'denemeci')
SET IDENTITY_INSERT [dbo].[TBLSUBE] OFF
GO
ALTER TABLE [dbo].[TBLARAC]  WITH CHECK ADD  CONSTRAINT [FK_TBLARAC_TBLSUBE] FOREIGN KEY([Sube_ID])
REFERENCES [dbo].[TBLSUBE] ([Sube_ID])
GO
ALTER TABLE [dbo].[TBLARAC] CHECK CONSTRAINT [FK_TBLARAC_TBLSUBE]
GO
ALTER TABLE [dbo].[TBLKIRA]  WITH CHECK ADD  CONSTRAINT [FK_TBLKIRA_TBLARAC] FOREIGN KEY([Arac_ID])
REFERENCES [dbo].[TBLARAC] ([Arac_ID])
GO
ALTER TABLE [dbo].[TBLKIRA] CHECK CONSTRAINT [FK_TBLKIRA_TBLARAC]
GO
ALTER TABLE [dbo].[TBLKIRA]  WITH CHECK ADD  CONSTRAINT [FK_TBLKIRA_TBLMUSTERI] FOREIGN KEY([Musteri_ID])
REFERENCES [dbo].[TBLMUSTERI] ([Musteri_ID])
GO
ALTER TABLE [dbo].[TBLKIRA] CHECK CONSTRAINT [FK_TBLKIRA_TBLMUSTERI]
GO
ALTER TABLE [dbo].[TBLKIRA]  WITH CHECK ADD  CONSTRAINT [FK_TBLKIRA_TBLPERSONEL] FOREIGN KEY([Personel_ID])
REFERENCES [dbo].[TBLPERSONEL] ([Personel_ID])
GO
ALTER TABLE [dbo].[TBLKIRA] CHECK CONSTRAINT [FK_TBLKIRA_TBLPERSONEL]
GO
ALTER TABLE [dbo].[TBLPERSONEL]  WITH CHECK ADD  CONSTRAINT [FK_TBLPERSONEL_TBLSUBE] FOREIGN KEY([Sube_ID])
REFERENCES [dbo].[TBLSUBE] ([Sube_ID])
GO
ALTER TABLE [dbo].[TBLPERSONEL] CHECK CONSTRAINT [FK_TBLPERSONEL_TBLSUBE]
GO
/****** Object:  StoredProcedure [dbo].[MARKAGETIR]    Script Date: 21.11.2022 13:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MARKAGETIR]
AS
SELECT TOP 1 Arac_Marka FROM TBLARAC GROUP BY Arac_Marka ORDER BY COUNT(*) DESC
GO
USE [master]
GO
ALTER DATABASE [EF_DbAutoGallery] SET  READ_WRITE 
GO
