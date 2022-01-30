
--UNION: 2 farkl� result set'i birle�tirir
--Kural: 2 farkl� result set i�indeki s�tunlar ayn� say�da, ayn� s�rada ve ayn� isimde olmal�d�r.
--Union result set'deki de�erleri DISTINCT ile tek olarak g�sterir. Ayn� kay�ttan 2 tane varsa sadece 1 tanesi g�r�necektir.

--M��teri ve Tedarik�ileri tek bir sorguda getirdik.
SELECT CompanyName, ContactName, ContactTitle, Address, 'M��teri' FROM Customers
UNION
SELECT CompanyName, ContactName, ContactTitle, Address, 'Tedarik�i' FROM Suppliers

--Tedarik�i ve m��terileri tek bir sorgu ile getiriyoruz
--Union ile �ekti�imiz i�in ayn� isimdeki kay�tlar bir kez geliyor.
SELECT CompanyName FROM Customers
UNION
SELECT CompanyName FROM Suppliers


--Union All ile �ekti�imiz i�in ayn� isimdeki kay�tlar tekil olarak de�il hepsi result set'de g�r�n�yor. 
SELECT CompanyName FROM Customers
UNION ALL
SELECT CompanyName FROM Suppliers
ORDER BY CompanyName