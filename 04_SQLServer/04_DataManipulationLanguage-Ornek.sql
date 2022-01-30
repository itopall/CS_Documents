--01) Northwnd db'sindeki Employees tablosuna kendi bilgilerinizle yeni bir kayýt oluþturunuz.
INSERT INTO Employees (LastName, FirstName) VALUES ('Ak', 'Hasan')
INSERT INTO Employees VALUES ('Yücel', 'Hasan Ali', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)

--02) Products tablosuna Apple IMac adýnda fiyatý 20000 olacak þekilde yeni bir ürün tanýmlayalým.
INSERT INTO Products (ProductName, UnitPrice, Discontinued) VALUES ('Apple IMac', 20000, 1)
INSERT INTO Products VALUES ('Iphone', null, null, null, 2000, null, null, null, 0, null)

--03) Customers tablosuna yeni bir müþteri kaydý ekleyelim
INSERT INTO Customers (CustomerId, CompanyName) VALUES ('MCSD', 'Yazýlým Sýnýfý')
INSERT INTO Customers VALUES ('MCSD2', 'Yazýlým Sýnýfý 2', null, null, null, null, null, null, null, null, null)

--04) Suppliers tablosuna yeni bir tedarikçi ekleyelim.
INSERT INTO Suppliers (CompanyName) VALUES ('Test Tedarikçisi')
INSERT INTO Suppliers VALUES ('Yeni Tedarikçi', null, null, null, null, null, null, null, null, null, null)



--05) Customers tablosuna yeni eklediðimiz kaydýn Telefon numarasýný 1234567890, adresini Ýstanbul/Beþiktaþ olarak güncelleyelim.
UPDATE Customers SET Phone = '1234567890', Address = 'Ýstanbul/Beþiktaþ' WHERE CustomerId = 'MCSD'

--06) Suppliers tablosuna yeklediðimiz tedarikçinin telefon numarasýný diðerleriyle ayný formatta olacak þekilde update edelim.
UPDATE Suppliers SET Phone = '(530) 123-4567' WHERE SupplierId = 33

--07) Order Details tablosundaki OrderId'si 10248 olan satýþa ait 42 Id'li ürünün quantity deðerini 5, UnitPrice deðerini 11 olacak þekilde update edelim.
UPDATE [Order Details] SET UnitPrice = 11, Quantity = 5 WHERE OrderId = 10248 AND ProductId = 42

--08) Suppliers tablosundaki ilk 29 kaydýn dýþýndaki diðer tüm kayýtlarý silelim
DELETE FROM Suppliers WHERE SupplierID > 29

--09) Customers tablosuna yeni eklenen MCSD ve MCSD2 kayýtlarýný silelim
DELETE FROM Customers WHERE CustomerId = 'MCSD' OR CustomerId = 'MSCD2' 
DELETE FROM Customers WHERE CustomerId IN ('MCSD', 'MCSD2')

--10) Customer tablosundaki FRANK kodlu müþteriyi silelim
DELETE FROM Customers WHERE CustomerId = 'FRANK' --Relation'dan dolayý silmeye izin verilmedi! Bu müþterinin Orders tablosunda satýþ kayýtlarý mevcut, o kayýtlar temizlenmeden Customers tablosundan bu kayýt silinemez!

--Orders tablosundaki iliþkili kayýtlarý update ettik, FRANK'e baðlý kayýt kalmadý
UPDATE Orders SET CustomerId = null WHERE CustomerId = 'FRANK' 
DELETE FROM Customers WHERE CustomerId = 'FRANK' --Artýk silme yapýlabilir
