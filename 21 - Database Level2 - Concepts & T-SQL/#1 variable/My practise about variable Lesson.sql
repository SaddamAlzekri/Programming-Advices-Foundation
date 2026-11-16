declare @EmployeeName nvarchar(50);
declare @EmployeeAge int;
declare @EmployeeAddress nvarchar(60);
declare @EmployeeSalary decimal(10, 2);
declare @CurrentDate date;

set @EmployeeName = 'Saddam Alzekri';
select @EmployeeAge = 26;
set @EmployeeAddress = 'I live in YEMEN country in Taiz City in Al-Turba twon.'
select @EmployeeSalary = 7000;
set @CurrentDate = GETDATE();

print 'The name of employee : ' + @EmployeeName;
print 'The age of employee : ' + cast(@EmployeeAge as varchar);
print 'The address of employee : ' + @EmployeeAddress;
print 'The salary of employee : ' + cast(@EmployeeSalary as varchar);
print 'The current date : ' + cast(@CurrentDate as varchar);