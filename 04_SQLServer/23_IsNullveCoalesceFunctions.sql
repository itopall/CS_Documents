
--ISNULL ve COALESCE: null olan bir kaydýn hesaplamada sorun çýkarmamasý için null yerine baþka bir deðerin getirilmesini saðlarlar.

--ISNULL: null yerine sadece bir deðer gelebilir.
SELECT ISNULL(null, 1)	--Deðer null olduðu için Select 1 döndürdü
SELECT ISNULL(null, 100)
SELECT ISNULL(50, 100)	--Deðer null olmadýðý için Select 50 deðerini döndürdü
SELECT ISNULL(null, 0) * 1.10 AS ZamliFiyat	--Null olan fiyatlar için çarpma iþleminde sorun yaþamamak adýna 0 deðeri ile çarpmasýný saðladýk.
SELECT ISNULL(100, 0) * 1.10 AS ZamliFiyat

SELECT ISNULL(UnitPrice, '0') AS Fiyat FROM Products 
SELECT ISNULL(UnitPrice, 0) * 1.10 AS KdvliFiyat FROM Products 


--COALESCE: 1. deðer null ise baþka bir deðeri, o da null ise baþka bir deðeri getirebilir.
SELECT COALESCE(null, 1)
SELECT COALESCE(null, null, 1) --1. parametre null ise 2. yi kontrol eder o da null ise 1 döndürür.
SELECT COALESCE(null, 50, 1)	--2. parametre null olmadýðý için (50) 2. parametreyi döndürür.

--ContactName ve ContactTitle null ise 'Bilinmiyor!' deðerini döndürür.
SELECT COALESCE(ContactName, ContactTitle, 'Bilinmiyor!') AS Kisi FROM Customers