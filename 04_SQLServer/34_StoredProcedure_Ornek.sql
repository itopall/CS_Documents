
--�RNEKLER
--1) Parametre olarak ald��� iki tarih aral���ndaki sat��lar� Sat�sId ve M��teriId baz�nda d�nen SP'yi yazal�m.
--Result: OrderId, CustomerID

CREATE PROC GetOrdersByDate(@startDate DATETIME, @endDate DATETIME)
AS
SELECT OrderId, CustomerID FROM Orders WHERE OrderDate BETWEEN @startDate AND @endDate

EXEC GetOrdersByDate '1996-01-01', '1997-01-01'


--2) Parametre olarak ald��� FirstName ve Id de�erleri ile Employee tablosundaki ilgili kayd� Update eden SP'yi yazal�m.



--3) Hangi tedarik�iden hangi �r�n�n temin edildi�ini d�nen SP'yi yazal�m (CompanyName, ProductName)



--4) Parametre olarak ald��� FirstName, LastName ve EmployeeId de�erleri ile Employes tablosuna yeni bir kay�t ekleyen ve yeni �retilen EmployeeId de�erini OUTPUT olarak geri d�n�p ekrana yazd�ran SP'yi yazal�m
--Yeni �retilen Id de�erini elde etmek i�in: @@IDENTITY 'den d�nen de�eri bir de�i�kene aktarabiliriz.



--5) Parametre olarak ald��� ProductId'ye ait �r�n� silen SP'yi yazal�m.