
--Sql'de deðiþken tanýmlarý DECLARE ile yapýlýr
--Tüm deðiþken isimleri @ ile baþlar
DECLARE @sayi INT
SET @sayi = 20
SELECT @sayi

--SQL_VARIANT veri tipi T-SQL'de her tipden veri saklamak üzere kullanýlabilir.
DECLARE @nesne SQL_VARIANT
SET @nesne = 1
SELECT @nesne
SET @nesne = 'Test'
SELECT @nesne


DECLARE @enPahaliUrun MONEY
SELECT @enPahaliUrun = MAX(UnitPrice) FROM Products --Bu þekilde sorgudan gelen deðer deðiþkene atanýrsa sonuç kümesi gelmez! Gelen deðer deðiþkene atanýr ve iþlem biter.

--SELECT @enPahaliUrun --Sonucu result set'de görmek için deðiþkeni Select etmek gerekir.

--Result yerine Messages kýsmýna not olarak yazdýrmak istersek Print'i kullanabiliriz.
PRINT @enPahaliUrun
PRINT 'Deneme'