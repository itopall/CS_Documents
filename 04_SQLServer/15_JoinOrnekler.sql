--1) Region ad� ve kendisine ba�l� olan Territory bilgilerini tek seferde �eken sorguyu yazal�m
SELECT RegionDescription, TerritoryDescription FROM Region
INNER JOIN Territories ON Territories.RegionID = Region.RegionID

--2) Brazilya'l� olan m��terilerin verdi�i sipari�leri listeleyelim
SELECT c.Country, c.CompanyName, o.*  FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE c.Country = 'Brazil'

--3) �r�n bazl� sipari� raporu olu�tural�m. Sipari�in i�erisinde ge�en her bir �r�n i�in a�a��daki bilgileri getiren sorguyu yazal�m
--Sipari�No, M��teri Ad�, �r�n ad�, Tutar
SELECT o.OrderId, c.CompanyName, p.ProductName, od.UnitPrice FROM Customers c
INNER JOIN Orders o ON o.CustomerID = c.CustomerID
INNER JOIN [Order Details] od ON od.OrderID = o.OrderId
INNER JOIN Products p ON p.ProductID = od.ProductID

--4) Her kategoriye ait �r�nlerin ortalama, toplam, en d���k ve en y�ksek fiyat�n� g�steren sorguyu yazal�m
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


--5) Hangi kargo �irketi i�in toplam ne kadarl�k navlun tutar� (Freight) �demesi yap�ld���n� g�steren sorguyu yazal�m.
--KargoSirketiAd�, ToplamFreight
SELECT s.CompanyName, SUM(o.Freight) ToplamNavlun FROM Shippers s
INNER JOIN Orders o ON o.ShipVia = s.ShipperID
GROUP BY s.CompanyName


--6) �r�n kategorilerine g�re sat�� adetlerinin toplam�n� getiren sorguyu b�y�kten k����e do�ru s�ralayarak yazal�m
--KategoriAdi, AdetToplami
SELECT c.CategoryName, SUM(od.Quantity) ToplamSatisAdedi FROM [Order Details] od
	INNER JOIN Products p ON p.ProductID = od.ProductId
	INNER JOIN Categories c ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName
ORDER BY
	--SUM(od.Quantity) DESC
	--ToplamSatisAdedi DESC --ToplamSatisAdedi alias'�n� temsil eder
	2 DESC --S�ralama i�lemi i�in bu 3 y�ntem de kullan�labilir. "2" s�tun s�ralamas�ndaki 2. s�tunu temsil eder.

--7) �al��anlar�n �r�n baz�nda yapt�klar� sat��lar�n toplam�n� getiren sorguyu yazal�m
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