
select * from People;
create Procedure SP_IsPersonExist
@PersonID int
as
begin
	if Exists (select Found = 1 from People where PersonID = @PersonID)
		return 1;
	else
		return 0;
end

declare @res int;
exec @res = SP_IsPersonExist @PersonID = 7;

if (@res = 1)
	print 'yes';
else
	print 'NO';