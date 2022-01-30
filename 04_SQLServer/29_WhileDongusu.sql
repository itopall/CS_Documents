
--WHILE DONGUSU
DECLARE @sayac INT
SET @sayac = 0

WHILE (@sayac < 10)
BEGIN
	SET @sayac = @sayac + 1

	--CONTINUE ile sayac 5 olduðunda yazdýrmadan, sonraki adýma geçmesini saðladýk
	IF(@sayac = 5)
		CONTINUE

	--BREAK ile sayac 8 olduðunda döngüden çýkýlmasýný saðladýk.
	IF(@sayac = 8)
		BREAK

	PRINT @sayac
END
PRINT 'Döngüden çýkýldý...'


--ÖRNEKLER

--1) Bir tane temp tablo oluþturup içerisine 1'den 100'e kadar olan sayýlarý insert edelim.
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