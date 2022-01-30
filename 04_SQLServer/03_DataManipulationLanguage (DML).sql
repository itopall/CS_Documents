--DATA Manipulation Language (DML): Db �zerinde datasal olarak yeni kay�t ekleme, silme, g�ncelleme ve okuma (CRUD i�lemleri) gibi i�lemleri ger�ekle�tiren komutlard�r.
--Komutlar: INSERT, UPDATE, DELETE, SELECT

--Kay�t ekleme i�lemleri i�in INSERT kullan�l�r
INSERT INTO Shippers VALUES ('Yurti�i Kargo', '123123123')
INSERT INTO Shippers (CompanyName, Phone) VALUES ('Aras Kargo', '123123345')

--Bu kullan�mda tabloda nullable olan s�tunlar i�in de zorunlu olarak null de�eri g�nderilmelidir.
INSERT INTO Test VALUES ('Ekrem', null, null, null, 'Be�ikta�', null, null, null, null, null, '12312334345', null, null, null)

--Bu kullan�mda ise nullable alanlar sorguya hi� dahil edilmeyebilir.
INSERT INTO Test (NameSurname, Address, Phone) VALUES ('Ekrem', 'Be�ikta�', '12312334345')


--Kay�t g�ncelleme i�lemleri i�in UPDATE kullan�l�r.
UPDATE tabloAdi SET s�tunAd� = 'Yeni De�er' --WHERE kriteri yaz�lmazsa tablodaki b�t�n kay�tlar g�ncellenir. �L�MC�L HATA!!!

UPDATE tabloAdi SET s�tunAd� = 'Yeni De�er' WHERE kriter --Sadece kritere uyan kay�tlar g�cellenir.


UPDATE Shippers SET CompanyName = 'Mng Kargo' WHERE CompanyName = 'Yurti�i Kargo' --Ad� 'Yurti�i Kargo' olan kay�tlar g�ncellendi. 
UPDATE Shippers SET Phone = '875654452' WHERE ShipperId = 26 --Sadece ShipperId'si 26 olan kay�t g�ncellendi.

UPDATE Shippers SET Phone = '1112223344', CompanyName = 'S�rat Kargo' WHERE ShipperId = 26 --Ayn� anda birden fazla s�tun g�ncelleme i�lemi yap�labilir.


--Kay�t silme i�lemleri i�in DELETE kullan�l�r.
DELETE FROM tabloAdi --WHERE kriteri belirtilmezse tablodaki b�t�n kay�tlar silinir. �L�MC�L HATA!!
DELETE FROM tabloAdi WHERE kriter --Sadece kritere uyan kay�tlar silinir!

DELETE FROM Shippers WHERE ShipperID = 26
DELETE FROM Shippers WHERE CompanyName = 'Aras Kargo'
DELETE FROM Shippers WHERE Phone = '123123123'

--1 Id'li kargo �irketine ba�l� sat�� kay�tlar� oldu�u i�in bu kay�t silinemez
DELETE FROM Shippers WHERE ShipperID = 1