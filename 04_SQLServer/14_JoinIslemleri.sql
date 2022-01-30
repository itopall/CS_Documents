
--Products tablosundaki herhangi bir �r�n�n kategori ad�na ula�abilmek i�in 2 farkl� sorgu yazmak zorunda kald�k!
SELECT * FROM Products
SELECT * FROM Categories WHERE CategoryId = 1

--JOIN kullanarak tek sorgu ile bu i�lemi ger�ekle�tirebiliriz.

--Tek bir sorgu yazarak ProductName ve CategoryName bilgisini �ektik!
--INNER JOIN sadece e�le�mesi sa�lanan kay�tlar� getirir. CategoryId'si null kay�tlar result set'de gelmez
SELECT ProductName, CategoryName FROM Products
INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID


--LEFT JOIN Products tablosundaki b�t�n kay�tlar� getirir, CategoryId'si olmayanlar�n kar��s�na NULL yazar
SELECT ProductName, CategoryName FROM Products
LEFT JOIN Categories ON Categories.CategoryID = Products.CategoryID


--RIGHT JOIN Categories tablosundaki b�t�n kay�tlar� getirir, o categoryId'ye ba�l� �r�n yoksa kar��s�na NULL yazar.
SELECT ProductName, CategoryName FROM Products
RIGHT JOIN Categories ON Categories.CategoryID = Products.CategoryID


--FULL JOIN:  Left ve R�ght Join'in i�lemlerini birlikte yapmak i�in kullan�l�r
--Hem kategorisi olmayan �r�nleri, hem de hi�bir �r�ne ba�l� olmayan kategorileri getirir.
SELECT ProductName, CategoryName FROM Products
FULL JOIN Categories ON Categories.CategoryID = Products.CategoryID


--CROSS JOIN: Her iki tablodaki b�t�n elemanlar� e�le�tirerek bir sonu� k�mesi olu�turur.
SELECT ProductName, CategoryName FROM Products
CROSS JOIN Categories


--SELF JOIN: Kendi i�erisinde ForeignKey ba�lant�s� olan tablolarda kullan�l�r. Asl�nda yapt��� i� INNER ya da LEFT join kullanmakt�r. A�a� yap�s� bulunan tablolardaki bilgilerin �ekilmesi i�in kullan�l�r.
SELECT 
	e.FirstName,
	e.LastName, 
	em.FirstName + ' ' + em.LastName AS ManagerNameSurname
FROM
	Employees e
	LEFT JOIN Employees em ON em.EmployeeID = e.ReportsTo


--Bir sorguda birden fazla JOIN yazabiliriz. Join'ler INNER LEFT ve RIGHT olmak �zere farkl� olabilirler
SELECT ProductName, CategoryName, CompanyName, ContactName FROM Products
INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID
INNER JOIN Suppliers ON Suppliers.SupplierID = Products.SupplierID


--Tablo adlar� i�in Alias tan�mlayabiliriz
SELECT p.ProductName, c.CategoryName, s.CompanyName FROM Products p
INNER JOIN Categories c ON c.CategoryID = p.CategoryID
INNER JOIN Suppliers s ON s.SupplierID = p.SupplierID