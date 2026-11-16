
------ Dynamic SQL1

CREATE PROCEDURE GenerateDynamicSQL1
    @TableName NVARCHAR(150)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = 'SELECT *FROM ' + @TableName;
    EXEC(@SQL);
END

------ Dynamic SQL2

CREATE PROCEDURE GenerateDynamicSQL2
    @TableName NVARCHAR(50)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = 'SELECT *FROM ' + @TableName;
    EXEC(@SQL);
END

-----------------------------------------------------------

DECLARE @TableName2 NVARCHAR(50) = 'Employees2';
EXEC GenerateDynamicSQL1
    @TableName2;
     
--------
DECLARE @TableName3 NVARCHAR(50) = 'Employees2';
EXEC GenerateDynamicSQL2
    @TableName3;




