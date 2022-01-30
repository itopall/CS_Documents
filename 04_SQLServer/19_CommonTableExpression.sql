
--COMMON TABLE EXPRESSION (CTE)
--Bir sorgu sonucunu SQL SERVER'da saklama imkaný verir

WITH OzetTablo
AS
(
	SELECT ProductId, UnitPrice FROM Products WHERE UnitPrice > 5
)
--SELECT * FROM Categories --Eðer bu satýr uncomment yapýlýrsa hata alýnýr.
--Çünkü OzetTablo sonuç kümesi, mutlaka expression tanýmlandýktan sonra kullanýlmalýdýr. Aksi halde server'dan düþer.
SELECT * FROM OzetTablo
