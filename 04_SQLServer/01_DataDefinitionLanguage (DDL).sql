--Data Definition Language (DDL) Database üzerinde þema iþlemleri (ekleme, silme, güncelleme) için kullanýlýr.
--Komutlar: CREATE, ALTER, DROP

--Yeni bir Db oluþturma
CREATE DATABASE DDLGiris

--Ýþlem yapýlacak Db'yi seçili hale getirme
USE DDLGiris

--Db'nin adýný deðiþtirme
ALTER DATABASE DDLGiris Modify Name = DDLGirisTest

--Db'yi silme
DROP DATABASE DDLGirisTest


--Yeni bir tablo oluþturma
CREATE TABLE Test
(
	Id INT NOT NULL,
	Name NVARCHAR(200) NULL
)

--Tabloya sütun ekleme
ALTER TABLE Test ADD Address NVARCHAR(500) 
ALTER TABLE Test ADD Phone NVARCHAR(11) 

--Tablonun içindeki sütunu güncelleme
ALTER TABLE Test ALTER COLUMN Address NVARCHAR(2000)

--Tablonun içindeki sütunu silme
ALTER TABLE Test DROP COLUMN Phone 
ALTER TABLE Test DROP COLUMN Address 

--Tablo silme
DROP TABLE Test

--Db'yi silme
DROP DATABASE DbIntro
