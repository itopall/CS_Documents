
--LEN fonksiyonu bir string i�indeki karakter say�s�n� verir
SELECT LEN('Deneme')
SELECT LEN(ProductName), ProductName FROM Products

--REVERSE fonksiyonu bir string de�eri ters �evirip sonucunu verir
SELECT REVERSE('Sql Server')
SELECT REVERSE(ProductName), ProductName FROM Products

--REPLACE fonksiyonu bir string i�erisindeki de�erin bir b�l�m�n ba�ka bir string ile de�i�tirilmesini sa�lar
SELECT REPLACE('deneme@gmail.com', 'gmail', 'hotmail')

--SUBSTRING fonksiyonu string i�erisinde bir b�l�m� ayr��t�r�p elde etmemizi sa�lar. 5. karakterden itibaren 3 karakter al
SELECT SUBSTRING('ali ata bak', 5, 3)

--LEFT/RIGHT sol'dan ve sa�dan ilk 3 harfi elde etmeyi sa�lar.
SELECT LEFT('Monitor', 3)
SELECT RIGHT('Monitor', 3)

--UPPER ve LOWER fonksiyonlar� bir string'in t�m harflerini k���k ya da b�y�k yapmam�z� sa�lar.
SELECT UPPER('asdasdasd')
SELECT LOWER('ASDASDASD')

--TRIM fonksiyonlar� SOL ya da SA� taraftan string i�indeki bo�luklar�n temizlenmesini sa�lar
SELECT LTRIM('     asdasd      ')
SELECT RTRIM('     asdasd      ')
SELECT RTRIM(LTRIM('     asdasd      '))		--Fonksiyonlar i� i�e kullan�labilir, �nce i�erdeki fonksiyon �al���r
SELECT LEN(RTRIM(LTRIM('     asdasd      ')))

--ASCII fonksiyonu bir karakterin ascii kodunu verir
SELECT ASCII('A')

--CHAR fonksiyonu Ascii kodunun karakter kar��l���n� verir
SELECT CHAR(65)

--CHARINDEX fonksiyonu bir karakterin bir string i�inde ilk ge�ti�i s�ray� verir, A karakterinin a�a��da ilk ge�ti�i yer 4 olarak gelir.
SELECT CHARINDEX('A', 'GFDADSFGDFG')

--DIFFERENCE fonksiyonu string'lerin benzerli�ine g�re 0-4 aras�nda bir de�er d�ner. Benze�me y�ksekse y�ksek sonu� verir.
SELECT DIFFERENCE('ABCDEF', 'A')
SELECT DIFFERENCE('ABCDEF', 'AB')
SELECT DIFFERENCE('ABCDEF', 'ABC')
SELECT DIFFERENCE('ABCDEF', 'ABCD')
SELECT DIFFERENCE('ABCDEF', 'ABCDE')
SELECT DIFFERENCE('ABCDEF', 'ABCDEF')
SELECT DIFFERENCE('ABCDEF', 'RT')

--SOUNDEX fonksiyonu girilen string'lerin foneti�ine (telaffuzuna) g�re bir puan �reterek birbirine yak�n olan kelimeleri bulmaya yarar.
SELECT SOUNDEX('Be�ikta�')
SELECT * FROM Products WHERE SOUNDEX(ProductName) = SOUNDEX('top')
SELECT * FROM Products WHERE SOUNDEX(ProductName) = SOUNDEX('winners')