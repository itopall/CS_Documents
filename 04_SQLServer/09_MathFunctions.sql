
--4 ��lem
SELECT 5 * 2 Carpim
SELECT 5 / 2 Bolum
SELECT 5 + 2 Toplam
SELECT 5 - 2 Fark

--PI Say�s�
SELECT PI()

--SQRT fonksiyonu ile karek�k alabiliriz
SELECT SQRT(9)

--POWER fonksiyonuyla say�n�n kuvvetini alabiliriz
SELECT POWER(5, 3)

--SQUARE fonksiyonu ile kare alabiliriz.
SELECT SQUARE(4)

--ABS fonksiyonu ile mutlak de�eri elde edebiliriz.
SELECT ABS(-100)

--FLOOR ile ondal�kl� bir say�n�n tam say� k�sm�n� alabiliriz
SELECT FLOOR(PI())
SELECT FLOOR(10.60)

--CEILING ile ondal�kl� bir say�y� yukar� yuvarlama i�lemi yapabiliriz.
SELECT CEILING(10.2)

--ROUND ile �ok detayl� yuvarlama i�lemleri yap�labilir.
SELECT ROUND(456.45, 1)		--456.50
SELECT ROUND(456.45, 0)		--456.00
SELECT ROUND(456.45, -1)	--460.00
SELECT ROUND(456.45, -2)	--500.00
SELECT ROUND(456.45, -3)	--Hata! Yuvarlanacak rakam kalmad�

SELECT RAND()
SELECT RAND(20) --20'ye kar��l�k gelen ondal�kl� bir de�er �retir
SELECT CEILING(RAND() * 100)	--1 ile 100 aras�nda rastgele bir say� elde ettik