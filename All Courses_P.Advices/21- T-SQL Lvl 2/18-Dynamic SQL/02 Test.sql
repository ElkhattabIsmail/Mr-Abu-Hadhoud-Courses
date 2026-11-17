USE [C21_DB1]
GO

DECLARE @RC int
DECLARE @TableName nvarchar(128)
DECLARE @TableName2 nvarchar(128)

-- TODO: Set parameter values here.
set @TableName = 'Students';
set @TableName2 = 'employees';

EXECUTE @RC = [dbo].[GenerateDynamicSQL1] 
   'Students'
EXECUTE @RC = [dbo].[GenerateDynamicSQL1] 
   @TableName

EXECUTE @RC = [dbo].[GenerateDynamicSQL2] 
   @TableName2

GO


