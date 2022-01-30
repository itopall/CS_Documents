
--TEMP TABLES (Ge�ici Tablolar)
--Bir sonu�  k�mesini ge�ici bir s�re saklamak i�in kullan�l�rlar.

--Product tablosu #Product olarak isimlendirildi�inde, bu tablo ba�l� olnunan veritaban�nda de�il tempDb sistem veritaban�nda olu�ur. 
CREATE TABLE #Product
(
	Id INT,
	Name NVARCHAR(50)
)


--tempdb veritaban� ge�ici �al��malar i�in bulunur. Bu veritaban�ndaki Temproary Tables, Sql Server restart edildi�inde temizlenir.
SELECT * FROm #Product

--Ge�ici tablolar server'dan otomatik silinmesi beklenmeden de DROP TABLE komutuyla silinebilirler.
DROP TABLE #Product