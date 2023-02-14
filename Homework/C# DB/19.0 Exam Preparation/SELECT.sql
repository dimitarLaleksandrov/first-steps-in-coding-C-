----- Section 3. Querying

----Aircraft


SELECT 
    Manufacturer,
    Model,
    FlightHours,
    Condition
	FROM Aircraft
	ORDER BY FlightHours DESC




------ Pilots and Aircraft

SELECT 
	  FirstName,
	  LastName,
      Manufacturer,
      Model,
      FlightHours
	  FROM Pilots As p
		JOIN PilotsAircraft AS pa ON p.Id = pa.PilotId
		JOIN Aircraft AS a ON a.Id = pa.AircraftId
	  WHERE a.FlightHours IS NOT NULL 
			AND FlightHours <= 304
	  ORDER BY a.FlightHours DESC,
				p.FirstName;



------ Top 20 Flight Destinations


SELECT TOP 20
		fd.Id AS DestinationId,
		[Start],
		FullName,
		AirportName,
		TicketPrice
   FROM FlightDestinations AS fd
   JOIN Passengers AS p ON fd.PassengerId = p.Id
   JOIN Airports AS a ON fd.AirportId = a.Id
   WHERE DATEPART(DAY, fd.Start) % 2 = 0
   ORDER BY fd.TicketPrice DESC, a.AirportName;



----   Number of Flights for Each Aircraft


	SELECT 
			a.Id AS	AircraftId,
			a.Manufacturer,
			a.FlightHours,
			COUNT(fd.Id) AS FlightDestinationsCount,
			ROUND(AVG(fd.TicketPrice), 2) AS AvgPrice
		FROM Aircraft AS a
		JOIN FlightDestinations as fd ON a.Id = fd.AircraftId
		GROUP BY a.Id, a.Manufacturer, a.FlightHours
		HAVING COUNT(fd.Id) >= 2
		ORDER BY FlightDestinationsCount DESC, AircraftId;    ----  ORDER BY 4 DESC, 1;





------ Regular Passengers


SELECT 
	    FullName,
		COUNT(a.Id) AS CountOfAircraft,
		SUM(fd.TicketPrice) AS TotalPayed
	FROM Passengers AS p
		JOIN FlightDestinations AS fd ON p.Id = fd.PassengerId
		JOIN Aircraft AS a ON a.Id = fd.AircraftId
	WHERE SUBSTRING(p.FullName, 2, 1) = 'a'
	GROUP BY p.Id, p.FullName
	HAVING COUNT(a.Id) > 1
	ORDER BY p.FullName;




------ Full Info for Flight Destinations




SELECT 
		 AirportName, 
		 fd.[Start] AS DayTime,
		 TicketPrice,
		 FullName,
		 Manufacturer,
		 Model
	FROM FlightDestinations AS fd
		JOIN Passengers AS p ON  fd.PassengerId = p.Id
		JOIN Aircraft AS a ON fd.AircraftId = a.Id
		JOIN Airports AS ap ON fd.AirportId = ap.Id
	WHERE CAST(fd.[Start] AS TIME) BETWEEN '06:00' AND '20:00'
		AND fd.TicketPrice > 2500
	ORDER BY a.Model;
