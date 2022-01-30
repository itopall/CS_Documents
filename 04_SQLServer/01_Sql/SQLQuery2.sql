--DDLOrnekler adýnda yeni bir database oluþturalým (DDL Komutlarý ile)

CREATE DATABASE DDLOrnekler

--2) DDLOrnkeler database'inin içine Haber, HaberYorum adýnda 2 adet tablo oluþturalým(DDL komutlarý ile)
--Haber: Id, Baþlýk , Özet, Detay
--HaberYorum: Id,HaberId, Yorum
USE DDLOrnekler

CREATE TABLE Haber
(
	Id INT  Not NULL ,
	Baslýk NVARCHAR(200) NULL,
	Ozet NVARCHAR(200),
	Detay NVARCHAR(200)
)
CREATE TABLE HaberYorum
(
	Id INT  Not NULL ,
	HaberId INT Not NULL,
	Yorum NVARCHAR(200)
	
)

--3) Haber tablosuna YayindaMi alaný ekleyelim 
ALTER TABLE Haber ADD YayindaMi BIT

--4) HaberYorum Tablosundaki yorum sütunun boyutunu 3000 yapma 

ALTER TABLE HaberYorum ALTER COLUMN Yorum NVARCHAR(3000)

--5) Haber tablosundaki YayindaMi Sütununu Silelim
ALTER TABLE Haber DROP COLUMN YayindaMi

--6) HaberYorum tablosunu silelim 

Drop Table HaberYorum

--7) DDLOrnekler db'sini silelim
Drop DATABASE DDLOrnekler

--8) Bir tane satýn alma süreç yönetimi projesi için db oluþturalým 
--Ýçerisinde Member, PurchaseOrder ve Invoice tablolarý olsun
--Member: Id,NameSurname
--PurchaseOrder: Id,MemberId,Price, IsApproved
--Invoice: Id, MemberId,PurchaseOrderId,IsPayed

CREATE DATABASE SatinIs

Use SatinIs

CREATE TABLE Member
(
	Id INT identity Not NULL PRIMARY KEY,
	NameSurname NVARCHAR(200) NULL,
)
CREATE TABLE PurchaseOrder
(
	Id INT identity Not NULL PRIMARY KEY,
	MemberId INT Not NULL,
	Price Money not NULL,
	IsApproved BIT not null
)
CREATE TABLE Invoice
(
	Id INT identity(1,1) Not NULL PRIMARY KEY,
	MemberId INT Not NULL,
	PurchaseOrderId INT Not NULL,
	IsPayed BIT not null
)
--9) Kurs otomasyon sistemi database'i oluþturalým
--Ders Tablosu: Id, LessonName, CreatedDate
--Ogrenci Tablosu: Id, NameSurname, LessonId, Age, CompanySchool, Class, CreatedDate
--Ogretmen Tablosu: Id, NameSurname, LessonId, CreatedDate
--Yoklama Tablosu: Id, OgrenciId, LessonId, CreatedDate

--Ýlk olarak bütün süreci designer üzerinden oluþturacak þekilde tasarlayalým
--Ýkinci olarak DDL kodlarý ile oluþturacak þekilde tasarlayalým.