USE [master]
GO
/****** Object:  Database [Entityfr_DbFirst_OtoGaleri]    Script Date: 15.11.2022 01:23:54 ******/
CREATE DATABASE [Entityfr_DbFirst_OtoGaleri]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Entityfr_DbFirst_OtoGaleri', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERCANKURBAN\MSSQL\DATA\Entityfr_DbFirst_OtoGaleri.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Entityfr_DbFirst_OtoGaleri_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERCANKURBAN\MSSQL\DATA\Entityfr_DbFirst_OtoGaleri_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Entityfr_DbFirst_OtoGaleri].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ARITHABORT OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET RECOVERY FULL 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET  MULTI_USER 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Entityfr_DbFirst_OtoGaleri', N'ON'
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET QUERY_STORE = OFF
GO
USE [Entityfr_DbFirst_OtoGaleri]
GO
/****** Object:  Table [dbo].[TBLARAC]    Script Date: 15.11.2022 01:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLARAC](
	[Arac_ID] [int] IDENTITY(1,1) NOT NULL,
	[Arac_Marka] [varchar](50) NULL,
	[Arac_Model] [varchar](50) NULL,
	[Arac_Renk] [varchar](50) NULL,
	[Arac_GovdeModeli] [varchar](50) NULL,
	[Arac_GovdeStili] [varchar](50) NULL,
	[Arac_UretimYili] [int] NULL,
	[Arac_UretimYeri] [varchar](50) NULL,
	[Arac_UretimAdedi] [int] NULL,
	[Arac_YolcuAdedi] [tinyint] NULL,
	[Arac_Fotograf] [varchar](500) NULL,
	[Arac_Hiz] [varchar](50) NULL,
	[Arac_Motor] [varchar](100) NULL,
	[Arac_VitesKutusu] [varchar](50) NULL,
	[Arac_Agirlik] [varchar](10) NULL,
	[Arac_Uzunluk] [varchar](10) NULL,
	[Arac_Genislik] [varchar](10) NULL,
	[Arac_Yukseklik] [varchar](10) NULL,
	[Arac_Frenler] [varchar](50) NULL,
	[Arac_ElektrikSistemi] [varchar](50) NULL,
	[Sube_ID] [int] NULL,
 CONSTRAINT [PK_TBLARAC] PRIMARY KEY CLUSTERED 
(
	[Arac_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLKULLANICI]    Script Date: 15.11.2022 01:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLKULLANICI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_Adi] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL,
	[Sifre_Tekrar] [varchar](20) NULL,
	[Guvenlik_Sorusu] [varchar](100) NULL,
	[Guvenlik_Cevap] [varchar](50) NULL,
 CONSTRAINT [PK_TBLKULLANICI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLMUSTERI]    Script Date: 15.11.2022 01:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLMUSTERI](
	[Musteri_ID] [int] IDENTITY(1,1) NOT NULL,
	[Musteri_TCNO] [varchar](11) NULL,
	[Musteri_Adi] [varchar](30) NULL,
	[Musteri_Soyadi] [varchar](30) NULL,
	[Musteri_Mail] [varchar](120) NULL,
	[Musteri_Telefon] [varchar](20) NULL,
	[Musteri_Adresi] [varchar](200) NULL,
	[Musteri_Fotograf] [varchar](500) NULL,
	[Arac_ID] [int] NULL,
 CONSTRAINT [PK_TBLMUSTERI] PRIMARY KEY CLUSTERED 
(
	[Musteri_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLPERSONEL]    Script Date: 15.11.2022 01:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLPERSONEL](
	[Personel_ID] [int] IDENTITY(1,1) NOT NULL,
	[Personel_TCNO] [bigint] NULL,
	[Personel_Adi] [varchar](30) NULL,
	[Personel_Soyadi] [varchar](30) NULL,
	[Personel_Yas] [tinyint] NULL,
	[Personel_Mail] [varchar](120) NULL,
	[Personel_Telefon] [varchar](20) NULL,
	[Personel_Adres] [varchar](200) NULL,
	[Personel_Fotograf] [varchar](500) NULL,
	[Sube_ID] [int] NULL,
 CONSTRAINT [PK_TBLPERSONEL] PRIMARY KEY CLUSTERED 
(
	[Personel_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSUBE]    Script Date: 15.11.2022 01:23:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSUBE](
	[Sube_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sube_Adi] [varchar](50) NULL,
	[Sube_IL] [varchar](50) NULL,
	[Sube_ILCE] [varchar](50) NULL,
	[Sube_CalisanSayisi] [tinyint] NULL,
	[Sube_Ciro] [int] NULL,
	[Musteri_ID] [int] NULL,
	[Personel_ID] [int] NULL,
 CONSTRAINT [PK_TBLSUBE] PRIMARY KEY CLUSTERED 
(
	[Sube_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBLKULLANICI] ON 

INSERT [dbo].[TBLKULLANICI] ([ID], [Kullanici_Adi], [Sifre], [Sifre_Tekrar], [Guvenlik_Sorusu], [Guvenlik_Cevap]) VALUES (1, N'sercan', N'1', N'1', N'En sevdiğiniz renk nedir?', N'Siyah')
SET IDENTITY_INSERT [dbo].[TBLKULLANICI] OFF
GO
USE [master]
GO
ALTER DATABASE [Entityfr_DbFirst_OtoGaleri] SET  READ_WRITE 
GO
