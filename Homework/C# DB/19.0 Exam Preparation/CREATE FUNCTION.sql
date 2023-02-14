------  Find all Destinations by Email Address

CREATE FUNCTION udf_FlightDestinationsByEmail(@email VARCHAR(50)) ---- OR ALTER   za IF proverki ina4e ne raboti a puk se iztriva za JUDGE		
RETURNS INT AS
BEGIN
	DECLARE @destinacionCount INT;
	SET @destinacionCount = 
						(
							SELECT
							COUNT(fd.Id)
							FROM Passengers AS p
							JOIN FlightDestinations AS fd ON p.Id = fd.PassengerId
							WHERE p.Email = @email
							GROUP BY p.Id


						);
	IF @destinacionCount IS NULL 
		SET @destinacionCount = 0;

	RETURN @destinacionCount;
END;



-----  Full Info for Airports



