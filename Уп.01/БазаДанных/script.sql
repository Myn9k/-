USE [master]
GO
/****** Object:  Database [ws_015]    Script Date: 14.12.2023 12:13:29 ******/
CREATE DATABASE [ws_015]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ws_015', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ws_015.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ws_015_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ws_015_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ws_015] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ws_015].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ws_015] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ws_015] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ws_015] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ws_015] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ws_015] SET ARITHABORT OFF 
GO
ALTER DATABASE [ws_015] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ws_015] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ws_015] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ws_015] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ws_015] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ws_015] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ws_015] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ws_015] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ws_015] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ws_015] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ws_015] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ws_015] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ws_015] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ws_015] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ws_015] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ws_015] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ws_015] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ws_015] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ws_015] SET  MULTI_USER 
GO
ALTER DATABASE [ws_015] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ws_015] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ws_015] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ws_015] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ws_015] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ws_015] SET QUERY_STORE = OFF
GO
USE [ws_015]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Code] [char](2) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[id] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[CountOfStars] [int] NOT NULL,
	[CountryCode] [char](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelComment]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelComment](
	[id] [int] NOT NULL,
	[Hotelid] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[Author] [nvarchar](255) NOT NULL,
	[CreationDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelImage]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelImage](
	[id] [int] NOT NULL,
	[Hotelid] [int] NOT NULL,
	[ImageSource] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelOfTour]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelOfTour](
	[HotelId] [int] NOT NULL,
	[TourId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HotelId] ASC,
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tour]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tour](
	[id] [int] NOT NULL,
	[TicketCount] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePreview] [nvarchar](max) NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[isActual] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[id] [int] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfTour]    Script Date: 14.12.2023 12:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfTour](
	[TypeId] [int] NOT NULL,
	[TourId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC,
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'12', N'Япония')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'35', N'Британия')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'54', N'США')
INSERT [dbo].[Country] ([Code], [Name]) VALUES (N'67', N'Россия')
GO
INSERT [dbo].[Hotel] ([id], [Name], [CountOfStars], [CountryCode]) VALUES (1, N'A', 5, N'12')
INSERT [dbo].[Hotel] ([id], [Name], [CountOfStars], [CountryCode]) VALUES (2, N'B', 5, N'35')
INSERT [dbo].[Hotel] ([id], [Name], [CountOfStars], [CountryCode]) VALUES (3, N'C', 5, N'54')
INSERT [dbo].[Hotel] ([id], [Name], [CountOfStars], [CountryCode]) VALUES (4, N'D', 5, N'67')
GO
INSERT [dbo].[HotelComment] ([id], [Hotelid], [Text], [Author], [CreationDate]) VALUES (1, 1, N'Good', N'A', CAST(N'2005-02-02' AS Date))
INSERT [dbo].[HotelComment] ([id], [Hotelid], [Text], [Author], [CreationDate]) VALUES (2, 2, N'Good', N'B', CAST(N'2004-03-03' AS Date))
INSERT [dbo].[HotelComment] ([id], [Hotelid], [Text], [Author], [CreationDate]) VALUES (3, 3, N'Good', N'C', CAST(N'2006-01-03' AS Date))
INSERT [dbo].[HotelComment] ([id], [Hotelid], [Text], [Author], [CreationDate]) VALUES (4, 4, N'Good', N'D', CAST(N'2007-04-01' AS Date))
GO
INSERT [dbo].[HotelImage] ([id], [Hotelid], [ImageSource]) VALUES (1, 1, N'ds')
INSERT [dbo].[HotelImage] ([id], [Hotelid], [ImageSource]) VALUES (2, 2, N'ds')
INSERT [dbo].[HotelImage] ([id], [Hotelid], [ImageSource]) VALUES (3, 3, N'ds')
INSERT [dbo].[HotelImage] ([id], [Hotelid], [ImageSource]) VALUES (4, 4, N'ds')
GO
INSERT [dbo].[HotelOfTour] ([HotelId], [TourId]) VALUES (1, 1)
INSERT [dbo].[HotelOfTour] ([HotelId], [TourId]) VALUES (2, 2)
INSERT [dbo].[HotelOfTour] ([HotelId], [TourId]) VALUES (3, 3)
INSERT [dbo].[HotelOfTour] ([HotelId], [TourId]) VALUES (4, 4)
GO
INSERT [dbo].[Tour] ([id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [isActual]) VALUES (1, 5, N'A', N'dsd', N'dasda', CAST(5000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Tour] ([id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [isActual]) VALUES (2, 4, N'B', N'dsd', N'dasda', CAST(4500.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Tour] ([id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [isActual]) VALUES (3, 9, N'C', N'dsd', N'dasda', CAST(3500.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[Tour] ([id], [TicketCount], [Name], [Description], [ImagePreview], [Price], [isActual]) VALUES (4, 7, N'D', N'dsd', N'dasda', CAST(2500.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[Type] ([id], [Name], [Description]) VALUES (1, N'A', N'dsada')
INSERT [dbo].[Type] ([id], [Name], [Description]) VALUES (2, N'B', N'dsada')
INSERT [dbo].[Type] ([id], [Name], [Description]) VALUES (3, N'C', N'dsada')
INSERT [dbo].[Type] ([id], [Name], [Description]) VALUES (4, N'D', N'dsada')
GO
INSERT [dbo].[TypeOfTour] ([TypeId], [TourId]) VALUES (1, 1)
INSERT [dbo].[TypeOfTour] ([TypeId], [TourId]) VALUES (2, 2)
INSERT [dbo].[TypeOfTour] ([TypeId], [TourId]) VALUES (3, 3)
INSERT [dbo].[TypeOfTour] ([TypeId], [TourId]) VALUES (4, 4)
GO
ALTER TABLE [dbo].[Hotel]  WITH CHECK ADD FOREIGN KEY([CountryCode])
REFERENCES [dbo].[Country] ([Code])
GO
ALTER TABLE [dbo].[HotelComment]  WITH CHECK ADD FOREIGN KEY([Hotelid])
REFERENCES [dbo].[Hotel] ([id])
GO
ALTER TABLE [dbo].[HotelImage]  WITH CHECK ADD FOREIGN KEY([Hotelid])
REFERENCES [dbo].[Hotel] ([id])
GO
ALTER TABLE [dbo].[HotelOfTour]  WITH CHECK ADD FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([id])
GO
ALTER TABLE [dbo].[HotelOfTour]  WITH CHECK ADD FOREIGN KEY([TourId])
REFERENCES [dbo].[Tour] ([id])
GO
ALTER TABLE [dbo].[TypeOfTour]  WITH CHECK ADD FOREIGN KEY([TourId])
REFERENCES [dbo].[Tour] ([id])
GO
ALTER TABLE [dbo].[TypeOfTour]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [dbo].[Type] ([id])
GO
USE [master]
GO
ALTER DATABASE [ws_015] SET  READ_WRITE 
GO
