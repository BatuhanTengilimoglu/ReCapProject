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