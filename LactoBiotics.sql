Create database LactoBiotics

drop database LactoBiotics

use LactoBiotics




-----------------------------------------------------------------------------------------------------
------- User_Accounts -------
drop table UserAccounts

Create table UserAccounts
(
UserId int primary key identity (1,1),
Username varchar (20) unique not null,
UserPass varchar (20)not null,
Usertype varchar (50)not null,
UserFname varchar (20)not null,
UserLname varchar (20)not null,
UserEmail varchar (50)not null,
UserStatus varchar (20)not null,
SecQuest varchar (max)not null,
SecAns varchar (max)not null,
Date datetime
)

select * from UserAccounts

insert into UserAccounts values ('admin', 'admin', 'Administrator', 'earl', 'cejas', 'lykearl@gmail.com', 'Active', 'What is the name of your pet?', 'earl', '05/09/2019')

-------------------------------------------------------------------------------------------------------

drop procedure spLogin

create procedure spLogin
@Username varchar (max),
@UserPass varchar (max)
as
select * from UserAccounts where Username = @Username and UserPass = @UserPass return

-------------------------------------------------------------------------------------------------------

drop procedure spAddUser

create procedure spAddUser
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

-------------------------------------------------------------------------------------------------------

drop procedure spUpdateUser

create proc spUpdateUser
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

---------------------------------------------------------------------------------------------------------------

drop procedure spDeleteUser

create procedure spDeleteUser
@UserId int
as
delete from UserAccounts
where UserId = @UserId return

---------------------------------------------------------------------------------------------------------------

drop procedure spSearchUser

create procedure spSearchUser
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

---------------------------------------------------------------------------------------------------------------

drop procedure spViewUser

create procedure spViewUser
as
select * from UserAccounts

---------------------------------------------------------------------------------------------------------------



----------------------------------------------------------------------------------------------------------------
------Customer-----

drop table Customers

create table Customers
(
CustomerId int primary key identity (1,1),
CustomerName varchar (50),
Tin varchar (50),
CustomerAddress varchar(50),
BusinessStyle varchar (50),
ContactNo varchar (20),
CustomerType varchar (50),
UserId int foreign key references UserAccounts(UserId),
Date datetime
)

---------------------------------------------------------------------------------------------------------------

drop procedure spAddCustomer

create procedure spAddCustomer
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

-----------------------------------------------------------------------------------------------------------

drop procedure spUpdateCustomer

create procedure spUpdateCustomer
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

---------------------------------------------------------------------------------------------------------------

drop procedure spRemoveCustomer

create procedure spRemoveCustomer
@CustomerId int
as
delete from Customers
where CustomerId = @CustomerId return

---------------------------------------------------------------------------------------------------------------

drop procedure spSearchCustomer

create procedure spSearchCustomer
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

---------------------------------------------------------------------------------------------------------------

drop procedure spViewCustomer

create procedure spViewCustomer
as
select * from Customers

---------------------------------------------------------------------------------------------------------------

 


 
----------------------------------------------------------------------------------------------------------------
---------Products-----------

drop table Products

create table Products
(
ProductID int identity (1,1),
ProductCode varchar (50) primary key,
ProductName varchar (50),
ProductCategory varchar (50),
ProductPrice decimal (10,2),
Quantity int,
QuantityPerBox int,
Box decimal (7,2),	
ProductDescription varchar (max),
UserId int foreign key references UserAccounts(UserId),
Date datetime
)

----------------------------------------------------------------------------------------------------------------------

drop procedure spAddProducts

create procedure spAddProducts
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

----------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateProducts

create procedure spUpdateProducts
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

-----------------------------------------------------------------------------------------------------------------------

drop procedure spRemoveProducts

create procedure spRemoveProducts
@ProductCode varchar (50)
as
delete from Products
where ProductCode = @ProductCode  return

-----------------------------------------------------------------------------------------------------------------------

drop procedure spViewProducts

create procedure spViewProducts
as
select * from products

-----------------------------------------------------------------------------------------------------------------------

drop procedure spSearchProducts

create procedure spSearchProducts
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

------------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateProduct

create procedure spUpdateProduct
 @ProductCode varchar (50),
 @Quantity int,
 @Box decimal (7,2)
 as
 update products 
 set Quantity = Quantity - @Quantity , Box = Box - @Box
 WHERE products.ProductCode = @ProductCode

-------------------------------------------------------------------------------------------------------------------

drop procedure spCancelOrder

create procedure spCancelOrder
@quantityToRevert int,
@product_Code varchar(max),
@Box decimal (7,2)
as
update Products
set Quantity = Quantity + @quantityToRevert, Box = Box + @Box 
where products.productCode = @product_Code

