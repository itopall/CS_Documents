
--Stored Procedure: T-SQL kodlarýný tek bir parça haline getirmek için kullanýlabilirler. Bir veritabaný nesnesidir ve CREATE PROC diyerek oluþturulabilir.

--STORED Procedure'ler performansý arttýran nesnelerdir.
--SELECT'i direkt olarak çaðýrmak, View üzerinden çaðýrmak ve bir SP üzerinden çaðýrmak arasýnda Performans farký vardýr.


--Procedure yerine PROC yazýlabilir.
CREATE PROCEDURE AllProducts
AS
SELECT * FROM Products

--Bir procedure'ü çaðýrýrken EXEC komutu kullanýlýr ya da sadece procedure'ün adý yazýlýr.
EXEC AllProducts
AllProducts

--WITH RECOMPILE keyword'ünü execution sýrasýnda yazmak, procedure'ün execution plan'ý tekrardan oluþturup cache'i yenilemesini saðlar.
EXEC AllProducts WITH RECOMPILE



--Parametre alan stored procedure
CREATE PROC GetProducts(@min INT, @max INT)
WITH RECOMPILE
AS
SELECT * FROM Products WHERE UnitPrice BETWEEN @min AND @max

--Parametre alan bir sp'yi çaðýrýrken deðerlerini aaðýdaki þekilde atayarak çaðýrabiliriz. Parametrelerin isimlerini vererek çaðýrýyorsak sýralamanýn bir önemi yoktur.
EXEC GetProducts @max = 300, @min = 50 

--SP'nin parametreleri sýrayla doðru bir þekilde verildiðinde parametre isimlerinin bildirilmesine gerek yoktur.
EXEC GetProducts 50, 300



--Function'larda olduðu gibi SP'lerde de default parametre tanýmlanabilir. Bu durumda parametre optional olur yani deðeri gönderilmezse default parametreye atanýr.
--Parametre olarak gönderilen Customer'a ait sipariþleri listeleyen SP'yi yazdýk.
CREATE PROC GetOrderByCustomerId(@customerId NCHAR(5) = 'ALFKI')
AS
SELECT * FROM Orders WHERE CustomerId = @customerId

EXEC GetOrderByCustomerId 'CHOPS'

--Bu sp'yi Execute ederken parametre vermek zorunda deðiliz.
EXEC GetOrderByCustomerId 


--ProductCount SP'si ürün sayýsýný 1x1'lik bir result set'de dönse dahi deðiþken üzerine atayamayýz!
--Çünkü procedure sonucu return etmemiþtir! @productCount deðiþkeni Print olarak 0 yazacaktýr.
CREATE PROC ProductCount
AS 
SELECT Count(*) [Ürün Sayýsý] FROM Products

DECLARE @productCount INT
EXEC @productCount = ProductCount
PRINT @productCount


--Ayný SP'yi RETURN edecek þekilde yazdýðýmýzda ise dönen sonucu deðiþkene atayýp kullanabiliriz
CREATE PROC ProductCountNew
AS 
DECLARE @productCount INT
SELECT @productCount =  Count(*) FROM Products
RETURN @productCount

--ProductCountNew, ürün sayýsýný RETURN ettiðinden dolayý aþaðýdaki þekilde bir kullanýmda, dönen deðer INT bir deðiþkene alýnabilir ve farklý bir yerde (Örneðin PRINT içinde) kullanýlabilir.
DECLARE @productCountNew INT
EXEC @productCountNew = ProductCountNew
PRINT @productCountNew


--ÖNEMLÝ NOT: STORED PROCEDURE'ler yalnýzca ve yalnýzca INT dönebilirler
--Çünkü procedure'lerin amacý geriye kullanýlabilir deðerler dönmek deðil, bir iþi gerçekleþtirmektir. Bu ihtiyaç SQL'de fonksiyon yazarak gerçekleþtirilebilir.

--Procedure'ler geriye INT dýþýnda deðer dönmeseler de, bazý ihtiyaçlarý karþýlamak için OUTPUT parametre tekniði ile deðer dönüþü yaptýrýlabilir.

--OUTPUT Parametre: Procedure'ün dýþarýya parametre aracýlýðýyla deðerler döndürmesini saðlar.

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


--sp_help SP'si bir veritabaný nesnesi hakkýnda bilgi almak için kullanýlabilir.
EXEC sp_help Products
EXEC sp_help ProductInformation

--SP ve View gibi nesnelerin içeriðini verir
EXEC sp_helptext ProductInformation

--SP listesini verir.
SELECT * FROM sys.procedures

--Database listesini verir.
SELECT * FROM sys.databases

