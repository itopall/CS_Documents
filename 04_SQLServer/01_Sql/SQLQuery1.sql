--Data Definition Language(DDL) Database üzeride þema iþlemleri (ekleme,silme,güncelleme) için kullanýlýr.
--KOMUTLARI: Create, ALTER , DROP

--Yeni bir Db oluþturma
CREATE DATABASE DDLGiris

--Ýþlem yapýlacak Db'yi seçili hale getirme
USE DDlGiris 

--Db'nin adýný deðiþtirme
ALTER DATABASE DDlGiris Modify Name = DDLGirisTest

--Db'yi silme
DROP DATABASE DDLGirisTest

--Yeni bir table oluþturma
CREATE TABLE Text
(
	Id INT Not NULL,
	Name NVARCHAR(200) NULL
)
--Tabloya sütun ekleme
ALTER TABLE Text ADD Address NVARCHAR(500)
ALTER TABLE Text ADD Phone NVARCHAR(11)

--Tablonun içindeki sütunu güncelleme
ALTER TABLE Text ALTER COLUMN Address NVARCHAR(2000)

--Tablonun içindeki sütunu silme 
ALTER TABLE Text DROP COLUMN Phone
ALTER TABLE Test DROP COLUMN Address

--Tablo Silme
DROP TABLE Text

--Db'yi silme 
DROP DATABASE DoIntro