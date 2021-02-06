CREATE TABLE Cars
(	
	[CarId] int IDENTITY(1,1) PRIMARY KEY,
	[BrandId] int FOREIGN KEY(BrandId) REFERENCES Brands(BrandId),
	[ColorId] int FOREIGN KEY(ColorId) REFERENCES Colors(ColorId),
	[ModelYear] VARCHAR(50),
	[DailyPrice] decimal,
	[Description] VARCHAR(50) 
)
insert into Cars(BrandId,ColorId,ModelYear,DailyPrice,Description)
values
(1,1,'2003',150,'Ekonomik Araba'),
(2,1,'2008',150,'Normal Araba'),
(2,2,'2010',150,'İyi Araba'),
(3,3,'2016',150,'Güzel Araba'),
(4,2,'2020',150,'Çok Güzel Araba')

CREATE TABLE Brands 
(
	[BrandId] int IDENTITY(1,1) PRIMARY KEY,
	[BrandName] VARCHAR(50) UNIQUE
)
insert into Brands(BrandName)
Values 
('AUDI'),
('BMW'),
('MERCEDES'),
('FORD')

CREATE TABLE Colors
(
	[ColorId] int IDENTITY(1,1) PRIMARY KEY,
	[ColorName] VARCHAR(50) UNIQUE
)
insert into Colors(ColorName)
Values 
('Siyah'),
('Beyaz'),
('Gri'),
('Kırmızı'),
('Mavi')

DROP TABLE Colors
drop table Brands
drop table cars
select * from Cars

