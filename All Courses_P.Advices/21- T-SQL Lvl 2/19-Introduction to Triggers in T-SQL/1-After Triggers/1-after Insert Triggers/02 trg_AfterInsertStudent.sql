
CREATE TRIGGER trg_AfterInsertStudent ON Students  -- affect on stuents table
AFTER INSERT

AS
BEGIN
    INSERT INTO StudentInsertLog(StudentID, Name, Subject, Grade)
    SELECT StudentID, Name, Subject, Grade FROM inserted;  -- temp table created whene insert new record.
END;
--An After Insert Trigger in T-SQL is executed automatically after a new record is inserted into a table.
--It's typically used for tasks that need to occur immediately following the insertion, such as logging, auditing, or updating 
--other related data.
