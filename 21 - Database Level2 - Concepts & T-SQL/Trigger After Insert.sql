

CREATE TRIGGER trg_TransactionAfterInsert on Students
After Insert
AS
BEGIN
    INSERT INTO StudentInsertLog (StudentID, Name, Subject, Grade) 
    SELECT StudentID, Name, Subject, Grade FROM inserted;
END

--------------------

INSERT INTO Students (StudentID ,Name, Subject, Grade) values (10,'Lebardo', 'Math', 99);

select *from StudentInsertLog; 