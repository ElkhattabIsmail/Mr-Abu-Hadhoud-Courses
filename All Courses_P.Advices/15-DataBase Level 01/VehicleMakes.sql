
-- get data from file
Restore database VehicleMakes
from disk = 'C:\VehicleMakesDB.bak';


USE VehicleMakes
ALTER AUTHORIZATION ON DATABASE::VehicleMakes TO [sa]

--Solution for Diagram problem : 
--EXEC sp_changedbowner 'sa';

use VehicleMakes;

select * from Bodies;
select * from VehicleDetails;
select * from VehicleMasterDetails;
select * from DriveTypes;
select * from Makes;
select * from FuelTypes;
select * from MakeModels;
select * from SubModels;

