
--Stored Procedure: T-SQL kodlar�n� tek bir par�a haline getirmek i�in kullan�labilirler. Bir veritaban� nesnesidir ve CREATE PROC diyerek olu�turulabilir.

--STORED Procedure'ler performans� artt�ran nesnelerdir.
--SELECT'i direkt olarak �a��rmak, View �zerinden �a��rmak ve bir SP �zerinden �a��rmak aras�nda Performans fark� vard�r.


--Procedure yerine PROC yaz�labilir.
CREATE PROCEDURE AllProducts
AS
SELECT * FROM Products

--Bir procedure'� �a��r�rken EXEC komutu kullan�l�r ya da sadece procedure'�n ad� yaz�l�r.
EXEC AllProducts
AllProducts

--WITH RECOMPILE keyword'�n� execution s�ras�nda yazmak, procedure'�n execution plan'� tekrardan olu�turup cache'i yenilemesini sa�lar.
EXEC AllProducts WITH RECOMPILE



--Parametre alan stored procedure
CREATE PROC GetProducts(@min INT, @max INT)
WITH RECOMPILE
AS
SELECT * FROM Products WHERE UnitPrice BETWEEN @min AND @max

--Parametre alan bir sp'yi �a��r�rken de�erlerini aa��daki �ekilde atayarak �a��rabiliriz. Parametrelerin isimlerini vererek �a��r�yorsak s�ralaman�n bir �nemi yoktur.
EXEC GetProducts @max = 300, @min = 50 

--SP'nin parametreleri s�rayla do�ru bir �ekilde verildi�inde parametre isimlerinin bildirilmesine gerek yoktur.
EXEC GetProducts 50, 300



--Function'larda oldu�u gibi SP'lerde de default parametre tan�mlanabilir. Bu durumda parametre optional olur yani de�eri g�nderilmezse default parametreye atan�r.
--Parametre olarak g�nderilen Customer'a ait sipari�leri listeleyen SP'yi yazd�k.
CREATE PROC GetOrderByCustomerId(@customerId NCHAR(5) = 'ALFKI')
AS
SELECT * FROM Orders WHERE CustomerId = @customerId

EXEC GetOrderByCustomerId 'CHOPS'

--Bu sp'yi Execute ederken parametre vermek zorunda de�iliz.
EXEC GetOrderByCustomerId 


--ProductCount SP'si �r�n say�s�n� 1x1'lik bir result set'de d�nse dahi de�i�ken �zerine atayamay�z!
--��nk� procedure sonucu return etmemi�tir! @productCount de�i�keni Print olarak 0 yazacakt�r.
CREATE PROC ProductCount
AS 
SELECT Count(*) [�r�n Say�s�] FROM Products

DECLARE @productCount INT
EXEC @productCount = ProductCount
PRINT @productCount


--Ayn� SP'yi RETURN edecek �ekilde yazd���m�zda ise d�nen sonucu de�i�kene atay�p kullanabiliriz
CREATE PROC ProductCountNew
AS 
DECLARE @productCount INT
SELECT @productCount =  Count(*) FROM Products
RETURN @productCount

--ProductCountNew, �r�n say�s�n� RETURN etti�inden dolay� a�a��daki �ekilde bir kullan�mda, d�nen de�er INT bir de�i�kene al�nabilir ve farkl� bir yerde (�rne�in PRINT i�inde) kullan�labilir.
DECLARE @productCountNew INT
EXEC @productCountNew = ProductCountNew
PRINT @productCountNew


--�NEML� NOT: STORED PROCEDURE'ler yaln�zca ve yaln�zca INT d�nebilirler
--��nk� procedure'lerin amac� geriye kullan�labilir de�erler d�nmek de�il, bir i�i ger�ekle�tirmektir. Bu ihtiya� SQL'de fonksiyon yazarak ger�ekle�tirilebilir.

--Procedure'ler geriye INT d���nda de�er d�nmeseler de, baz� ihtiya�lar� kar��lamak i�in OUTPUT parametre tekni�i ile de�er d�n��� yapt�r�labilir.

--OUTPUT Parametre: Procedure'�n d��ar�ya parametre arac�l���yla de�erler d�nd�rmesini sa�lar.

ALTER PROC ProductInformation
(
	@productCount INT OUTPUT,
	@sumPrice INT OUTPUT,
	@average INT OUTPUT,
	@note NVARCHAR(100) OUTPUT
)
AS
SELECT
	@productCount = COUNT(*),
	@sumPrice = SUM(UnitPrice),
	@average = AVG(UnitPrice),
	@note = 'test'
FROM
	Products
	
DECLARE @p1 INT
DECLARE @p2 INT
DECLARE @p3 INT
DECLARE @p4 NVARCHAR(100)

EXEC ProductInformation @p1 OUTPUT, @p2 OUTPUT, @p3 OUTPUT, @p4 OUTPUT

PRINT 'Count: ' + CAST(@p1 AS NVARCHAR(10))
PRINT 'Sum: ' + CAST(@p2 AS NVARCHAR(10))
PRINT 'Avg: ' + CAST(@p3 AS NVARCHAR(10))
PRINT 'Note: ' + @p4


--sp_help SP'si bir veritaban� nesnesi hakk�nda bilgi almak i�in kullan�labilir.
EXEC sp_help Products
EXEC sp_help ProductInformation

--SP ve View gibi nesnelerin i�eri�ini verir
EXEC sp_helptext ProductInformation

--SP listesini verir.
SELECT * FROM sys.procedures

--Database listesini verir.
SELECT * FROM sys.databases

