
--WHILE DONGUSU
DECLARE @sayac INT
SET @sayac = 0

WHILE (@sayac < 10)
BEGIN
	SET @sayac = @sayac + 1

	--CONTINUE ile sayac 5 oldu�unda yazd�rmadan, sonraki ad�ma ge�mesini sa�lad�k
	IF(@sayac = 5)
		CONTINUE

	--BREAK ile sayac 8 oldu�unda d�ng�den ��k�lmas�n� sa�lad�k.
	IF(@sayac = 8)
		BREAK

	PRINT @sayac
END
PRINT 'D�ng�den ��k�ld�...'


--�RNEKLER

--1) Bir tane temp tablo olu�turup i�erisine 1'den 100'e kadar olan say�lar� insert edelim.
CREATE TABLE #WhileDongusuTest
(
	Sayi INT
)

DECLARE @sayac INT
SET @sayac = 0

WHILE (@sayac < 100)
BEGIN
	SET @sayac += 1
	
	INSERT INTO #WhileDongusuTest VALUES (@sayac)
END

SELECT * FROM #WhileDongusuTest