--------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateStocks

create procedure spUpdateStocks
 @ProductCode varchar (50),
 @Quantity int,
 @Box decimal (3,2)
 as
 update products 
 set Quantity = Quantity + @Quantity, Box = Box + @Box
 WHERE products.ProductCode = @ProductCode

-------------------------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------------------------
---------- Reservation ----------

drop table ProductsReservation

create table ProductsReservation
(
ReservationID int primary key identity (1,1),
ProductCode varchar (50) foreign key references products(ProductCode),
OrderQuantity int,
TotalPrice decimal,
ClaimDate datetime,
ReservationStatus varchar (50),
CustomerID int foreign key references customers(CustomerID),
UserID int foreign key references UserAccounts(UserID),
Date datetime
)

---------------------------------------------------------------------------------------------------------------------

drop procedure spAddReservation

create procedure spAddReservation
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

---------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateReservation

create procedure spUpdateReservation
@ReservationID int,
@ReservationStatus varchar(50)
as
update ProductsReservation
set ReservationStatus = @ReservationStatus
where ReservationId = @ReservationId

----------------------------------------------------------------------------------------------------------------------

drop procedure spSelectReservation

create procedure spSelectReservation
as
select ReservationId, products.ProductCode, products.ProductName, ProductsReservation.OrderQuantity, ProductsReservation.totalPrice, ProductsReservation.ClaimDate, ProductsReservation.ReservationStatus, 
customers.CustomerName, customers.CustomerAddress, customers.CustomerID, UserAccounts.Username, UserAccounts.UserID, ProductsReservation.Date
from ProductsReservation inner join products on ProductsReservation.ProductCode = products.ProductCode inner join customers on ProductsReservation.CustomerID = customers.CustomerID inner join UserAccounts on ProductsReservation.UserID = UserAccounts.UserID

----------------------------------------------------------------------------------------------------------------------

drop procedure spSearchReservation

create procedure spSearchReservation
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

----------------------------------------------------------------------------------------------------------------------




----------------------------------------------------------------------------------------------------------------------
------------- Delivery ---------------


drop table ProductsDelivery

create table ProductsDelivery
(
DeliveryId int primary key identity (1,1),
ProductCode varchar (50) foreign key references products(ProductCode),
OrderQuantity int,
TotalPrice decimal,
DeliveryDate datetime,
DeliveryStatus varchar (50),
CustomerID int foreign key references customers(CustomerID),
UserID int foreign key references UserAccounts(UserID),
Date datetime
)

---------------------------------------------------------------------------------------------------------------------

drop procedure spAddDelivery

create procedure spAddDelivery
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

---------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateDelivery

create procedure spUpdateDelivery
@DeliveryId int,
@DeliveryStatus varchar(50)
as
update ProductsDelivery
set DeliveryStatus = @DeliveryStatus
where DeliveryId = @DeliveryId

----------------------------------------------------------------------------------------------------------------------

drop procedure spSelectDelivery

create procedure spSelectDelivery
as
select DeliveryId, products.ProductCode, products.ProductName, ProductsDelivery.OrderQuantity, ProductsDelivery.TotalPrice, ProductsDelivery.DeliveryDate, ProductsDelivery.DeliveryStatus, 
customers.CustomerName, Customers.CustomerAddress, customers.CustomerID, UserAccounts.Username, UserAccounts.UserId, ProductsDelivery.Date
from ProductsDelivery inner join products on ProductsDelivery.ProductCode = products.productCode inner join customers on ProductsDelivery.CustomerID = customers.CustomerID inner join UserAccounts on ProductsDelivery.UserID = UserAccounts.UserID

----------------------------------------------------------------------------------------------------------------------

drop procedure spSearchDelivery

Create procedure spSearchDelivery
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

---------------------------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------------------------
---------- inventory reports --------

drop table ProductsInventory

create table ProductsInventory
(
InventoryId int primary key identity (1,1),
ProductCode varchar (50) foreign key references Products(ProductCode),
Balance int,
StocksIn int,
StocksOut int,
Box Decimal,
Date datetime
)

------------------------------------------------------------------------------------------------------------------

drop procedure spAddInventory

create procedure spAddInventory
@ProductCode varchar (50),
@Balance int,
@StocksIn int,
@StocksOut int,
@Box decimal,
@Date datetime
as
insert into ProductsInventory
values (@ProductCode, @Balance, @StocksIn, @StocksOut, @Box, @Date)

------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateInventory

create procedure spUpdateInventory
@ProductCode varchar (50),
@StocksOut int
as
update ProductsInventory
Set StocksOut = StocksOut + @StocksOut
where ProductsInventory.ProductCode = @ProductCode

