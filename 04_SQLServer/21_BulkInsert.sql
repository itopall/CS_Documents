
--BULK INSERT: Var olan ya da yeni olu�turulacak bir tabloya toplu bir �ekilde veri kopyalamak i�in kullan�l�r.
--INSERT INTO TabloAdi SELECT...

CREATE TABLE ProductSummaryBulkTest
(
	Id int Identity(1,1),
	Name NVARCHAR(100)
)


--Identity'leri di�er tablodan almak istemiyorsak sadece di�er s�tunlar� alabiliriz.
INSERT INTO ProductSummaryBulkTest(Name) SELECT ProductName FROM Products 
SELECT * FROM ProductSummaryBulkTest

--Identity kolonlara veri giri�i normalde yap�lamaz ancak IDENTITY_INSERT'e tablo i�in ON atand���nda o tabloda identity kolona insert yap�labilir.
SET IDENTITY_INSERT ProductSummaryBulkTest ON 
INSERT INTO ProductSummaryBulkTest(Id, Name) SELECT ProductId, ProductName FROM Products 
SET IDENTITY_INSERT ProductSummaryBulkTest OFF


---------------------------------------------------------------------------------------------------------------
--Bir result set'i yeni bir tabloya toplu �ekilde INSERT etmek i�in a�a��daki sorguyu kullanabiliriz.
--SELECT s�tunlar INTO TabloAdi FROM KaynakTablo
SELECT ProductId, ProductName INTO ProductSummaryBulkTest2 FROM Products
SELECT ProductId, ProductName INTO ProductSummaryBulkTest3 FROM Products WHERE CategoryId = 1
SELECT * FROM ProductSummaryBulkTest2
SELECT * FROM ProductSummaryBulkTest3

--Ba�ka bir db'ye bulk insert ile veri kopyalama
SELECT ProductId, ProductName INTO [Test].dbo.ProductSummaryBulkTest FROM Products