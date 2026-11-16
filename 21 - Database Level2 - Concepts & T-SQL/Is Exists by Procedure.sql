
CREATE PROCEDURE SP_CheckPersonExits
    @PersonID INT
AS
BEGIN
    IF EXISTS(SELECT *FROM People WHERE PersonID = @PersonID)
           RETURN 1;
        ELSE
           RETURN 0;
END

----------------

DECLARE @Result INT;

EXEC @Result = SP_CheckPersonExits
    @PersonID = 2;

IF @Result = 1
    PRINT 'Is Exists :-)';
ELSE
    PRINT 'Is Not Exists :-)'