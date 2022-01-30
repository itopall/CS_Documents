--01) Northwnd db'sindeki Employees tablosuna kendi bilgilerinizle yeni bir kay�t olu�turunuz.
INSERT INTO Employees (LastName, FirstName) VALUES ('Ak', 'Hasan')
INSERT INTO Employees VALUES ('Y�cel', 'Hasan Ali', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)

--02) Products tablosuna Apple IMac ad�nda fiyat� 20000 olacak �ekilde yeni bir �r�n tan�mlayal�m.
INSERT INTO Products (ProductName, UnitPrice, Discontinued) VALUES ('Apple IMac', 20000, 1)
INSERT INTO Products VALUES ('Iphone', null, null, null, 2000, null, null, null, 0, null)

--03) Customers tablosuna yeni bir m��teri kayd� ekleyelim
INSERT INTO Customers (CustomerId, CompanyName) VALUES ('MCSD', 'Yaz�l�m S�n�f�')
INSERT INTO Customers VALUES ('MCSD2', 'Yaz�l�m S�n�f� 2', null, null, null, null, null, null, null, null, null)

--04) Suppliers tablosuna yeni bir tedarik�i ekleyelim.
INSERT INTO Suppliers (CompanyName) VALUES ('Test Tedarik�isi')
INSERT INTO Suppliers VALUES ('Yeni Tedarik�i', null, null, null, null, null, null, null, null, null, null)



--05) Customers tablosuna yeni ekledi�imiz kayd�n Telefon numaras�n� 1234567890, adresini �stanbul/Be�ikta� olarak g�ncelleyelim.
UPDATE Customers SET Phone = '1234567890', Address = '�stanbul/Be�ikta�' WHERE CustomerId = 'MCSD'

--06) Suppliers tablosuna yekledi�imiz tedarik�inin telefon numaras�n� di�erleriyle ayn� formatta olacak �ekilde update edelim.
UPDATE Suppliers SET Phone = '(530) 123-4567' WHERE SupplierId = 33

--07) Order Details tablosundaki OrderId'si 10248 olan sat��a ait 42 Id'li �r�n�n quantity de�erini 5, UnitPrice de�erini 11 olacak �ekilde update edelim.
UPDATE [Order Details] SET UnitPrice = 11, Quantity = 5 WHERE OrderId = 10248 AND ProductId = 42

--08) Suppliers tablosundaki ilk 29 kayd�n d���ndaki di�er t�m kay�tlar� silelim
DELETE FROM Suppliers WHERE SupplierID > 29

--09) Customers tablosuna yeni eklenen MCSD ve MCSD2 kay�tlar�n� silelim
DELETE FROM Customers WHERE CustomerId = 'MCSD' OR CustomerId = 'MSCD2' 
DELETE FROM Customers WHERE CustomerId IN ('MCSD', 'MCSD2')

--10) Customer tablosundaki FRANK kodlu m��teriyi silelim
DELETE FROM Customers WHERE CustomerId = 'FRANK' --Relation'dan dolay� silmeye izin verilmedi! Bu m��terinin Orders tablosunda sat�� kay�tlar� mevcut, o kay�tlar temizlenmeden Customers tablosundan bu kay�t silinemez!

--Orders tablosundaki ili�kili kay�tlar� update ettik, FRANK'e ba�l� kay�t kalmad�
UPDATE Orders SET CustomerId = null WHERE CustomerId = 'FRANK' 
DELETE FROM Customers WHERE CustomerId = 'FRANK' --Art�k silme yap�labilir
