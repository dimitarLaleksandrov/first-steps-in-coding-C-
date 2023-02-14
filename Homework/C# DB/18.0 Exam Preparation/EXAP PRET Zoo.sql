CREATE DATABASE Zoo

GO


USE Zoo

GO

CREATE TABLE Owners
		(
			[Id] INT PRIMARY KEY IDENTITY, --- PK, Unique table identification, Identity- auto incremented(populvane)  Null is not allowed
			[Name] VARCHAR(50) NOT NULL, --- Null is not allowed
			[PhoneNumber] VARCHAR(15) NOT NULL,
			[Address] VARCHAR(50) ---- Null is allowed

		)

CREATE TABLE AnimalTypes
		(
			[Id] INT PRIMARY KEY IDENTITY, -- PK, Unique table identification, Identity
			[AnimalType] VARCHAR(30) NOT NULL --- Null is not allowed
		)

CREATE TABLE Cages
		(
			[Id] INT PRIMARY KEY IDENTITY,  -- PK, Unique table identification, Identity
			[AnimalTypeId] INT FOREIGN KEY REFERENCES AnimalTypes1(Id) NOT NULL  --- Relationship with table AnimalTypes,  Null is not allowed
		)

CREATE TABLE Animals
		(
			[Id] INT PRIMARY KEY IDENTITY,  --- PK, Unique table identification, Identity
			[Name] VARCHAR(30) NOT NULL,  --- Null is not allowed
			[BirthDate] DATE NOT NULL,
			[OwnerId] INT FOREIGN KEY REFERENCES Owners(Id),  --- Relationship with table Owners(PK),  Null is allowed
			[AnimalTypeId] INT FOREIGN KEY REFERENCES AnimalTypes(Id) NOT NULL  --- Relationship with table AnimalTypes,  Null is not allowed
		)

CREATE TABLE AnimalsCages
		(
			[CageId] INT FOREIGN KEY REFERENCES Cages(Id),  --- PK, Unique table identification, Relationship with table Cages,  Null is not allowed
			[AnimalId] INT FOREIGN KEY REFERENCES  Animals(Id)   --- PK, Unique table identification, Relationship with table Animals, Null is not allowed
			PRIMARY KEY(CageId, AnimalId)
		)

CREATE TABLE VolunteersDepartments
		(
			[Id] INT PRIMARY KEY IDENTITY,  --- PK, Unique table identification, Identity
			[DepartmentName] VARCHAR(30) NOT NULL  --- Null is not allowed
		)

CREATE TABLE Volunteers
		(
			[Id] INT PRIMARY KEY IDENTITY,  --- PK, Unique table identification, Identity(strat, seed) if needet
			[Name] VARCHAR(50) NOT NULL,  --- Null is not allowed
			[PhoneNumber]  VARCHAR(15) NOT NULL,
			[Address]  VARCHAR(50),   ----  Null is allowed
			[AnimalId] INT FOREIGN KEY REFERENCES Animals(Id),  --- Relationship with table Animals(PK); Null is allowed
			[DepartmentId] INT FOREIGN KEY REFERENCES VolunteersDepartments(Id) NOT NULL  --- Relationship with table VolunteersDepartments(PK), Null is not allowed.
		)


---- Insert some info

--- start from REFERENCES table's wach whu table refenece to whu AnimalId need to be fill in Volunteers1 props. so need to be create first Animals1 whit the prop. AnimalId
INSERT INTO Animals1(Name, BirthDate, OwnerId, AnimalTypeId)
	VALUES ('Giraffe', '2018-09-21', 21, 1),
			('Harpy Eagle', '2015-04-17', 15, 3),
			('Hamadryas Baboon', '2017-11-02', NULL, 1),
			('Tuatara', '2021-06-30', 2, 4)

INSERT INTO Volunteers1(Name, PhoneNumber, Address, AnimalId, DepartmentId)
	VALUES	('Anita Kostova', 0896365412, 'Sofia, 5 Rosa str.', 15, 1),
			('Anita Kostova', 0896365412, 'Sofia, 5 Rosa str.', 15, 1),
			('Anita Kostova', 0896365412, 'Sofia, 5 Rosa str.', 15, 1)


---- SELECT * FROM Animals1 - if we wona check the table

------ Update
-- Kaloqn Stoqnov (a current owner, present in the database) came to the zoo to adopt all the animals, who don't have an owner. 
-- Update the records by putting to those animals the correct OwnerId.


--- SELECT * FROM Owners1 WHERE Name = 'Kaloqn Stoqnov'  get ID

SELECT Id FROM Owners1 WHERE Name = 'Kaloqn Stoqnov' --- SELECT * FROM Owners1 to see hez ID(PK)
---- for UPDATE PROBLEM IN JUDGE
UPDATE Animals1 SET OwnerId = (
			SELECT Id FROM Owners1 WHERE Name = 'Kaloqn Stoqnov' --- SELECT * FROM Owners1 to see hez ID(PK)
		)
		WHERE OwnerId IS NULL
---- for UPDATE PROBLEM IN JUDGE
SELECT * FROM Animals1 WHERE OwnerId IS NULL --	SELECT * FROM Animals1 WHER Owners1 IS NULL

