
CREATE TABLE StudentDeleteLog
(
LogID INT PRIMARY KEY IDENTITY(1, 1),
StudentID NVARCHAR(50),
Name nvarchar(50),
Grade int,
DeleteDateTime DATETIME DEFAULT GETDATE()
);

------
CREATE TRIGGER trg_TransActionAfterDelete ON Students
AFTER DELETE
AS
BEGIN
    INSERT INTO StudentDeleteLog(StudentID, Name, Grade)
    SELECT StudentID, Name, Grade from deleted;
END

-------

DELETE FROM Students WHERE StudentID = 10;

SELECT *FROM StudentDeleteLog;