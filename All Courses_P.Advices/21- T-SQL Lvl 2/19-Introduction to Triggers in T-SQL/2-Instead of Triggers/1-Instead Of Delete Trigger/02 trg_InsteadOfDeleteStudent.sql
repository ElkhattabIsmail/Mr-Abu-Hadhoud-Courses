
--when a DELETE operation is performed on a table, +cmnt+
--a special temporary table named "deleted" is automatically created. This temporary table holds the copies 
--of the rows that are being deleted from the original table.
CREATE or alter TRIGGER trg_InsteadOfDeleteStudent ON Students  -- الإستغناء عن خدمات الحذف العادية وتبديلها بطريقتنا الخاصة
INSTEAD OF DELETE
AS
BEGIN
  -- Soft Delete Not a hard delete lkie delete statement do.
  -- Marking the record as inactive instead of deleting
    UPDATE Students
    SET IsActive = 0
    FROM Students S
	-- or WHERE S.StudentID IN (SELECT  D.StudentID FROM deleted D);
	WHERE S.StudentID IN (SELECT  D.StudentID FROM deleted D);
    --INNER JOIN deleted D ON S.StudentID = D.StudentID;  -- deleted table has the old data of student.

END;
