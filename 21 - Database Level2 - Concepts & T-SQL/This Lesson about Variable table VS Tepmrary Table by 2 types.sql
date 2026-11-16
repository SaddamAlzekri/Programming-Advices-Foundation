use tempdb;

BEGIN TRANSACTION
BEGIN TRY
    UPDATE Accounts SET Balance = Balance - 100 WHERE AccountID = 1;
    UPDATE Accounts SET Balance = Balance + 100 WHERE AccountID = 2;
    INSERT INTO Transactions (FromAccount, ToAccount, Amount, Date) VALUES(1, 2, 100, GETDATE());

    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
END CATCH

SELECT *FROM Accounts;

--------- Variable table
DECLARE @EmployeeTable table (
    EmployeeID int Primary Key identity(1,1),
    Name varchar(50) not null
);

insert into @EmployeeTable(Name) values ('Saddam');
insert into @EmployeeTable(Name) values ('Ali');
insert into @EmployeeTable(Name) values ('Salwa');

select *from @EmployeeTable;

--------- Variable table Type of(Local Temprary)

create table #EmployeeTabletable (
    EmployeeID int Primary Key identity(1,1),
    Name varchar(50) not null
);

insert into #EmployeeTabletable(Name) values ('Saddam');
insert into #EmployeeTabletable(Name) values ('Ali');
insert into #EmployeeTabletable(Name) values ('Salwa');

select *from #EmployeeTabletable;

drop table #EmployeeTabletable;


--------- Variable table Type of(Global Temprary)

create table ##EmployeeTabletable (
    EmployeeID int Primary Key identity(1,1),
    Name varchar(50) not null
);

insert into ##EmployeeTabletable(Name) values ('Saddam');
insert into ##EmployeeTabletable(Name) values ('Ali');
insert into ##EmployeeTabletable(Name) values ('Salwa');

select *from ##EmployeeTabletable;

drop table ##EmployeeTabletable;

