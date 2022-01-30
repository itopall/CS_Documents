
--Cast ve Convert: Tip dönüþümleri için kullanýlan fonksiyonlardýr.

--Eðer string'in içindeki deðer sayý ise her iki tarafta da number varmýþ gibi düþünerek toplama iþlemi yapar
SELECT 5 + '5'
SELECT 10 + '10'
SELECT '20' + 20

--String'in içerisinde rakam dýþýnda karakter varsa hata verir
SELECT 30 + '30a'

--Her iki tarafta da string varsa metin birleþtirme iþlemi yapar.
SELECT '5' + '5'
SELECT 'test' + 'deneme'


--CAST Kullanýmý
SELECT CAST('10' AS INT) + 20
SELECT CAST(10 AS NVARCHAR) + '20'
SELECT CAST('2020-08-29' AS DATE)
SELECT DATEADD(d, 3, CAST('2020-08-29' AS DATE))

SELECT CAST(ProductId AS NVARCHAR) + ' - ' + ProductName FROM Products


--CONVERT Kullanýmý
SELECT CONVERT(INT, '10') + 20
SELECT CONVERT(NVARCHAR, 10) + '20'
SELECT CONVERT(DATE, '2020-08-29')
SELECT DATEADD(d, 3, CONVERT(DATE, '2020-08-29'))

SELECT CONVERT(NVARCHAR, ProductId) + ' - ' + ProductName FROM Products

SELECT CONVERT(NVARCHAR, GETDATE(), 101) --Convert'de formatlama iþlemi yapabiliriz.
SELECT CONVERT(NVARCHAR, GETDATE(), 102)
SELECT CONVERT(NVARCHAR, GETDATE(), 111)