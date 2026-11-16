
DECLARE Cursor_Static CURSOR STATIC FOR
SELECT StudentID, Name, Subject, Grade FROM Students;
OPEN Cursor_Static

DECLARE @StudentID INT, @Name NVARCHAR(50), @Subject NVARCHAR(50), @Grade INT;
FETCH NEXT FROM Cursor_Static INTO @StudentID, @Name, @Subject, @Grade;

WHILE @@FETCH_STATUS = 0
BEGIN
    IF @Grade >= 90
        PRINT CAST(@StudentID AS NVARCHAR ) +' '+ @Name +' '+ @Subject +' '+ CAST(@Grade AS NVARCHAR);
    
    FETCH NEXT FROM Cursor_Static INTO @StudentID, @Name, @Subject, @Grade;
END
CLOSE Cursor_Static;
DEALLOCATE Cursor_Static;