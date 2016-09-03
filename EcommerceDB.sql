create database EcommerceDB
go
use EcommerceDB
go
create table Category(
	CategoryID int identity(1,1) primary key,
	CategoryName varchar(30)
)
go
create table Manufacturer(
	ManufacturerID int identity(1,1) primary key,
	ManufacturerName varchar(30)
)
go
create table Product(
	ProductID int identity(1,1) primary key,
	CategoryID int foreign key references Category(CategoryID),
	ManufacturerID int foreign key references Manufacturer(ManufacturerID),
	ProductName varchar(100),
	BasisPrice int,
	SellingPrice int,
	CreatedAt datetime
)
go
create table ProductDetail(
	ID int identity(1,1) primary key,
	ProductID int foreign key references Product(ProductID),
	Screen varchar(20),
	OS varchar(10),
	FrontCamera int,
	RearCamera int,
	CPU varchar(30),
	RAM varchar(30),
	MemoryCard varchar(10),
	SIMCard varchar(10),
	Connection varchar(10),
	Battery varchar(10),
	InternalStorage varchar(10),
	[Weight] int
)
go
create table ProductColor(
	ID int identity(1,1) primary key,
	ProductID int foreign key references Product(ProductID),
	ColoName varchar(10),
	QuantityInStock int
)
go
create table ProductImage(
	ImageID int identity(1,1) primary key,
	ProductID int foreign key references Product(ProductID),
	ImagePath varchar(100)
)
go
create table [User](
	UserID int identity(1,1) primary key,
	UserName varchar(20),
	[Password] varchar(200),
	Email varchar(20),
	Phone varchar(20),
	[Role] int
)
go
create table [Order](
	OrderID int identity(1,1) primary key,
	UserID int foreign key references [User](UserID),
	FullName varchar(50),
	ShippingAddress varchar(100),
	Total int,
	PaymentMethod varchar(50),
	CreatedDate datetime
)
go
create table OrderDetail(
	ItemID int identity(1,1) primary key,
	OrderID int foreign key references [Order](OrderID),
	ProductID int foreign key references Product(ProductID),
	Quantity int,
	UnitPrice int,
	TotalUnit int
)
select * from [Order]