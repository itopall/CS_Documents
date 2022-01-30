
--CLUSTERED INDEX: Fiziksel sýralama yapar.
--NONCLUSTERED INDEX: Kayýtlarý fiziksel olarak sýralamaz kolay eriþim için index sayfalarý üretir.

--Table Scan: Index olmayan bir tabloda arama yaparsak sql server kayýtlarý tek tek kontrol etmek zorunda kalýr, bu duruma Table Scan denir.

CREATE TABLE Product_IndexTest
(
	Id INT,
	PRoductName NVARCHAR(50)
)

--Primary Key olmadýðý için Table Scan ile arama yapýldýðý Execution plan üzerinden görüldü.
SELECT * FROM Product_IndexTest

--Product tablosundaki Id alanýna göre fiziksel index (clustured) tanýmladýk.
CREATE CLUSTERED INDEX IND_Id ON Product_IndexTest(Id)

--Product tablosundaki ProductName alanýna göre fiziksel olmayan index (nonclustured) tanýmladýk
CREATE NONCLUSTERED INDEX IND_ProductName ON Product_IndexTest(ProductName)

SELECT * FROM Product_IndexTest WHERE Id = 10
SELECT * FROM Product_IndexTest WHERE ProductName = 'test'

--Rebuild Ýþlemi: Index'in yeniden oluþmasýný saðlar.
ALTER INDEX IND_ProductName ON Product_IndexTest REBUILD

--Reorganize Ýþlemi: Index'leri yeniden yapmak yerine sadece yeniden düzenlenmesini saðlar.
ALTER INDEX IND_ProductName ON Product_IndexTest REORGANIZE


--Execution planý incelediðimizde Clustured Index'ler üzerinden join'li tablolara gidildiðini gördük
SELECT * FROM Products p
	INNER JOIN Suppliers s ON s.SupplierId = p.SupplierID
	INNER JOIN Categories c ON c.CategoryID = p.CategoryId
WHERE p.ProductName = 'Ikura'


--ÖDEV
--Bir tane Log tablosu oluþturalým içerisinde Id, LogType (nvarchar), Description alanlarý olsun ve bu tablo için en uygun olan alanlara index tanýmlamalarýný yapalým.
