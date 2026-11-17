
--Error Handling with IF

DECLARE @ErrorValue INT;

-- Example SQL operation
INSERT INTO Employees (Name) VALUES ('John Doe');

-- Capture the error immediately
SET @ErrorValue = @@ERROR;    -- If Error = 0 -> NO errors occurred


-- Check and respond to the error  <>   ->  !=
IF @ErrorValue <> 0
BEGIN
    PRINT 'An error occurred with error number: ' + CAST(@ErrorValue AS VARCHAR);
    -- Additional error handling logic
END