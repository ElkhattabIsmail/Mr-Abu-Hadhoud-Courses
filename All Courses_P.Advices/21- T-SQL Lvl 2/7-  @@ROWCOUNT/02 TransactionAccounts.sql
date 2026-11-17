
select * from Accounts;

BEGIN TRANSACTION;  -- Run All Statements as a single Block/Unit -> Runs All and commit changes or dont run any statement (Roll Back).

	BEGIN TRY
	-- حاول قدر الإمكان تقليل  الكود هنا
		-- Subtract $100 from Account 1
		UPDATE Accounts SET Balance = Balance - 100 WHERE AccountID = 1;

		-- Add $100 to Account 2
		UPDATE Accounts SET Balance = Balance + 100 WHERE AccountID = 2;

		-- Log the transaction
		INSERT INTO Transactions (FromAccount, ToAccount, Amount, Date) VALUES (1, 2, 100, GETDATE());


		-- if reach here thats mean no error found up.
		-- Commit the transaction
		COMMIT;

	END TRY
	BEGIN CATCH
		-- Rollback in case of error
		ROLLBACK; -- Returns in log files and Reset Data as it was.
		-- Error handling code here (e.g., logging the error)
	END CATCH;


	select * from Accounts;



	--### Example from comm

	Begin Try
        Begin Transaction;
		Declare @TransferAmount Int = 100;

		if((select Balance from Accounts where AccountID = 1) < @TransferAmount)
			Throw 50004 , 'Error: There is No enough balance, Transaction cancelled',1
			
		if(@TransferAmount < 0 )
		Throw 50004 , 'Error: Transaction Amount should be a positive amount!',1

		update Accounts set Balance = Balance - @TransferAmount where AccountID = 1
		 IF @@ROWCOUNT = 0
        THROW 50004, 'Error: The first update statement did not affect any rows.', 1;

		update Accounts set Balance = Balance + @TransferAmount where AccountID = 2
		 IF @@ROWCOUNT = 0
        THROW 50004, 'Error: The second update statement did not affect any rows.', 1;

		Insert Into Transactions (FromAccount,ToAccount,Amount,Date) Values(1,2,@TransferAmount,GetDate())
		 IF @@ROWCOUNT = 0
        THROW 50004, 'Error: The Insert statement did not affect any rows.', 1;

		Commit;
	ENd Try

	Begin Catch
		RollBack;
		select ERROR_MESSAGE() as ErrorMessage;
	End Catch