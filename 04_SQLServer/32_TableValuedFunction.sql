
--Geriye bir sonu� k�mesi d�nd�ren fonksiyonlard�r.
--RETURN TABLE, Return edilecek veri k�mesi i�in mutlaka bir select yaz�lmal�d�r.

CREATE FUNCTION GetExpensiveProducts()
RETURNS TABLE
AS
RETURN SELECT TOP 5 * FROM Products ORDER BY UnitPrice DESC

--Table Valued Functions FROM'dan sonra kullan�l�r.
--Table Valued Functions �ema ad� yazmadan kullan�labilir.
SELECT * FROM GetExpensiveProducts()

--�RNEK
--1) Parametre olarak ald��� CategoryId'ye ait �r�nlerin listesini getiren function'� yazal�m
CREATE FUNCTION GetProductsByCategoryId(@categoryId INT)
RETURNS TABLE
AS
RETURN SELECT * FROM Products WHERE CategoryId = @categoryId

SELECT * FROM GetProductsByCategoryId(5)
