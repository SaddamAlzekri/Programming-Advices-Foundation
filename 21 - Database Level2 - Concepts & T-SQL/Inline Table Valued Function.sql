

CREATE FUNCTION dbo.GetStudentBySubject(@Subject NVARCHAR(50))
RETURNS TABLE
RETURN 
    (
         SELECT *FROM Students WHERE Subject = @Subject
    )

--- 
SELECT *from dbo.GetStudentBySubject('Math');

SELECT  StudentID, Name, Grade Subject from dbo.GetStudentBySubject('Math');

SELECT  AVG(Grade) from dbo.GetStudentBySubject('Math');

SELECT S.StudentID, S.Name, S.Subject, AVG(GSBS.Grade) AS AverageOFGrade
FROM Students S JOIN dbo.GetStudentBySubject('Math') GSBS on S.Subject = GSBS.Subject group by S.StudentID, S.Name, S.Subject;

