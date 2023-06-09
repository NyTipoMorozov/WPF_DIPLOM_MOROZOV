USE [master]
GO
/****** Object:  Database [diplom ]    Script Date: 13.06.2023 23:47:54 ******/
CREATE DATABASE [diplom ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'diplom', FILENAME = N'K:\sql\sqlmain\MSSQL15.SQLEXPRESS\MSSQL\DATA\diplom .mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'diplom _log', FILENAME = N'K:\sql\sqlmain\MSSQL15.SQLEXPRESS\MSSQL\DATA\diplom _log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [diplom ] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [diplom ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [diplom ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [diplom ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [diplom ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [diplom ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [diplom ] SET ARITHABORT OFF 
GO
ALTER DATABASE [diplom ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [diplom ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [diplom ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [diplom ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [diplom ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [diplom ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [diplom ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [diplom ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [diplom ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [diplom ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [diplom ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [diplom ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [diplom ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [diplom ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [diplom ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [diplom ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [diplom ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [diplom ] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [diplom ] SET  MULTI_USER 
GO
ALTER DATABASE [diplom ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [diplom ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [diplom ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [diplom ] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [diplom ] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [diplom ] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [diplom ] SET QUERY_STORE = OFF
GO
USE [diplom ]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 13.06.2023 23:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[Model] [nvarchar](100) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 13.06.2023 23:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NULL,
	[ItemsID] [int] NULL,
	[UserID] [int] NULL,
	[Name] [nvarchar](100) NOT NULL,
	[SecondName] [nvarchar](100) NOT NULL,
	[ThirdName] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](25) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[Comment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 13.06.2023 23:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.06.2023 23:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[IdRole] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (1, N'BMW X4', 3, 5000000.0000)
INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (3, N'Lada Priora', 1, 1100000.0000)
INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (4, N'Lada Niva Legend', 1, 2500000.0000)
INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (5, N'Gelly Monjaro', 2, 3000000.0000)
INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (6, N'BMW X5', 1, 4000000.0000)
INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (7, N'Москвич-3', 4, 800000.0000)
INSERT [dbo].[Cars] ([CarID], [Model], [Quantity], [Price]) VALUES (9, N'Москвич-4', 1, 1400000.0000)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ClientID], [CarID], [ItemsID], [UserID], [Name], [SecondName], [ThirdName], [PhoneNumber], [email], [Comment]) VALUES (2, 1, NULL, NULL, N'Федор', N'Сорокин', N'Константинович', N'79871234356', N'fedora1415@mail.ru', N'Хочу рассмотреть модель автомобиля BMW X4')
INSERT [dbo].[Client] ([ClientID], [CarID], [ItemsID], [UserID], [Name], [SecondName], [ThirdName], [PhoneNumber], [email], [Comment]) VALUES (8, 3, 3, NULL, N'Анастасия', N'Рыбина', N'Анатольевна', N'73164151256', N'nastahahah@mail.ru', N'Мне понравилась модель авто Lada Priora, так же хочу преобрести аптечку в салон')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemID], [Name], [Quantity], [Price]) VALUES (1, N'Набор автомобилиста "Все под рукой"', 3, 4000.0000)
INSERT [dbo].[Items] ([ItemID], [Name], [Quantity], [Price]) VALUES (3, N'Аптечка "Первая помощь"', 5, 3500.0000)
INSERT [dbo].[Items] ([ItemID], [Name], [Quantity], [Price]) VALUES (4, N'Домкрат профессиональный', 9, 3500.0000)
INSERT [dbo].[Items] ([ItemID], [Name], [Quantity], [Price]) VALUES (5, N'Брызговики', 5, 1500.0000)
INSERT [dbo].[Items] ([ItemID], [Name], [Quantity], [Price]) VALUES (6, N'Чехлы для шин AutoShock', 12, 1850.0000)
INSERT [dbo].[Items] ([ItemID], [Name], [Quantity], [Price]) VALUES (7, N'Аптечка "Мини"', 8, 400.0000)
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Login], [Password], [Name], [IdRole]) VALUES (1, N'user', N'user', N'Exsmple User', 0)
INSERT [dbo].[Users] ([ID], [Login], [Password], [Name], [IdRole]) VALUES (3, N'admin', N'admin', N'ExampleAdmin', 1)
INSERT [dbo].[Users] ([ID], [Login], [Password], [Name], [IdRole]) VALUES (5, N'Ivan', N'Ivan', N'Ivan', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Cars] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Cars]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Items] FOREIGN KEY([ItemsID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Items]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Users]
GO
USE [master]
GO
ALTER DATABASE [diplom ] SET  READ_WRITE 
GO