----- DELETE 
----The Zoo decided to close one of the Volunteers Departments - Education program assistant. Your job is to delete this department from the database. 
---NOTE: Keep in mind that there could be foreign key constraint conflicts!
---- find the VolunteersDepartments ID
SELECT * FROM VolunteersDepartments1
		WHERE DepartmentName = 'Education program assistant'   --- is 2
--- find the volunteers 
SELECT * FROM Volunteers1
		WHERE DepartmentId = 2 -- 'Education program assistant' we have 6 volunteers 

--- first we need to relice the volunteers to relice the chainse
DELETE FROM Volunteers1
		WHERE DepartmentId = (
		SELECT Id FROM VolunteersDepartments1
		WHERE DepartmentName = 'Education program assistant'
		)
-- then we safely delete the department

DELETE FROM VolunteersDepartments1
		WHERE DepartmentName = 'Education program assistant'




----- Section 3. Querying 


-- Volunteers
SELECT Name, PhoneNumber, Address, AnimalId, DepartmentId
	FROM Volunteers
	ORDER BY Name,   -- (ascending) ASC ,  DESC
			AnimalId,
			DepartmentId

--- Animals data

SELECT a.Name,
		a.AnimalType,
		FORMAT(a.BirthDate, 'dd.MM.yyyy')
		AS	BirthDate
		FROM Animals
		AS a
INNER JOIN AnimalTypes
		AS anty
		ON a.AnimalTypeId = anty.Id
	ORDER BY a.Name


---- Owners and Their Animals

SELECT TOP(5) o.Name 
		AS Owner,
		COUNT(a.Id)
		AS CountOfAnimals
		FROM Owners
		AS o 
LEFT JOIN Animals
		AS a
		ON o.Id = a.OwnerId
	GROUP BY o.Name
	ORDER By CountOfAnimals DESC, Owner


----- Owners, Animals and Cages			
			
SELECT CONCAT(o.Name, '-', a.Name)
		AS OwnersAnimals,
			o.PhoneNumber,
			ac.CageId
		FROM Owners
		AS o
INNER JOIN Animals
		AS a
		ON o.Id = a.OwnerId
INNER JOIN AnimalTypes
		AS at
		ON a.AnimalTypeId = at.Id
INNER JOIN AnimalsCages
		AS ac
		ON a.Id = ac.AnimalId
	WHERE a.AnimalTypeId = 'Mammals'
ORDER BY o.Name,
		a.Name DESC



----  Volunteers in Sofia

SELECT v.Name,
		v.PhoneNumber,	 
		TRIM(REPLACE(REPLACE(v.Address, 'Sofia', ''), ',', ''))        ----- SUBSTRING(v.Address, CHARINDEX(',', v.Address)+ 1, LEN(v.Address)) AS Address
		AS Address
		FROM Volunteers
		AS v
INNER JOIN VolunteersDepartments
		AS vd
		ON v.DepartmentId = vd.Id
	WHERE vd.DepartmanName = 'Education program assistant' AND
			v.Address LIKE '%Sofia%'
	ORDER BY v.Name



----Animals for Adoption

SELECT a.Name,
		DATEPART(YEAR, a.BirthDate)
		AS BirthYear,
		at.AnimalType
	FROM Animals
	AS a
INNER JOIN AnimalTypes
			AS at
			ON a.AnimalTypesId = at.Id
	WHERE a.OwnerId IS NULL AND
			DATEDIFF(YEAR, a.BirthDate, '01/01/2022') < 5 AND
			at.AnimalType <> 'Birds'    ---  <>  != razli4en ravno
	ORDER BY a.Name



---- Section 4. Programmability 

---  All Volunteers in a Department

GO
CREATE FUNCTION udf_GetVolunteersCountFromADepartment (@VolunteersDepartment VARCHAR(30))
RETURNS INT
		AS
		BEGIN
			DECLARE @departmenId INT;
			SET @departmenId = (
								SELECT Id FROM VolunteersDepartments
								WHERE DepartmantName = @VolunteersDepartment
								);
			DECLARE @departmantVoluntersCount INT;
			SET  @departmantVoluntersCount = (
												SELECT COUNT(*) FROM Volunteers
													WHERE DepartmendId = @departmenId
											);
				RETURN @departmantVoluntersCount;
		END

GO




----- Animals with Owner or Not

GO

CREATE PROCEDURE usp_AnimalsWithOwnersOrNot(@AnimalName VARCHAR(30))
				AS
			  BEGIN 
				DECLARE @ownerName VARCHAR(50);
				SELECT a.Name,
						ISNULL(o.Name, 'For adoption')   ---  CASE  WHEN o.Name IS NULL THEN 'For adoption' ELSE o.Name END AS OwnersName 
						AS OwnersName 
					FROM Animals
					AS a
			 LEFT JOIN Owners
					AS o
					ON a.OwnerId = o.Id
				WHERE a.Name = @AnimalName

				END
GO

EXEC usp_AnimalsWithOwnersOrNot 'Pumpkinseed Sunfish'