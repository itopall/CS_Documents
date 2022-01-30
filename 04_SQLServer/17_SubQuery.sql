
--SUBQUERY
--Alt sorgu ya da iç içe sorgu olarak adlandýrýlýr.

--WHERE kriteri içerisinde SubQuery Kullanýmý
SELECT 
	e.EmployeeID, e.FirstName, e.LastName
FROM 
	Employees e
WHERE
	EmployeeId IN (SELECT DISTINCT EmployeeID FROM Orders)
		

SELECT * FROM Products WHERE CategoryID = (SELECT TOP 1 CategoryID FROM Categories WHERE CategoryName = 'Condiments')


--SELECT içerisinde SubQuery kullanýmý
SELECT
	c.CategoryName,
	c.CategoryID,
	(SELECT COUNT(*) FROM Products p WHERE p.CategoryID = c.CategoryID) AS UrunSayisi
FROM
	Categories c
