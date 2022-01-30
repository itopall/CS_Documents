--SELECT Syntax'ý
SELECT sütunlar FROM tabloAdi

--Tablodaki bütün sütunlarý getirir
SELECT * FROM Customers

--Sadece bazý sütunlarýn gelmesi istenirse aþaðýdaki gibi virgülle sütun adlarý belirtilerek alýnabilir.
SELECT CompanyName, ContactName FROM Customers

--Sütun adlarýnýn farklý görünmesi istenirse Alias tanýmlanabilir. Eðer birden fazla kelimeden oluþan bir alias tanýmlamak istenirse [] içerisinde kullanmak zorunludur. Alias'larýn içerisinde TR karakter kullanýlabilir.
SELECT CompanyName AS ÞirketAdý, ContactName [Ýletiþim Kurulacak Kiþi] FROM Customers


--Filtrelemek için WHERE kriterleri kullanýlýr
SELECT * FROM Employees WHERE LastName = 'Fuller'
SELECT * FROM Orders WHERE ShipCountry = 'Germany'
SELECT CustomerId FROM Orders WHERE ShipCountry = 'Germany'
SELECT * FROM Orders WHERE ShipCountry != 'Germany'
SELECT * FROM Orders WHERE ShipCountry <> 'Germany'

--Birden fazla kriter girebilmek için AND keyword'ü kullanýlýr
SELECT * FROM [Order Details] WHERE UnitPrice > 10 AND UnitPrice < 50
SELECT * FROM [Order Details] WHERE UnitPrice >= 10 AND UnitPrice <= 50

--BETWEEN ile iki deðer arasýndaki sonuçlar alýnabilir
SELECT * FROM [Order Details] WHERE UnitPrice BETWEEN 10 AND 50

--NOT keyword'ü ile belirtilen kriter'in dýþýnda kalan deðerler alýnabilir.
SELECT * FROM [Order Details] WHERE UnitPrice NOT BETWEEN 10 AND 50

--OR Kullanýmý, birden fazla deðeri ayný anda sorgulamak istiyorsak kullanýlabilir
SELECT * FROM Customers WHERE City = 'Berlin' OR City = 'México D.F.' OR City = 'London'

--In Kullanýmý: OR ile ayný iþi yapan daha kýsa bir yöntemdir.
SELECT * FROM Customers WHERE City IN ('Berlin', 'México D.F.', 'London')
SELECT * FROM Products WHERE ProductId IN (3, 5, 10)

--null sorgulamasý yapýlýrken = ile kullanýrsak sonuç alamayýz!
SELECT * FROM Customers WHERE Region = null

--is null keyword'ü kullanýlarak null kayýtlar elde edilebilir.
SELECT * FROM Customers WHERE Region is null

--null olmayan kayýtlar
SELECT * FROM Customers WHERE Region is not null

--LIKE Kullanýmý
SELECT * FROM Products WHERE ProductName LIKE 'A%'		--A ile baþlayanlar
SELECT * FROM Products WHERE ProductName LIKE 'Alice%'	--Alice ile baþlayanlar
SELECT * FROM Products WHERE ProductName NOT LIKE 'A%'	--A ile baþlamayanlar
SELECT * FROM Products WHERE ProductName LIKE '%A'		--A ile bitenler
SELECT * FROM Products WHERE ProductName LIKE '%URA'	--URA ile bitenler
SELECT * FROM Products WHERE ProductName LIKE '%A%'		--Ýçerisinde A geçenler
SELECT * FROM Products WHERE ProductName LIKE '%AN%'	--Ýçerisinde AN geçenler
SELECT * FROM Products WHERE ProductName LIKE 'C%G'		--C ile baþlayýp G ile bitenler
SELECT * FROM Products WHERE ProductName LIKE '[AB]%'	--A veya B ile baþlayanlar
SELECT * FROM Products WHERE ProductName LIKE '[A-F]%'	--A'dan F'ye kadar olan harflerden biri ile baþlayanlar
SELECT * FROM Products WHERE ProductName LIKE '[^A-F]%'	--A'dan F'ye kadar olan harflerden biri ile baþlamayanlar
SELECT * FROM Products WHERE ProductName LIKE '__A%'	--3. harfi A olanlar


--ORDER BY Kullanýmý
SELECT * FROM Products ORDER BY ProductName						--ProductName'e göre artan sýralama yapar (ASC)
SELECT * FROM Products ORDER BY ProductName ASC					--Yukarýdaki satýrla ayný iþi yapar
SELECT * FROM Products ORDER BY ProductName DESC				--ProductName'e göre azalan sýralama yapar (DESC)
SELECT * FROM Products ORDER BY UnitPrice						--UnitPrice'a göre artan sýralama yapar
SELECT * FROM Products ORDER BY UnitPrice DESC					--UnitPrice'a göre azalan sýralama yapar
SELECT * FROM Products ORDER BY 3								--Sütun numarasýna göre sýralama
SELECT * FROM Products ORDER BY SupplierId, ProductName			--Önce SupplierId sonra ProductName'e göre sýralama
SELECT * FROM Products ORDER BY SupplierId, ProductName	DESC	--Önce SupplierId ASC olarak sonra ProductName DESC olarak sýralama
