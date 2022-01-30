
--COMMON TABLE EXPRESSION (CTE)
--Bir sorgu sonucunu SQL SERVER'da saklama imkan� verir

WITH OzetTablo
AS
(
	SELECT ProductId, UnitPrice FROM Products WHERE UnitPrice > 5
)
--SELECT * FROM Categories --E�er bu sat�r uncomment yap�l�rsa hata al�n�r.
--��nk� OzetTablo sonu� k�mesi, mutlaka expression tan�mland�ktan sonra kullan�lmal�d�r. Aksi halde server'dan d��er.
SELECT * FROM OzetTablo
