
--String Format: Verileri formatlamak için kullanýlýr.

DECLARE @tarih DATETIME, @tutar MONEY
SET @tarih = GETDATE()
SET @tutar = 1234567.45

SELECT
	FORMAT(@tarih, 'd', 'tr-TR') AS Tarih,
	FORMAT(@tarih, 'dd', 'tr-TR') AS AyýnGunu,
	FORMAT(@tarih, 'ddd', 'tr-TR') AS HaftanýnGunu,
	FORMAT(@tarih, 'yyy', 'tr-TR') AS Yýl,
	FORMAT(@tarih, 'd', 'en-US') AS TarihEN

SELECT
	FORMAT(@tutar, 'c', 'tr-TR') AS TurkLirasý,
	FORMAT(@tutar, 'c', 'en-US') AS Dolar,
	FORMAT(@tutar, 'N', 'tr-TR') AS OndalýkTR,
	FORMAT(@tutar, 'N', 'en-US') AS OndalýkEN,
	FORMAT(@tutar, 'P', 'tr-TR') AS YuzdelikOran

SELECT FORMAT(@tutar, '##,##0.00') AS SayiFormatý
SELECT FORMAT(@tutar, '##-##-####') AS SayiFormatý