-----------------Program 1

select PerformamceCategory, count(*) as NumberOfSalary, AVG(Salary) as AverageSalary
from (
select Name, Salary,
case 
    when PerformanceRating >=80 then 'High'
    when PerformanceRating >=60 then 'Medium'
    else 'Low'
end as PerformamceCategory
from Employees2) as PerformanceTable 
group by PerformamceCategory;

-----------------Program 2

declare @Number int;

set @Number = 1;

while @Number <= 5
begin
     print 'Counter is : ' + cast(@Number as varchar);
     set @Number = @Number + 1;
end

-----------------Program 3

declare @Number2 int;

set @Number2 = 5;

while @Number2 > 0
begin
     print 'Counter is : ' + cast(@Number2 as varchar);
     set @Number2 = @Number2 - 1; 
end

-----------------Program 4

declare @CustomerID int;
declare @Name varchar(50);
declare @MaxID int;

select @CustomerID = min(CustomerID) from Customers;
select @MaxID = Max(CustomerID) from Customers;

while @CustomerID is not null and @CustomerID <= @MaxID
begin
     select @Name = Name from Customers where CustomerID = @CustomerID;
     print @Name;

     select @CustomerID = Min(CustomerID) from Customers where CustomerID > @CustomerID;
end

-----------------Program 5

declare @balance decimal(10, 2) = 950;
declare @Withdrawal decimal(10, 2) = 100;

while @balance > 0
begin
     set @balance = @balance - @Withdrawal;

     if @balance < 0
     begin
          print 'Your Count donot enouph:-)';
          break;
     end
     print 'Your Balance : ' + cast(@Balance as varchar);
end

-----------------Program 6

declare @row int = 1;
declare @col int = 0;
declare @result int;
while @col <= 10
begin
     set @col = @col + 1;
     set @row = 1;
     print '****** Table Of ' + cast(@col as varchar) + ' ******';
     while @row <= 10
     begin
          set @result = @col * @row;
          print cast(@col as varchar) + ' * ' + cast (@row as varchar) + ' = ' + cast(@result as varchar);
          set @row = @row + 1;
     end
end
-----------------Program 7
declare @row2 int = 1;
declare @col2 int = 1;
declare @result2 int;
declare @headColString varchar(250);
declare @rowString varchar(250);

set @headColString = char(9);

while @col2 <= 10
begin
     set @headColString = @headColString + Cast(@col2 as varchar) + char(9);
     set @col2 = @col2 + 1;
end

print @headColString;

set @col2 = 1;
while @col2 <= 10
begin
     set @row2 = 1;
     set @rowString = cast(@col2 as varchar) + char(9);

     while @row2 <= 10
     begin
          set @result2 = @col2 * @row2;
          set @rowString = @rowString + cast(@result2 as varchar) + char(9);
          set @row2 = @row2 + 1;
     end
     print @rowString;
     set @col2 = @col2 + 1;
end

-----------------Program 8

declare @Num int = 1;

while @Num <= 10
begin
    if @Num = 5
    begin
        break;
    end
    print 'Number : ' + cast(@Num as varchar );
    set @Num = @Num + 1;
end
-----------------Program 9

declare @Num2 int = 0;

while @Num2 <= 10
begin
    set @Num2 = @Num2 + 1;
    if @Num2 % 2 = 0
    begin
        continue;
    end
    print 'Number : ' + cast(@Num2 as varchar );
end

