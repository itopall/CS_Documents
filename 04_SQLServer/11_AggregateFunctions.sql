--Aggregate Functions

--COUNT fonksiyonu, adet bilgisini verir
SELECT COUNT(*) FROM Products
SELECT COUNT(ProductId) FROM Products
SELECT COUNT(CategoryId) FROM Products --CateoryId de�eri null olan kay�tlar oldu�u i�in farkl� sonu� verdi

--MAX ve MIN fonksiyonlar�, arat�lan s�tun i�in tablodaki en b�y�k ve en k���k de�eri getirir.
SELECT MAX(UnitPrice) FROM [Order Details]
SELECT MIN(UnitPrice) FROM [Order Details]

--SUM fonksiyonu, arat�lan s�tun i�in toplam de�eri verir
SELECT SUM(UnitPrice) FROM [Order Details]

--AVG fonksiyonu, arat�lan s�tun i�in ortalama de�eri verir
SELECT AVG(UnitPrice) FROM [Order Details]

--HATA!! A�a��daki �ekilde sorguyu yazarsak hata ile kar��la��r�z. Aggregate function'lar�n yan�nda ba�ka s�tun da select edilmek istenirse, o s�tunlar�n gruplanmas� zorunludur.
SELECT SUM(UnitPrice), CategoryId FROM Products

--Gruplanmad��� takdirde a�a��daki gibi Sum s�tunu tek bir de�er d�nerken CategoryId s�tunu birden fazla de�er d�ner ve sql bu verileri tek bir sorguda birle�tiremez!
SUM		CategoryId
1000	Bilgisayar
		Tekstil
		G�da

--Gruplad���m�z zaman ise Sql veriyi gruplanan alana g�re k�rmas� gerekti�ini anlar ve a�a��daki gibi sonu�lar� CategoryId'ye g�re b�lerek g�sterir.
SUM		CategoryId
300		Bilgisayar
400		Tekstil
300		G�da


