USE [master]
GO
/****** Object:  Database [MyCompany]    Script Date: 29-08-2020 21:39:04 ******/
CREATE DATABASE [MyCompany]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyCompany', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MyCompany.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyCompany_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MyCompany_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MyCompany] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyCompany].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyCompany] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyCompany] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyCompany] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyCompany] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyCompany] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyCompany] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyCompany] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyCompany] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyCompany] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyCompany] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyCompany] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyCompany] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyCompany] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyCompany] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyCompany] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyCompany] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyCompany] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyCompany] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyCompany] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyCompany] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyCompany] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyCompany] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyCompany] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyCompany] SET  MULTI_USER 
GO
ALTER DATABASE [MyCompany] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyCompany] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyCompany] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyCompany] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyCompany] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyCompany] SET QUERY_STORE = OFF
GO
USE [MyCompany]
GO
/****** Object:  Table [dbo].[temployee]    Script Date: 29-08-2020 21:39:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temployee](
	[Id] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Mobile] [nvarchar](15) NOT NULL,
	[City] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_temployee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[temployee] ON 
GO
INSERT [dbo].[temployee] ([Id], [Name], [Email], [Mobile], [City], [Address]) VALUES (1, N'Tej Singh', N'tej2020@gmail.com', N'9999369005', N'Delhi', N'Delhi-110096')
GO
INSERT [dbo].[temployee] ([Id], [Name], [Email], [Mobile], [City], [Address]) VALUES (1001, N'Sumit', N'sumit.rawat@gmail.com', N'9999999999', N'Noida', N'Sector 22')
GO
SET IDENTITY_INSERT [dbo].[temployee] OFF
GO
USE [master]
GO
ALTER DATABASE [MyCompany] SET  READ_WRITE 
GO