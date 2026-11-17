
declare @Number int;
declare @MultiplicationNumber int;
declare @Result int;

set @Number = 1;

set @Result = 0;


WHILE @Number <= 10
BEGIN
	set @MultiplicationNumber = 1;
    WHILE @MultiplicationNumber <= 10
	BEGIN
		set @Result = @Number * @MultiplicationNumber;
		print Cast(@Number as  varchar) + ' * ' + Cast(@MultiplicationNumber as  varchar) + ' = ' + Cast(@Result as  varchar);
		set @MultiplicationNumber = @MultiplicationNumber + 1;
	END	
	set @Number = @Number + 1;
END