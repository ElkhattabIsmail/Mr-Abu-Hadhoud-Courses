

Declare @a int, @b int;
set @a = 20;
set @b=10;

-- you can use >, < , =, != 
-- BEGIN = {    , END = }     LIKE C# BODY

IF @a < @b
	BEGIN
		PRINT 'Yes A is greater than B'
END

ELSE
BEGIN
    PRINT 'No A is Less than B'
END