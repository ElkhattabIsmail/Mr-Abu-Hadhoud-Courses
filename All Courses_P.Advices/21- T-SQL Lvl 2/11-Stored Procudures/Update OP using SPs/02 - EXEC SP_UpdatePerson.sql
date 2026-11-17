
declare @RowsAffected int ;

EXEC SP_UpdatePerson 
    @PersonID = 12, -- The ID of the person you want to update
    @FirstName = 'Ismail',
    @LastName = 'Ahmed',
    @Email = 'Aib@example.com' ;

	set @RowsAffected = @@ROWCOUNT;

	if @RowsAffected > 0
	begin
		select * from People where PersonID = 1;
	end

	else
	begin
		print 'No Person With that ID '
	end


