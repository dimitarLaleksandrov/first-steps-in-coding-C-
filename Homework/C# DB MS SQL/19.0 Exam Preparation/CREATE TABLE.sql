CREATE TABLE Passengers (
		Id INT PRIMARY KEY IDENTITY,  --- PK, Unique table identification, Identity
		FullName VARCHAR(100) UNIQUE NOT NULL,   ----  Unique, NULL is not allowed
		Email VARCHAR(50) UNIQUE NOT NULL 
);
CREATE TABLE Pilots (
		Id INT PRIMARY KEY IDENTITY, --- PK, Unique table identification, Identity
		FirstName VARCHAR(30) UNIQUE NOT NULL,
		LastName VARCHAR(30) UNIQUE NOT NULL,
		Age TINYINT NOT NULL CHECK(Age >= 21 AND Age <= 62),  ----  Age should be between 21 and 62 both inclusively, NULL is not allowed
		Rating FLOAT CHECK(Rating >= 0.0 AND Rating <= 10.0) NULL
);
CREATE TABLE AircraftTypes (
		Id INT PRIMARY KEY IDENTITY,
		TypeName VARCHAR(30) UNIQUE NOT NULL
);
CREATE TABLE Aircraft (
		Id INT PRIMARY KEY IDENTITY,
		Manufacturer VARCHAR (25) NOT NULL,
		Model VARCHAR (30) NOT NULL,
		[Year] INT NOT NULL,
		FlightHours INT NULL,
		Condition CHAR NOT NULL,    --- One character.
		TypeId INT NOT NULL FOREIGN KEY REFERENCES AircraftTypes(Id)  ----  Relationship with table AircraftTypes, NULL is not allowed.
);
CREATE TABLE PilotsAircraft (
		AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
		PilotId INT FOREIGN KEY REFERENCES Pilots(Id) NOT NULL,
		PRIMARY KEY (AircraftId, PilotId)
);
CREATE TABLE Airports (
		Id INT PRIMARY KEY IDENTITY,
		AirportName VARCHAR(70) UNIQUE NOT NULL,
		Country VARCHAR(100) UNIQUE NOT NULL
);
CREATE TABLE FlightDestinations (
		Id INT PRIMARY KEY IDENTITY,
		AirportId INT FOREIGN KEY REFERENCES Airports(Id) NOT NULL,
		[Start] DATETIME NOT NULL,
		AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
		PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
		TicketPrice DECIMAL(18, 2) DEFAULT 15   --- The DEFAULT value is 15, NULL is not allowed
);



