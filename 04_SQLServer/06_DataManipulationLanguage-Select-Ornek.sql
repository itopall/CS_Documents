--01) London'da olan ve �irketin ad� A harfi ile ba�layan m��terileri listeleyelim.
SELECT * FROM Customers WHERE City = 'London' AND CompanyName LIKE 'A%'

--02) Mexico'da bulunan ve Iletisim kurulan ki�inin Owner oldu�u m��terileri listeleyelim.
SELECT * FROM Customers WHERE Country = 'Mexico' AND ContactTitle = 'Owner'

--03) Territories tablosundaki RegionId de�eri 1 ve 2 (Eastern, Western) olan b�lgeleri getiren sorguyu yazal�m
SELECT * FROM Territories WHERE RegionId = 1 OR RegionId = 2
SELECT * FROM Territories WHERE RegionId IN (1,2)

--4) Sat�� Detaylardaki sat�� fiyat� 5 ile 10 aras�nda olan sat��lar� listeleyelim.
SELECT * FROM [Order Details] WHERE UnitPrice >= 5 AND UnitPrice <= 10
SELECT * FROM [Order Details] WHERE UnitPrice BETWEEN 5 AND 10

--5) Customers tablosundaki m��terileri CompanyName ya da ContactName alanlar�na g�re girilen kelimenin i�erisinde ge�en kay�tlar� getiren sorguyu yazal�m
SELECT * FROM Customers WHERE CompanyName LIKE '%or%' OR ContactName LIKE '%or%'