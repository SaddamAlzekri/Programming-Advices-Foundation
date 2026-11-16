use C21_DB1;

declare @DepartmentID int;
declare @StartDate date;
declare @EndDate date;
declare @TotalEmployees int;
declare @DepartmentName VARCHAR(50);


SET @DepartmentID = 3;
SET @StartDate = '2023-01-01';
SET @EndDate = '2023-12-31';

SELECT @DepartmentName = Name from Departments where DepartmentID = @DepartmentID;

select @TotalEmployees = COUNT(*)
from Employees
where DepartmentID = @DepartmentID AND HireDate BETWEEN @StartDate AND @EndDate;


print 'Department Report';
print 'Department Name : ' + @DepartmentName;
print 'Reporting Period : ' + cast(@StartDate as varchar) + ' to ' + CAST(@EndDate as varchar);
print 'Total employees hired in : ' + CAST(@StartDate as VARCHAR) + ' : ' + CAST(@TotalEmployeeS AS VARCHAR);  