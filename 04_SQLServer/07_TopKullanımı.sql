--Top: Sonuç kümesinin içerisinden kaç tane kayýt dönmesini belirleyebileceðimiz komuttur.

--Tablodaki ilk 5 kaydý getirir.
SELECT TOP 5 * FROM Products

--En pahalý ürün
SELECT TOP 1 * FROM Products ORDER BY UnitPrice DESC

--En pahalý 5 ürün
SELECT TOP 5 * FROM Products ORDER BY UnitPrice DESC

--En pahalý 10 ürün
SELECT TOP 10 * FROM Products ORDER BY UnitPrice