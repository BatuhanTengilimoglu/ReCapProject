﻿--[CarId] int IDENTITY(1,1) PRIMARY KEY bölümünde IDENTITY(1,1) yazılmasının sebebi her eklenilen kolon için farklı
--bir id oluşturmak için PRIMARY KEY ise onun tanımladığı ve tekrar edilememesini sağladı
--FOREIGN KEY ise BrandId ve ColorId nin başka bir tablodan geldiğini ve başka tablonun PRIMARY KEY i olduğunu belirtti
--REFERENCES ise nereyi referans aldığımızı belirtmek için kullandık
--kısacası cars tablosunda bulundan BrandId ve ColorId aynı zamanda başka tablodan aldığımızı ve onu referans olarak
--kullanmayı yazdık

--Tablo yaratmak için kulllanıldı

CREATE TABLE Cars
(	
	[CarId] int IDENTITY(1,1) PRIMARY KEY,
	[BrandId] int FOREIGN KEY(BrandId) REFERENCES Brands(BrandId),
	[ColorId] int FOREIGN KEY(ColorId) REFERENCES Colors(ColorId),
	[ModelYear] VARCHAR(50),
	[DailyPrice] decimal,
	[Description] VARCHAR(50) 
)

--Yaratılan kolona bilgileri eklemek için kullanıldı

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Description)
VALUES
(1,1,'2003',150,'Ekonomik Araba'),
(2,1,'2008',150,'Normal Araba'),
(2,2,'2010',150,'İyi Araba'),
(3,3,'2016',150,'Güzel Araba'),
(4,2,'2020',150,'Çok Güzel Araba')

--Tablo yaratmak için kulllanıldı

CREATE TABLE Brands 
(
	[BrandId] int IDENTITY(1,1) PRIMARY KEY,
	[BrandName] VARCHAR(50) UNIQUE
)
INSERT INTO Brands(BrandName)
VALUES 
('AUDI'),
('BMW'),
('MERCEDES'),
('FORD')

--Tablo yaratmak için kulllanıldı

CREATE TABLE Colors
(
	[ColorId] int IDENTITY(1,1) PRIMARY KEY,
	[ColorName] VARCHAR(50) UNIQUE
)
--Yaratılan kolona bilgileri eklemek için kullanıldı
INSERT INTO Colors(ColorName)
Values 
('Siyah'),
('Beyaz'),
('Gri'),
('Kırmızı'),
('Mavi')

--Tabloları kaldırmak için kullanıldı

DROP TABLE Colors
DROP TABLE Brands
DROP TABLE cars

--Tablo seçmek için kullanıldı

select * from Cars

CREATE TABLE Users
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[FirstName] NVARCHAR(50) not null,
	[LastName] NVARCHAR (50) not null,
	[Email] NVARCHAR(100) UNIQUE not null,
	[Password] NVARCHAR(50) not null,
)

CREATE TABLE Customers
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[UserId] int FOREIGN KEY REFERENCES Users(Id),
	[CompanyName] VARCHAR(100) ,
	
)

insert into Customers(UserId,CompanyName)
Values 
(3,'Oğuzhan Otomotiv')

select * from Customers
SET DATEFORMAT DMY;
UPDATE Customers
SET CompanyName='Güneş otomotiv'
WHERE Id=3;



select * from Users
alter table Users
CREATE TABLE Rentals
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[CarId] int FOREIGN KEY REFERENCES Cars(CarId) not null,
	[CustomerId] int FOREIGN KEY REFERENCES Customers(Id) not null,
	[RentDate] date not null,
	[ReturnDate] date
	)


select * from rentals

insert into Rentals(CarId,CustomerId,RentDate,ReturnDate)
Values 
(3,3,'05/02/2021',null)

select * from rentals

CREATE TABLE CarImages
(
    [Id] int IDENTITY(1,1) PRIMARY KEY,
	[CarId] int FOREIGN KEY(CarId) REFERENCES Cars(CarId),
	[ImagePath] VARCHAR(MAX),
	[Date] Date,

)
