
--Parametre alarak g�vdesinde belli bir kod sat�r�n� �al��t�r�r ve herhangi bir tipden sonu� d�nd�rebilirler.
--Fonksiyonlar SELECT edilerek kullan�l�rlar ve sorgu i�erisinde kullan�labilirler.

--Fonksiyonlar geri d�n�� tiplerine g�re 2 gruba ayr�l�rlar;
--1) Scalar Functions: Geriye tek bir de�er d�nen fonksiyonlar
--2) Table Value Functions: Geriye bir sonu� k�mesi d�nen fonksiyonlar

--Fonksiyonlar�n d�nd�rd��� de�er select edilerek result set olu�turulabilir ya da bir de�i�kene al�narak ba�ka bir sorgu i�inde kullan�labilir.

--GETDATE()'in d�nd�rd��� DATETIME de�eri a�a��da result set haline getirildi.
SELECT GETDATE()

CREATE FUNCTION GetPrice(@pruductId INT = 1)
RETURNS MONEY
AS
BEGIN
	DECLARE @price MONEY
	SELECT @price = UnitPrice FROM Products WHERE ProductId = @pruductId
	RETURN @price
END

--Kullan�c� tan�ml� fonksiyon �a�r�l�rken mutlaka �ema ad�yla birlikte �a�r�lmal�d�r.
SELECT dbo.GetPrice(1)
SELECT dbo.GetPrice(DEFAULT)

SELECT * FROM Products WHERE ProductId = 1


--�RNEK
--1) Bir CustomerId alarak o m��terinin sipari�lerinin toplam fiyat�n� d�nd�ren fonksiyonu yazal�m.

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

--Fonksiyonlar Select edilebildikleri i�in sorgu i�erisinde kullan�labilirler.
SELECT CustomerId, CompanyName, dbo.GetCustomerOrdersTotalPrice(CustomerId) AS ToplamTutar FROM Customers

