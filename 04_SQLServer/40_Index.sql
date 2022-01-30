
--CLUSTERED INDEX: Fiziksel s�ralama yapar.
--NONCLUSTERED INDEX: Kay�tlar� fiziksel olarak s�ralamaz kolay eri�im i�in index sayfalar� �retir.

--Table Scan: Index olmayan bir tabloda arama yaparsak sql server kay�tlar� tek tek kontrol etmek zorunda kal�r, bu duruma Table Scan denir.

CREATE TABLE Product_IndexTest
(
	Id INT,
	PRoductName NVARCHAR(50)
)

--Primary Key olmad��� i�in Table Scan ile arama yap�ld��� Execution plan �zerinden g�r�ld�.
SELECT * FROM Product_IndexTest

--Product tablosundaki Id alan�na g�re fiziksel index (clustured) tan�mlad�k.
CREATE CLUSTERED INDEX IND_Id ON Product_IndexTest(Id)

--Product tablosundaki ProductName alan�na g�re fiziksel olmayan index (nonclustured) tan�mlad�k
CREATE NONCLUSTERED INDEX IND_ProductName ON Product_IndexTest(ProductName)

SELECT * FROM Product_IndexTest WHERE Id = 10
SELECT * FROM Product_IndexTest WHERE ProductName = 'test'

--Rebuild ��lemi: Index'in yeniden olu�mas�n� sa�lar.
ALTER INDEX IND_ProductName ON Product_IndexTest REBUILD

--Reorganize ��lemi: Index'leri yeniden yapmak yerine sadece yeniden d�zenlenmesini sa�lar.
ALTER INDEX IND_ProductName ON Product_IndexTest REORGANIZE


--Execution plan� inceledi�imizde Clustured Index'ler �zerinden join'li tablolara gidildi�ini g�rd�k
SELECT * FROM Products p
	INNER JOIN Suppliers s ON s.SupplierId = p.SupplierID
	INNER JOIN Categories c ON c.CategoryID = p.CategoryId
WHERE p.ProductName = 'Ikura'


--�DEV
--Bir tane Log tablosu olu�tural�m i�erisinde Id, LogType (nvarchar), Description alanlar� olsun ve bu tablo i�in en uygun olan alanlara index tan�mlamalar�n� yapal�m.
