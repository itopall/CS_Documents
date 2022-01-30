
--Geriye bir sonuç kümesi döndüren fonksiyonlardýr.
--RETURN TABLE, Return edilecek veri kümesi için mutlaka bir select yazýlmalýdýr.

CREATE FUNCTION GetExpensiveProducts()
RETURNS TABLE
AS
RETURN SELECT TOP 5 * FROM Products ORDER BY UnitPrice DESC

--Table Valued Functions FROM'dan sonra kullanýlýr.
--Table Valued Functions þema adý yazmadan kullanýlabilir.
SELECT * FROM GetExpensiveProducts()

--ÖRNEK
--1) Parametre olarak aldýðý CategoryId'ye ait ürünlerin listesini getiren function'ý yazalým
CREATE FUNCTION GetProductsByCategoryId(@categoryId INT)
RETURNS TABLE
AS
RETURN SELECT * FROM Products WHERE CategoryId = @categoryId

SELECT * FROM GetProductsByCategoryId(5)
