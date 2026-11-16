select *from Students
delete from Students where Id > 2010;
Use StudentsDB;
GO

CREATE PROCEDURE SP_AddStudent
(
@Name NVARCHAR(25), 
@Age INT, 
@Grade INT,
@ImagePath nvarchar(250)
)
AS
BEGIN
BEGIN TRY
    INSERT INTO Students (Name, Age, Grade, ImagePath) VALUES (@Name, @Age, @Grade, @ImagePath);
    SELECT SCOPE_IDENTITY();
END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE();
END CATCH
END

GO

CREATE PROCEDURE SP_DeleteStudent
(
@ID INT
)
AS
BEGIN
    BEGIN TRY
        DELETE FROM Students WHERE Id = @ID;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END

GO

CREATE PROCEDURE SP_GetAllStudents
AS
BEGIN
    BEGIN TRY
        SELECT *FROM Students;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END

GO

CREATE PROCEDURE SP_GetAverageStudents
AS
BEGIN
BEGIN TRY
    SELECT CAST(ROUND(AVG(Grade), 2) AS DECIMAL(5, 2)) FROM Students;
END TRY
BEGIN CATCH
END CATCH
END
GO

CREATE PROCEDURE SP_GetPassedStudents
AS
BEGIN
    BEGIN TRY
        SELECT * FROM Students WHERE Grade > 50;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END
GO

CREATE PROCEDURE SP_GetStudentById
(
@Id INT
)
AS
BEGIN
    BEGIN TRY
        SELECT * FROM Students WHERE Id = @Id;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE();
    END CATCH
END
GO

CREATE PROCEDURE SP_UpdateStudent
(
@Id INT,
@Name NVARCHAR(25),
@Age INT,
@Grade decimal,
@ImagePath nvarchar(250)
)
AS
BEGIN
    BEGIN TRY
        UPDATE Students SET
        Name = @Name,
        Age = @Age,
        Grade = @Grade,
        ImagePath = @ImagePath
        WHERE Id = @Id;
    END TRY
    BEGIN CATCH
    SELECT ERROR_MESSAGE();
    END CATCH
END

GO

--drop procedure SP_AddStudent;
--drop procedure SP_DeleteStudent;
--drop procedure SP_GetAllStudents;
--drop procedure SP_GetAverageStudents;
--drop procedure SP_GetPassedStudents;
--drop procedure SP_GetStudentById;
--drop procedure SP_UpdateStudent;
