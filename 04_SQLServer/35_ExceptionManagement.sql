
--Id'si verilen �r�n�n fiyat�n� g�ncelleyen bir Proc yazal�m
CREATE PROC UpdateProductPrice(@productId INT, @unitPrice MONEY)
AS
UPDATE Products SET UnitPrice = @unitPrice WHERE ProductId = @productId

--�r�n fiyat�n� 0 olarak update edebildik.
EXEC UpdateProductPrice 1, 0


--�r�n�n fiyat�n�n 0 olarak update edilmesini engelleyecek �ekilde Proc'u tekrar yazd�k.
ALTER PROC UpdateProductPrice(@productId INT, @unitPrice MONEY)
AS
IF(@unitPrice > 0)
	UPDATE Products SET UnitPrice = @unitPrice WHERE ProductId = @productId
ELSE
	RAISERROR('Price de�eri s�f�r olamaz!', 12, 1)

--�r�n fiyat�n� 0 olarak update edemedik!
EXEC UpdateProductPrice 1, 0


--TRY-CATCH ile Exception Management uygulama
BEGIN TRY
	EXEC UpdateProductPrice 1, 0
END TRY
BEGIN CATCH
	--UpdateProductPrice proc'unda hata meydana geldi�inde yap�lacak i�lemler bu kod blo�unda yaz�labilir.

	DECLARE @state INT
	SELECT @state = ERROR_STATE()

	--De�i�kene atad���m�z hatan�n hangisi oldu�unu yakalad�k, ona g�re mesaj yazd�rd�k.
	IF(@state = 1)
		PRINT 'Bu sat�rda hata olu�tu: Hata Detay�: Price i�in de�er 0 olamaz!'
END CATCH


--RAISERROR'f�rlatt��� mesajlar�n numaralar� otomatik olarak 50000 olur
--50000 �ncesi SQL'in kendi hatalar�d�r. Manuel olu�turdu�umuz hata kay�tlar� i�in 50000'den b�y�k kodlar verilir.
--12: SQL'in kulland��� hata derecesi (level)'dir. Farkl� bir rakam da verilebilir. 10'dan k���k verilirse Exception Management'de catch blo�una d��mez!
--1: Hata stat�'s�d�r (state). hangi hatan�n ne sebeple f�rlat�ld���n� ay�rt edebilmek i�in kullan�labilir.
--�rnek: 1= Kay�t bulunamad� hatas�, 2= De�er bo� ge�ilemez hatas� vs. gibi kendi isteklerimize g�re s�n�fland�rabiliriz.


BEGIN TRY
	EXEC UpdateProductPrice 1, 0
END TRY
BEGIN CATCH
	--@@ERROR'dan �nce Print'i eklersek @@ERROR kodu 0'a d�ner f�rlat�lan hata kodunu kaybederiz.
	--PRINT 'cache''e d��t�'

	--@@ERROR son yap�lan i�lemdeki hata numaras�nu d�ner!
	SELECT @@ERROR [Hata Mesaj Kodu]	--50000

	--A�a��daki fonksiyonlar ile en son meydana gelen hata bilgilerine ula�abiliriz.
	SELECT ERROR_STATE() [State]		--1
	SELECT ERROR_SEVERITY() [Level]		--12
	SELECT ERROR_MESSAGE() [Message]	--Price de�eri s�f�r olamaz!

END CATCH



--�RNEK:
--Employee tablosundaki FirstName'i g�ncelleyen bir proc yazal�m (Parametreler: Id, FirstName) ve proc i�erisinde FirstName de�erinin bo� girilmesini engelleyelim.
--TRY-CATCH ile olu�an hatay� yakalay�p mesaj� ekrana yazd�ral�m.
CREATE PROC UpdateEmployeeFirstNameById(@employeeId INT, @firstName NVARCHAR(10))
AS
IF(@firstName != '')
	UPDATE Employees SET FirstName = @firstName WHERE EmployeeID = @employeeId
ELSE
	RAISERROR('�sim bo� b�rak�lamaz!', 12, 1)


SELECT * FROm Employees
EXEC UpdateEmployeeFirstNameById 13, ''

BEGIN TRY
	EXEC UpdateEmployeeFirstNameById 13, ''
END TRY
BEGIN CATCH
	PRINT 'Hata Olu�tu! Hata Mesaj�: ' + ERROR_MESSAGE()
END CATCH