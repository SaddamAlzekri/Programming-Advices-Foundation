
SELECT Name, Salary FROM Employees2 
ORDER BY CASE
    WHEN Salary > 80000 THEN 1
    ELSE 2
    END;

    ----------------------------

SELECT Name, Department, 
CASE Department
    WHEN 'HR' THEN Salary * 1.15
    WHEN 'IT' THEN Salary * 1.10
    ELSE Salary * 1.5

END AS SalaryAfterBonus from Employees2;

    ----------------------------

SELECT Name, Department, PerformanceRating,
CASE 
    WHEN PerformanceRating >= 90 THEN Salary * 1.15
    WHEN PerformanceRating >= 75 THEN Salary * 1.10
    WHEN PerformanceRating >= 50 THEN Salary * 1.05
    ELSE Salary

END AS SalaryAfterBonus from Employees2;

    ----------------------------

SELECT Name, Department, PerformanceRating,
SalaryAfterBonus = 
CASE
    WHEN Department = 'Marketing' THEN 
        CASE
            WHEN PerformanceRating >= 90 THEN Salary * 1.15
            WHEN PerformanceRating >= 75 THEN Salary * 1.10
            WHEN PerformanceRating >= 50 THEN Salary * 1.05
            ELSE Salary
        END 
        WHEN Department = 'HR' THEN 
        CASE
            WHEN PerformanceRating >= 90 THEN Salary * 1.15
            WHEN PerformanceRating >= 75 THEN Salary * 1.10
            WHEN PerformanceRating >= 50 THEN Salary * 1.05
            ELSE Salary
        END 
        WHEN Department = 'IT' THEN 
        CASE
            WHEN PerformanceRating >= 90 THEN Salary * 1.15
            WHEN PerformanceRating >= 75 THEN Salary * 1.10
            WHEN PerformanceRating >= 50 THEN Salary * 1.05
            ELSE Salary
        END 
END FROM Employees2;

    ----------------------------

SELECT PerFormanceCategory, COUNT(*) NumberEmployees, AVG(Salary) AS SalaryOfAverageInGroup FROM
(SELECT Name, Salary, PerformanceRating,
CASE
    WHEN PerformanceRating >= 90 THEN 'High'
    WHEN PerformanceRating >= 75 THEN 'Medium'
    WHEN PerformanceRating >= 50 THEN 'Low'
    ELSE 'Fail'
END AS PerFormanceCategory FROM Employees2) AS PerformanceTable Group BY PerFormanceCategory;

    ----------------------------

DECLARE @Row INT = 1;
DECLARE @Column INT = 1;
DECLARE @Result INT;

WHILE @Column <= 10
BEGIN
    SET @Row = 1;
    PRINT 'Table of : ' + CAST(@Column AS NVARCHAR)
    WHILE @Row <= 10
    BEGIN
        SET @Result = @Column * @Row;
        PRINT CAST(@Column AS NVARCHAR) + ' * ' + CAST(@Row AS NVARCHAR) + ' = ' +  CAST(@Result AS NVARCHAR);
        SET @Row = @Row + 1;
    END
    SET @Column = @Column + 1;
END

    ----------------------------

SELECT *FROM Employees3;

BEGIN TRY
    DECLARE @Error INT;
    IF EXISTS (SELECT 1 FROM Employees3 WHERE EmployeeID = 1)
    BEGIN
        THROW 51000, 'This Primary_Key is there is in the table, Change its.', 1;
    END
    

    INSERT INTO Employees3(EmployeeID, Name, Position) values (1, 'Saddam Al-zekri', 'IT Manager');

END TRY
BEGIN CATCH
    SELECT Error_Message();   
END CATCH

    ----------------------------

BEGIN TRY
    if 10/2 = 3
        print 'Done! The Result bigger than Zero';
    else
       BEGIN
            --PRINT CAST(@ErrorOfEmployee2 AS NVARCHAR);
            THROW 51000, 'The Result is failed', 1;
        END        
END TRY
BEGIN CATCH
    select Error_Message();
END CATCH

    ----------------------------

SELECT *FROM Employees3;

declare @Error3 int;

insert into Employees3(EmployeeID, Name, Position) values(1, 'Saddam', 'IT Manager');

set @Error3 = @@ERROR;

print 'The number of Error is : ' + CAST(@Error3 AS NVARCHAR);

    ----------------------------

SELECT *FROM Employees3;

declare @EffectRow int;

Update Employees3 set Name = 'Saddam Al-zekri' where EmployeeID = 1;

set @EffectRow = @@ROWCOUNT;

print 'The Rows that Effects is : ' + CAST(@EffectRow AS NVARCHAR);

