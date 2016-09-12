create database EcommerceDB
go
use EcommerceDB
go
create table Category(
	CategoryID int identity(1,1) primary key,
	CategoryName varchar(30)
)
go
insert into Category values('Smartphone')
insert into Category values('Tablet')
insert into Category values('Laptop')
go
create table Manufacturer(
	ManufacturerID int identity(1,1) primary key,
	ManufacturerName varchar(30)
)
go
insert into Manufacturer values('Apple')
insert into Manufacturer values('Samsung')
insert into Manufacturer values('Sony')
insert into Manufacturer values('HTC')
insert into Manufacturer values('Asus')
insert into Manufacturer values('LG')
insert into Manufacturer values('Pantech')
insert into Manufacturer values('Dell')
insert into Manufacturer values('HP-Compaq')
insert into Manufacturer values('Acer')
go
select * from Manufacturer
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
	Screen varchar(100),
	OS varchar(50),
	FrontCamera int,
	RearCamera int,
	CPU varchar(100),
	RAM varchar(30),
	MemoryCard varchar(50),
	SIMCard varchar(50),
	Connection varchar(50),
	Battery varchar(50),
	InternalStorage varchar(50),
	[Weight] int
)
go
create table ProductColor(
	ID int identity(1,1) primary key,
	ProductID int foreign key references Product(ProductID),
	ColorName varchar(50),
	QuantityInStock int
)
go
create table ProductImage(
	ImageID int identity(1,1) primary key,
	ProductID int foreign key references Product(ProductID),
	ImagePath varchar(200)
)
go
create table [User](
	UserID int identity(1,1) primary key,
	UserName varchar(20),
	[Password] varchar(200),
	Email varchar(50),
	[Role] int
)
go
create table Comment(
	CommentID int identity(1,1) primary key,
	UserID int foreign key references [User](UserID),
	ProductID int foreign key references Product(ProductID),
	Comment varchar(1000),
	CreatedDate datetime
) 
create table [Order](
	OrderID int identity(1,1) primary key,
	FullName varchar(50),
	Phone varchar(20),
	Email varchar(50),
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
select * from [User]