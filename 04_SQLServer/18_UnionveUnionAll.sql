
--UNION: 2 farklý result set'i birleþtirir
--Kural: 2 farklý result set içindeki sütunlar ayný sayýda, ayný sýrada ve ayný isimde olmalýdýr.
--Union result set'deki deðerleri DISTINCT ile tek olarak gösterir. Ayný kayýttan 2 tane varsa sadece 1 tanesi görünecektir.

--Müþteri ve Tedarikçileri tek bir sorguda getirdik.
SELECT CompanyName, ContactName, ContactTitle, Address, 'Müþteri' FROM Customers
UNION
SELECT CompanyName, ContactName, ContactTitle, Address, 'Tedarikçi' FROM Suppliers

--Tedarikçi ve müþterileri tek bir sorgu ile getiriyoruz
--Union ile çektiðimiz için ayný isimdeki kayýtlar bir kez geliyor.
SELECT CompanyName FROM Customers
UNION
SELECT CompanyName FROM Suppliers


--Union All ile çektiðimiz için ayný isimdeki kayýtlar tekil olarak deðil hepsi result set'de görünüyor. 
SELECT CompanyName FROM Customers
UNION ALL
SELECT CompanyName FROM Suppliers
ORDER BY CompanyName