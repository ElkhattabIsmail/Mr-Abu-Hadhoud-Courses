
use C21_DB1;

-- @@ERROR DontAvoid the Crash in ur App
-- Not a Good Way to catch an error but in old sql that the available way to do it.

-- Attempt to insert an invalid record into a table
INSERT INTO Departments (DepartmentID, Name)
VALUES (1, 'Business'); -- Assume 'DepartmentID' is a primary key and '1' already exists

DECLARE @ErrorNumber INT = @@ERROR;
-- Check if the previous statement caused an error
IF @ErrorNumber <> 0 -- <> -> !=
BEGIN
    -- Handle the error
    PRINT 'An error occurred during the insert operation.';
    -- You can also capture the specific error number and store it or use it in logic
    PRINT 'The error number is: ' + CAST(@ErrorNumber AS VARCHAR);
END
