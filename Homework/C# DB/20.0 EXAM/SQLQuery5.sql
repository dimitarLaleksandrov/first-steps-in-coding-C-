SELECT 
	 [Name],
     Rating
FROM Boardgames
ORDER BY YearPublished ASC,
		[Name] DESC



SELECT 
		Id,
		[Name],
		YearPublished,
		CategoryId
		AS CategoryName
FROM Boardgames AS b
    LEFT JOIN Categories AS c ON c.Id = b.CategoryId
WHERE c.[Name] = ''
ORDER BY YearPublished DESC
SELECT 
	[Name]
	WHERE Categories.[Name] = 'Strategy Games'
	AND Categories.[Name] = 'Wargames'
	FROM Categories

	
SELECT 
		Id,
		SUBSTRING(c.FirstName + ' ' + c.LastName),
		AS CreatorName,
		Email
FROM Creators AS c 



SELECT TOP(5)
		[Name],
		Rating,
		CategoryName
FROM


SELECT 
	SUBSTRING(c.FirstName + c.LastName)
	AS FullName,
		Email,
		--Rating
FROM Creators AS c





SELECT 
		bg.Id,
		bg.[Name],
		bg.YearPublished,
		c.[Name] AS CategoryName
FROM Categories AS c
JOIN Boardgames AS bg ON bg.CategoryId = c.Id
WHERE c.[Name] = 'Strategy Games'
	 OR c.[Name] = 'Wargames'
ORDER BY bg.YearPublished DESC

---TODO
SELECT 
		c.Id,
		CONCAT(c.FirstName, ' ', c.LastName) AS CreatorName,
		c.Email
FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON cb.CreatorId = c.ID
JOIN Boardgames AS bg ON bg.Id = cd.BoardgameId
WHERE



SELECT TOP(5)
		bg.[Name],
		bg.Rating,
		c.[Name] AS CategoryName
FROM Categories AS c
JOIN Boardgames AS bg ON bg.CategoryId = c.Id
JOIN PlayersRanges AS p ON bg.PlayersRangeId = p.Id
WHERE bg.Rating > 7.00
AND CHARINDEX('a', bg.[Name]) > 0 OR bg.Rating > 7.50
AND p.PlayersMin = 2 
AND p.PlayersMax = 5
ORDER BY bg.[Name] ASC, bg.Rating DESC


SELECT 
		CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
		c.Email,
		bg.Rating
FROM Creators AS c
JOIN CreatorsBoardgames AS cb ON c.Id = cb.CreatorId
JOIN Boardgames AS bg ON bg.Id = cb.BoardgameId
WHERE RIGHT(c.Email, 4) IN ('.com')
ORDER BY FullName ASC


