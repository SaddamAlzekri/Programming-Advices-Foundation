CREATE PROCEDURE SP_DeletePerson
    @PersonID int
AS 
BEGIN
    DELETE FROM People WHERE PersonID = @PersonID;
END

-----------

DECLARE @PersonID INT = 1;
EXEC SP_DeletePerson
    @PersonID = @PersonID;

SELECT *FROM People;
