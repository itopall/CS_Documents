
--Veritaban� nesnelerini k�melemek i�in kullan�l�rlar.
--Y�netimi kolayla�t�r�p, g�venlik taraf�yla ilgili i�leri basitle�tirirler
--Her veritaban� nesnesi mutlaka bir �ema alt�nda olu�turulur.
--�ema ismi verilmedi�inde, ilgili nesne o kullan�c�n�n varsay�lan �emas� alt�nda olu�ur. (�u an dbo.)

--�emalar birer nesnedir ve veritaban� i�inde olu�turulurlar
CREATE SCHEMA ord


--E�er tan�mlanan bir veritaban� nesnesine �emas� s�ylenmezse, ba�l� olan kullan�c�n�n �emas� kullan�l�r. Ancak istenirse �ema ad� yaz�labilir.
CREATE TABLE ord.SchemaTest
(
	Id INT,
	Name NVARCHAR(100)
)

SELECT * FROM ord.SchemaTest


--Varolan bir �emay� silmek i�in �nce ba�l� oldu�u tablolar� silmek gerekiyor.
DROP TABLE ord.SchemaTest
DROP SCHEMA ord