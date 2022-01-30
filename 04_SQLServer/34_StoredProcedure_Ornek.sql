
--ÖRNEKLER
--1) Parametre olarak aldýðý iki tarih aralýðýndaki satýþlarý SatýsId ve MüþteriId bazýnda dönen SP'yi yazalým.
--Result: OrderId, CustomerID

CREATE PROC GetOrdersByDate(@startDate DATETIME, @endDate DATETIME)
AS
SELECT OrderId, CustomerID FROM Orders WHERE OrderDate BETWEEN @startDate AND @endDate

EXEC GetOrdersByDate '1996-01-01', '1997-01-01'


--2) Parametre olarak aldýðý FirstName ve Id deðerleri ile Employee tablosundaki ilgili kaydý Update eden SP'yi yazalým.



--3) Hangi tedarikçiden hangi ürünün temin edildiðini dönen SP'yi yazalým (CompanyName, ProductName)



--4) Parametre olarak aldýðý FirstName, LastName ve EmployeeId deðerleri ile Employes tablosuna yeni bir kayýt ekleyen ve yeni üretilen EmployeeId deðerini OUTPUT olarak geri dönüp ekrana yazdýran SP'yi yazalým
--Yeni üretilen Id deðerini elde etmek için: @@IDENTITY 'den dönen deðeri bir deðiþkene aktarabiliriz.



--5) Parametre olarak aldýðý ProductId'ye ait ürünü silen SP'yi yazalým.