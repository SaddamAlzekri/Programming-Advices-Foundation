----  Project 1

use C21_DB1;

BEGIN TRY
        INSERT INTO Employees3 (EmployeeID, Name, Position) values(1, 'John Joe', 'Sales Marketing');
        INSERT INTO Employees3 (EmployeeID, Name, Position) values(1, 'Maria Sole', 'Manager');
END TRY
BEGIN CATCH
           PRINT 'There are Same Primary key : ' +  ERROR_MESSAGE();
END CATCH

SELECT *FROM Employees3;

----  Project 2

BEGIN TRY
        SELECT 1/0;
END TRY
BEGIN CATCH
        SELECT ERROR_NUMBER() AS NumberOfError,
               ERROR_SEVERITY() AS LevelOfDengerous,
               ERROR_STATE() AS NumberOfState,
               ERROR_PROCEDURE() as ReturnOfNameOfProcedure,
               ERROR_LINE() as ReturnOfLineNumber,
               ERROR_MESSAGE() ReturnErrorText;
END CATCH

----  Project 3


select *from Products;

DECLARE @NewStockQuantity int;
set @NewStockQuantity = -5;

BEGIN TRY
        IF @NewStockQuantity < 0
            THROW 51000, 'The StockQuantity is less than Zero', 1;

        Update Products set  StockQuantity = @NewStockQuantity where ProductID = 1;
END TRY
BEGIN CATCH
         SELECT ERROR_NUMBER() AS NumberOfError,
                ERROR_LINE() AS NumberOfErrorinLine,
                ERROR_MESSAGE() as Errortext;
END CATCH

----  Project 4

SELECT *FROM Departments;

declare @Error int = @@ERROR;
INSERT INTO Departments(DepartmentID, Name) values (1, 'john');
if @Error <> 0
    begin
    PRINT 'Error : ' + cast(@Error as varchar);
    end

update Departments set DepartmentID = 5 where DepartmentID = 4;

select @@ROWCOUNT as Roweffect;

