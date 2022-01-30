
--Transaction: Veritaban�nda meydana gelen birden fazla i�in bir b�t�n olarak ele al�nmas�n� sa�layan yap�d�r. �rne�in bir sat���n ger�ekle�ebilmesi i�in Order Details yablosuna INSERT, Products tablosuna UPDATE yap�lmal�d�r. Ancak bu i�lemler birbirinden ba��ms�z ele al�n�rsa meydana gelebilecek bir hatada o ana kadar yap�lan i�lemler onaylan�r. K�sacas� Order Details'a INSERT yap�ld�ktan sonra UPDATE s�ras�nda problem meydana gelirse ORDER DETAILS'�n insert'� yap�lm�� olaca��ndan, �r�nde stok fazlas� olu�ur.
--Insert s�ras�nda problem gelmez, Update s�ras�nda problem olu�ursa Insert yap�lm�� olur.


--Order tablosuna INSERT
--Order Detail tablosuna INSERT
--Products tablosundaki stok say�s�n� azaltmak i�in UPDATE

--Ba�lat�lan bir transaction'un 2 sonucu olabilir:
--1) COMMIT: Transaction'da ger�ekle�en i�lemlerin onaylanmas� ve veritaban�na yans�t�lmas�n� sa�lar.
--2) ROLLBACK: Transaction'� iptal eder. O ana kadar yap�lan i�lemleri geri al�r.


SELECT * FROM Orders
SELECT * FROM [Order Details] WHERE OrderID = 10248
SELECT * FROM Products --29

BEGIN TRY
	BEGIN TRANSACTION --Transaction ba�lat�ld�.
		
		INSERT INTO [Order Details] VALUES (10248, 18, 62.50, 5, 0)

		RAISERROR('Hata olu�tu!', 12, 2) --�stteki insert girildikten sonra bilin�li olarak hata f�rlatt�k!

		UPDATE Products SET UnitsInStock = UnitsInStock - 5 WHERE ProductId = 16

	COMMIT --Hata yoksa transaction onayland� ve de�i�iklikler database'e yans�d�.
END TRY
BEGIN CATCH
	ROLLBACK --Herhangi bir varsa b�t�n i�lemleri geri al�r.
	PRINT ERROR_MESSAGE()
END CATCH	


--�RNEK
--Bir tane ProductStock tablosu olu�tural�m (Id, ProductId, Quantity)
--Bir tane PurchaseOrder tablosu olu�tural�m (Id, CustomerId, ProductId, Quantity)
--Herhangi bir �r�n i�in ProductStock tablosuna insert girelim Quantity = 100 olsun
--PurchaseOrder tablosuna ilgili �r�n i�in yeni bir kay�t girelim ve ayn� anda ProductStock tablosundaki quantity de�erini girilen miktar kadar azaltal�m.