
--BULK INSERT: Var olan ya da yeni oluþturulacak bir tabloya toplu bir þekilde veri kopyalamak için kullanýlýr.
--INSERT INTO TabloAdi SELECT...

CREATE TABLE ProductSummaryBulkTest
(
	Id int Identity(1,1),
	Name NVARCHAR(100)
)


--Identity'leri diðer tablodan almak istemiyorsak sadece diðer sütunlarý alabiliriz.
INSERT INTO ProductSummaryBulkTest(Name) SELECT ProductName FROM Products 
SELECT * FROM ProductSummaryBulkTest

--Identity kolonlara veri giriþi normalde yapýlamaz ancak IDENTITY_INSERT'e tablo için ON atandýðýnda o tabloda identity kolona insert yapýlabilir.
SET IDENTITY_INSERT ProductSummaryBulkTest ON 
INSERT INTO ProductSummaryBulkTest(Id, Name) SELECT ProductId, ProductName FROM Products 
SET IDENTITY_INSERT ProductSummaryBulkTest OFF


---------------------------------------------------------------------------------------------------------------
--Bir result set'i yeni bir tabloya toplu þekilde INSERT etmek için aþaðýdaki sorguyu kullanabiliriz.
--SELECT sütunlar INTO TabloAdi FROM KaynakTablo
SELECT ProductId, ProductName INTO ProductSummaryBulkTest2 FROM Products
SELECT ProductId, ProductName INTO ProductSummaryBulkTest3 FROM Products WHERE CategoryId = 1
SELECT * FROM ProductSummaryBulkTest2
SELECT * FROM ProductSummaryBulkTest3

--Baþka bir db'ye bulk insert ile veri kopyalama
SELECT ProductId, ProductName INTO [Test].dbo.ProductSummaryBulkTest FROM Products