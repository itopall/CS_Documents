
--4 Ýþlem
SELECT 5 * 2 Carpim
SELECT 5 / 2 Bolum
SELECT 5 + 2 Toplam
SELECT 5 - 2 Fark

--PI Sayýsý
SELECT PI()

--SQRT fonksiyonu ile karekök alabiliriz
SELECT SQRT(9)

--POWER fonksiyonuyla sayýnýn kuvvetini alabiliriz
SELECT POWER(5, 3)

--SQUARE fonksiyonu ile kare alabiliriz.
SELECT SQUARE(4)

--ABS fonksiyonu ile mutlak deðeri elde edebiliriz.
SELECT ABS(-100)

--FLOOR ile ondalýklý bir sayýnýn tam sayý kýsmýný alabiliriz
SELECT FLOOR(PI())
SELECT FLOOR(10.60)

--CEILING ile ondalýklý bir sayýyý yukarý yuvarlama iþlemi yapabiliriz.
SELECT CEILING(10.2)

--ROUND ile çok detaylý yuvarlama iþlemleri yapýlabilir.
SELECT ROUND(456.45, 1)		--456.50
SELECT ROUND(456.45, 0)		--456.00
SELECT ROUND(456.45, -1)	--460.00
SELECT ROUND(456.45, -2)	--500.00
SELECT ROUND(456.45, -3)	--Hata! Yuvarlanacak rakam kalmadý

SELECT RAND()
SELECT RAND(20) --20'ye karþýlýk gelen ondalýklý bir deðer üretir
SELECT CEILING(RAND() * 100)	--1 ile 100 arasýnda rastgele bir sayý elde ettik