
SELECT *FROM
(
    SELECT EmployeeId, Name, Sales, Department FROM Employees6 WHERE Department = 'Sales'
) EmployeeTable;

-------------------------

with EmployeeTable AS
(
    SELECT EmployeeId, Name, Sales, Department FROM Employees6 WHERE Department = 'Sales'
)

SELECT *FROM EmployeeTable;

-------------------------

-- Common Table Expresion

WITH OneToTen AS
(
    SELECT 1 AS Number

UNION ALL
    SELECT Number + 1 FROM OneToTen WHERE Number < 10
)

SELECT *FROM OneToTen;


---------------

WITH EmployeeTreeHierechy AS 
(
    SELECT EmployeeID ,ManagerID ,Name ,CAST(Name AS NVARCHAR(MAX)) AS 'Hierechy', 0 AS Level FROM Employees7 WHERE ManagerID IS NULL
    UNION ALL
    SELECT E.EmployeeID , E.ManagerID ,E.Name , CAST(HIER.Hierechy + '->' + E.Name AS NVARCHAR(MAX)), HIER.Level + 1
    FROM Employees7 E INNER JOIN EmployeeTreeHierechy HIER ON E.ManagerID = HIER.EmployeeID
)

SELECT *FROM EmployeeTreeHierechy ORDER BY Hierechy;

------------------------------

DECLARE @StartDate DATE = '2026-01-01'; 
DECLARE @EndDate DATE = '2026-01-31';

WITH PrintDatesOfMonth AS
(
    SELECT @StartDate AS ValueDate
    UNION ALL
    SELECT DATEADD(DAY, 1, ValueDate) FROM PrintDatesOfMonth WHERE ValueDate < @EndDate
)
SELECT *FROM PrintDatesOfMonth;

---------------------------------
WITH DeplicateEmail AS
(
SELECT Email, Count(*) DeplicateEmail FROM Contacts group BY Email HAVING cOUNT(*) > 1
)
SELECT c.ContactID, c.Name, c.Email FROM Contacts c inner join DeplicateEmail d ON c.Email = d.Email;

---------------------------------



WITH NOTDAPPLE AS
(
SELECT Email from Contacts GROUP BY Email having count(*) < 2
)
SELECT c.ContactID, c.Name, c.Email FROM Contacts c INNER JOIN NOTDAPPLE d ON c.Email = d.Email;
---------------------------------
SELECT *FROM SalesRecords

WITH Toto as
(
select EmployeeID as EmployeesNumber, SUM(SaleAmount) as TotalSalary from  SalesRecords group by EmployeeID
),
Toto2 as
(
select EmployeesNumber, TotalSalary, DENSE_RANK() over(order by TotalSalary desc) as RunkNumber from  Toto
)
select EmployeesNumber, TotalSalary, RunkNumber from Toto2;


