USE [master]
GO
/****** Object:  Database [LactoBiotics]    Script Date: 10/14/2019 10:51:48 PM ******/
CREATE DATABASE [LactoBiotics]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LactoBiotics', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CEJASEARL\MSSQL\DATA\LactoBiotics.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LactoBiotics_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CEJASEARL\MSSQL\DATA\LactoBiotics_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LactoBiotics] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LactoBiotics].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LactoBiotics] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LactoBiotics] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LactoBiotics] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LactoBiotics] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LactoBiotics] SET ARITHABORT OFF 
GO
ALTER DATABASE [LactoBiotics] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LactoBiotics] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LactoBiotics] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LactoBiotics] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LactoBiotics] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LactoBiotics] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LactoBiotics] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LactoBiotics] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LactoBiotics] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LactoBiotics] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LactoBiotics] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LactoBiotics] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LactoBiotics] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LactoBiotics] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LactoBiotics] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LactoBiotics] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LactoBiotics] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LactoBiotics] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LactoBiotics] SET  MULTI_USER 
GO
ALTER DATABASE [LactoBiotics] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LactoBiotics] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LactoBiotics] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LactoBiotics] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LactoBiotics] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LactoBiotics]
GO
/****** Object:  Table [dbo].[AddToCart]    Script Date: 10/14/2019 10:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AddToCart](
	[ProductCode] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[ProductPrice] [decimal](10, 2) NULL,
	[OrderQuantity] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[CustomerName] [varchar](50) NULL,
	[CustomerAddress] [varchar](50) NULL,
	[CustomerTin] [varchar](50) NULL,
	[Date] [datetime] NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[StockOnHand] [int] NULL,
	[QuantityPerBox] [int] NULL,
	[AvailableBox] [decimal](7, 2) NULL,
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[Tin] [varchar](50) NULL,
	[CustomerAddress] [varchar](50) NULL,
	[BusinessStyle] [varchar](50) NULL,
	[ContactNo] [varchar](20) NULL,
	[CustomerType] [varchar](50) NULL,
	[UserId] [int] NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeliveryCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeliveryCart](
	[ProductCode] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[ProductPrice] [decimal](10, 2) NULL,
	[OrderQuantity] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[CustomerName] [varchar](50) NULL,
	[CustomerAddress] [varchar](50) NULL,
	[CustomerTin] [varchar](50) NULL,
	[DeliveryDate] [datetime] NULL,
	[date] [datetime] NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[DeliveryStatus] [varchar](50) NULL,
	[StockOnHand] [int] NULL,
	[QuantityPerBox] [int] NULL,
	[AvailableBox] [decimal](7, 2) NULL,
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](50) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[ProductCategory] [varchar](50) NULL,
	[ProductPrice] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
	[QuantityPerBox] [int] NULL,
	[Box] [decimal](7, 2) NULL,
	[ProductDescription] [varchar](max) NULL,
	[UserId] [int] NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsDelivery]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsDelivery](
	[DeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](50) NULL,
	[OrderQuantity] [int] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[DeliveryDate] [datetime] NULL,
	[DeliveryStatus] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsInventory](
	[InventoryId] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](50) NULL,
	[Balance] [int] NULL,
	[StocksIn] [int] NULL,
	[StocksOut] [int] NULL,
	[Box] [decimal](18, 0) NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[InventoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsReservation]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsReservation](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](50) NULL,
	[OrderQuantity] [int] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[ClaimDate] [datetime] NULL,
	[ReservationStatus] [varchar](50) NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReservationCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReservationCart](
	[ProductCode] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[ProductPrice] [decimal](10, 2) NULL,
	[OrderQuantity] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[CustomerName] [varchar](50) NULL,
	[CustomerAddress] [varchar](50) NULL,
	[CustomerTin] [varchar](50) NULL,
	[ClaimDate] [datetime] NULL,
	[date] [datetime] NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[ReservationStatus] [varchar](50) NULL,
	[StockOnHand] [int] NULL,
	[QuantityPerBox] [int] NULL,
	[AvailableBox] [decimal](7, 2) NULL,
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesReports]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesReports](
	[SalesReportID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [varchar](50) NULL,
	[OrderQuantity] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[CustomerID] [int] NULL,
	[UserID] [int] NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserAccounts](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[UserPass] [varchar](20) NOT NULL,
	[Usertype] [varchar](50) NOT NULL,
	[UserFname] [varchar](20) NOT NULL,
	[UserLname] [varchar](20) NOT NULL,
	[UserEmail] [varchar](50) NOT NULL,
	[UserStatus] [varchar](20) NOT NULL,
	[SecQuest] [varchar](max) NOT NULL,
	[SecAns] [varchar](max) NOT NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Tin], [CustomerAddress], [BusinessStyle], [ContactNo], [CustomerType], [UserId], [Date]) VALUES (1, N'sad', N'213-132-421-421', N'talisay', N'manufacturer', N'31242142213', N'Walk-in Client', 1, CAST(N'2019-10-14 15:50:03.070' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductCode], [ProductName], [ProductCategory], [ProductPrice], [Quantity], [QuantityPerBox], [Box], [ProductDescription], [UserId], [Date]) VALUES (1, N'AP-0', N'Agricultural Item', N'Agricultural Products', CAST(12.00 AS Decimal(10, 2)), 225, 50, CAST(4.50 AS Decimal(7, 2)), N'sad', 1, CAST(N'2019-10-14 15:49:10.123' AS DateTime))
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[ProductsDelivery] ON 

INSERT [dbo].[ProductsDelivery] ([DeliveryId], [ProductCode], [OrderQuantity], [TotalPrice], [DeliveryDate], [DeliveryStatus], [CustomerID], [UserID], [Date]) VALUES (1, N'AP-0', 15, CAST(180 AS Decimal(18, 0)), CAST(N'2019-09-25 02:36:32.000' AS DateTime), N'Delivered', 1, 1, CAST(N'2019-10-14 15:54:29.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ProductsDelivery] OFF
SET IDENTITY_INSERT [dbo].[ProductsInventory] ON 

INSERT [dbo].[ProductsInventory] ([InventoryId], [ProductCode], [Balance], [StocksIn], [StocksOut], [Box], [Date]) VALUES (1, N'AP-0', 250, 250, 0, CAST(5 AS Decimal(18, 0)), CAST(N'2019-10-14 15:49:10.187' AS DateTime))
SET IDENTITY_INSERT [dbo].[ProductsInventory] OFF
SET IDENTITY_INSERT [dbo].[SalesReports] ON 

INSERT [dbo].[SalesReports] ([SalesReportID], [ProductCode], [OrderQuantity], [TotalAmount], [CustomerID], [UserID], [Date]) VALUES (1, N'AP-0', 5, CAST(60.00 AS Decimal(10, 2)), 1, 1, CAST(N'2019-10-14 15:50:37.000' AS DateTime))
INSERT [dbo].[SalesReports] ([SalesReportID], [ProductCode], [OrderQuantity], [TotalAmount], [CustomerID], [UserID], [Date]) VALUES (2, N'AP-0', 5, CAST(60.00 AS Decimal(10, 2)), 1, 1, CAST(N'2019-10-14 16:44:34.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[SalesReports] OFF
SET IDENTITY_INSERT [dbo].[UserAccounts] ON 

INSERT [dbo].[UserAccounts] ([UserId], [Username], [UserPass], [Usertype], [UserFname], [UserLname], [UserEmail], [UserStatus], [SecQuest], [SecAns], [Date]) VALUES (1, N'admin', N'admin', N'Administrator', N'earl', N'cejas', N'lykearl@gmail.com', N'Active', N'What is the name of your pet?', N'earl', CAST(N'2019-05-09 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[UserAccounts] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__UserAcco__536C85E4ED117F79]    Script Date: 10/14/2019 10:51:49 PM ******/
ALTER TABLE [dbo].[UserAccounts] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AddToCart]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserAccounts] ([UserId])
GO
ALTER TABLE [dbo].[DeliveryCart]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserAccounts] ([UserId])
GO
ALTER TABLE [dbo].[ProductsDelivery]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[ProductsDelivery]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[ProductsDelivery]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccounts] ([UserId])
GO
ALTER TABLE [dbo].[ProductsInventory]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[ProductsReservation]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[ProductsReservation]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[ProductsReservation]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccounts] ([UserId])
GO
ALTER TABLE [dbo].[ReservationCart]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[SalesReports]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[SalesReports]  WITH CHECK ADD FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
GO
ALTER TABLE [dbo].[SalesReports]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccounts] ([UserId])
GO
/****** Object:  StoredProcedure [dbo].[spAddCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddCart]
@ProductCode varchar (50),
@ProductName varchar (50),
@ProductPrice decimal (10,2),
@OrderQuantity int,
@TotalAmount decimal (10,2),
@CustomerName varchar (50),
@CustomerAddress Varchar (50),
@CustomerTin varchar (50),
@Date Datetime,
@CustomerID int ,
@UserID int,
@StockOnHand int,
@QuantityPerBox int,
@AvailableBox decimal (7,2)
as
insert into AddToCart
values (@ProductCode, @ProductName, @ProductPrice, @OrderQuantity, @TotalAmount, @CustomerName, @CustomerAddress, @CustomerTin, @Date, @CustomerID, @UserID, @StockOnHand, @QuantityPerBox, @AvailableBox)

GO
/****** Object:  StoredProcedure [dbo].[spAddCustomer]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddCustomer]
@CustomerName varchar (50),
@Tin varchar (50),
@CustomerAddress varchar(50),
@BusinessStyle varchar (50),
@ContactNo varchar (20),
@CustomerType varchar (50),
@UserId int,
@Date datetime 
as
insert into Customers
values (@CustomerName, @Tin, @CustomerAddress, @BusinessStyle, @ContactNo ,@CustomerType,@UserId, @Date) return

GO
/****** Object:  StoredProcedure [dbo].[spAddDelCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddDelCart]
@ProductCode varchar (50),
@ProductName varchar (50),
@ProductPrice decimal (10,2),
@OrderQuantity int,
@TotalAmount decimal (10,2),
@CustomerName varchar (50),
@CustomerAddress Varchar (50),
@CustomerTin varchar (50),
@DeliveryDate Datetime,
@Date datetime,
@CustomerID int ,
@UserID int,
@DeliveryStatus varchar (50),
@StockOnHand int,
@QuantityPerBox int,
@AvailableBox decimal (7,2)
as
insert into DeliveryCart
values (@ProductCode, @ProductName, @ProductPrice, @OrderQuantity, @TotalAmount, @CustomerName, @CustomerAddress, @CustomerTin, @DeliveryDate, @Date, @CustomerID, @UserID, @DeliveryStatus, @StockOnHand, @QuantityPerBox, @AvailableBox)

GO
/****** Object:  StoredProcedure [dbo].[spAddDelivery]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddDelivery]
@ProductCode varchar (50),
@OrderQuantity int,
@TotalPrice decimal,
@DeliveryDate datetime,
@DeliveryStatus varchar (50),
@CustomerID int,
@UserID int,
@Date datetime
as
insert into ProductsDelivery
values (@ProductCode, @OrderQuantity, @TotalPrice, @DeliveryDate, @DeliveryStatus, @CustomerID, @UserID, @Date)

GO
/****** Object:  StoredProcedure [dbo].[spAddInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddInventory]
@ProductCode varchar (50),
@Balance int,
@StocksIn int,
@StocksOut int,
@Box decimal,
@Date datetime
as
insert into ProductsInventory
values (@ProductCode, @Balance, @StocksIn, @StocksOut, @Box, @Date)

--------------
GO
/****** Object:  StoredProcedure [dbo].[spAddProducts]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddProducts]
@ProductCode varchar (50),
@ProductName varchar (50),
@ProductCategory varchar (50),
@ProductPrice decimal (10,2),
@Quantity int,
@QuantityPerBox int,
@Box decimal (7,2),
@ProductDescription varchar (max),
@UserId int,
@Date datetime
as
insert into Products
values (@ProductCode, @ProductName, @ProductCategory, @ProductPrice, @Quantity, @QuantityPerBox, @Box, @productDescription, @UserId, @Date) return

GO
/****** Object:  StoredProcedure [dbo].[spAddResCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddResCart]
@ProductCode varchar (50),
@ProductName varchar (50),
@ProductPrice decimal (10,2),
@OrderQuantity int,
@TotalAmount decimal (10,2),
@CustomerName varchar (50),
@CustomerAddress Varchar (50),
@CustomerTin varchar (50),
@ClaimDate datetime,
@Date datetime,
@CustomerID int ,
@UserID int,
@ReservationStatus varchar (50),
@StockOnHand int,
@QuantityPerBox int,
@AvailableBox Decimal (7,2)
as
insert into ReservationCart
values (@ProductCode, @ProductName, @ProductPrice, @OrderQuantity, @TotalAmount, @CustomerName, @CustomerAddress, @CustomerTin, @ClaimDate, @Date, @CustomerID, @UserID, @ReservationStatus, @StockOnHand, @QuantityPerBox, @AvailableBox)

GO
/****** Object:  StoredProcedure [dbo].[spAddReservation]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddReservation]
@ProductCOde varchar (50),
@OrderQuantity int,
@TotalPrice decimal,
@ClaimDate datetime,
@ReservationStatus varchar (50),
@CustomerID int,
@UserID int,
@Date datetime
as
insert into ProductsReservation
values (@ProductCode, @OrderQuantity, @TotalPrice, @ClaimDate, @ReservationStatus, @CustomerID, @UserID, @Date)

GO
/****** Object:  StoredProcedure [dbo].[spAddSalesReports]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddSalesReports]
@ProductCode varchar(50),
@OrderQuantity int,
@TotalAmount decimal (10,2),
@CustomerID int,
@UserID int,
@Date datetime
as
insert into SalesReports
values(@ProductCode, @OrderQuantity, @TotalAmount, @CustomerID, @UserID, @Date)

GO
/****** Object:  StoredProcedure [dbo].[spAddUser]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spAddUser]
@Username varchar (20),
@UserPass varchar (20),
@Usertype varchar (50),
@UserFname varchar (20),
@UserLname varchar (20),
@UserEmail varchar (50),
@UserStatus varchar (20), 
@SecQuest varchar (max),
@SecAns varchar (max),
@Date datetime
as
insert into UserAccounts 
values (@Username,@UserPass,@Usertype,@UserFname,@UserLname, @UserEmail, @UserStatus, @SecQuest, @SecAns,@Date) return

GO
/****** Object:  StoredProcedure [dbo].[spCancelOrder]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spCancelOrder]
@quantityToRevert int,
@product_Code varchar(max),
@Box decimal (7,2)
as
update Products
set Quantity = Quantity + @quantityToRevert, Box = Box + @Box 
where products.productCode = @product_Code

GO
/****** Object:  StoredProcedure [dbo].[spDeleteCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spDeleteCart]
@OrderID int
as
delete from AddToCart
where OrderID = @OrderID

GO
/****** Object:  StoredProcedure [dbo].[spDeleteDelCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spDeleteDelCart]
@OrderID int
as
delete from DeliveryCart
where OrderID = @OrderID

GO
/****** Object:  StoredProcedure [dbo].[spDeleteProInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spDeleteProInventory]
@ProductCode varchar (50)
as
delete from ProductsInventory 
where ProductCode = @ProductCode

GO
/****** Object:  StoredProcedure [dbo].[spDeleteResCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spDeleteResCart]
@OrderID int
as
delete from ReservationCart
where OrderID = @OrderID

GO
/****** Object:  StoredProcedure [dbo].[spDeleteUser]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteUser]
@UserId int
as
delete from UserAccounts
where UserId = @UserId return
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spLogin]
@Username varchar (max),
@UserPass varchar (max)
as
select * from UserAccounts where Username = @Username and UserPass = @UserPass return

GO
/****** Object:  StoredProcedure [dbo].[spRemoveCustomer]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spRemoveCustomer]
@CustomerId int
as
delete from Customers
where CustomerId = @CustomerId return

GO
/****** Object:  StoredProcedure [dbo].[spRemoveProducts]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spRemoveProducts]
@ProductCode varchar (50)
as
delete from Products
where ProductCode = @ProductCode  return

--------
GO
/****** Object:  StoredProcedure [dbo].[spSearchCustomer]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSearchCustomer]
@key varchar (max)
as
select * from Customers
where CustomerId like '%' +@key+ '%' or
      CustomerName like '%' + @key+ '%' or
	  Tin like '%' + @key+ '%' or
      CustomerAddress like '%' + @key+ '%' or
	  BusinessStyle like '%' + @key+ '%' or
	  ContactNo like '%' + @key+ '%' or
	  CustomerType like '%' + @key+ '%' or
      UserId like '%' +@key+ '%' or
	  Date like '%' + @key+ '%' 
	  return

GO
/****** Object:  StoredProcedure [dbo].[spSearchDelivery]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[spSearchDelivery]
@key varchar (max)
as
select * from ProductsDelivery, Products, Customers, UserAccounts
where DeliveryID like '%' +@key+ '%' or
      Products.ProductCode like '%' +@key+ '%' or
	  Products.ProductName like '%' +@key+ '%' or
	  OrderQuantity like '%' +@key+ '%' or
	  TotalPrice like '%' +@key+ '%' or
	  DeliveryDate like '%' +@key+ '%' or
	  DeliveryStatus like '%' +@key+ '%' or
	  customers.CustomerName like '%' +@key+ '%' or
	  customers.CustomerAddress like '%' +@key+ '%' or
	  customers.CustomerID like '%' +@key+ '%' or
	  UserAccounts.Username like '%' +@key+ '%' or
	  UserAccounts.UserID like '%' +@key+ '%' or
	  ProductsDelivery.Date like '%' +@key+ '%' 

GO
/****** Object:  StoredProcedure [dbo].[spSearchProducts]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSearchProducts]
@key varchar (max)
as
select * from Products
where ProductID like '%' +@key+ '%' or
	  ProductCode like '%' +@key+ '%' or
	  ProductName like '%' +@key+ '%' or
	  ProductCategory like '%' +@key+ '%' or
	  ProductPrice like '%' +@key+ '%' or
	  Quantity like '%' +@key+ '%' or
	  QuantityPerBox like '%' +@key+ '%' or
	  Box like '%' +@key+ '%' or
	  ProductDescription like '%' +@key+ '%' or
	  UserId like '%' +@key+ '%' or
	  Date like '%' +@key+ '%'

GO
/****** Object:  StoredProcedure [dbo].[spSearchReservation]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSearchReservation]
@key varchar (max)
as
select * from ProductsReservation, Products, Customers, UserAccounts
where ReservationID like '%' +@key+ '%' or
      Products.ProductCode like '%' +@key+ '%' or
	  ProductName like '%' +@key+ '%' or
	  OrderQuantity like '%' +@key+ '%' or
	  TotalPrice like '%' +@key+ '%' or
	  ClaimDate like '%' +@key+ '%' or
	  ReservationStatus like '%' +@key+ '%' or
	  Customers.CustomerName like '%' +@key+ '%' or
	  Customers.CustomerAddress like '%' +@key+ '%' or
	  Customers.CustomerID like '%' +@key+ '%' or
	  UserAccounts.Username like '%' +@key+ '%' or
	  UserAccounts.UserID like '%' +@key+ '%' or
	  ProductsReservation.Date like '%' +@key+ '%' 

GO
/****** Object:  StoredProcedure [dbo].[spSearchSalesReports]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSearchSalesReports]
@key varchar (max)
as
select * from SalesReports, Customers, UserAccounts, Products
where SalesReportID like '%' +@key+ '%' or
      Products.ProductCode  like '%' +@key+ '%' or
	  Products.ProductName  like '%' +@key+ '%' or
	  Products.ProductPrice  like '%' +@key+ '%' or
	  OrderQuantity  like '%' +@key+ '%' or
	  TotalAmount  like '%' +@key+ '%' or
	  Products.ProductDescription  like '%' +@key+ '%' or
	  Customers.CustomerName  like '%' +@key+ '%' or
	  Customers.CustomerAddress  like '%' +@key+ '%' or
	  Customers.CustomerID  like '%' +@key+ '%' or
	  UserAccounts.Username  like '%' +@key+ '%' or
	  SalesReports.Date  like '%' +@key+ '%' 

-----------------------------
GO
/****** Object:  StoredProcedure [dbo].[spSearchUser]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSearchUser]
@key varchar (max)
as
select * from UserAccounts
where UserId like '%' +@key+ '%' or
      Username like '%' +@key+ '%' or
      UserPass like '%' +@key+ '%' or
	  Usertype like '%' +@key+ '%' or
      UserFname like '%' + @key+ '%' or
	  UserLname like '%' + @key+ '%' or
	  UserEmail like '%' + @key+ '%' or
	  UserStatus like '%' + @key+ '%' or
	  SecQuest like '%' + @key+ '%'or
	  SecAns like '%' + @key+ '%'or
	  Date  like '%' + @key+ '%'
	  return
GO
/****** Object:  StoredProcedure [dbo].[spSelectDelivery]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSelectDelivery]
as
select DeliveryId, products.ProductCode, products.ProductName, ProductsDelivery.OrderQuantity, ProductsDelivery.TotalPrice, ProductsDelivery.DeliveryDate, ProductsDelivery.DeliveryStatus, 
customers.CustomerName, Customers.CustomerAddress, customers.CustomerID, UserAccounts.Username, UserAccounts.UserId, ProductsDelivery.Date
from ProductsDelivery inner join products on ProductsDelivery.ProductCode = products.productCode inner join customers on ProductsDelivery.CustomerID = customers.CustomerID inner join UserAccounts on ProductsDelivery.UserID = UserAccounts.UserID

GO
/****** Object:  StoredProcedure [dbo].[spSelectInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSelectInventory]
as
select InventoryID, products.ProductCode, Products.ProductName, productsInventory.Balance, StocksIn, StocksOut, ProductsInventory.Box, ProductsInventory.Date
from ProductsInventory inner join products on ProductsInventory.ProductCode = products.ProductCode
 
GO
/****** Object:  StoredProcedure [dbo].[spSelectReservation]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spSelectReservation]
as
select ReservationId, products.ProductCode, products.ProductName, ProductsReservation.OrderQuantity, ProductsReservation.totalPrice, ProductsReservation.ClaimDate, ProductsReservation.ReservationStatus, 
customers.CustomerName, customers.CustomerAddress, customers.CustomerID, UserAccounts.Username, UserAccounts.UserID, ProductsReservation.Date
from ProductsReservation inner join products on ProductsReservation.ProductCode = products.ProductCode inner join customers on ProductsReservation.CustomerID = customers.CustomerID inner join UserAccounts on ProductsReservation.UserID = UserAccounts.UserID

------
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCustomer]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateCustomer]
@CustomerId int,
@CustomerName varchar (50),
@Tin varchar (50),
@CustomerAddress varchar(20),
@BusinessStyle varchar (50),
@ContactNo varchar (20),
@CustomerType varchar (50),
@Date datetime
as
update Customers
set CustomerName = @CustomerName, Tin = @Tin, CustomerAddress = @CustomerAddress, BusinessStyle = @BusinessStyle, ContactNo = @ContactNo, CustomerType = @CustomerType,  Date = @Date
where CustomerId = @CustomerId return

---------
GO
/****** Object:  StoredProcedure [dbo].[spUpdateDelivery]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateDelivery]
@DeliveryId int,
@DeliveryStatus varchar(50)
as
update ProductsDelivery
set DeliveryStatus = @DeliveryStatus
where DeliveryId = @DeliveryId

GO
/****** Object:  StoredProcedure [dbo].[spUpdateInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateInventory]
@ProductCode varchar (50),
@StocksOut int
as
update ProductsInventory
Set StocksOut = StocksOut + @StocksOut
where ProductsInventory.ProductCode = @ProductCode

GO
/****** Object:  StoredProcedure [dbo].[spUpdateProduct]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateProduct]
 @ProductCode varchar (50),
 @Quantity int,
 @Box decimal (7,2)
 as
 update products 
 set Quantity = Quantity - @Quantity , Box = Box - @Box
 WHERE products.ProductCode = @ProductCode

GO
/****** Object:  StoredProcedure [dbo].[spUpdateProductInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateProductInventory]
@ProductCode varchar (50),
@StocksIn int
as
update ProductsInventory
Set StocksIn = StocksIn + @StocksIn
where ProductsInventory.ProductCode = @ProductCode

GO
/****** Object:  StoredProcedure [dbo].[spUpdateProducts]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateProducts]
@ProductID int,
@ProductCode varchar (50),
@ProductName varchar (50),
@ProductCatergory varchar (50),
@ProductPrice decimal (10,2),
@Quantity int,
@QuantityPerBox int,
@Box decimal (7,2),
@ProductDescription varchar (50),
@Date datetime
as
update Products
set ProductCode = @ProductCode, ProductName = @ProductName, ProductCategory = @ProductCatergory, ProductPrice = @ProductPrice, Quantity = @Quantity, QuantityPerBox = @QuantityPerBox, Box = @Box, ProductDescription = @ProductDescription, Date = @Date
where ProductID = @ProductID return

GO
/****** Object:  StoredProcedure [dbo].[spUpdateProInventory]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateProInventory]
@ProductCode varchar (50),
@StocksIn int,
@StocksOut int
as
update ProductsInventory
Set StocksIn = StocksIn + @StocksIn, StocksOut = StocksOut - @StocksOut
where ProductsInventory.ProductCode = @ProductCode

GO
/****** Object:  StoredProcedure [dbo].[spUpdateReservation]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateReservation]
@ReservationID int,
@ReservationStatus varchar(50)
as
update ProductsReservation
set ReservationStatus = @ReservationStatus
where ReservationId = @ReservationId

GO
/****** Object:  StoredProcedure [dbo].[spUpdateStocks]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUpdateStocks]
 @ProductCode varchar (50),
 @Quantity int,
 @Box decimal (3,2)
 as
 update products 
 set Quantity = Quantity + @Quantity, Box = Box + @Box
 WHERE products.ProductCode = @ProductCode

GO
/****** Object:  StoredProcedure [dbo].[spUpdateUser]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spUpdateUser]
@UserId int,
@Username varchar (20),
@UserPass varchar (20),
@Usertype varchar (50),
@UserFname varchar (20),
@UserLname varchar (20),
@UserEmail varchar (50),
@UserStatus varchar (20), 
@SecQuest varchar (max),
@SecAns varchar (max),
@Date datetime
as
update UserAccounts
set Username=@Username, UserPass=@UserPass, Usertype=@Usertype, UserFname=@UserFname, UserLname=@UserLname, UserEmail=@UserEmail,
UserStatus=@UserStatus, SecQuest=@SecQuest, SecAns=@SecAns, Date=@Date
from UserAccounts
where UserId=@UserId;
GO
/****** Object:  StoredProcedure [dbo].[spViewCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewCart]
as
select * from AddToCart

GO
/****** Object:  StoredProcedure [dbo].[spViewCustomer]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewCustomer]
as
select * from Customers

GO
/****** Object:  StoredProcedure [dbo].[spViewDelCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewDelCart]
as
select * from DeliveryCart

--------
GO
/****** Object:  StoredProcedure [dbo].[spViewProducts]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewProducts]
as
select * from products

---------------
GO
/****** Object:  StoredProcedure [dbo].[spViewResCart]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewResCart]
as
select * from ReservationCart

-----------------------
GO
/****** Object:  StoredProcedure [dbo].[spViewSalesReports]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewSalesReports]
as
select SalesReportID, products.productCode, products.ProductName, products.ProductCategory, products.ProductPrice, OrderQuantity, SalesReports.TotalAmount, products.ProductDescription, Customers.CustomerName, Customers.CustomerAddress, customers.CustomerID, UserAccounts.Username, UserAccounts.UserID, SalesReports.Date
from SalesReports inner join products on SalesReports.productCode = products.productCode inner join UserAccounts on SalesReports.UserID = UserAccounts.UserID
inner join customers on SalesReports.CustomerID = customers.CustomerID 
 
GO
/****** Object:  StoredProcedure [dbo].[spViewUser]    Script Date: 10/14/2019 10:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spViewUser]
as
select * from UserAccounts

GO
USE [master]
GO
ALTER DATABASE [LactoBiotics] SET  READ_WRITE 
GO
