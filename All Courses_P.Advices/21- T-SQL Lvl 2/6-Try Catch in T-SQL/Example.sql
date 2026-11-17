
 BEGIN TRY
        -- Intentional division by zero error
        SELECT 1 / 0;

    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,		-- Returns The Error Number
            ERROR_SEVERITY() AS ErrorSeverity,  -- Returns The Severity Level
            ERROR_STATE() AS ErrorState,		-- Returns Category Error
            ERROR_PROCEDURE() AS ErrorProcedure,-- Returns The function cuz the Error 
            ERROR_LINE() AS ErrorLine,		    -- Returns The Error at line
            ERROR_MESSAGE() AS ErrorMessage;	-- Returns The Error Massage
    END CATCH