
--Simple Program--------
DECLARE @Age INT = 26;

IF @Age >= 18
BEGIN
    PRINT 'This is Adults.'
END
ELSE
BEGIN
    PRINT 'This is kids.'
END

--Simple Calculator--------

DECLARE @Num1 FLOAT;
DECLARE @Num2 FLOAT;
DECLARE @Result FLOAT;
DECLARE @Operator CHAR(1);

SET @Num1 = 10;
SET @Num2 = 7;
SET @Operator = '*';

IF @Operator = '+'
BEGIN
     SET @Result = @Num1 + @Num2
     PRINT 'Addition : ' + CAST(@Result AS VARCHAR);
END

ELSE IF @Operator = '-'
BEGIN
     SET @Result = @Num1 - @Num2
     PRINT 'Subtraction : ' + CAST(@Result AS VARCHAR);
END

ELSE IF @Operator = '*'
BEGIN
     SET @Result = @Num1 * @Num2
     PRINT 'Multiplication : ' + CAST(@Result AS VARCHAR);
END

ELSE IF @Operator = '/'
BEGIN
     SET @Result = @Num1 / @Num2
     PRINT 'Division : ' + CAST(@Result AS VARCHAR);
END

--Value Exchange Program--------

DECLARE @Number1 INT = 10;
DECLARE @Number2 INT = 25;
DECLARE @MaxValue INT;

IF @Number1 > @Number2
BEGIN
     SET @MaxValue = @Number1;
     print 'Max value : ' + CAST(@MAxValue AS VARCHAR); 
END
ELSE
BEGIN
     SELECT @MaxValue = @Number2;
     print 'Max value : ' + CAST(@MAxValue AS VARCHAR); 
END

-- Program about loan for KuramiBank--------

DECLARE @MyAge INT = 26;
DECLARE @MySalary DECIMAL(10, 2);

SET @MySalary = 5000;

IF @MyAge >= 18 AND @MySalary >= 5000
BEGIN 
     PRINT 'Eligible for get loan for KuramiBank';
END
ELSE
BEGIN
     PRINT 'Not Eligible for get loan for KuramiBank';
END

-- Program about loan for AltadamonBank--------

IF (@MyAge >= 30 AND @MySalary >= 5000) or @MySalary >= 7000
BEGIN 
     PRINT 'Eligible for get loan for AltadamonBank';
END
ELSE
BEGIN
     PRINT 'Not Eligible for get loan for AltadamonBank';
END
-- ProgramS for test Not Assign--------
DECLARE @IsActive bit = 1;

IF NOT (@IsActive = 1)
BEGIN
     PRINT 'Is Active';
END
ELSE 
BEGIN
     PRINT 'IS not Active';
END

-- Program about Error Handling--------
--This is program return The display error and print NUMBER OF THIS ERROR  
DECLARE @ErrorValue int;

INSERT INTo Employees (Name) values ('Saddam Al-zekri'); 

SELECT @ErrorValue = @@ERROR;

IF @ErrorValue <> 0
BEGIN
     PRINT 'Number of error is : ' + CAST(@ErrorValue AS VARCHAR);
END
--This lesson about Using if with exists--------

IF EXISTS (SELECT *FROM Employees WHERE Name = 'John Smith')
BEGIN
    PRINT 'Yes, John Smith is found';
END
ELSE
BEGIN
     PRINT 'No, John Smith is not found';
END