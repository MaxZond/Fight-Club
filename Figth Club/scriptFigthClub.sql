USE [master]
GO
/****** Object:  Database [FigthClub]    Script Date: 15.11.2022 12:52:17 ******/
CREATE DATABASE [FigthClub]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FigthClub', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FigthClub.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FigthClub_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FigthClub_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FigthClub] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FigthClub].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FigthClub] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FigthClub] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FigthClub] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FigthClub] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FigthClub] SET ARITHABORT OFF 
GO
ALTER DATABASE [FigthClub] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FigthClub] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FigthClub] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FigthClub] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FigthClub] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FigthClub] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FigthClub] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FigthClub] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FigthClub] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FigthClub] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FigthClub] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FigthClub] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FigthClub] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FigthClub] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FigthClub] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FigthClub] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FigthClub] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FigthClub] SET RECOVERY FULL 
GO
ALTER DATABASE [FigthClub] SET  MULTI_USER 
GO
ALTER DATABASE [FigthClub] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FigthClub] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FigthClub] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FigthClub] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FigthClub] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FigthClub', N'ON'
GO
ALTER DATABASE [FigthClub] SET QUERY_STORE = OFF
GO
USE [FigthClub]
GO
/****** Object:  User [sus]    Script Date: 15.11.2022 12:52:17 ******/
CREATE USER [sus] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[sus]
GO
/****** Object:  Schema [sus]    Script Date: 15.11.2022 12:52:17 ******/
CREATE SCHEMA [sus]
GO
/****** Object:  Table [dbo].[Charecter]    Script Date: 15.11.2022 12:52:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Charecter](
	[Код_персонажа] [int] IDENTITY(1,1) NOT NULL,
	[Код_пользователя] [int] NOT NULL,
	[Имя_персонажа] [nvarchar](35) NOT NULL,
	[Сила] [int] NOT NULL,
	[Выносливость] [int] NOT NULL,
	[Здоровье] [int] NOT NULL,
	[Особые_умения] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Код_персонажа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15.11.2022 12:52:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Код_пользователя] [int] IDENTITY(1,1) NOT NULL,
	[Электронная_почта] [nvarchar](100) NOT NULL,
	[Логин] [nvarchar](50) NOT NULL,
	[Пароль] [nvarchar](50) NOT NULL,
	[Никнейм] [nvarchar](30) NOT NULL,
	[Роль] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Код_пользователя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Charecter] ON 

INSERT [dbo].[Charecter] ([Код_персонажа], [Код_пользователя], [Имя_персонажа], [Сила], [Выносливость], [Здоровье], [Особые_умения]) VALUES (3, 1, N'Walter White', 45, 20, 15, N'Cancer, Make a Meth')
INSERT [dbo].[Charecter] ([Код_персонажа], [Код_пользователя], [Имя_персонажа], [Сила], [Выносливость], [Здоровье], [Особые_умения]) VALUES (4, 1, N'Boxer', 90, 75, 80, N'Musculs, Speed')
INSERT [dbo].[Charecter] ([Код_персонажа], [Код_пользователя], [Имя_персонажа], [Сила], [Выносливость], [Здоровье], [Особые_умения]) VALUES (5, 1, N'Baby Figther', 70, 90, 90, N'Sexy')
INSERT [dbo].[Charecter] ([Код_персонажа], [Код_пользователя], [Имя_персонажа], [Сила], [Выносливость], [Здоровье], [Особые_умения]) VALUES (6, 5, N'Smirnov', 100, 100, 100, N'Ginius')
INSERT [dbo].[Charecter] ([Код_персонажа], [Код_пользователя], [Имя_персонажа], [Сила], [Выносливость], [Здоровье], [Особые_умения]) VALUES (7, 11, N'Crus', 92, 87, 90, N'Old Spice')
INSERT [dbo].[Charecter] ([Код_персонажа], [Код_пользователя], [Имя_персонажа], [Сила], [Выносливость], [Здоровье], [Особые_умения]) VALUES (1006, 5, N'Danger Dima', 89, 99, 99, N'Love DB')
SET IDENTITY_INSERT [dbo].[Charecter] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (1, N'coolstrelok12345@ya.ru', N'Strelok', N'strelokCool12345', N'BigBoss', N'user')
INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (2, N'senegan@ye.ru', N'Vork', N'zondzond', N'BigClock', N'user')
INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (3, N'p.max@yandex.ru', N'adminMax', N'admin', N'Zond', N'admin')
INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (5, N'badboy@gmail.com', N'admin', N'admin', N'BadBoy13579', N'admin')
INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (6, N'perelom@mail.com', N'Perelom', N'12345', N'Zondick', N'user')
INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (8, N'Arab@flax.ue', N'RichRab', N'6789', N'Arab', N'user')
INSERT [dbo].[Users] ([Код_пользователя], [Электронная_почта], [Логин], [Пароль], [Никнейм], [Роль]) VALUES (11, N'x', N'x', N'x', N'x', N'user')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Charecter]  WITH CHECK ADD  CONSTRAINT [FK_Charecter_Users] FOREIGN KEY([Код_пользователя])
REFERENCES [dbo].[Users] ([Код_пользователя])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Charecter] CHECK CONSTRAINT [FK_Charecter_Users]
GO
USE [master]
GO
ALTER DATABASE [FigthClub] SET  READ_WRITE 
GO
