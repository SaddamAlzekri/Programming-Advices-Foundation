
SELECT StudentID, Name, Subject, Grade, ROW_NUMBER() over (order by grade desc) as Row_Number
FROM Students order by Grade desc;

SELECT StudentID, Name, Subject, Grade, Rank() over (order by Grade desc) as Rank
from Students order by Grade desc;


SELECT StudentID, Name, Subject, Grade, DENSE_RANK() OVER (ORDER BY Grade DESC) AS Dense_Rank
from Students order by Grade DESC;

SELECT StudentID, Name, Subject, Grade, DENSE_RANK() over (Partition by Subject order by Grade desc) as  DENSE_RANKByPartition
from Students;

select StudentID, Name, Subject, Grade, avg(Grade) over (partition by Subject), sum(Grade) over (partition by Subject)
from Students;

select StudentId, Name, lag(Grade, 1) over (order by Grade) as PreviesGrade, Grade, 
lead(Grade, 1) over (order by Grade) as NextGrade from Students; 