
--String Format: Verileri formatlamak i�in kullan�l�r.

DECLARE @tarih DATETIME, @tutar MONEY
SET @tarih = GETDATE()
SET @tutar = 1234567.45

SELECT
	FORMAT(@tarih, 'd', 'tr-TR') AS Tarih,
	FORMAT(@tarih, 'dd', 'tr-TR') AS Ay�nGunu,
	FORMAT(@tarih, 'ddd', 'tr-TR') AS Haftan�nGunu,
	FORMAT(@tarih, 'yyy', 'tr-TR') AS Y�l,
	FORMAT(@tarih, 'd', 'en-US') AS TarihEN

SELECT
	FORMAT(@tutar, 'c', 'tr-TR') AS TurkLiras�,
	FORMAT(@tutar, 'c', 'en-US') AS Dolar,
	FORMAT(@tutar, 'N', 'tr-TR') AS Ondal�kTR,
	FORMAT(@tutar, 'N', 'en-US') AS Ondal�kEN,
	FORMAT(@tutar, 'P', 'tr-TR') AS YuzdelikOran

SELECT FORMAT(@tutar, '##,##0.00') AS SayiFormat�
SELECT FORMAT(@tutar, '##-##-####') AS SayiFormat