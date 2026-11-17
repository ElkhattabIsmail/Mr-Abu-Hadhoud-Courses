CREATE PROCEDURE SP_GetPersonByID
    @PersonID INT
AS   --> result of query.

BEGIN
    SELECT * FROM People WHERE PersonID = @PersonID
END