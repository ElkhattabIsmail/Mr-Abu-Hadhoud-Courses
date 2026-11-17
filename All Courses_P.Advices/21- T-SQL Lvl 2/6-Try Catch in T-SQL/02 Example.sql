
use C21_DB1;

BEGIN TRY
    -- Insert a record into the Employees table
    INSERT INTO Employees3 (EmployeeID, Name, Position) VALUES (1, 'John Doe', 'Sales Manager');
    
    -- Attempt to insert a duplicate record which will cause an error
    INSERT INTO Employees3 (EmployeeID, Name, Position) VALUES (1, 'Jane Smith', 'Marketing Manager');
END TRY

--Error Functions
--Within the CATCH block, you can use functions to get detailed error information:

--ERROR_NUMBER():		Returns the error number.
--ERROR_SEVERITY():	    Returns the severity.
--ERROR_STATE():		Returns the error state number.
--ERROR_PROCEDURE():    Returns the name of the stored procedure or trigger where the error occurred.
--ERROR_LINE():		    Returns the line number where the error occurred.
--ERROR_MESSAGE():      Returns the complete text of the error message.

BEGIN CATCH
    -- Handle the error
    PRINT 'An error occurred: ' + cast(ERROR_PROCEDURE() as varchar);
    -- Rollback the transaction if any
END CATCH

