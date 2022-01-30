
--Veritabaný nesnelerini kümelemek için kullanýlýrlar.
--Yönetimi kolaylaþtýrýp, güvenlik tarafýyla ilgili iþleri basitleþtirirler
--Her veritabaný nesnesi mutlaka bir þema altýnda oluþturulur.
--Þema ismi verilmediðinde, ilgili nesne o kullanýcýnýn varsayýlan þemasý altýnda oluþur. (þu an dbo.)

--Þemalar birer nesnedir ve veritabaný içinde oluþturulurlar
CREATE SCHEMA ord


--Eðer tanýmlanan bir veritabaný nesnesine þemasý söylenmezse, baðlý olan kullanýcýnýn þemasý kullanýlýr. Ancak istenirse þema adý yazýlabilir.
CREATE TABLE ord.SchemaTest
(
	Id INT,
	Name NVARCHAR(100)
)

SELECT * FROM ord.SchemaTest


--Varolan bir þemayý silmek için önce baðlý olduðu tablolarý silmek gerekiyor.
DROP TABLE ord.SchemaTest
DROP SCHEMA ord