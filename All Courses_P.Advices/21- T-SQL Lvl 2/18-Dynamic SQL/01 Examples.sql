-- ex 01
CREATE PROCEDURE GenerateDynamicSQL1
    @TableName NVARCHAR(128)  -- parameter
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = 'SELECT * FROM ' + @TableName;  -- dynamic parameter
    EXECUTE(@SQL);   -- execute by EXECUTE command
END


Go
-- ex 02
CREATE PROCEDURE GenerateDynamicSQL2
    @TableName NVARCHAR(128)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = N'SELECT * FROM ' + QUOTENAME(@TableName);
	EXEC sp_executesql @SQL;  -- execute by EXECUTE sp_executesql

END