
--ISNULL ve COALESCE: null olan bir kayd�n hesaplamada sorun ��karmamas� i�in null yerine ba�ka bir de�erin getirilmesini sa�larlar.

--ISNULL: null yerine sadece bir de�er gelebilir.
SELECT ISNULL(null, 1)	--De�er null oldu�u i�in Select 1 d�nd�rd�
SELECT ISNULL(null, 100)
SELECT ISNULL(50, 100)	--De�er null olmad��� i�in Select 50 de�erini d�nd�rd�
SELECT ISNULL(null, 0) * 1.10 AS ZamliFiyat	--Null olan fiyatlar i�in �arpma i�leminde sorun ya�amamak ad�na 0 de�eri ile �arpmas�n� sa�lad�k.
SELECT ISNULL(100, 0) * 1.10 AS ZamliFiyat

SELECT ISNULL(UnitPrice, '0') AS Fiyat FROM Products 
SELECT ISNULL(UnitPrice, 0) * 1.10 AS KdvliFiyat FROM Products 


--COALESCE: 1. de�er null ise ba�ka bir de�eri, o da null ise ba�ka bir de�eri getirebilir.
SELECT COALESCE(null, 1)
SELECT COALESCE(null, null, 1) --1. parametre null ise 2. yi kontrol eder o da null ise 1 d�nd�r�r.
SELECT COALESCE(null, 50, 1)	--2. parametre null olmad��� i�in (50) 2. parametreyi d�nd�r�r.

--ContactName ve ContactTitle null ise 'Bilinmiyor!' de�erini d�nd�r�r.
SELECT COALESCE(ContactName, ContactTitle, 'Bilinmiyor!') AS Kisi FROM Customers