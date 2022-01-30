
--Cast ve Convert: Tip d�n���mleri i�in kullan�lan fonksiyonlard�r.

--E�er string'in i�indeki de�er say� ise her iki tarafta da number varm�� gibi d���nerek toplama i�lemi yapar
SELECT 5 + '5'
SELECT 10 + '10'
SELECT '20' + 20

--String'in i�erisinde rakam d���nda karakter varsa hata verir
SELECT 30 + '30a'

--Her iki tarafta da string varsa metin birle�tirme i�lemi yapar.
SELECT '5' + '5'
SELECT 'test' + 'deneme'


--CAST Kullan�m�
SELECT CAST('10' AS INT) + 20
SELECT CAST(10 AS NVARCHAR) + '20'
SELECT CAST('2020-08-29' AS DATE)
SELECT DATEADD(d, 3, CAST('2020-08-29' AS DATE))

SELECT CAST(ProductId AS NVARCHAR) + ' - ' + ProductName FROM Products


--CONVERT Kullan�m�
SELECT CONVERT(INT, '10') + 20
SELECT CONVERT(NVARCHAR, 10) + '20'
SELECT CONVERT(DATE, '2020-08-29')
SELECT DATEADD(d, 3, CONVERT(DATE, '2020-08-29'))

SELECT CONVERT(NVARCHAR, ProductId) + ' - ' + ProductName FROM Products

SELECT CONVERT(NVARCHAR, GETDATE(), 101) --Convert'de formatlama i�lemi yapabiliriz.
SELECT CONVERT(NVARCHAR, GETDATE(), 102)
SELECT CONVERT(NVARCHAR, GETDATE(), 111)