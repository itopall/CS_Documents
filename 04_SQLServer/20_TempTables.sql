
--TEMP TABLES (Geçici Tablolar)
--Bir sonuç  kümesini geçici bir süre saklamak için kullanýlýrlar.

--Product tablosu #Product olarak isimlendirildiðinde, bu tablo baðlý olnunan veritabanýnda deðil tempDb sistem veritabanýnda oluþur. 
CREATE TABLE #Product
(
	Id INT,
	Name NVARCHAR(50)
)


--tempdb veritabaný geçici çalýþmalar için bulunur. Bu veritabanýndaki Temproary Tables, Sql Server restart edildiðinde temizlenir.
SELECT * FROm #Product

--Geçici tablolar server'dan otomatik silinmesi beklenmeden de DROP TABLE komutuyla silinebilirler.
DROP TABLE #Product