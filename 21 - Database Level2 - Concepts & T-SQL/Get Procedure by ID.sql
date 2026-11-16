
CREATE PROCEDURE SP_GetAllPeopleByID
    @PersonID int
 AS
 BEGIN
     SELECT *FROM People WHERE PersonID = @PersonID;
 END

 ----------------

 EXEC SP_GetAllPeopleByID
     @PersonID = 2;