
--VIEW: Veritabanýnda oluþturulabilecek nesnelerden biridir
--CREATE VIEW ifadesiyle oluþturulur.
--View nesnelerinin özünde yaptýklarý tek þey, "SELECT ifadeleri saklamaktýr."
--View nesneleri Raporlar ve Güvenlik konularý için kullanýlabilir.
--View nesnelerinin PERFORMANSA hiçbir etkisi yoktur
--View nesneleri PARAMETRÝK yapýlamaz!

CREATE VIEW ProductSummary
AS
SELECT ProductId, CategoryId, UnitPrice, Discontinued FROM Products 

SELECT * FROM ProductSummary


--Where kriteri olan view oluþturma
CREATE VIEW ProductSummary2
AS
SELECT ProductId, CategoryId, UnitPrice, Discontinued FROM Products WHERE UnitPrice > 10

SELECT * FROM ProductSummary2


CREATE VIEW ProductSummary3
AS
SELECT * FROm Products WHERE CategoryId = 1

--Eðer view'lar tek bir tablo içerirse (join'siz) view üzerinden insert iþlemi yapýlabilir.
INSERT INTO ProductSummary3 (ProductName, CategoryId, Discontinued) VALUES ('Test11', 1, 1)
SELECT * FROM ProductSummary3


--Çalýþanlarýn Id, Name ve Surname bilgilerini getiren View'ý yazalým
CREATE VIEW EmployeeSummary
AS
SELECT EmployeeId, FirstName, LastName FROM Employees

SELECT * FROM EmployeeSummary

--View içeriðini güncelleme
ALTER VIEW EmployeeSummary
AS
SELECT EmployeeId KullanýcýNo, FirstName Isim, LastName Soyisim, Title Unvan FROM Employees

--View'ý silme
DROP VIEW EmployeeSummary


--ÖRNEKLER
--1) Ucuz ürünler listesini (fiyatý 20'den düþük) getiren view'ý yazalým
CREATE VIEW CheapProducts
AS
SELECT * FROM Products WHERE UnitPrice < 20

SELECT * FROM CheapProducts


--2) Sipariþleri CompanyName, OrderDate þeklinde döndüren View'ý yazalým
CREATE VIEW OrderSummary
AS
SELECT CompanyName, OrderDate FROM Orders
	INNER JOIN Customers ON Customers.CustomerId = Orders.CustomerId

SELECT * FROM OrderSummary
