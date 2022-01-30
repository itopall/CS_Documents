
--Parametre alarak gövdesinde belli bir kod satýrýný çalýþtýrýr ve herhangi bir tipden sonuç döndürebilirler.
--Fonksiyonlar SELECT edilerek kullanýlýrlar ve sorgu içerisinde kullanýlabilirler.

--Fonksiyonlar geri dönüþ tiplerine göre 2 gruba ayrýlýrlar;
--1) Scalar Functions: Geriye tek bir deðer dönen fonksiyonlar
--2) Table Value Functions: Geriye bir sonuç kümesi dönen fonksiyonlar

--Fonksiyonlarýn döndürdüðü deðer select edilerek result set oluþturulabilir ya da bir deðiþkene alýnarak baþka bir sorgu içinde kullanýlabilir.

--GETDATE()'in döndürdüðü DATETIME deðeri aþaðýda result set haline getirildi.
SELECT GETDATE()

CREATE FUNCTION GetPrice(@pruductId INT = 1)
RETURNS MONEY
AS
BEGIN
	DECLARE @price MONEY
	SELECT @price = UnitPrice FROM Products WHERE ProductId = @pruductId
	RETURN @price
END

--Kullanýcý tanýmlý fonksiyon çaðrýlýrken mutlaka þema adýyla birlikte çaðrýlmalýdýr.
SELECT dbo.GetPrice(1)
SELECT dbo.GetPrice(DEFAULT)

SELECT * FROM Products WHERE ProductId = 1


--ÖRNEK
--1) Bir CustomerId alarak o müþterinin sipariþlerinin toplam fiyatýný döndüren fonksiyonu yazalým.

CREATE FUNCTION GetCustomerOrdersTotalPrice(@customerId NCHAR(5))
RETURNS MONEY
AS
BEGIN
	DECLARE @totalPrice MONEY

	SELECT @totalPrice = SUM(UnitPrice) FROM Orders o
		INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
	WHERE o.CustomerId = @customerId

	return @totalPrice
END


SELECT dbo.GetCustomerOrdersTotalPrice('CENTC') AS ToplamTutar
SELECT dbo.GetCustomerOrdersTotalPrice('COMMI') AS ToplamTutar

--Fonksiyonlar Select edilebildikleri için sorgu içerisinde kullanýlabilirler.
SELECT CustomerId, CompanyName, dbo.GetCustomerOrdersTotalPrice(CustomerId) AS ToplamTutar FROM Customers

