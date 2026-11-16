
-- Create Scaler function to get average of grade from students table

CREATE FUNCTION dbo.GetAverageGrade(@Subject INT)
RETURNS INT
AS
BEGIN
    DECLARE @AvgGrade INT;

    SELECT @AvgGrade = AVG(Grade) FROM Students WHERE Subject = @Subject;

    RETURN @AvgGrade;
END

-- Create Scaler function to get bonus by students table

CREATE FUNCTION dbo.BonusIncrement(@PerformanceRating INT, @Salary INT)
RETURNS INT
AS 
BEGIN
    DECLARE @Bonus INT ;
    
    IF @PerformanceRating >= 90
        SET @Bonus = @Salary * 1.15;
    ELSE IF @PerformanceRating >= 80
        SET @Bonus = @Salary * 1.10;
    ELSE
        SET @Bonus = @Salary * 1.5;

        RETURN @Bonus;
END

