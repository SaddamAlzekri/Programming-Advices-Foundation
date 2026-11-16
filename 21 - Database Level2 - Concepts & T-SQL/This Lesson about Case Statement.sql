use LIBMS;
select *from Packages;

SELECT PackageName, PackagePrice,
CASE 
    WHEN PackagePrice < 30 THEN 'Cheap'
    WHEN PackagePrice BETWEEN 30 AND 60 THEN 'Moderate'
    WHEN PackagePrice > 60 THEN 'Expensive'
END AS Pricecategory
FROM Packages

--Another example--
DECLARE @Salary DECIMAL(10, 2);
SET @Salary = 3500;

SELECT CASE
    WHEN @Salary >= 2000 THEN 'The Salary is a few : ' + CAST (@Salary AS varchar)
    WHEN @Salary >= 4000 THEN 'The Salary is a Moderate : ' + CAST (@Salary AS varchar)
    WHEN @Salary > 5000 THEN 'The Salary is a highest : ' + CAST (@Salary AS varchar)
    ELSE 'Enter correct Salary.'
END AS LevelOfSalary;

--Another example--

SELECT 
CASE PackageID
    WHEN 1 THEN 'Basic'
    WHEN 2 THEN 'Premium'
    WHEN 3 THEN 'Golden'
END as PackeName FROM Packages

--Another example--

