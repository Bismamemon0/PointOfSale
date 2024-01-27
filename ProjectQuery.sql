USE [master]
GO
/****** Object:  Database [InventoryManagementSystem]    Script Date: 1/27/2024 7:22:56 AM ******/
CREATE DATABASE [InventoryManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventoryManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\InventoryManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventoryManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\InventoryManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [InventoryManagementSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventoryManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventoryManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventoryManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventoryManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [InventoryManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventoryManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [InventoryManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [InventoryManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventoryManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventoryManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventoryManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventoryManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InventoryManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'InventoryManagementSystem', N'ON'
GO
ALTER DATABASE [InventoryManagementSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [InventoryManagementSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [InventoryManagementSystem]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
	[productName] [varchar](50) NULL,
	[unitPrice] [int] NULL,
	[Quantity] [int] NULL,
	[Description] [varchar](50) NULL,
	[Categoryid] [int] NULL,
	[Quality] [varchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_stocklist]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_stocklist]
AS
SELECT        dbo.Products.ProductID, dbo.Products.productName, dbo.Products.CategoryID, dbo.Products.CategoryName, dbo.Products.unitPrice, dbo.Products.Quantity, dbo.Products.quality, dbo.Products.Description
FROM            dbo.Categories INNER JOIN
                         dbo.Products ON dbo.Categories.CategoryID = dbo.Products.CategoryID
GO
/****** Object:  Table [dbo].[PurchaseDetails]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetails](
	[PurchaseDetail] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NULL,
	[ProductId] [int] NULL,
	[PurchaseQuantity] [int] NULL,
	[PurchaseUnitPrice] [float] NULL,
 CONSTRAINT [PK_PurchaseDetails] PRIMARY KEY CLUSTERED 
(
	[PurchaseDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_PurchaseDetail]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_PurchaseDetail]
AS
SELECT        dbo.PurchaseDetails.PurchaseDetail, dbo.PurchaseDetails.ProductId, dbo.Products.productName, dbo.PurchaseDetails.PurchaseQuantity, dbo.PurchaseDetails.PurchaseUnitPrice, 
                         dbo.PurchaseDetails.PurchaseQuantity * dbo.PurchaseDetails.PurchaseUnitPrice AS ItemCost, dbo.PurchaseDetails.PurchaseID
FROM            dbo.PurchaseDetails INNER JOIN
                         dbo.Products ON dbo.PurchaseDetails.ProductId = dbo.Products.ProductID
GO
/****** Object:  Table [dbo].[Company]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CumpanyID] [int] IDENTITY(1,1) NOT NULL,
	[cumpanyname] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[ContactNo] [varchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CumpanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerNmae] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[ContactNO] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerBalance]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerBalance](
	[SalePayment] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[PaidDate] [date] NOT NULL,
	[PaidAmount] [float] NOT NULL,
	[balanceAmount] [float] NOT NULL,
	[Description] [varbinary](100) NULL,
 CONSTRAINT [PK_CustomerBalance] PRIMARY KEY CLUSTERED 
(
	[SalePayment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[purchaseID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NOT NULL,
	[Purchasedate] [date] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[Desvription] [varchar](50) NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[purchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchasePayment]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchasePayment](
	[PurchasePaymentID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NOT NULL,
	[TotalBalance] [float] NOT NULL,
	[Payment] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[RemainingBalance] [float] NOT NULL,
	[Description] [varbinary](50) NULL,
 CONSTRAINT [PK_PurchasePayment] PRIMARY KEY CLUSTERED 
(
	[PurchasePaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetail]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetail](
	[SaleDetail] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NULL,
	[ProductID] [int] NULL,
	[SaleQuantirty] [int] NULL,
	[SaleUnitPrice] [int] NULL,
 CONSTRAINT [PK_SaleDetail] PRIMARY KEY CLUSTERED 
(
	[SaleDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 1/27/2024 7:22:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[SaleDate] [date] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
	[Description] [varbinary](100) NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([CategoryID], [name], [Description]) VALUES (11, N'labtop', N'welcome customer')
GO
INSERT [dbo].[Categories] ([CategoryID], [name], [Description]) VALUES (12, N'shampo', N'welcome')
GO
INSERT [dbo].[Categories] ([CategoryID], [name], [Description]) VALUES (13, N'massla', N'welcome')
GO
INSERT [dbo].[Categories] ([CategoryID], [name], [Description]) VALUES (14, N'mobile', N'category shampo
')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Company] ON 
GO
INSERT [dbo].[Company] ([CumpanyID], [cumpanyname], [Description], [ContactNo]) VALUES (3, N'bisma', N'welcome', N'+47382-95782958')
GO
INSERT [dbo].[Company] ([CumpanyID], [cumpanyname], [Description], [ContactNo]) VALUES (5, N'daniyal', N'welcome', N'+12345-67891234')
GO
INSERT [dbo].[Company] ([CumpanyID], [cumpanyname], [Description], [ContactNo]) VALUES (10, N'shama', N'welcome', N'+45825-70827890')
GO
INSERT [dbo].[Company] ([CumpanyID], [cumpanyname], [Description], [ContactNo]) VALUES (11, N'rimsha', N'we;lcome', N'+45978-25789273')
GO
INSERT [dbo].[Company] ([CumpanyID], [cumpanyname], [Description], [ContactNo]) VALUES (12, N'humaira', N'welcome customer', N'+36712-63762371')
GO
INSERT [dbo].[Company] ([CumpanyID], [cumpanyname], [Description], [ContactNo]) VALUES (13, N'alisha', N'welcome', N'+36472-64718714')
GO
SET IDENTITY_INSERT [dbo].[Company] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerNmae], [Address], [Description], [ContactNO]) VALUES (9, N'risma', N'rasham bazar', N'welcome', N'+56743-57728946')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerNmae], [Address], [Description], [ContactNO]) VALUES (10, N'humaira', N'rasham bazar', N'welcome', N'+63876-43717381')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (13, N'Rice', N'BISMA', 10, 10, N'WELCOME', NULL, NULL)
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (55, N'labtop', N'lanovo', 1200, 112, N'Best Quality', 11, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (56, N'labtop', N'apple', 1300, 57, N'best Quality', 11, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (57, N'labtop', N'Dell', 800, 119, N'best Quality', 11, N'Normal')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (58, N'labtop', N'dell', 10, 10, N'welcome', 11, N'Normal')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (59, N'Point Of Sale', NULL, 400000, 2, N'', 11, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (60, N'Point Of Sale', NULL, 20000, 2, N'', 11, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (61, N'shampo', N'lifeboy shampo', 150, 142, N'welcome', 12, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (62, N'shampo', N'sunsilk', 150, 42, N'welcome', 12, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (63, N'shampo', N'lifeboys', 200, 10, N'welcome', 12, N'Normal')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (64, N'massla', N'garam masala', 250, 124, N'welcome', 13, N'Normal')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (65, N'massla', N'chat masala', 350, 122, N'welcome', 13, N'Normal')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (66, N'mobile', N'Qmobile', 4000, 505, N'welcome customer', 14, N'Normal')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (67, N'mobile', N'Iphone', 20000, 8, N'welcome', 14, N'Best')
GO
INSERT [dbo].[Products] ([ProductID], [CategoryName], [productName], [unitPrice], [Quantity], [Description], [Categoryid], [Quality]) VALUES (69, N'mobile', N'infinix', 20000, 18, N'welcome', 14, N'Best')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Purchase] ON 
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (16, 3, CAST(N'2023-12-18' AS Date), 0, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (17, 3, CAST(N'2023-12-18' AS Date), 0, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (18, 3, CAST(N'2023-12-18' AS Date), 0, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (19, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (20, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (21, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (22, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (23, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (24, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (25, 3, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (26, 5, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (27, 5, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (28, 5, CAST(N'2023-12-19' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (29, 3, CAST(N'2023-12-21' AS Date), 0, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (30, 3, CAST(N'2023-12-21' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (31, 3, CAST(N'2023-12-21' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (32, 3, CAST(N'2023-12-21' AS Date), 0, N'welco0me')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (33, 10, CAST(N'2023-12-21' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (34, 10, CAST(N'2023-12-21' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (35, 11, CAST(N'2023-12-21' AS Date), 0, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (36, 3, CAST(N'2023-12-22' AS Date), 0, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (37, 3, CAST(N'2023-12-22' AS Date), 100, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (38, 3, CAST(N'2023-12-22' AS Date), 1000, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (39, 3, CAST(N'2023-12-22' AS Date), 7000, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (40, 3, CAST(N'2023-12-22' AS Date), 3600, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (41, 3, CAST(N'2023-12-22' AS Date), 100000, N'')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (42, 3, CAST(N'2023-12-22' AS Date), 5000, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (43, 3, CAST(N'2023-12-22' AS Date), 12000, N'welcomes')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (44, 3, CAST(N'2023-12-22' AS Date), 27400, N'welcomes')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (45, 3, CAST(N'2023-12-22' AS Date), 71400, N'welcomes')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (46, 3, CAST(N'2023-12-22' AS Date), 200, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (47, 3, CAST(N'2023-12-22' AS Date), 200, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (48, 12, CAST(N'2024-01-19' AS Date), 33000, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (49, 12, CAST(N'2024-01-19' AS Date), 33000, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (50, 12, CAST(N'2024-01-19' AS Date), 33000, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (51, 12, CAST(N'2024-01-19' AS Date), 3500, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (52, 12, CAST(N'2024-01-19' AS Date), 33500, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (53, 13, CAST(N'2024-01-19' AS Date), 400, N'welcome')
GO
INSERT [dbo].[Purchase] ([purchaseID], [CompanyID], [Purchasedate], [TotalAmount], [Desvription]) VALUES (54, 13, CAST(N'2024-01-19' AS Date), 1000, N'welcome')
GO
SET IDENTITY_INSERT [dbo].[Purchase] OFF
GO
SET IDENTITY_INSERT [dbo].[PurchaseDetails] ON 
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (3, 16, 55, 2, 200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (4, 17, 56, 2, 400)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (5, 18, 55, 3, 300)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (6, 19, 55, 10, 1000000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (7, 20, 55, 10, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (8, 22, 55, 10, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (9, 23, 55, 10, 20000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (10, 24, 55, 10, 20000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (11, 25, 55, 10, 20000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (12, 25, 55, 10, 30000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (13, 26, 56, 10, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (14, 27, 56, 10, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (15, 27, 57, 10, 100000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (16, 28, 56, 10, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (17, 28, 57, 10, 100000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (18, 28, 57, 10, 20000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (19, 29, 61, 20, 200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (20, 30, 62, 10, 450)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (21, 31, 62, 10, 450)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (22, 32, 64, 50, 150)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (23, 33, 65, 20, 120)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (24, 34, 65, 50, 150)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (25, 35, 65, 10, 10)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (26, 36, 57, 50, 50000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (27, 37, 62, 10, 10)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (28, 38, 64, 10, 100)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (29, 39, 64, 10, 100)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (30, 39, 65, 20, 300)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (31, 40, 55, 3, 1200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (32, 41, 57, 10, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (33, 42, 61, 100, 50)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (34, 43, 55, 10, 1200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (35, 44, 55, 12, 1200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (36, 44, 56, 10, 1300)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (37, 45, 55, 12, 1200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (38, 45, 56, 10, 1300)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (39, 45, 57, 4, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (40, 45, 57, 5, 800)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (41, 46, 61, 1, 100)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (42, 46, 62, 1, 100)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (43, 47, 61, 1, 100)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (44, 47, 62, 1, 100)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (45, 48, 66, 1, 3000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (46, 48, 67, 1, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (47, 48, 69, 2, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (48, 49, 66, 1, 3000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (49, 49, 67, 1, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (50, 49, 69, 2, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (51, 50, 66, 1, 3000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (52, 50, 67, 1, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (53, 50, 69, 2, 10000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (54, 51, 66, 1, 3500)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (55, 52, 66, 1, 3500)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (56, 52, 69, 2, 15000)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (57, 53, 64, 2, 200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (58, 54, 64, 2, 200)
GO
INSERT [dbo].[PurchaseDetails] ([PurchaseDetail], [PurchaseID], [ProductId], [PurchaseQuantity], [PurchaseUnitPrice]) VALUES (59, 54, 65, 2, 300)
GO
SET IDENTITY_INSERT [dbo].[PurchaseDetails] OFF
GO
ALTER TABLE [dbo].[CustomerBalance]  WITH CHECK ADD  CONSTRAINT [FK_CustomerBalance_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[CustomerBalance] CHECK CONSTRAINT [FK_CustomerBalance_Customer]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([Categoryid])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Company1] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CumpanyID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Company1]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetails_Products]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetails_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchase] ([purchaseID])
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetails_Purchase]
GO
ALTER TABLE [dbo].[PurchasePayment]  WITH CHECK ADD  CONSTRAINT [FK_PurchasePayment_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CumpanyID])
GO
ALTER TABLE [dbo].[PurchasePayment] CHECK CONSTRAINT [FK_PurchasePayment_Company]
GO
ALTER TABLE [dbo].[SaleDetail]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetail_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[SaleDetail] CHECK CONSTRAINT [FK_SaleDetail_Products]
GO
ALTER TABLE [dbo].[SaleDetail]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetail_Sales] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
ALTER TABLE [dbo].[SaleDetail] CHECK CONSTRAINT [FK_SaleDetail_Sales]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customer]
GO
/****** Object:  StoredProcedure [dbo].[NewPurchase]    Script Date: 1/27/2024 7:22:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NewPurchase](
@SupplierID int,
@PurchaseID int,
@ProductID int,
@ProductName varchar(50),
@CategoryId int,
@CategoryName varchar(50),
@PurchaseQuantity varchar(50),
@PurchaseUnitPrice varchar(50),
@SaleUnitPrice varchar(50),
@Quanlity varchar(50)
)as
begin
	insert into PurchaseDetails(PurchaseID,ProductId,PurchaseQuantity,PurchaseUnitPrice) values
	(@PurchaseID,@ProductID,@PurchaseQuantity,@PurchaseUnitPrice)
	if (Exists(select * from Products where ProductID = @ProductID and Quality = @Quanlity and Categoryid= @CategoryId))
	begin
	update Products set unitPrice = @SaleUnitPrice, Quantity = Quantity + @PurchaseQuantity where ProductID = @ProductID;
	end
	else
	begin
	insert into Products (Categoryid,CategoryName,unitPrice,Quantity,Quality,[Description]) values 
	(@CategoryId,@ProductName,@SaleUnitPrice,@PurchaseQuantity,@Quanlity,'');
	end
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PurchaseDetails"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 167
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Products"
            Begin Extent = 
               Top = 6
               Left = 261
               Bottom = 158
               Right = 431
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_PurchaseDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_PurchaseDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Categories"
            Begin Extent = 
               Top = 22
               Left = 8
               Bottom = 135
               Right = 178
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Products"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_stocklist'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_stocklist'
GO
USE [master]
GO
ALTER DATABASE [InventoryManagementSystem] SET  READ_WRITE 
GO
