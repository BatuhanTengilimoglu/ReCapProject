![Never gonna give you up](https://edm.com/.image/t_share/MTc0NjYyNjI0ODg4MjM1Mzg2/science-of-earworms-explain-why-never-gonna-give-you-up-is-stuck-in-our-heads-30-years-later.png)

# Aşağıda query de yazdığım komutları da paylaştım umarım anlaşılır yazabilmişimdir


## SQL QUERY
 
**[CarId] int IDENTITY(1,1) PRIMARY KEY bölümünde IDENTITY(1,1) yazılmasının sebebi her eklenilen kolon için farklı
bir id oluşturmak için PRIMARY KEY ise onun tanımladığı ve tekrar edilememesini sağladı
FOREIGN KEY ise BrandId ve ColorId nin başka bir tablodan geldiğini ve başka tablonun PRIMARY KEY i olduğunu belirtti
REFERENCES ise nereyi referans aldığımızı belirtmek için kullandık
kısacası cars tablosunda bulundan BrandId ve ColorId aynı zamanda başka tablodan aldığımızı ve onu referans olarak
kullanmayı yazdık**


**Tablo yaratmak için kulllanıldı**
```sql
  CREATE TABLE Cars
(
  
	[CarId] int IDENTITY(1,1) PRIMARY KEY,
  
	[BrandId] int FOREIGN KEY(BrandId) REFERENCES Brands(BrandId),
  
	[ColorId] int FOREIGN KEY(ColorId) REFERENCES Colors(ColorId),
  
	[ModelYear] VARCHAR(50),
  
	[DailyPrice] decimal,
  
	[Description] VARCHAR(50) 
  
)
```
**Yaratılan kolona bilgileri eklemek için kullanıldı**
```sql
INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Description)
VALUES
(1,1,'2003',150,'Ekonomik Araba'),
(2,1,'2008',150,'Normal Araba'),
(2,2,'2010',150,'İyi Araba'),
(3,3,'2016',150,'Güzel Araba'),
(4,2,'2020',150,'Çok Güzel Araba')
```
**Cars Tablosu yaratmak için kulllanıldı**
```sql
CREATE TABLE Brands 
(
	[BrandId] int IDENTITY(1,1) PRIMARY KEY,
	[BrandName] VARCHAR(50) UNIQUE
)
```
**Yaratılan kolona bilgileri eklemek için kullanıldı**
```sql
INSERT INTO Brands(BrandName)

VALUES 
('AUDI'),
('BMW'),
('MERCEDES'),
('FORD')
```
**Colors Tablosu yaratmak için kulllanıldı**
```sql
CREATE TABLE Colors
(
	[ColorId] int IDENTITY(1,1) PRIMARY KEY,
	[ColorName] VARCHAR(50) UNIQUE
)
```
**Yaratılan kolona bilgileri eklemek için kullanıldı**
```sql
INSERT INTO Colors(ColorName)
VALUES
('Siyah'),
('Beyaz'),
('Gri'),
('Kırmızı'),
('Mavi')
```
**Tabloları kaldırmak için kullanıldı**
```sql
DROP TABLE Colors
DROP TABLE Brands
DROP TABLE cars
```
**Tablo seçmek için kullanıldı**
```sql
select * from Cars
```
