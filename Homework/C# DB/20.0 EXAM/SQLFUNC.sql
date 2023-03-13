CREATE PROCEDURE usp_SearchByCategory(@category VARCHAR(50))
AS
			  BEGIN
					SELECT
							bg.[Name],
							bg.YearPublished,
							bg.Rating,
							c.[Name] AS CategoryName,
							p.[Name] AS PublisherName,
						CONCAT(pr.PlayersMin, ' ', 'people') AS MinPlayers,
						CONCAT(pr.PlayersMax, ' ', 'people') AS MaxPlayers 
					FROM Categories AS c
					JOIN Boardgames AS bg ON c.Id = bg.CategoryId
					JOIN Publishers AS p ON bg.PublisherId = p.Id
					JOIN PlayersRanges AS pr ON bg.PlayersRangeId = pr.Id
					WHERE c.[Name] = @category
					ORDER BY p.[Name] ASC, 
					 bg.YearPublished DESC
					
			  END;