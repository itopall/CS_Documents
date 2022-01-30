
--Except ve Intersect

--EXCEPT: �lk tabloda olup ikinci tabloda olmayan kay�tlar� listeler
SELECT ProductId FROM Products
EXCEPT
SELECT ProductId FROM [Order Details]

--NOT IN: Except ile ayn� mant�kda �al���r.
SELECT ProductId FROM Products
WHERE ProductId NOT IN (SELECT ProductId FROM [Order Details])

--NOT EXISTS: Except ile ayn� mant�kda �al���r.
SELECT ProductId FROM Products p
WHERE NOT EXISTS (SELECT ProductId FROm [Order Details] od WHERE p.ProductID = od. ProductId) 


--INTERSECT: Her iki tabloda da olan kay�tlar� listeler.
SELECT ProductId FROM Products
INTERSECT
SELECT ProductId FROM [Order Details]

--IN Intersect ile ayn� mant�kda �al���r
SELECT ProductId FROM Products
WHERE ProductId IN (SELECT ProductId FROM [Order Details])

--EXISTS: Intersect ile ayn� mant�kda �al���r.
SELECT ProductId FROM Products p
WHERE EXISTS (SELECT ProductId FROm [Order Details] od WHERE p.ProductID = od. ProductId) 