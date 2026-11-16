
CREATE TRIGGER SP_TriggerInsteadOfInsert ON StudentView
INSTEAD OF INSERT
AS BEGIN

    INSERT INTO PersonalInfo(StudentID, Name, Address) 
    SELECT StudentID, Name, Address FROM inserted;

    INSERT INTO AcademicInfo(StudentID, Course, Grade) 
    SELECT StudentID, Course, Grade FROM inserted;
END

---------------------

INSERT INTO StudentView (StudentID, Name, Address, Course, Grade) values (3, 'Phodi', 'YEMEN Sanaa City', 'Science', 98);

SELECT *FROM PersonalInfo;
SELECT *FROM AcademicInfo;