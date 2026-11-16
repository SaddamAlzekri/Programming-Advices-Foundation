
CREATE TRIGGER SP_TriggerInsteadOfUpdate ON StudentView
INSTEAD OF UPDATE
AS
BEGIN
    UPDATE  PersonalInfo SET 
    StudentID = i.StudentID,
    Name = i.Name, 
    Address = i.Address
    FROM PersonalInfo P JOIN inserted i ON P.StudentID = i.StudentID;
    
    UPDATE  AcademicInfo SET 
    StudentID = i.StudentID,
    Course = i.Course, 
    Grade = i.Grade
    FROM AcademicInfo A JOIN inserted i ON A.StudentID = i.StudentID;
END

-----------------------

UPDATE StudentView SET 
StudentID = 1,
Name = 'Saddam Alzekri',
Address = 'YEMEN - Taiz Al-turba Twon',
Course = 'Math',
Grade = 99
WHERE StudentID = 1;


SELECT *FROM AcademicInfo;
SELECT *FROM PersonalInfo;
