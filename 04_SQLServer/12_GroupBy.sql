
--ProductId'lere göre satýþ adetlerini alma
SELECT COUNT(*), ProductId FROM [Order Details]
GROUP BY ProductId

--Saðlamasýný yaparak gerçekten tabloda 39 adet olduðunu gördük
SELECT * FROM [Order Details] WHERE ProductId = 2

--HATA!! UnitPrice'larýna göre grupladýk ancak ProductId deðerlerini select etmeye çalýþtýk, her bir UnitPrice grubuna karþýlýk ProductId select edemeyiz!
--Özetle, select'in içerisinde hangi sütunu kullanmýþsak o sütuna göre GROUP yapmamýz gerekir
SELECT COUNT(*), ProductId FROM [Order Details]
GROUP BY UnitPrice

--CategoryId bazýnda ürünlerin toplam fiyatlarýný getiren sorgu 
SELECT SUM(UnitPrice), CategoryId FROM Products
GROUP BY CategoryId

--Country bazýnda Supplier sayýsýný getiren sorgu
SELECT COUNT(*), Country FROM Suppliers
GROUP BY Country


--CategoryId'sine göre grupladýðýmýz ürünlerden sadece sayýsý 10'dan büyük olanlarý getiren sorgu;
--WHERE kriterleri içerisinde Aggregate functions kullanamayýz! Gruplama iþlemlerinde aggregate function'ýn döndürdüðü deðerler üzerinde (count) filtreleme yapmak için HAVING kullanýlýr.
SELECT COUNT(*), CategoryId FROM Products
WHERE CategoryId IN (1,2,3,4)	--Direkt tabloda filtre uygular
GROUP BY CategoryId
HAVING COUNT(*) > 10	--Gruplanan alanda filtre uygular.


--Birden fazla alana göre gruplama iþlemi yapmak
SELECT COUNT(*), CategoryId, SupplierId FROM Products
GROUP BY CategoryId, SupplierId

--Tablodan sorgu çekerek saðlamasýný yapýyoruz. Sonuç olarak 4 satýr veri geldi.
SELECT * FROM Products WHERE CategoryId = 2 AND SupplierId = 2


--Sýralama Kuralý: SELECT FROM TabloAdý, WHERE, GROUP BY, HAVING, ORDER BY
SELECT COUNT(*), CategoryId, SupplierId FROM Products
WHERE CategoryId IN (1,2,3,4,5)
GROUP BY CategoryId, SupplierId
HAVING COUNT(*) > 1
ORDER BY SupplierId


--Tek baþýna group by kullanýmý (Group By kullandýðýmýz sütuna göre tekil sonuçlarý gösterir)
SELECT SupplierId FROM Products GROUP BY SupplierId
SELECT CategoryId FROM Products GROUP BY CategoryId

--Distinct keyword'ü tek baþýna group by kullanýmý ile ayný iþi yapar.
SELECT DISTINCT CategoryId FROM Products 