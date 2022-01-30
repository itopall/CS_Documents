--SELECT Syntax'�
SELECT s�tunlar FROM tabloAdi

--Tablodaki b�t�n s�tunlar� getirir
SELECT * FROM Customers

--Sadece baz� s�tunlar�n gelmesi istenirse a�a��daki gibi virg�lle s�tun adlar� belirtilerek al�nabilir.
SELECT CompanyName, ContactName FROM Customers

--S�tun adlar�n�n farkl� g�r�nmesi istenirse Alias tan�mlanabilir. E�er birden fazla kelimeden olu�an bir alias tan�mlamak istenirse [] i�erisinde kullanmak zorunludur. Alias'lar�n i�erisinde TR karakter kullan�labilir.
SELECT CompanyName AS �irketAd�, ContactName [�leti�im Kurulacak Ki�i] FROM Customers


--Filtrelemek i�in WHERE kriterleri kullan�l�r
SELECT * FROM Employees WHERE LastName = 'Fuller'
SELECT * FROM Orders WHERE ShipCountry = 'Germany'
SELECT CustomerId FROM Orders WHERE ShipCountry = 'Germany'
SELECT * FROM Orders WHERE ShipCountry != 'Germany'
SELECT * FROM Orders WHERE ShipCountry <> 'Germany'

--Birden fazla kriter girebilmek i�in AND keyword'� kullan�l�r
SELECT * FROM [Order Details] WHERE UnitPrice > 10 AND UnitPrice < 50
SELECT * FROM [Order Details] WHERE UnitPrice >= 10 AND UnitPrice <= 50

--BETWEEN ile iki de�er aras�ndaki sonu�lar al�nabilir
SELECT * FROM [Order Details] WHERE UnitPrice BETWEEN 10 AND 50

--NOT keyword'� ile belirtilen kriter'in d���nda kalan de�erler al�nabilir.
SELECT * FROM [Order Details] WHERE UnitPrice NOT BETWEEN 10 AND 50

--OR Kullan�m�, birden fazla de�eri ayn� anda sorgulamak istiyorsak kullan�labilir
SELECT * FROM Customers WHERE City = 'Berlin' OR City = 'M�xico D.F.' OR City = 'London'

--In Kullan�m�: OR ile ayn� i�i yapan daha k�sa bir y�ntemdir.
SELECT * FROM Customers WHERE City IN ('Berlin', 'M�xico D.F.', 'London')
SELECT * FROM Products WHERE ProductId IN (3, 5, 10)

--null sorgulamas� yap�l�rken = ile kullan�rsak sonu� alamay�z!
SELECT * FROM Customers WHERE Region = null

--is null keyword'� kullan�larak null kay�tlar elde edilebilir.
SELECT * FROM Customers WHERE Region is null

--null olmayan kay�tlar
SELECT * FROM Customers WHERE Region is not null

--LIKE Kullan�m�
SELECT * FROM Products WHERE ProductName LIKE 'A%'		--A ile ba�layanlar
SELECT * FROM Products WHERE ProductName LIKE 'Alice%'	--Alice ile ba�layanlar
SELECT * FROM Products WHERE ProductName NOT LIKE 'A%'	--A ile ba�lamayanlar
SELECT * FROM Products WHERE ProductName LIKE '%A'		--A ile bitenler
SELECT * FROM Products WHERE ProductName LIKE '%URA'	--URA ile bitenler
SELECT * FROM Products WHERE ProductName LIKE '%A%'		--��erisinde A ge�enler
SELECT * FROM Products WHERE ProductName LIKE '%AN%'	--��erisinde AN ge�enler
SELECT * FROM Products WHERE ProductName LIKE 'C%G'		--C ile ba�lay�p G ile bitenler
SELECT * FROM Products WHERE ProductName LIKE '[AB]%'	--A veya B ile ba�layanlar
SELECT * FROM Products WHERE ProductName LIKE '[A-F]%'	--A'dan F'ye kadar olan harflerden biri ile ba�layanlar
SELECT * FROM Products WHERE ProductName LIKE '[^A-F]%'	--A'dan F'ye kadar olan harflerden biri ile ba�lamayanlar
SELECT * FROM Products WHERE ProductName LIKE '__A%'	--3. harfi A olanlar


--ORDER BY Kullan�m�
SELECT * FROM Products ORDER BY ProductName						--ProductName'e g�re artan s�ralama yapar (ASC)
SELECT * FROM Products ORDER BY ProductName ASC					--Yukar�daki sat�rla ayn� i�i yapar
SELECT * FROM Products ORDER BY ProductName DESC				--ProductName'e g�re azalan s�ralama yapar (DESC)
SELECT * FROM Products ORDER BY UnitPrice						--UnitPrice'a g�re artan s�ralama yapar
SELECT * FROM Products ORDER BY UnitPrice DESC					--UnitPrice'a g�re azalan s�ralama yapar
SELECT * FROM Products ORDER BY 3								--S�tun numaras�na g�re s�ralama
SELECT * FROM Products ORDER BY SupplierId, ProductName			--�nce SupplierId sonra ProductName'e g�re s�ralama
SELECT * FROM Products ORDER BY SupplierId, ProductName	DESC	--�nce SupplierId ASC olarak sonra ProductName DESC olarak s�ralama
