--Top: Sonu� k�mesinin i�erisinden ka� tane kay�t d�nmesini belirleyebilece�imiz komuttur.

--Tablodaki ilk 5 kayd� getirir.
SELECT TOP 5 * FROM Products

--En pahal� �r�n
SELECT TOP 1 * FROM Products ORDER BY UnitPrice DESC

--En pahal� 5 �r�n
SELECT TOP 5 * FROM Products ORDER BY UnitPrice DESC

--En pahal� 10 �r�n
SELECT TOP 10 * FROM Products ORDER BY UnitPrice