------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateProductInventory

create procedure spUpdateProductInventory
@ProductCode varchar (50),
@StocksIn int
as
update ProductsInventory
Set StocksIn = StocksIn + @StocksIn
where ProductsInventory.ProductCode = @ProductCode

------------------------------------------------------------------------------------------------------------------

drop procedure spUpdateProInventory

create procedure spUpdateProInventory
@ProductCode varchar (50),
@StocksIn int,
@StocksOut int
as
update ProductsInventory
Set StocksIn = StocksIn + @StocksIn, StocksOut = StocksOut - @StocksOut
where ProductsInventory.ProductCode = @ProductCode

------------------------------------------------------------------------------------------------------------------

drop procedure spSelectInventory

create procedure spSelectInventory
as
select InventoryID, products.ProductCode, Products.ProductName, productsInventory.Balance, StocksIn, StocksOut, ProductsInventory.Box, ProductsInventory.Date
from ProductsInventory inner join products on ProductsInventory.ProductCode = products.ProductCode
 
------------------------------------------------------------------------------------------------------------------

drop procedure spDeleteProInventory

create procedure spDeleteProInventory
@ProductCode varchar (50)
as
delete from ProductsInventory 
where ProductCode = @ProductCode

------------------------------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------------------------------
--------------- Sales Reports -------------------

drop table SalesReports

create table SalesReports
(
SalesReportID int primary key identity (1,1),
ProductCode varchar (50) foreign key references products(ProductCode),
OrderQuantity int,
TotalAmount decimal (10,2),
CustomerID int foreign key references customers(CustomerID),
UserID int foreign key references UserAccounts(UserID),
Date datetime
)

-------------------------------------------------------------------------------------------------------------------


drop procedure spAddSalesReports

create procedure spAddSalesReports
@ProductCode varchar(50),
@OrderQuantity int,
@TotalAmount decimal (10,2),
@CustomerID int,
@UserID int,
@Date datetime
as
insert into SalesReports
values(@ProductCode, @OrderQuantity, @TotalAmount, @CustomerID, @UserID, @Date)

---------------------------------------------------------------------------------------------------------------------

drop procedure spViewSalesReports

create procedure spViewSalesReports
as
select SalesReportID, products.productCode, products.ProductName, products.ProductCategory, products.ProductPrice, OrderQuantity, SalesReports.TotalAmount, products.ProductDescription, Customers.CustomerName, Customers.CustomerAddress, customers.CustomerID, UserAccounts.Username, UserAccounts.UserID, SalesReports.Date
from SalesReports inner join products on SalesReports.productCode = products.productCode inner join UserAccounts on SalesReports.UserID = UserAccounts.UserID
inner join customers on SalesReports.CustomerID = customers.CustomerID 
 
---------------------------------------------------------------------------------------------------------------------

drop procedure spSearchSalesReports

create procedure spSearchSalesReports
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

---------------------------------------------------------------------------------------------------------------------

drop table AddToCart

create table AddToCart
(
ProductCode varchar (50) foreign key references products(ProductCode),
ProductName varchar (50),
ProductPrice decimal (10,2),
OrderQuantity int,
TotalAmount decimal (10,2),
CustomerName varchar (50),
CustomerAddress Varchar (50),
CustomerTin varchar (50),
Date datetime,
CustomerID int ,
UserID int,
StockOnHand int,
QuantityPerBox int,
AvailableBox decimal (7,2),
OrderID int identity (1,1) primary key
)

---------------------------------------------------------------------------------------------------------------------

drop procedure spAddCart

create procedure spAddCart
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

---------------------------------------------------------------------------------------------------------------------

drop procedure spDeleteCart

create procedure spDeleteCart
@OrderID int
as
delete from AddToCart
where OrderID = @OrderID

---------------------------------------------------------------------------------------------------------------------

drop procedure spViewCart

create procedure spViewCart
as
select * from AddToCart

---------------------------------------------------------------------------------------------------------------------

drop table DeliveryCart

create table DeliveryCart
(
ProductCode varchar (50) foreign key references products(ProductCode),
ProductName varchar (50),
ProductPrice decimal (10,2),
OrderQuantity int,
TotalAmount decimal (10,2),
CustomerName varchar (50),
CustomerAddress Varchar (50),
CustomerTin varchar (50),
DeliveryDate datetime,
date datetime,
CustomerID int ,
UserID int,
DeliveryStatus Varchar(50),
StockOnHand int,
QuantityPerBox int,
AvailableBox decimal (7,2),
OrderID int identity (1,1) primary key
)

