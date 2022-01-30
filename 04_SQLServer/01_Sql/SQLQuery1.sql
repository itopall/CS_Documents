--Data Definition Language(DDL) Database �zeride �ema i�lemleri (ekleme,silme,g�ncelleme) i�in kullan�l�r.
--KOMUTLARI: Create, ALTER , DROP

--Yeni bir Db olu�turma
CREATE DATABASE DDLGiris

--��lem yap�lacak Db'yi se�ili hale getirme
USE DDlGiris 

--Db'nin ad�n� de�i�tirme
ALTER DATABASE DDlGiris Modify Name = DDLGirisTest

--Db'yi silme
DROP DATABASE DDLGirisTest

--Yeni bir table olu�turma
CREATE TABLE Text
(
	Id INT Not NULL,
	Name NVARCHAR(200) NULL
)
--Tabloya s�tun ekleme
ALTER TABLE Text ADD Address NVARCHAR(500)
ALTER TABLE Text ADD Phone NVARCHAR(11)

--Tablonun i�indeki s�tunu g�ncelleme
ALTER TABLE Text ALTER COLUMN Address NVARCHAR(2000)

--Tablonun i�indeki s�tunu silme 
ALTER TABLE Text DROP COLUMN Phone
ALTER TABLE Test DROP COLUMN Address

--Tablo Silme
DROP TABLE Text

--Db'yi silme 
DROP DATABASE DoIntro