
	use C21_DB1;

    declare @NewStockQty INT;

	set @NewStockQty=-5;

	-- Your Own Custom ERROR...

    -- Start a TRY block
    BEGIN TRY
        -- Check if NewStockQty is negative
        IF @NewStockQty < 0
            THROW 51000, 'Stock quantity cannot be negative.', 1; -- ( ErrorNumber > 50000 , Message ,  State of this Error )

        -- Proceed with updating stock (example code)
        UPDATE Products SET StockQuantity = @NewStockQty WHERE ProductID = 1;
    END TRY
    -- Start a CATCH block to handle the error
    BEGIN CATCH
        SELECT 
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_MESSAGE() AS ErrorMessage;
    END CATCH

