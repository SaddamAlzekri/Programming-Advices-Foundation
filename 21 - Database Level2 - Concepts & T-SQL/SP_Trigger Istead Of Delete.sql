
CREATE TRIGGER SP_TriggerIsteadOfDelete ON Students
INSTEAD OF DELETE
AS 
BEGIN
     UPDATE Students SET ISActive = 0
     FROM Students S JOIN deleted D ON S.StudentID = D.StudentID;
END

-------------------------

DELETE FROM Students WHERE StudentID =  9;

SELECT *FROM Students;
