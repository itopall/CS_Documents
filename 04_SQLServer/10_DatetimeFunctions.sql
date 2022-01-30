
--GETDATE fonksiyonu SQL sunucusunun �al��t��� bilgisayar�n tarih ve saatini verir.
SELECT GETDATE()

--DATEADD fonksiyonu, bir tarihe belirli bir cinsten (g�n, ay) ekleme yapmam�z� sa�lar
--Negatif say�sal de�erler verilerek tarihten ��karma i�lemi yapabiliriz.
SELECT DATEADD(m, 5, GETDATE())
SELECT DATEADD(m, -5, GETDATE())
SELECT DATEADD(d, 5, GETDATE())
SELECT DATEADD(d, -5, GETDATE())

--DATEDIFF fonksiyonu iki tarih aras�ndaki fark� verir.
SELECT DATEDIFF(yy, '01.01.2000', GETDATE()) --20 y�l
SELECT DATEDIFF(mm, '01.01.2000', GETDATE()) --247 ay

--DATENAME fonksiyonu ay ad�n� d�ner
SELECT DATENAME(m, GETDATE())

--DATEPART fonksiyonu bir tarih i�inden belli bir b�l�m� elde etmemizi sa�lar
SELECT DATEPART(yy, GETDATE())
SELECT DATEPART(mm, GETDATE())

--YEAR, MONTH ve DAY fonksiyonlar� rakamsal olarak ilgili de�erleri d�nerler
SELECT YEAR(GETDATE())
SELECT MONTH(GETDATE())
SELECT DAY(GETDATE())

--DayOfWeek: Haftan�n g�n�n� rakamsal olarak d�ner
SELECT DATEPART(dw, GETDATE())