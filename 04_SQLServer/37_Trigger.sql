
--AFTER ve INSTEAD OF olmak üzere 2 çeþit trigger oluþturulabilir.
--Bu trigger çeþitleri INSERT, UPDATE, DELETE olaylarý için yazýlabilir.
--Trigger'lar satýr bazlý çalýþmazlar, bulk iþlemlerde de tetiklenirler.

CREATE TABLE ProductStock_TriggerTest
(
	Id INT PRIMARY KEY Identity(1,1) NOT NULL,
	ProductId INT,
	Quantity INT,
	IsActive BIT
)

--INSERT TRIGGER
--Order Details tablosuna Insert girildiðinde tetiklenerek stock sayýnýsý otomatik olarak azaltacak bir trigger yazalým.
CREATE TRIGGER DecreaseStock ON [Order Details]
AFTER INSERT --AFTER DELETE, AFTER UPDATE
AS
BEGIN
	DECLARE @productId INT
	DECLARE @quantity INT

	--INSERT Trigger'larda iþlem yapýlan satýra INSERTED komutu ile eriþebiliriz.
	--Satýþ yapýlan ProductId ve Quantity deðerlerini INSERTED'dan aldýk
	SELECT @productId = ProductId, @quantity = Quantity FROM INSERTED

	--Girilen ürün için yeterli stock var mý diye kontrol ediyoruz.
	IF(@quantity <= (SELECT Quantity FROM ProductStock_TriggerTest WHERE ProductId = @productId AND IsActive = 1))
		UPDATE ProductStock_TriggerTest SET Quantity = Quantity - @quantity WHERE ProductId = @productId
	ELSE
	BEGIN
		ROLLBACK --Yeterli stock yok ise ROLLBACK ile insert iþlemi dahil olmak üzere bütün iþlemleri geri alýyoruz.
		PRINT 'Yeterli stok bulunmadýðý için iþlem iptal edildi!'
	END
END


--Herhangi bir ürün için stock kaydý oluþturuyoruz.
SELECT * FROM ProductStock_TriggerTest
INSERT INTO ProductStock_TriggerTest VALUES (19, 1000, 1)

--Order Details tablosuna yeni bir satýþ kaydý giriyoruz ve stock, trigger ile otomatik azalýyor
SELECT * FROM [Order Details] WHERE OrderID = 10248
INSERT INTO [Order Details] VALUES (10248, 19, 62.5, 250, 0)



----------------------------------------------------------------------------------------------------------------------------
--DELETE TRIGGER
--Herhangi bir Employee kaydý DELETE edilirse bir trigger ile ilgili kaydýn EmployeeHistory_TriggerTest adýndaki bir tabloya yedeklenmesini saðlayalým

CREATE TABLE EmployeeHistory_TriggerTest
(
	EmployeeId INT,
	FirstName NVARCHAR(100)
)

CREATE TRIGGER EmployeeBackup ON Employees
AFTER DELETE
AS
BEGIN 
	INSERT INTO EmployeeHistory_TriggerTest (EmployeeId, FirstName)
	SELECT EmployeeId, FirstName FROM DELETED
END

--Tablodan sildikten sonra trigger tarafýndan ilgili kaydýn History tablosuna yedeklendiðini gördük
SELECT * FROM Employees
DELETE FROM Employees WHERE EmployeeID = 20
SELECT * FROM EmployeeHistory_TriggerTest



----------------------------------------------------------------------------------------------------------------------------
--UPDATE TRIGGER
--Ürünün fiyatýný 0 olamayacak ve eski fiyattan daha düþük olamayacak þekilde ayarlayacak bir tirgger yazalým
CREATE TRIGGER ProductPriceControl ON Products
AFTER UPDATE
AS
BEGIN
	DECLARE @newPrice MONEY
	DECLARE @oldPrice MONEY

	SELECT @newPrice = UnitPrice FROM INSERTED
	SELECT @oldPrice = UnitPrice FROM DELETED

	IF(@newPrice <= 0 OR @newPrice < @oldPrice)
	BEGIN
		ROLLBACK
		PRINT 'Fiyat 0 ya da eski fiyattan düþük olamaz!'
	END
END

SELECT * FROM Products
UPDATE Products SET UnitPrice = 0 WHERE ProductId = 1



----------------------------------------------------------------------------------------------------------------------------
--INSTEAD OF TRIGGER
CREATE TRIGGER SetPassiveInsteadOfDelete ON ProductStock_TriggerTest
INSTEAD OF DELETE
AS
BEGIN
	UPDATE p SET IsActive = 0 FROM ProductStock_TriggerTest p
	INNER JOIN DELETED d ON d.Id = p.Id
END

--Instead Of Trigger ile DELETE iþlemi yapmak yerine o kaydý silmeyip IsActive deðerini false'a çeken bir trigger yazýldý.
SELECT * FROM ProductStock_TriggerTest
DELETE FROM ProductStock_TriggerTest WHERE Id = 1