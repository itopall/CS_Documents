
--GetDayName fonksiyonu Parametre olarak 1-7 aras�nda bir g�n index de�eri alarak geriye T�rk�e g�n ad�n� d�nd�ren fonksiyonu yazal�m

CREATE FUNCTION GetDayName(@index INT)
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @day NVARCHAR(10)

	IF(@index = 1)
		SET @day = 'Pazar'
	ELSE IF(@index = 2)
		SET @day = 'Pazartesi'
	ELSE IF(@index = 3)
		SET @day = 'Sal�'
	ELSE IF(@index = 4)
		SET @day = '�ar�amba'
	ELSE IF(@index = 5)
		SET @day = 'Per�embe'
	ELSE IF(@index = 6)
		SET @day = 'Cuma'
	ELSE IF(@index = 7)
		SET @day = 'Cumartesi'

	RETURN @day
END

SELECT dbo.GetDayName(5)
SELECT 
	FirstName,
	BirthDate,
	DATEPART(dw, BirthDate), 
	dbo.GetDayName(DATEPART(dw, BirthDate)) AS [Do�um G�n�] 
FROM Employees 



--�RNEKLER
--1) Parametre olarak bir ProductId al�p o �r�n�n fiyat�n�n Products tablosunun ortalama fiyat�ndan d���k ya da b�y�k olmas� durumuna g�re true ya da false d�necek scaler function'� yazal�m.

CREATE FUNCTION GetBigThanPriceAverage(@productId INT)
RETURNS BIT
AS
BEGIN
	DECLARE @result BIT
	DECLARE @avgPrice MONEY
	DECLARE @productPrice MONEY

	SELECT @productPrice = UnitPrice FROM Products WHERE ProductID = @productId
	SELECT @avgPrice = AVG(UnitPrice) FROM Products

	IF(@productPrice > @avgPrice)
		SET @result = 1
	ELSE
		SET @result = 0

	RETURN @result
END

SELECT dbo.GetBigThanPriceAverage(90)
SELECT ProductName, UnitPrice, dbo.GetBigThanPriceAverage(ProductId) AS Ortamalan�nUzerindeMi FROM Products



--�DEV
--1) Parametre olarak ald��� bir string de�erin i�erisindeki bo�luklar� temizleyecek ve temiz halini return edecek scaler function'� yazal�m
--Parametre: '    asd      asd    dfgdfg    '
--Result: 'asdasddfgdfg'
