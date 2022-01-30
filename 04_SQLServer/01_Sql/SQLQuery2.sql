--DDLOrnekler ad�nda yeni bir database olu�tural�m (DDL Komutlar� ile)

CREATE DATABASE DDLOrnekler

--2) DDLOrnkeler database'inin i�ine Haber, HaberYorum ad�nda 2 adet tablo olu�tural�m(DDL komutlar� ile)
--Haber: Id, Ba�l�k , �zet, Detay
--HaberYorum: Id,HaberId, Yorum
USE DDLOrnekler

CREATE TABLE Haber
(
	Id INT  Not NULL ,
	Basl�k NVARCHAR(200) NULL,
	Ozet NVARCHAR(200),
	Detay NVARCHAR(200)
)
CREATE TABLE HaberYorum
(
	Id INT  Not NULL ,
	HaberId INT Not NULL,
	Yorum NVARCHAR(200)
	
)

--3) Haber tablosuna YayindaMi alan� ekleyelim 
ALTER TABLE Haber ADD YayindaMi BIT

--4) HaberYorum Tablosundaki yorum s�tunun boyutunu 3000 yapma 

ALTER TABLE HaberYorum ALTER COLUMN Yorum NVARCHAR(3000)

--5) Haber tablosundaki YayindaMi S�tununu Silelim
ALTER TABLE Haber DROP COLUMN YayindaMi

--6) HaberYorum tablosunu silelim 

Drop Table HaberYorum

--7) DDLOrnekler db'sini silelim
Drop DATABASE DDLOrnekler

--8) Bir tane sat�n alma s�re� y�netimi projesi i�in db olu�tural�m 
--��erisinde Member, PurchaseOrder ve Invoice tablolar� olsun
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
--9) Kurs otomasyon sistemi database'i olu�tural�m
--Ders Tablosu: Id, LessonName, CreatedDate
--Ogrenci Tablosu: Id, NameSurname, LessonId, Age, CompanySchool, Class, CreatedDate
--Ogretmen Tablosu: Id, NameSurname, LessonId, CreatedDate
--Yoklama Tablosu: Id, OgrenciId, LessonId, CreatedDate

--�lk olarak b�t�n s�reci designer �zerinden olu�turacak �ekilde tasarlayal�m
--�kinci olarak DDL kodlar� ile olu�turacak �ekilde tasarlayal�m.