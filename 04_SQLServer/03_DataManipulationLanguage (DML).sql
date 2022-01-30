--DATA Manipulation Language (DML): Db üzerinde datasal olarak yeni kayýt ekleme, silme, güncelleme ve okuma (CRUD iþlemleri) gibi iþlemleri gerçekleþtiren komutlardýr.
--Komutlar: INSERT, UPDATE, DELETE, SELECT

--Kayýt ekleme iþlemleri için INSERT kullanýlýr
INSERT INTO Shippers VALUES ('Yurtiçi Kargo', '123123123')
INSERT INTO Shippers (CompanyName, Phone) VALUES ('Aras Kargo', '123123345')

--Bu kullanýmda tabloda nullable olan sütunlar için de zorunlu olarak null deðeri gönderilmelidir.
INSERT INTO Test VALUES ('Ekrem', null, null, null, 'Beþiktaþ', null, null, null, null, null, '12312334345', null, null, null)

--Bu kullanýmda ise nullable alanlar sorguya hiç dahil edilmeyebilir.
INSERT INTO Test (NameSurname, Address, Phone) VALUES ('Ekrem', 'Beþiktaþ', '12312334345')


--Kayýt güncelleme iþlemleri için UPDATE kullanýlýr.
UPDATE tabloAdi SET sütunAdý = 'Yeni Deðer' --WHERE kriteri yazýlmazsa tablodaki bütün kayýtlar güncellenir. ÖLÜMCÜL HATA!!!

UPDATE tabloAdi SET sütunAdý = 'Yeni Deðer' WHERE kriter --Sadece kritere uyan kayýtlar gücellenir.


UPDATE Shippers SET CompanyName = 'Mng Kargo' WHERE CompanyName = 'Yurtiçi Kargo' --Adý 'Yurtiçi Kargo' olan kayýtlar güncellendi. 
UPDATE Shippers SET Phone = '875654452' WHERE ShipperId = 26 --Sadece ShipperId'si 26 olan kayýt güncellendi.

UPDATE Shippers SET Phone = '1112223344', CompanyName = 'Sürat Kargo' WHERE ShipperId = 26 --Ayný anda birden fazla sütun güncelleme iþlemi yapýlabilir.


--Kayýt silme iþlemleri için DELETE kullanýlýr.
DELETE FROM tabloAdi --WHERE kriteri belirtilmezse tablodaki bütün kayýtlar silinir. ÖLÜMCÜL HATA!!
DELETE FROM tabloAdi WHERE kriter --Sadece kritere uyan kayýtlar silinir!

DELETE FROM Shippers WHERE ShipperID = 26
DELETE FROM Shippers WHERE CompanyName = 'Aras Kargo'
DELETE FROM Shippers WHERE Phone = '123123123'

--1 Id'li kargo þirketine baðlý satýþ kayýtlarý olduðu için bu kayýt silinemez
DELETE FROM Shippers WHERE ShipperID = 1