
CREATE TABLE Department_ConstraintTest
(
	Id INT,
	Name NVARCHAR(50)
)

CREATE TABLE Personel_ConstraintTest
(
	Id INT, --PRIMARY KEY NOT NULL ekleyerek bu aþamada Constraint'leri tanýmlayabilirdik. --Identity(1,1) PRIMARY KEY NOT NULL,	
	DepartmentId INT,
	NameSurname NVARCHAR(50),
	GSM NVARCHAR(11),
	TCKNO NVARCHAR(11)
)

ALTER TABLE Personel_ConstraintTest ALTER COLUMN Id INT NOT NULL
ALTER TABLE Personel_ConstraintTest ADD CONSTRAINT PK_PersonelId PRIMARY KEY (Id)

INSERT INTO Personel_ConstraintTest VALUES (10, 1, 'test', '12312312123', '34534534534')
SELECT * FROM Personel_ConstraintTest


--Composite Key Örneði
ALTER TABLE Personel_ConstraintTest ADD CONSTRAINT PK_PersonelId PRIMARY KEY (colum1, column2)


--FOREIGN KEY CONSTRAINT
ALTER TABLE Department_ConstraintTest ALTER COLUMN Id INT NOT NULL 
ALTER TABLE Department_ConstraintTest ADD CONSTRAINT PK_DepartmentIdId PRIMARY KEY (Id)

ALTER TABLE Personel_ConstraintTest ADD CONSTRAINT FK_DepartmentIdNew FOREIGN KEY (DepartmentId) REFERENCES Department_ConstraintTest(Id)

--Bir kýsýtlamanýn eklenmesi sýrasýnda, eðer o kýsýtlamadan geçmeyen veriler tabloda bulunuyorsa kýsýtlamanýn oluþturulmasýna izin verilmez.
SELECT * FROM Department_ConstraintTest
SELECT * FROM Personel_ConstraintTest

--TRUNCATE: Identity kolonlarý seed deðerlerine geri döner, tüm kayýtlar silinir.
TRUNCATE TABLE Personel_ConstraintTest


--UNIQUE CONSTRAINT
ALTER TABLE Personel_ConstraintTest ADD CONSTRAINT UQ_GSM UNIQUE (GSM)
ALTER TABLE Personel_ConstraintTest ADD CONSTRAINT UQ_TCKNO UNIQUE (TCKNO)

INSERT INTO Personel_ConstraintTest VALUES (11, null, 'test', '12312312122', '34534534535')
SELECT * FROM Personel_ConstraintTest


--DEFAULT VALUE Tanýmlama
ALTER TABLE Personel_ConstraintTest ADD CreatedDate DATETIME
ALTER TABLE Personel_ConstraintTest ADD CONSTRAINT DF_CreatedDate DEFAULT GETDATE() FOR CreatedDate
