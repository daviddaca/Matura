USE [master]
GO
/****** Object:  Database [LojaltiKartice]    Script Date: 5/18/2016 7:05:31 PM ******/
CREATE DATABASE [LojaltiKartice] ON  PRIMARY 
( NAME = N'Kartice lojalnosti', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Kartice lojalnosti.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Kartice lojalnosti_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Kartice lojalnosti_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LojaltiKartice].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LojaltiKartice] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LojaltiKartice] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LojaltiKartice] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LojaltiKartice] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LojaltiKartice] SET ARITHABORT OFF 
GO
ALTER DATABASE [LojaltiKartice] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LojaltiKartice] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LojaltiKartice] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LojaltiKartice] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LojaltiKartice] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LojaltiKartice] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LojaltiKartice] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LojaltiKartice] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LojaltiKartice] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LojaltiKartice] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LojaltiKartice] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LojaltiKartice] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LojaltiKartice] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LojaltiKartice] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LojaltiKartice] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LojaltiKartice] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LojaltiKartice] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LojaltiKartice] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LojaltiKartice] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LojaltiKartice] SET  MULTI_USER 
GO
ALTER DATABASE [LojaltiKartice] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LojaltiKartice] SET DB_CHAINING OFF 
GO
USE [LojaltiKartice]
GO
/****** Object:  Table [dbo].[Kartice]    Script Date: 5/18/2016 7:05:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kartice](
	[Broj kartice] [nvarchar](10) NOT NULL,
	[Ime Vlasnika] [nvarchar](50) NULL,
	[Prezime Vlasnika] [nvarchar](50) NULL,
	[Adresa Vlasnika] [nvarchar](50) NULL,
	[Ostvareni Bodovi] [float] NULL,
	[Ostvareni Popust] [float] NULL,
	[Rok vazenja] [float] NULL,
 CONSTRAINT [PK_Kartice] PRIMARY KEY CLUSTERED 
(
	[Broj kartice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'1268463161', N'Mitar', N'Simic', N'Beogradska', 150, 2000, 1)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'3516831334', N'Sima', N'Stojanovic', N'Somborska', 455, 2011, 5)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'6216846168', N'Kosta', N'Kostic', N'Bubanjska Dolina', 200, 5911, 10)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'6451264642', N'Luka', N'Popovic', N'Djure Jaksic', 13, 900, 2)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'6497851325', N'Srdjan', N'Mitic', N'Aleksandra Medvedeva', 67, 200, 4)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'6516846816', N'Petar', N'Petrovic', N'Goce Delcev', 112, 1200, 9)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'7589621464', N'Nikola', N'Tosic', N'Bubanjska', 25, 500, 5)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'8689589595', N'Nikola', N'Marinkovic', N'Somborska', 75, 2016, 8)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'8754151666', N'Mihjlo ', N'Mladenovic', N'Bulevar Medijana', 85, 800, 3)
GO
INSERT [dbo].[Kartice] ([Broj kartice], [Ime Vlasnika], [Prezime Vlasnika], [Adresa Vlasnika], [Ostvareni Bodovi], [Ostvareni Popust], [Rok vazenja]) VALUES (N'9845641135', N'Srdjan ', N'Lilic', N'Obrenoviceva', 66, 6320, 7)
GO
USE [master]
GO
ALTER DATABASE [LojaltiKartice] SET  READ_WRITE 
GO
