
--AFTER ve INSTEAD OF olmak �zere 2 �e�it trigger olu�turulabilir.
--Bu trigger �e�itleri INSERT, UPDATE, DELETE olaylar� i�in yaz�labilir.
--Trigger'lar sat�r bazl� �al��mazlar, bulk i�lemlerde de tetiklenirler.

CREATE TABLE ProductStock_TriggerTest
(
	Id INT PRIMARY KEY Identity(1,1) NOT NULL,
	ProductId INT,
	Quantity INT,
	IsActive BIT
)

--INSERT TRIGGER
--Order Details tablosuna Insert girildi�inde tetiklenerek stock say�n�s� otomatik olarak azaltacak bir trigger yazal�m.
CREATE TRIGGER DecreaseStock ON [Order Details]
AFTER INSERT --AFTER DELETE, AFTER UPDATE
AS
BEGIN
	DECLARE @productId INT
	DECLARE @quantity INT

	--INSERT Trigger'larda i�lem yap�lan sat�ra INSERTED komutu ile eri�ebiliriz.
	--Sat�� yap�lan ProductId ve Quantity de�erlerini INSERTED'dan ald�k
	SELECT @productId = ProductId, @quantity = Quantity FROM INSERTED

	--Girilen �r�n i�in yeterli stock var m� diye kontrol ediyoruz.
	IF(@quantity <= (SELECT Quantity FROM ProductStock_TriggerTest WHERE ProductId = @productId AND IsActive = 1))
		UPDATE ProductStock_TriggerTest SET Quantity = Quantity - @quantity WHERE ProductId = @productId
	ELSE
	BEGIN
		ROLLBACK --Yeterli stock yok ise ROLLBACK ile insert i�lemi dahil olmak �zere b�t�n i�lemleri geri al�yoruz.
		PRINT 'Yeterli stok bulunmad��� i�in i�lem iptal edildi!'
	END
END


--Herhangi bir �r�n i�in stock kayd� olu�turuyoruz.
SELECT * FROM ProductStock_TriggerTest
INSERT INTO ProductStock_TriggerTest VALUES (19, 1000, 1)

--Order Details tablosuna yeni bir sat�� kayd� giriyoruz ve stock, trigger ile otomatik azal�yor
SELECT * FROM [Order Details] WHERE OrderID = 10248
INSERT INTO [Order Details] VALUES (10248, 19, 62.5, 250, 0)



----------------------------------------------------------------------------------------------------------------------------
--DELETE TRIGGER
--Herhangi bir Employee kayd� DELETE edilirse bir trigger ile ilgili kayd�n EmployeeHistory_TriggerTest ad�ndaki bir tabloya yedeklenmesini sa�layal�m

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

--Tablodan sildikten sonra trigger taraf�ndan ilgili kayd�n History tablosuna yedeklendi�ini g�rd�k
SELECT * FROM Employees
DELETE FROM Employees WHERE EmployeeID = 20
SELECT * FROM EmployeeHistory_TriggerTest



----------------------------------------------------------------------------------------------------------------------------
--UPDATE TRIGGER
--�r�n�n fiyat�n� 0 olamayacak ve eski fiyattan daha d���k olamayacak �ekilde ayarlayacak bir tirgger yazal�m
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
		PRINT 'Fiyat 0 ya da eski fiyattan d���k olamaz!'
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

--Instead Of Trigger ile DELETE i�lemi yapmak yerine o kayd� silmeyip IsActive de�erini false'a �eken bir trigger yaz�ld�.
SELECT * FROM ProductStock_TriggerTest
DELETE FROM ProductStock_TriggerTest WHERE Id = 1