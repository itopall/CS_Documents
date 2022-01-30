
--1) IF ELSE

--Ürün tablosundaki ürünlerin sayýsý çift ise "Çifttir" deðil ise "Tekdir" yazdýralým
DECLARE @productCount INT
SELECT @productCount = COUNT(*) FROM Products
PRINT @productCount

--PRINT ile yazdýrýlan bilgi Result Set'in yanýnda Messages kýsmýnda görülebilir.
--IF-ELSE bloklarý içerisinde tek satýr iþlem yapýlacaksa ekstra bir iþlem yapmaya gerek kalmadan direkt yazýlabilir aksi halde BEGIN-END bloklarý kullanýlmasý gerekir.
--IF (@productCount % 2 = 1)
--	PRINT 'Tekdir'
--ELSE
--	PRINT 'Çifttir'


--Ýki satýr iþlem yapýldýðý için BEGIN-END kullanýldý.
--IF (@productCount % 2 = 1)
--	BEGIN
--		PRINT 'Tekdir'
--		PRINT 'Test'
--	END
--ELSE
--	BEGIN
--		PRINT 'Çifttir'
--		PRINT 'Test'
--	END


--Ýkiden fazla koþul kullanma
IF (@productCount % 4 = 1)
	PRINT 'Kalan 1''dir'
ELSE IF (@productCount % 4 = 2)
	PRINT 'Kalan 2''dir'
ELSE IF (@productCount % 4 = 3)
	PRINT 'Kalan 3''dir'
ELSE
	PRINT 'Kalan yok'


--2) CASE-WHEN

--Ürünleri fiyat aralýðýna göre * ile sýnýflandýran sorguyu yazalým
--ELSE: IF ELSE'de olduðu gibi case'lerin hiçbiri koþulu karþýlamýyorsa direkt else kýsmýna düþer
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
		ELSE 'Fiyat Tanýmlanmamýþ'
	END Puan
FROM
	Products


--ÖRNEKLER
--1) Satýþlarýn sayýsý 500'den fazla mý az mý olduðunu bulup ekrana yazdýran sorguyu yazalým.
DECLARE @count INT
SELECT @count = COUNT(*) FROM Orders
PRINT @count

IF(@count > 500)
	PRINT '500''den fazla'
ELSE
	PRINT '500''den az'

--2) Çalýþanlarýn doðum günlerini ve o gün doðan çalýþan sayýsýný veren sorguyu yazalým
--DATEART(dw, Tarih)
--Ekran Çýktýsý;
--Pazartesi, 3
--Çarþamba, 2
SELECT 
	COUNT(*) KisiSayisi,
	CASE
		WHEN DATEPART(dw, BirthDate) = 1 THEN 'Pazar'
		WHEN DATEPART(dw, BirthDate) = 2 THEN 'Pazartesi'
		WHEN DATEPART(dw, BirthDate) = 3 THEN 'Salý'
		WHEN DATEPART(dw, BirthDate) = 4 THEN 'Çarþamba'
		WHEN DATEPART(dw, BirthDate) = 5 THEN 'Perþembe'
		WHEN DATEPART(dw, BirthDate) = 6 THEN 'Cuma'
		WHEN DATEPART(dw, BirthDate) = 7 THEN 'Cumartesi'
	END Gun
FROM
	Employees
GROUP BY
	DATEPART(dw, BirthDate)