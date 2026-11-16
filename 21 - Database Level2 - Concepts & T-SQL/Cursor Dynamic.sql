
DECLARE Cursor_Dynamic CURSOR DYNAMIC FOR
SELECT StudentID, Name, Subject, Grade FROM Students;
OPEN Cursor_Dynamic;
DECLARE @StudentID INT, @Name NVARCHAR(50), @Subject NVARCHAR(50), @Grade INT;

FETCH NEXT FROM Cursor_Dynamic INTO @StudentID, @Name, @Subject, @Grade;

WHILE @@FETCH_STATUS = 0
BEGIN
    IF @Grade >= 90
        PRINT CAST(@StudentID AS NVARCHAR(50)) + ' ' + @Name + ' ' + @Subject +' '+CAST(@Grade AS NVARCHAR);

    FETCH NEXT FROM Cursor_Dynamic INTO @StudentID, @Name, @Subject, @Grade;
END

CLOSE Cursor_Dynamic;
DEALLOCATE Cursor_Dynamic;