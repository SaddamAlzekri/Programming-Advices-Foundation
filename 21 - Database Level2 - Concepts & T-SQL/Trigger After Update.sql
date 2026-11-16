CREATE Trigger trg_TransactionAfterUpdate on Students
AFTER UPDATE
AS 
BEGIN
   IF UPDATE(Grade)
   BEGIN
       INSERT INTO StudentUpdateLog(StudentID, OldGrade, NewGrade)
       select i.StudentID, d.Grade, i.Grade FROM inserted i join deleted d on i.StudentID = d.StudentID;
   END
END

-----------------

UPDATE Students 
    SET Name = 'Leo',
        Subject = 'Science',
        Grade = 88
        WHERE StudentID = 10;

SELECT *FROM StudentUpdateLog;

