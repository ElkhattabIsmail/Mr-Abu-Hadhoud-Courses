use C21_DB1;

DECLARE @Result INT;
EXEC @Result = SP_CheckPersonExists @PersonID = 1; -- Replace 123 with the actual PersonID


IF @Result = 1
    PRINT 'Person exists.';
ELSE
    PRINT 'Person does not exist.';