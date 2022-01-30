
--LEN fonksiyonu bir string içindeki karakter sayýsýný verir
SELECT LEN('Deneme')
SELECT LEN(ProductName), ProductName FROM Products

--REVERSE fonksiyonu bir string deðeri ters çevirip sonucunu verir
SELECT REVERSE('Sql Server')
SELECT REVERSE(ProductName), ProductName FROM Products

--REPLACE fonksiyonu bir string içerisindeki deðerin bir bölümün baþka bir string ile deðiþtirilmesini saðlar
SELECT REPLACE('deneme@gmail.com', 'gmail', 'hotmail')

--SUBSTRING fonksiyonu string içerisinde bir bölümü ayrýþtýrýp elde etmemizi saðlar. 5. karakterden itibaren 3 karakter al
SELECT SUBSTRING('ali ata bak', 5, 3)

--LEFT/RIGHT sol'dan ve saðdan ilk 3 harfi elde etmeyi saðlar.
SELECT LEFT('Monitor', 3)
SELECT RIGHT('Monitor', 3)

--UPPER ve LOWER fonksiyonlarý bir string'in tüm harflerini küçük ya da büyük yapmamýzý saðlar.
SELECT UPPER('asdasdasd')
SELECT LOWER('ASDASDASD')

--TRIM fonksiyonlarý SOL ya da SAÐ taraftan string içindeki boþluklarýn temizlenmesini saðlar
SELECT LTRIM('     asdasd      ')
SELECT RTRIM('     asdasd      ')
SELECT RTRIM(LTRIM('     asdasd      '))		--Fonksiyonlar iç içe kullanýlabilir, önce içerdeki fonksiyon çalýþýr
SELECT LEN(RTRIM(LTRIM('     asdasd      ')))

--ASCII fonksiyonu bir karakterin ascii kodunu verir
SELECT ASCII('A')

--CHAR fonksiyonu Ascii kodunun karakter karþýlýðýný verir
SELECT CHAR(65)

--CHARINDEX fonksiyonu bir karakterin bir string içinde ilk geçtiði sýrayý verir, A karakterinin aþaðýda ilk geçtiði yer 4 olarak gelir.
SELECT CHARINDEX('A', 'GFDADSFGDFG')

--DIFFERENCE fonksiyonu string'lerin benzerliðine göre 0-4 arasýnda bir deðer döner. Benzeþme yüksekse yüksek sonuç verir.
SELECT DIFFERENCE('ABCDEF', 'A')
SELECT DIFFERENCE('ABCDEF', 'AB')
SELECT DIFFERENCE('ABCDEF', 'ABC')
SELECT DIFFERENCE('ABCDEF', 'ABCD')
SELECT DIFFERENCE('ABCDEF', 'ABCDE')
SELECT DIFFERENCE('ABCDEF', 'ABCDEF')
SELECT DIFFERENCE('ABCDEF', 'RT')

--SOUNDEX fonksiyonu girilen string'lerin fonetiðine (telaffuzuna) göre bir puan üreterek birbirine yakýn olan kelimeleri bulmaya yarar.
SELECT SOUNDEX('Beþiktaþ')
SELECT * FROM Products WHERE SOUNDEX(ProductName) = SOUNDEX('top')
SELECT * FROM Products WHERE SOUNDEX(ProductName) = SOUNDEX('winners')