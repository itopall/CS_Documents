--Data Definition Language (DDL) Database �zerinde �ema i�lemleri (ekleme, silme, g�ncelleme) i�in kullan�l�r.
--Komutlar: CREATE, ALTER, DROP

--Yeni bir Db olu�turma
CREATE DATABASE DDLGiris

--��lem yap�lacak Db'yi se�ili hale getirme
USE DDLGiris

--Db'nin ad�n� de�i�tirme
ALTER DATABASE DDLGiris Modify Name = DDLGirisTest

--Db'yi silme
DROP DATABASE DDLGirisTest


--Yeni bir tablo olu�turma
CREATE TABLE Test
(
	Id INT NOT NULL,
	Name NVARCHAR(200) NULL
)

--Tabloya s�tun ekleme
ALTER TABLE Test ADD Address NVARCHAR(500) 
ALTER TABLE Test ADD Phone NVARCHAR(11) 

--Tablonun i�indeki s�tunu g�ncelleme
ALTER TABLE Test ALTER COLUMN Address NVARCHAR(2000)

--Tablonun i�indeki s�tunu silme
ALTER TABLE Test DROP COLUMN Phone 
ALTER TABLE Test DROP COLUMN Address 

--Tablo silme
DROP TABLE Test

--Db'yi silme
DROP DATABASE DbIntro
