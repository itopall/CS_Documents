
--SUBQUERY
--Alt sorgu ya da i� i�e sorgu olarak adland�r�l�r.

--WHERE kriteri i�erisinde SubQuery Kullan�m�
SELECT 
	e.EmployeeID, e.FirstName, e.LastName
FROM 
	Employees e
WHERE
	EmployeeId IN (SELECT DISTINCT EmployeeID FROM Orders)
		

SELECT * FROM Products WHERE CategoryID = (SELECT TOP 1 CategoryID FROM Categories WHERE CategoryName = 'Condiments')


--SELECT i�erisinde SubQuery kullan�m�
SELECT
	c.CategoryName,
	c.CategoryID,
	(SELECT COUNT(*) FROM Products p WHERE p.CategoryID = c.CategoryID) AS UrunSayisi
FROM
	Categories c
