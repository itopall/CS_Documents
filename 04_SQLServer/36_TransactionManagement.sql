
--Transaction: Veritabanýnda meydana gelen birden fazla iþin bir bütün olarak ele alýnmasýný saðlayan yapýdýr. Örneðin bir satýþýn gerçekleþebilmesi için Order Details yablosuna INSERT, Products tablosuna UPDATE yapýlmalýdýr. Ancak bu iþlemler birbirinden baðýmsýz ele alýnýrsa meydana gelebilecek bir hatada o ana kadar yapýlan iþlemler onaylanýr. Kýsacasý Order Details'a INSERT yapýldýktan sonra UPDATE sýrasýnda problem meydana gelirse ORDER DETAILS'ýn insert'ü yapýlmýþ olacaðýndan, üründe stok fazlasý oluþur.
--Insert sýrasýnda problem gelmez, Update sýrasýnda problem oluþursa Insert yapýlmýþ olur.


--Order tablosuna INSERT
--Order Detail tablosuna INSERT
--Products tablosundaki stok sayýsýný azaltmak için UPDATE

--Baþlatýlan bir transaction'un 2 sonucu olabilir:
--1) COMMIT: Transaction'da gerçekleþen iþlemlerin onaylanmasý ve veritabanýna yansýtýlmasýný saðlar.
--2) ROLLBACK: Transaction'ý iptal eder. O ana kadar yapýlan iþlemleri geri alýr.


SELECT * FROM Orders
SELECT * FROM [Order Details] WHERE OrderID = 10248
SELECT * FROM Products --29

BEGIN TRY
	BEGIN TRANSACTION --Transaction baþlatýldý.
		
		INSERT INTO [Order Details] VALUES (10248, 18, 62.50, 5, 0)

		RAISERROR('Hata oluþtu!', 12, 2) --Üstteki insert girildikten sonra bilinçli olarak hata fýrlattýk!

		UPDATE Products SET UnitsInStock = UnitsInStock - 5 WHERE ProductId = 16

	COMMIT --Hata yoksa transaction onaylandý ve deðiþiklikler database'e yansýdý.
END TRY
BEGIN CATCH
	ROLLBACK --Herhangi bir varsa bütün iþlemleri geri alýr.
	PRINT ERROR_MESSAGE()
END CATCH	


--ÖRNEK
--Bir tane ProductStock tablosu oluþturalým (Id, ProductId, Quantity)
--Bir tane PurchaseOrder tablosu oluþturalým (Id, CustomerId, ProductId, Quantity)
--Herhangi bir ürün için ProductStock tablosuna insert girelim Quantity = 100 olsun
--PurchaseOrder tablosuna ilgili ürün için yeni bir kayýt girelim ve ayný anda ProductStock tablosundaki quantity deðerini girilen miktar kadar azaltalým.