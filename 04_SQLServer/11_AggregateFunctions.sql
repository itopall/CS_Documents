--Aggregate Functions

--COUNT fonksiyonu, adet bilgisini verir
SELECT COUNT(*) FROM Products
SELECT COUNT(ProductId) FROM Products
SELECT COUNT(CategoryId) FROM Products --CateoryId deðeri null olan kayýtlar olduðu için farklý sonuç verdi

--MAX ve MIN fonksiyonlarý, aratýlan sütun için tablodaki en büyük ve en küçük deðeri getirir.
SELECT MAX(UnitPrice) FROM [Order Details]
SELECT MIN(UnitPrice) FROM [Order Details]

--SUM fonksiyonu, aratýlan sütun için toplam deðeri verir
SELECT SUM(UnitPrice) FROM [Order Details]

--AVG fonksiyonu, aratýlan sütun için ortalama deðeri verir
SELECT AVG(UnitPrice) FROM [Order Details]

--HATA!! Aþaðýdaki þekilde sorguyu yazarsak hata ile karþýlaþýrýz. Aggregate function'larýn yanýnda baþka sütun da select edilmek istenirse, o sütunlarýn gruplanmasý zorunludur.
SELECT SUM(UnitPrice), CategoryId FROM Products

--Gruplanmadýðý takdirde aþaðýdaki gibi Sum sütunu tek bir deðer dönerken CategoryId sütunu birden fazla deðer döner ve sql bu verileri tek bir sorguda birleþtiremez!
SUM		CategoryId
1000	Bilgisayar
		Tekstil
		Gýda

--Grupladýðýmýz zaman ise Sql veriyi gruplanan alana göre kýrmasý gerektiðini anlar ve aþaðýdaki gibi sonuçlarý CategoryId'ye göre bölerek gösterir.
SUM		CategoryId
300		Bilgisayar
400		Tekstil
300		Gýda


