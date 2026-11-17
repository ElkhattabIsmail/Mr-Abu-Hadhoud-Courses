use c21_DB1;

    DECLARE @SQL NVARCHAR(MAX);
 --   SET @SQL = N'SELECT * FROM Employees where EmployeeID=1 or 1=1';
    SET @SQL = N'SELECT * FROM Employees where EmployeeID = 1 or 2=2' ;
	
	print @SQL; 

	EXECUTE(@SQL);

	--Example using input validation:
DECLARE @input NVARCHAR(50) = 1;


IF ISNUMERIC(@input) = 1
BEGIN
    SELECT *
    FROM Students
    WHERE studentID = @input;
END
ELSE
BEGIN
    -- Handle invalid input
    SELECT 'Invalid input';
END
