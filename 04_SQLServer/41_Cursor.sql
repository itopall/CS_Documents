
--SQL CURSOR KULLANIMI

DECLARE @FirstName NVARCHAR(MAX), @LastName NVARCHAR(MAX) --Cursor'da kullanaca��m�z parametreleri tan�mlad�k.

	DECLARE CRS_Employees CURSOR FOR
	SELECT FirstName, LastName FROM Employees --Cursor'da i�lenecek veriler ve listeyi select sorgusu ile �ekiyoruz.

	OPEN CRS_Employees --Cursor'� a��yoruz

		FETCH NEXT FROM CRS_Employees INTO @FirstName, @LastName --SELECT sorgusunda gelen s�tunlar s�ras�na g�re de�i�kenlere atan�r.

		WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @FirstName + ' ' + @LastName
			--SELECT, INSERT, UPDATE i�lemleri yap�labilir.

			FETCH NEXT FROM CRS_Employees INTO @FirstName, @LastName
		END

	CLOSE CRS_Employees --Cursor'� kapat�yoruz
	DEALLOCATE CRS_Employees --Cursor ile i�imiz bitti�inde sistemden temizlemek i�in DEALLOCATE etmemiz gerekmektedir.