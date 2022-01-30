
--Sql'de de�i�ken tan�mlar� DECLARE ile yap�l�r
--T�m de�i�ken isimleri @ ile ba�lar
DECLARE @sayi INT
SET @sayi = 20
SELECT @sayi

--SQL_VARIANT veri tipi T-SQL'de her tipden veri saklamak �zere kullan�labilir.
DECLARE @nesne SQL_VARIANT
SET @nesne = 1
SELECT @nesne
SET @nesne = 'Test'
SELECT @nesne


DECLARE @enPahaliUrun MONEY
SELECT @enPahaliUrun = MAX(UnitPrice) FROM Products --Bu �ekilde sorgudan gelen de�er de�i�kene atan�rsa sonu� k�mesi gelmez! Gelen de�er de�i�kene atan�r ve i�lem biter.

--SELECT @enPahaliUrun --Sonucu result set'de g�rmek i�in de�i�keni Select etmek gerekir.

--Result yerine Messages k�sm�na not olarak yazd�rmak istersek Print'i kullanabiliriz.
PRINT @enPahaliUrun
PRINT 'Deneme'