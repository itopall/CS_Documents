
--GetDayName fonksiyonu Parametre olarak 1-7 arasýnda bir gün index deðeri alarak geriye Türkçe gün adýný döndüren fonksiyonu yazalým

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
		SET @day = 'Salý'
	ELSE IF(@index = 4)
		SET @day = 'Çarþamba'
	ELSE IF(@index = 5)
		SET @day = 'Perþembe'
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
	dbo.GetDayName(DATEPART(dw, BirthDate)) AS [Doðum Günü] 
FROM Employees 



--ÖRNEKLER
--1) Parametre olarak bir ProductId alýp o ürünün fiyatýnýn Products tablosunun ortalama fiyatýndan düþük ya da büyük olmasý durumuna göre true ya da false dönecek scaler function'ý yazalým.

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
SELECT ProductName, UnitPrice, dbo.GetBigThanPriceAverage(ProductId) AS OrtamalanýnUzerindeMi FROM Products



--ÖDEV
--1) Parametre olarak aldýðý bir string deðerin içerisindeki boþluklarý temizleyecek ve temiz halini return edecek scaler function'ý yazalým
--Parametre: '    asd      asd    dfgdfg    '
--Result: 'asdasddfgdfg'
