
--ProductId'lere g�re sat�� adetlerini alma
SELECT COUNT(*), ProductId FROM [Order Details]
GROUP BY ProductId

--Sa�lamas�n� yaparak ger�ekten tabloda 39 adet oldu�unu g�rd�k
SELECT * FROM [Order Details] WHERE ProductId = 2

--HATA!! UnitPrice'lar�na g�re gruplad�k ancak ProductId de�erlerini select etmeye �al��t�k, her bir UnitPrice grubuna kar��l�k ProductId select edemeyiz!
--�zetle, select'in i�erisinde hangi s�tunu kullanm��sak o s�tuna g�re GROUP yapmam�z gerekir
SELECT COUNT(*), ProductId FROM [Order Details]
GROUP BY UnitPrice

--CategoryId baz�nda �r�nlerin toplam fiyatlar�n� getiren sorgu 
SELECT SUM(UnitPrice), CategoryId FROM Products
GROUP BY CategoryId

--Country baz�nda Supplier say�s�n� getiren sorgu
SELECT COUNT(*), Country FROM Suppliers
GROUP BY Country


--CategoryId'sine g�re gruplad���m�z �r�nlerden sadece say�s� 10'dan b�y�k olanlar� getiren sorgu;
--WHERE kriterleri i�erisinde Aggregate functions kullanamay�z! Gruplama i�lemlerinde aggregate function'�n d�nd�rd��� de�erler �zerinde (count) filtreleme yapmak i�in HAVING kullan�l�r.
SELECT COUNT(*), CategoryId FROM Products
WHERE CategoryId IN (1,2,3,4)	--Direkt tabloda filtre uygular
GROUP BY CategoryId
HAVING COUNT(*) > 10	--Gruplanan alanda filtre uygular.


--Birden fazla alana g�re gruplama i�lemi yapmak
SELECT COUNT(*), CategoryId, SupplierId FROM Products
GROUP BY CategoryId, SupplierId

--Tablodan sorgu �ekerek sa�lamas�n� yap�yoruz. Sonu� olarak 4 sat�r veri geldi.
SELECT * FROM Products WHERE CategoryId = 2 AND SupplierId = 2


--S�ralama Kural�: SELECT FROM TabloAd�, WHERE, GROUP BY, HAVING, ORDER BY
SELECT COUNT(*), CategoryId, SupplierId FROM Products
WHERE CategoryId IN (1,2,3,4,5)
GROUP BY CategoryId, SupplierId
HAVING COUNT(*) > 1
ORDER BY SupplierId


--Tek ba��na group by kullan�m� (Group By kulland���m�z s�tuna g�re tekil sonu�lar� g�sterir)
SELECT SupplierId FROM Products GROUP BY SupplierId
SELECT CategoryId FROM Products GROUP BY CategoryId

--Distinct keyword'� tek ba��na group by kullan�m� ile ayn� i�i yapar.
SELECT DISTINCT CategoryId FROM Products 