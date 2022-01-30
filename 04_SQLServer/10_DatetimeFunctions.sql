
--GETDATE fonksiyonu SQL sunucusunun çalýþtýðý bilgisayarýn tarih ve saatini verir.
SELECT GETDATE()

--DATEADD fonksiyonu, bir tarihe belirli bir cinsten (gün, ay) ekleme yapmamýzý saðlar
--Negatif sayýsal deðerler verilerek tarihten çýkarma iþlemi yapabiliriz.
SELECT DATEADD(m, 5, GETDATE())
SELECT DATEADD(m, -5, GETDATE())
SELECT DATEADD(d, 5, GETDATE())
SELECT DATEADD(d, -5, GETDATE())

--DATEDIFF fonksiyonu iki tarih arasýndaki farký verir.
SELECT DATEDIFF(yy, '01.01.2000', GETDATE()) --20 yýl
SELECT DATEDIFF(mm, '01.01.2000', GETDATE()) --247 ay

--DATENAME fonksiyonu ay adýný döner
SELECT DATENAME(m, GETDATE())

--DATEPART fonksiyonu bir tarih içinden belli bir bölümü elde etmemizi saðlar
SELECT DATEPART(yy, GETDATE())
SELECT DATEPART(mm, GETDATE())

--YEAR, MONTH ve DAY fonksiyonlarý rakamsal olarak ilgili deðerleri dönerler
SELECT YEAR(GETDATE())
SELECT MONTH(GETDATE())
SELECT DAY(GETDATE())

--DayOfWeek: Haftanýn gününü rakamsal olarak döner
SELECT DATEPART(dw, GETDATE())