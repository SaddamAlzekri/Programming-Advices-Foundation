
-- Call Scaler function

SELECT Name, Subject, dbo.GetAverageGrade(Subject) AS AverageGrade FROM Teachers;

-- Call Scaler function to get bonus by students table

SELECT *FROM Employees2;

select Name, Department, Salary as  BeforeBonus, dbo.BonusIncrement(PerformanceRating, Salary) as AfterBonus, PerformanceRating FROM Employees2;


