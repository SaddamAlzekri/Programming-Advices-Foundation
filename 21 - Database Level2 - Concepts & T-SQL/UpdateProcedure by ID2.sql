CREATE PROCEDURE SP_UpdatePerson
    @PersonID INT,
    @FirstName NVARCHAR(50),    
    @LastName NVARCHAR(50),    
    @Email NVARCHAR(250)
AS
BEGIN
    UPDATE People SET FirstName = @FirstName,
           LastName = @LastName,
           Email = @Email WHERE PersonID = @PersonID;
END

----------------

DECLARE @ID int = 1;

exec SP_UpdatePerson
    @PersonID = @ID,
    @FirstName = 'Ali',
    @LastName = 'Saleh',
    @Email = 'Alisaleh@gmail.com'


    select *from People;
