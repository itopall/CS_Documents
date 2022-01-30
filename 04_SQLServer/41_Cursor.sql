
--SQL CURSOR KULLANIMI

DECLARE @FirstName NVARCHAR(MAX), @LastName NVARCHAR(MAX) --Cursor'da kullanacaðýmýz parametreleri tanýmladýk.

	DECLARE CRS_Employees CURSOR FOR
	SELECT FirstName, LastName FROM Employees --Cursor'da iþlenecek veriler ve listeyi select sorgusu ile çekiyoruz.

	OPEN CRS_Employees --Cursor'ý açýyoruz

		FETCH NEXT FROM CRS_Employees INTO @FirstName, @LastName --SELECT sorgusunda gelen sütunlar sýrasýna göre deðiþkenlere atanýr.

		WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @FirstName + ' ' + @LastName
			--SELECT, INSERT, UPDATE iþlemleri yapýlabilir.

			FETCH NEXT FROM CRS_Employees INTO @FirstName, @LastName
		END

	CLOSE CRS_Employees --Cursor'ý kapatýyoruz
	DEALLOCATE CRS_Employees --Cursor ile iþimiz bittiðinde sistemden temizlemek için DEALLOCATE etmemiz gerekmektedir.