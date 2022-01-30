--1) DDLOrnekler adýnda yeni bir database oluþturalým (DDL komutlarý ile)
CREATE DATABASE DDLOrnekler

--2) DDLOrnekler database'inin içine Haber, HaberYorum adýnda 2 adet tablo oluþturalým (DDL komutlarý ile)
--Haber: Id, Baslik, Ozet, Detay
--HaberYorum: Id, HaberId, Yorum

USE DDLOrnekler

CREATE TABLE Haber
(
	Id INT Identity(1,1) NOT NULL PRIMARY KEY,
	Baslik NVARCHAR(200) NULL,
	Ozet NVARCHAR(500) NULL,
	Detay NVARCHAR(4000) NULL
)

CREATE TABLE HaberYorum
(
	Id INT Identity(1,1) NOT NULL PRIMARY KEY,
	HaberId INT NOT NULL,
	Yorum NVARCHAR(1000) 
)

--3) Haber tablosuna YayýndaMi alaný ekleyelim
ALTER TABLE Haber ADD YayindaMi BIT

--4) HaberYorum tablosundaki Yorum sütununun boyutunu 3000 yapalým.
ALTER TABLE HaberYorum ALTER COLUMN Yorum NVARCHAR(3000)

--5) Haber tablosundaki YayindaMi sütununu silelim
ALTER TABLE Haber DROP COLUMN YayindaMi

--6) HaberYorum tablosunu silelim
DROP TABLE HaberYorum

--7) DDLOrnekler database'ini silelim
USE DBIntro
DROP DATABASE DDLOrnekler

--8) Bir tane satýn alma süreç yönetimi projesi için db oluþturalým
--Ýçerisinde: Member, PurchaseOrder ve Invoce tablolarý olsun
--Member: Id, NameSurname 
--PurchaseOrder: Id, MemberId, Price, IsApproved
--Invoice: Id, MemberId, PurchaseOrderId, IsPayed 

CREATE DATABASE SatinAlmaSurecYonetimi
USE SatinAlmaSurecYonetimi

CREATE TABLE Member
(
	Id INT Identity(1,1) NOT NULL PRIMARY KEY,
	NameSurname NVARCHAR(200) NOT NULL
)

CREATE TABLE PurchaseOrder
(
	Id INT Identity(1,1) NOT NULL PRIMARY KEY,
	MemberId INT NOT NULL,
	Price MONEY NOT NULL,
	IsApproved BIT NOT NULL
)

CREATE TABLE Invoice
(
	Id INT Identity(1,1) NOT NULL PRIMARY KEY,
	MemberId INT NOT NULL,
	PurchaseOrderId INT NOT NULL,
	IsPayed BIT NOT NULL
)


--9) Ödev: Kurs otomasyon sistemi database'i oluþturalým
--Ders Tablosu: Id, LessonName, CreatedDate
--Ogrenci Tablosu: Id, NameSurname, LessonId, Age, CompanySchool, Class, CreatedDate
--Ogretmen Tablosu: Id, NameSurname, LessonId, CreatedDate
--Yoklama Tablosu: Id, OgrenciId, LessonId, CreatedDate

--Ýlk olarak bütün süreci designer üzerinden oluþturacak þekilde tasarlayalým
--Ýkinci olarak DDL kodlarý ile oluþturacak þekilde tasarlayalým.