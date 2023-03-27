CREATE FUNCTION udf_CreatorWithBoardgames(@name NVARCHAR(30))
RETURNS INT AS
BEGIN
	DECLARE @boardgamesCounts INT
	SET @boardgamesCounts = 
				(
					SELECT  COUNT(c.FirstName)
					FROM Creators AS c
					JOIN CreatorsBoardgames AS cb ON cb.CreatorId = c.Id
					WHERE c.FirstName = @name
				)


	RETURN @boardgamesCounts

END;
SELECT dbo.udf_CreatorWithBoardgames('Bruno')