---------------------------------------------------------------------------------------------------------------------

drop procedure spAddDelCart

create procedure spAddDelCart
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

---------------------------------------------------------------------------------------------------------------------

drop procedure spDeleteDelCart

create procedure spDeleteDelCart
@OrderID int
as
delete from DeliveryCart
where OrderID = @OrderID

---------------------------------------------------------------------------------------------------------------------

drop procedure spViewDelCart

create procedure spViewDelCart
as
select * from DeliveryCart

---------------------------------------------------------------------------------------------------------------------

drop table ReservationCart

create table ReservationCart
(
ProductCode varchar (50) foreign key references products(ProductCode),
ProductName varchar (50),
ProductPrice decimal (10,2),
OrderQuantity int,
TotalAmount decimal (10,2),
CustomerName varchar (50),
CustomerAddress Varchar (50),
CustomerTin varchar (50),
ClaimDate datetime,
date datetime,
CustomerID int ,
UserID int,
ReservationStatus varchar (50),
StockOnHand int,
QuantityPerBox int,
AvailableBox decimal (7,2),
OrderID int identity (1,1) Primary key
)

---------------------------------------------------------------------------------------------------------------------

drop procedure spAddResCart

create procedure spAddResCart
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

---------------------------------------------------------------------------------------------------------------------

drop procedure spDeleteResCart

create procedure spDeleteResCart
@OrderID int
as
delete from ReservationCart
where OrderID = @OrderID

---------------------------------------------------------------------------------------------------------------------

drop procedure spViewResCart

create procedure spViewResCart
as
select * from ReservationCart

---------------------------------------------------------------------------------------------------------------------





























----------------------------------------------------------------------------------------------------------------------
------------ generate product code ------------

drop procedure spGenerateSoapProCode

create procedure spGenerateSoapProCode
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID

----------------------------------------------

drop procedure spGenerateHerbalProCode

create procedure spGenerateHerbalProCode
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID

----------------------------------------------

drop procedure spGenerateDogFoodProCode

create procedure spGenerateDogFoodProCode
as
declare @productID int
select @productID = IDENT_CURRENT('products')
return @productID
---------------------------------------------------------------------------------------------------------------------




































































----------------------------------------------------------------------------------------------------------------
------------------- Stocks --------------------

drop table stocks

create table stocks
(
stocks_id int primary key identity (1,1),
productID int foreign key references products(productID),
stock_in int,
users_id int foreign key references user_acc(users_id),
stock_in_date datetime
)

-----------------------------------------------------------------------------------------------------------------

drop procedure sp_add_stocks

create procedure sp_add_stocks
@productID int,
@stock_in int,
@users_id int,
@stock_in_date datetime
as
insert into stocks
values (@productID, @stock_in, @users_id, @stock_in_date)

-----------------------------------------------------------------------------------------------------------------

drop procedure sp_update_stocks

create procedure sp_update_stocks
@stocks_id int,
@productID int,
@stock_in int,
@stock_in_date datetime
as
update stocks
set  productID = @productID, stock_in = @stock_in, stock_in_date = @stock_in_date
where stocks_id = @stocks_id

------------------------------------------------------------------------------------------------------------------

drop procedure sp_delete_stocks

create procedure sp_delete_stocks
@stocks_id int
as
delete from stocks
where stocks_id = @stocks_id

------------------------------------------------------------------------------------------------------------------

drop procedure sp_search_stocks

create procedure sp_search_stocks
@key varchar (max)
as
select * from stocks
where stocks_id like '%' + @key + '%' or
      productId like '%' + @key + '%' or
	  stock_in like '%' + @key + '%' or
	  users_id like '%' + @key + '%' or
	  stock_in_date like '%' + @key + '%'

------------------------------------------------------------------------------------------------------------------

drop procedure sp_update_stocks_pro

create procedure sp_update_stocks_pro
 @productID int,
 @stock_in int
 as
 update stocks 
 set stock_in = stock_in - @stock_in
 WHERE stocks.productID = @productID

-------------------------------------------------------------------------------------------------------------------

drop procedure sp_cancel_order

create procedure sp_cancel_order
@quantityToRevert int,
@product_ID varchar(max)
as
update stocks
set stock_in = stock_in + @quantityToRevert 
where productID = @product_ID

--------------------------------------------------------------------------------------------------------------------

drop procedure sp_view_stocks

create procedure sp_view_stocks
as
select stocks_id, stocks.productID,  products.product_code, products.product_name, products.product_category, products.product_price, stocks.stock_in, products.product_description
from stocks inner join products on stocks.productID = products.productID
 
------------------------------------------------------------------------------------------------------------------
