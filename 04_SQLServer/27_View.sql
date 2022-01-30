
--VIEW: Veritaban�nda olu�turulabilecek nesnelerden biridir
--CREATE VIEW ifadesiyle olu�turulur.
--View nesnelerinin �z�nde yapt�klar� tek �ey, "SELECT ifadeleri saklamakt�r."
--View nesneleri Raporlar ve G�venlik konular� i�in kullan�labilir.
--View nesnelerinin PERFORMANSA hi�bir etkisi yoktur
--View nesneleri PARAMETR�K yap�lamaz!

CREATE VIEW ProductSummary
AS
SELECT ProductId, CategoryId, UnitPrice, Discontinued FROM Products 

SELECT * FROM ProductSummary


--Where kriteri olan view olu�turma
CREATE VIEW ProductSummary2
AS
SELECT ProductId, CategoryId, UnitPrice, Discontinued FROM Products WHERE UnitPrice > 10

SELECT * FROM ProductSummary2


CREATE VIEW ProductSummary3
AS
SELECT * FROm Products WHERE CategoryId = 1

--E�er view'lar tek bir tablo i�erirse (join'siz) view �zerinden insert i�lemi yap�labilir.
INSERT INTO ProductSummary3 (ProductName, CategoryId, Discontinued) VALUES ('Test11', 1, 1)
SELECT * FROM ProductSummary3


--�al��anlar�n Id, Name ve Surname bilgilerini getiren View'� yazal�m
CREATE VIEW EmployeeSummary
AS
SELECT EmployeeId, FirstName, LastName FROM Employees

SELECT * FROM EmployeeSummary

--View i�eri�ini g�ncelleme
ALTER VIEW EmployeeSummary
AS
SELECT EmployeeId Kullan�c�No, FirstName Isim, LastName Soyisim, Title Unvan FROM Employees

--View'� silme
DROP VIEW EmployeeSummary


--�RNEKLER
--1) Ucuz �r�nler listesini (fiyat� 20'den d���k) getiren view'� yazal�m
CREATE VIEW CheapProducts
AS
SELECT * FROM Products WHERE UnitPrice < 20

SELECT * FROM CheapProducts


--2) Sipari�leri CompanyName, OrderDate �eklinde d�nd�ren View'� yazal�m
CREATE VIEW OrderSummary
AS
SELECT CompanyName, OrderDate FROM Orders
	INNER JOIN Customers ON Customers.CustomerId = Orders.CustomerId

SELECT * FROM OrderSummary
