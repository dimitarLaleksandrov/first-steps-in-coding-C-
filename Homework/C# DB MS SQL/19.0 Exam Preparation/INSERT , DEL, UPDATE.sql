
------    Insert

INSERT INTO Passengers (FullName, Email) 
	SELECT  CONCAT(FirstName, ' ', LastName),
			CONCAT(FirstName, LastName, '@gmail.com')
			FROM Pilots WHERE Id >= 5 AND Id <= 15;



------ Update


UPDATE Aircraft SET Condition = 'A'
		WHERE (Condition = 'B' OR Condition = 'C')
		AND	(FlightHours IS NULL OR FlightHours <= 100)
		AND	([Year] >= 2013); 




------ Delete




DELETE FROM Passengers
		WHERE LEN(FullName) <= 10;
