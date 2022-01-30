
--1) IF ELSE

--�r�n tablosundaki �r�nlerin say�s� �ift ise "�ifttir" de�il ise "Tekdir" yazd�ral�m
DECLARE @productCount INT
SELECT @productCount = COUNT(*) FROM Products
PRINT @productCount

--PRINT ile yazd�r�lan bilgi Result Set'in yan�nda Messages k�sm�nda g�r�lebilir.
--IF-ELSE bloklar� i�erisinde tek sat�r i�lem yap�lacaksa ekstra bir i�lem yapmaya gerek kalmadan direkt yaz�labilir aksi halde BEGIN-END bloklar� kullan�lmas� gerekir.
--IF (@productCount % 2 = 1)
--	PRINT 'Tekdir'
--ELSE
--	PRINT '�ifttir'


--�ki sat�r i�lem yap�ld��� i�in BEGIN-END kullan�ld�.
--IF (@productCount % 2 = 1)
--	BEGIN
--		PRINT 'Tekdir'
--		PRINT 'Test'
--	END
--ELSE
--	BEGIN
--		PRINT '�ifttir'
--		PRINT 'Test'
--	END


--�kiden fazla ko�ul kullanma
IF (@productCount % 4 = 1)
	PRINT 'Kalan 1''dir'
ELSE IF (@productCount % 4 = 2)
	PRINT 'Kalan 2''dir'
ELSE IF (@productCount % 4 = 3)
	PRINT 'Kalan 3''dir'
ELSE
	PRINT 'Kalan yok'


--2) CASE-WHEN

--�r�nleri fiyat aral���na g�re * ile s�n�fland�ran sorguyu yazal�m
--ELSE: IF ELSE'de oldu�u gibi case'lerin hi�biri ko�ulu kar��lam�yorsa direkt else k�sm�na d��er
SELECT
	ProductId,
	ProductName,
	UnitPrice,
	CASE
		WHEN UnitPrice BETWEEN 0 AND 10 THEN '*'
		WHEN UnitPrice BETWEEN 11 AND 20 THEN '**'
		WHEN UnitPrice BETWEEN 21 AND 30 THEN '***'
		WHEN UnitPrice BETWEEN 31 AND 40 THEN '****'
		WHEN UnitPrice > 41 THEN '*****'
		ELSE 'Fiyat Tan�mlanmam��'
	END Puan
FROM
	Products


--�RNEKLER
--1) Sat��lar�n say�s� 500'den fazla m� az m� oldu�unu bulup ekrana yazd�ran sorguyu yazal�m.
DECLARE @count INT
SELECT @count = COUNT(*) FROM Orders
PRINT @count

IF(@count > 500)
	PRINT '500''den fazla'
ELSE
	PRINT '500''den az'

--2) �al��anlar�n do�um g�nlerini ve o g�n do�an �al��an say�s�n� veren sorguyu yazal�m
--DATEART(dw, Tarih)
--Ekran ��kt�s�;
--Pazartesi, 3
--�ar�amba, 2
SELECT 
	COUNT(*) KisiSayisi,
	CASE
		WHEN DATEPART(dw, BirthDate) = 1 THEN 'Pazar'
		WHEN DATEPART(dw, BirthDate) = 2 THEN 'Pazartesi'
		WHEN DATEPART(dw, BirthDate) = 3 THEN 'Sal�'
		WHEN DATEPART(dw, BirthDate) = 4 THEN '�ar�amba'
		WHEN DATEPART(dw, BirthDate) = 5 THEN 'Per�embe'
		WHEN DATEPART(dw, BirthDate) = 6 THEN 'Cuma'
		WHEN DATEPART(dw, BirthDate) = 7 THEN 'Cumartesi'
	END Gun
FROM
	Employees
GROUP BY
	DATEPART(dw, BirthDate)