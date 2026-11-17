
-- Exec SP Using Script.

--> Right Mouse on Sp And Click on execute sp.

use PointOfSales_DB;

DECLARE @PersonID INT;

EXEC SP_AddNewPerson 
    @FirstName = 'John', 
    @LastName = 'Doe', 
    @Email = 'john.doe@example.com',
	@Phone = '06325625246',
	@Address =  'Fbs 508'

	set @PersonID = @@ROWCOUNT;
SELECT @PersonID AS NewPersonID;

select * from People
delete  from People where PersonID = 4
