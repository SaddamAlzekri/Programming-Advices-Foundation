create PROCEDURE SP_GetPeopleByID2
    @PersonID INT,
    @FirstName NVARCHAR(50) OUTPUT,
    @LastName nvarchar(50) OUTPUT,
    @Email NVARCHAR(255) OUTPUT,
    @IsFound BIT OUTPUT
AS
BEGIN
    IF EXISTS(SELECT 1 FROM People WHERE PersonID = @PersonID)
    BEGIN
        SELECT @FirstName = FirstName, 
        @LastName = LastName, 
        @Email = Email 
        FROM People WHERE PersonID = @PersonID; 
        SET @IsFound = 1;
    END
    ELSE
    BEGIN
       SET @IsFound = 0;
    END
END

--------------------------

DECLARE @ID int = 1;
DECLARE @FName nvarchar(50);
DECLARE @LName nvarchar(50);
DECLARE @E_mail nvarchar(250);
DECLARE @Is_Found BIT;

EXEC SP_GetPeopleByID2
    @PersonID = @ID,
    @FirstName = @FName OUTPUT,
    @LastName = @LName OUTPUT,
    @Email = @E_mail OUTPUT,
    @IsFound = @Is_Found OUTPUT;

IF @Is_Found = 1
BEGIN
    SELECT @ID AS PersonId, @FName AS FirstName, @LName AS LastName, @Is_Found AS IsFound;
END
ELSE
    PRINT 'Ther is not Person';