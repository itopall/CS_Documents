
--Products tablosundaki herhangi bir ürünün kategori adýna ulaþabilmek için 2 farklý sorgu yazmak zorunda kaldýk!
SELECT * FROM Products
SELECT * FROM Categories WHERE CategoryId = 1

--JOIN kullanarak tek sorgu ile bu iþlemi gerçekleþtirebiliriz.

--Tek bir sorgu yazarak ProductName ve CategoryName bilgisini çektik!
--INNER JOIN sadece eþleþmesi saðlanan kayýtlarý getirir. CategoryId'si null kayýtlar result set'de gelmez
SELECT ProductName, CategoryName FROM Products
INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID


--LEFT JOIN Products tablosundaki bütün kayýtlarý getirir, CategoryId'si olmayanlarýn karþýsýna NULL yazar
SELECT ProductName, CategoryName FROM Products
LEFT JOIN Categories ON Categories.CategoryID = Products.CategoryID


--RIGHT JOIN Categories tablosundaki bütün kayýtlarý getirir, o categoryId'ye baðlý ürün yoksa karþýsýna NULL yazar.
SELECT ProductName, CategoryName FROM Products
RIGHT JOIN Categories ON Categories.CategoryID = Products.CategoryID


--FULL JOIN:  Left ve Rýght Join'in iþlemlerini birlikte yapmak için kullanýlýr
--Hem kategorisi olmayan ürünleri, hem de hiçbir ürüne baðlý olmayan kategorileri getirir.
SELECT ProductName, CategoryName FROM Products
FULL JOIN Categories ON Categories.CategoryID = Products.CategoryID


--CROSS JOIN: Her iki tablodaki bütün elemanlarý eþleþtirerek bir sonuç kümesi oluþturur.
SELECT ProductName, CategoryName FROM Products
CROSS JOIN Categories


--SELF JOIN: Kendi içerisinde ForeignKey baðlantýsý olan tablolarda kullanýlýr. Aslýnda yaptýðý iþ INNER ya da LEFT join kullanmaktýr. Aðaç yapýsý bulunan tablolardaki bilgilerin çekilmesi için kullanýlýr.
SELECT 
	e.FirstName,
	e.LastName, 
	em.FirstName + ' ' + em.LastName AS ManagerNameSurname
FROM
	Employees e
	LEFT JOIN Employees em ON em.EmployeeID = e.ReportsTo


--Bir sorguda birden fazla JOIN yazabiliriz. Join'ler INNER LEFT ve RIGHT olmak üzere farklý olabilirler
SELECT ProductName, CategoryName, CompanyName, ContactName FROM Products
INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID
INNER JOIN Suppliers ON Suppliers.SupplierID = Products.SupplierID


--Tablo adlarý için Alias tanýmlayabiliriz
SELECT p.ProductName, c.CategoryName, s.CompanyName FROM Products p
INNER JOIN Categories c ON c.CategoryID = p.CategoryID
INNER JOIN Suppliers s ON s.SupplierID = p.SupplierID