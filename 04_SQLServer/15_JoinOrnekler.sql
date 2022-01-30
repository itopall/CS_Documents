--1) Region adý ve kendisine baðlý olan Territory bilgilerini tek seferde çeken sorguyu yazalým
SELECT RegionDescription, TerritoryDescription FROM Region
INNER JOIN Territories ON Territories.RegionID = Region.RegionID

--2) Brazilya'lý olan müþterilerin verdiði sipariþleri listeleyelim
SELECT c.Country, c.CompanyName, o.*  FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE c.Country = 'Brazil'

--3) Ürün bazlý sipariþ raporu oluþturalým. Sipariþin içerisinde geçen her bir ürün için aþaðýdaki bilgileri getiren sorguyu yazalým
--SipariþNo, Müþteri Adý, Ürün adý, Tutar
SELECT o.OrderId, c.CompanyName, p.ProductName, od.UnitPrice FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
INNER JOIN [Order Details] od ON od.OrderID = o.OrderId
INNER JOIN Products p ON p.ProductID = od.ProductID

--4) Her kategoriye ait ürünlerin ortalama, toplam, en düþük ve en yüksek fiyatýný gösteren sorguyu yazalým
--KategoriAdi, Ort, Toplam, EnBuyuk, EnKucuk
SELECT 
	Categories.CategoryName,
	AVG(UnitPrice) AS Ort,
	SUM(UnitPrice) AS Toplam,
	MIN(UnitPrice) EnBuyuk,
	MAX(UnitPrice) [En Kucuk]
FROM 
	Products
		INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID
GROUP BY CategoryName


--5) Hangi kargo þirketi için toplam ne kadarlýk navlun tutarý (Freight) ödemesi yapýldýðýný gösteren sorguyu yazalým.
--KargoSirketiAdý, ToplamFreight
SELECT s.CompanyName, SUM(o.Freight) ToplamNavlun FROM Shippers s
INNER JOIN Orders o ON o.ShipVia = s.ShipperID
GROUP BY s.CompanyName


--6) Ürün kategorilerine göre satýþ adetlerinin toplamýný getiren sorguyu büyükten küçüðe doðru sýralayarak yazalým
--KategoriAdi, AdetToplami
SELECT c.CategoryName, SUM(od.Quantity) ToplamSatisAdedi FROM [Order Details] od
	INNER JOIN Products p ON p.ProductID = od.ProductId
	INNER JOIN Categories c ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName
ORDER BY
	--SUM(od.Quantity) DESC
	--ToplamSatisAdedi DESC --ToplamSatisAdedi alias'ýný temsil eder
	2 DESC --Sýralama iþlemi için bu 3 yöntem de kullanýlabilir. "2" sütun sýralamasýndaki 2. sütunu temsil eder.

--7) Çalýþanlarýn ürün bazýnda yaptýklarý satýþlarýn toplamýný getiren sorguyu yazalým
--CalisanAdSoyad, UrunAdi, AdetToplami, TutarToplami
SELECT 
	e.FirstName + ' ' + e.LastName CalisanAdSoyad, 
	p.ProductName, 
	SUM(od.Quantity) SatisAdediToplami,
	SUM(od.UnitPrice) SatisTutariToplami
FROM 
	Employees e
		INNER JOIN Orders o ON o.EmployeeID = e.EmployeeID
		INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
		INNER JOIN Products p ON p.ProductID = od.ProductID
GROUP BY 
	e.FirstName + ' ' + e.LastName, p.ProductName
ORDER BY
	CalisanAdSoyad