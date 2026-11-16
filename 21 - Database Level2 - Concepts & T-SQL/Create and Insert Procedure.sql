select *from People;

----- Create of Procedure

CREATE PROCEDURE SP_AddNewPerson
    @FirstName nvarchar(50),
    @LastName nvarchar(50),
    @Email nvarchar(250),
    @AddNewPersonID int output
AS
BEGIN
    INSERT INTO People(FirstName, LastName, Email) VALUES(@FirstName, @LastName, @Email);

    SET @AddNewPersonID = SCOPE_IDENTITY();
END

----- INSERT INTO PROCEDURE
DECLARE @PersonID int;

EXEC SP_AddNewPerson
     @FirstName = 'Saddam',
     @LastName = 'Alzekri',
     @Email = 'Saddamalzekri33@gmail.com',
     @AddNewPersonID = @PersonID OUTPUT;

SELECT @PersonID AS NewPersonID;

