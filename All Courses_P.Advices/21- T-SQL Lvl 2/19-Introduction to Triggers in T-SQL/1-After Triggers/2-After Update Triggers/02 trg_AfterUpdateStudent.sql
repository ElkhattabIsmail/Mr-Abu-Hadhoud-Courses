
-- ON Students : Associates the trigger with the 'Students' table.
-- AFTER UPDATE: The trigger is fired after an update operation.

-- IF UPDATE(Grade): Checks if the 'Grade' column was part of the update.
-- The inserted and deleted tables: Special tables where inserted contains the
-- new values and deleted contains the old values of the updated rows.

CREATE or alter TRIGGER trg_AfterUpdateStudent ON Students
AFTER UPDATE
AS
BEGIN
   
 
  IF UPDATE(Grade) and (SELECT Grade FROM deleted) != (SELECT Grade FROM inserted) -- normal
    BEGIN
	-- any update on students table create a record with specific columns on StudentUpdateLog table
	-- capture the OldGrade after updating.
        INSERT INTO StudentUpdateLog(StudentID, OldGrade, NewGrade)
		SELECT i.StudentID, d.Grade AS OldGrade, i.Grade AS NewGrade
        FROM inserted i  
        INNER JOIN deleted d ON i.StudentID = d.StudentID;
		-- ✔️ inserted holds the updated (new) version of the data.
		-- ✔️ deleted holds the original data before the update.
		-- inserted hold the new values updated/inserted , in this case the inserted table holds  NewGrade
		-- deleted hold the Old values (Original) from Table. holds OldGrade
		-- the isserted and deleted are a temporary tables in memory. 
		-- scope of these tables ends when trigger scope ended.
		END


END;
