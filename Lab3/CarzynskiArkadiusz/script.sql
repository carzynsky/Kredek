USE [master]
GO
/****** Object:  Database [CarRental]    Script Date: 09.12.2019 15:11:14 ******/
CREATE DATABASE [CarRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRental', FILENAME = N'F:\mservices\MSSQL14.MSSQLSERVER\MSSQL\DATA\CarRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRental_log', FILENAME = N'F:\mservices\MSSQL14.MSSQLSERVER\MSSQL\DATA\CarRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CarRental] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRental] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRental] SET  MULTI_USER 
GO
ALTER DATABASE [CarRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRental] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarRental', N'ON'
GO
ALTER DATABASE [CarRental] SET QUERY_STORE = OFF
GO
USE [CarRental]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 09.12.2019 15:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[CarBrand] [nvarchar](30) NULL,
	[CarType] [nvarchar](30) NULL,
	[YearOfProduction] [int] NULL,
	[Color] [nvarchar](30) NULL,
	[Mileage] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 09.12.2019 15:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NULL,
	[LastName] [nvarchar](30) NULL,
	[PhoneNumber] [int] NULL,
	[City] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Places]    Script Date: 09.12.2019 15:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[PlaceId] [int] IDENTITY(1,1) NOT NULL,
	[StreetName] [nvarchar](30) NULL,
	[City] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[PlaceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rent]    Script Date: 09.12.2019 15:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rent](
	[RentId] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NULL,
	[CarId] [int] NULL,
	[PlaceId] [int] NULL,
	[RentDate] [date] NULL,
	[Bail] [int] NULL,
	[DayCost] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 09.12.2019 15:11:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workers](
	[WorkerId] [int] IDENTITY(1,1) NOT NULL,
	[Password] [nvarchar](30) NULL,
	[FirstName] [nvarchar](30) NULL,
	[LastName] [nvarchar](30) NULL,
	[HireDate] [date] NULL,
	[Salary] [int] NULL,
	[PlaceId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[WorkerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (1, N'Ford', N'Sedan', 2017, N'Czerwony', 10000)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (2, N'Ford', N'Hatchback', 2018, N'Czarny', 5600)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (3, N'Citroen', N'Hatchback', 2017, N'Srebrny', 20100)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (4, N'Mercedes', N'Sedan', 2019, N'Czerwony', 4500)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (5, N'Mazda', N'Sedan', 2018, N'Zółta', 6700)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (6, N'Nissan', N'SUV', 2019, N'Granatowy', 9990)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (7, N'BMW', N'Sedan', 2017, N'Złoty', 4500)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (8, N'Audi', N'Sedan', 2016, N'Czerwony', 17000)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (9, N'Hyundai', N'SUV', 2017, N'Biały', 13000)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (10, N'Toyota', N'Kombi', 2019, N'Srebrny', 6000)
INSERT [dbo].[Cars] ([CarId], [CarBrand], [CarType], [YearOfProduction], [Color], [Mileage]) VALUES (11, N'Audi', N'Sedan', 2017, N'Biały', 25000)
SET IDENTITY_INSERT [dbo].[Cars] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (1, N'Mikołaj', N'Nowak', 696023431, N'Warszawa')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (2, N'Radosław', N'Kowalski', 724555018, N'Wrocław')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (3, N'Szymon', N'Ptak', 601832132, N'Poznań')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (4, N'Joanna', N'Groch', 569285370, N'Gdańsk')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (5, N'Emilia', N'Marczak', 611833276, N'Legnica')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (6, N'Robert', N'Zieliński', 661208321, N'Lubin')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (7, N'Antoni', N'Buchalski', 672745659, N'Wrocław')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (8, N'Ewa', N'Koń', 723064723, N'Warszawa')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (9, N'Zofia', N'Smolińska', 721300982, N'Wrocław')
INSERT [dbo].[Clients] ([ClientID], [FirstName], [LastName], [PhoneNumber], [City]) VALUES (10, N'Justyna', N'Chmura', 623999230, N'Sopot')
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Places] ON 

INSERT [dbo].[Places] ([PlaceId], [StreetName], [City]) VALUES (1, N'Legnicka', N'Wrocław')
INSERT [dbo].[Places] ([PlaceId], [StreetName], [City]) VALUES (2, N'Włoska', N'Warszawa')
INSERT [dbo].[Places] ([PlaceId], [StreetName], [City]) VALUES (3, N'Wojska Polskiego', N'Gdańsk')
INSERT [dbo].[Places] ([PlaceId], [StreetName], [City]) VALUES (4, N'Armii Krajowej', N'Poznań')
INSERT [dbo].[Places] ([PlaceId], [StreetName], [City]) VALUES (5, N'Kolejowa', N'Legnica')
SET IDENTITY_INSERT [dbo].[Places] OFF
SET IDENTITY_INSERT [dbo].[Rent] ON 

INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (1, 1, 1, 1, CAST(N'2019-11-30' AS Date), 3000, 1000)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (2, 2, 2, 1, CAST(N'2019-11-28' AS Date), 5000, 1200)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (3, 3, 3, 2, CAST(N'2019-11-29' AS Date), 5000, 800)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (4, 4, 4, 3, CAST(N'2019-12-04' AS Date), 8000, 2000)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (5, 5, 5, 2, CAST(N'2019-12-07' AS Date), 8000, 1000)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (6, 6, 6, 4, CAST(N'2019-12-08' AS Date), 9000, 800)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (7, 7, 7, 5, CAST(N'2019-12-06' AS Date), 8000, 700)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (8, 8, 8, 4, CAST(N'2019-12-07' AS Date), 7500, 650)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (9, 9, 9, 4, CAST(N'2019-12-04' AS Date), 5000, 900)
INSERT [dbo].[Rent] ([RentId], [ClientId], [CarId], [PlaceId], [RentDate], [Bail], [DayCost]) VALUES (10, 10, 10, 2, CAST(N'2019-12-07' AS Date), 2500, 500)
SET IDENTITY_INSERT [dbo].[Rent] OFF
SET IDENTITY_INSERT [dbo].[Workers] ON 

INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (1, N'AXHS2', N'Adam', N'Lewandowski', CAST(N'2016-12-08' AS Date), 3000, 1)
INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (2, N'DS341', N'Agata', N'Miroń', CAST(N'2018-03-21' AS Date), 2800, 2)
INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (3, N'HDK32', N'Ignacy', N'Lew', CAST(N'2016-01-11' AS Date), 3200, 2)
INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (4, N'NSDE2', N'Tomasz', N'Gruz', CAST(N'2018-10-03' AS Date), 3300, 3)
INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (5, N'DKDSJ', N'Michalina', N'Kruk', CAST(N'2016-04-27' AS Date), 3100, 4)
INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (6, N'23FFF', N'Ewelina', N'Białek', CAST(N'2013-06-02' AS Date), 4000, 5)
INSERT [dbo].[Workers] ([WorkerId], [Password], [FirstName], [LastName], [HireDate], [Salary], [PlaceId]) VALUES (7, N'TEST', N'Marek', N'Mazanek', CAST(N'2019-03-13' AS Date), 1760, 4)
SET IDENTITY_INSERT [dbo].[Workers] OFF
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([CarId])
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Rent]  WITH CHECK ADD FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Places] ([PlaceId])
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Places] ([PlaceId])
GO
USE [master]
GO
ALTER DATABASE [CarRental] SET  READ_WRITE 
GO
