
--Id'si verilen ürünün fiyatýný güncelleyen bir Proc yazalým
CREATE PROC UpdateProductPrice(@productId INT, @unitPrice MONEY)
AS
UPDATE Products SET UnitPrice = @unitPrice WHERE ProductId = @productId

--Ürün fiyatýný 0 olarak update edebildik.
EXEC UpdateProductPrice 1, 0


--Ürünðn fiyatýnýn 0 olarak update edilmesini engelleyecek þekilde Proc'u tekrar yazdýk.
ALTER PROC UpdateProductPrice(@productId INT, @unitPrice MONEY)
AS
IF(@unitPrice > 0)
	UPDATE Products SET UnitPrice = @unitPrice WHERE ProductId = @productId
ELSE
	RAISERROR('Price deðeri sýfýr olamaz!', 12, 1)

--Ürün fiyatýný 0 olarak update edemedik!
EXEC UpdateProductPrice 1, 0


--TRY-CATCH ile Exception Management uygulama
BEGIN TRY
	EXEC UpdateProductPrice 1, 0
END TRY
BEGIN CATCH
	--UpdateProductPrice proc'unda hata meydana geldiðinde yapýlacak iþlemler bu kod bloðunda yazýlabilir.

	DECLARE @state INT
	SELECT @state = ERROR_STATE()

	--Deðiþkene atadýðýmýz hatanýn hangisi olduðunu yakaladýk, ona göre mesaj yazdýrdýk.
	IF(@state = 1)
		PRINT 'Bu satýrda hata oluþtu: Hata Detayý: Price için deðer 0 olamaz!'
END CATCH


--RAISERROR'fýrlattýðý mesajlarýn numaralarý otomatik olarak 50000 olur
--50000 öncesi SQL'in kendi hatalarýdýr. Manuel oluþturduðumuz hata kayýtlarý için 50000'den büyük kodlar verilir.
--12: SQL'in kullandýðý hata derecesi (level)'dir. Farklý bir rakam da verilebilir. 10'dan küçük verilirse Exception Management'de catch bloðuna düþmez!
--1: Hata statü'südür (state). hangi hatanýn ne sebeple fýrlatýldýðýný ayýrt edebilmek için kullanýlabilir.
--Örnek: 1= Kayýt bulunamadý hatasý, 2= Deðer boþ geçilemez hatasý vs. gibi kendi isteklerimize göre sýnýflandýrabiliriz.


BEGIN TRY
	EXEC UpdateProductPrice 1, 0
END TRY
BEGIN CATCH
	--@@ERROR'dan önce Print'i eklersek @@ERROR kodu 0'a döner fýrlatýlan hata kodunu kaybederiz.
	--PRINT 'cache''e düþtü'

	--@@ERROR son yapýlan iþlemdeki hata numarasýnu döner!
	SELECT @@ERROR [Hata Mesaj Kodu]	--50000

	--Aþaðýdaki fonksiyonlar ile en son meydana gelen hata bilgilerine ulaþabiliriz.
	SELECT ERROR_STATE() [State]		--1
	SELECT ERROR_SEVERITY() [Level]		--12
	SELECT ERROR_MESSAGE() [Message]	--Price deðeri sýfýr olamaz!

END CATCH



--ÖRNEK:
--Employee tablosundaki FirstName'i güncelleyen bir proc yazalým (Parametreler: Id, FirstName) ve proc içerisinde FirstName deðerinin boþ girilmesini engelleyelim.
--TRY-CATCH ile oluþan hatayý yakalayýp mesajý ekrana yazdýralým.
CREATE PROC UpdateEmployeeFirstNameById(@employeeId INT, @firstName NVARCHAR(10))
AS
IF(@firstName != '')
	UPDATE Employees SET FirstName = @firstName WHERE EmployeeID = @employeeId
ELSE
	RAISERROR('Ýsim boþ býrakýlamaz!', 12, 1)


SELECT * FROm Employees
EXEC UpdateEmployeeFirstNameById 13, ''

BEGIN TRY
	EXEC UpdateEmployeeFirstNameById 13, ''
END TRY
BEGIN CATCH
	PRINT 'Hata Oluþtu! Hata Mesajý: ' + ERROR_MESSAGE()
END CATCH