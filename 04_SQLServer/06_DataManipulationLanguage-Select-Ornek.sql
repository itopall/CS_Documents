--01) London'da olan ve þirketin adý A harfi ile baþlayan müþterileri listeleyelim.
SELECT * FROM Customers WHERE City = 'London' AND CompanyName LIKE 'A%'

--02) Mexico'da bulunan ve Iletisim kurulan kiþinin Owner olduðu müþterileri listeleyelim.
SELECT * FROM Customers WHERE Country = 'Mexico' AND ContactTitle = 'Owner'

--03) Territories tablosundaki RegionId deðeri 1 ve 2 (Eastern, Western) olan bölgeleri getiren sorguyu yazalým
SELECT * FROM Territories WHERE RegionId = 1 OR RegionId = 2
SELECT * FROM Territories WHERE RegionId IN (1,2)

--4) Satýþ Detaylardaki satýþ fiyatý 5 ile 10 arasýnda olan satýþlarý listeleyelim.
SELECT * FROM [Order Details] WHERE UnitPrice >= 5 AND UnitPrice <= 10
SELECT * FROM [Order Details] WHERE UnitPrice BETWEEN 5 AND 10

--5) Customers tablosundaki müþterileri CompanyName ya da ContactName alanlarýna göre girilen kelimenin içerisinde geçen kayýtlarý getiren sorguyu yazalým
SELECT * FROM Customers WHERE CompanyName LIKE '%or%' OR ContactName LIKE '%or%'