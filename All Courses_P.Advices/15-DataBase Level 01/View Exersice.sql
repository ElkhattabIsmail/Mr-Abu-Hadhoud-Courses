select * from VehicleDetails

select * from VehicleMasterDetails 
where DriveTypeName is null;

select count(*) from VehicleDetailsView 
select count(*) from VehicleMasterDetails 


SELECT dbo.VehicleDetails.ID, dbo.VehicleDetails.MakeID, dbo.Makes.Make, dbo.VehicleDetails.ModelID, dbo.MakeModels.ModelName, dbo.VehicleDetails.SubModelID, dbo.SubModels.SubModelName, dbo.VehicleDetails.BodyID, dbo.Bodies.BodyName, 
             dbo.VehicleDetails.Vehicle_Display_Name, dbo.VehicleDetails.Year, dbo.VehicleDetails.DriveTypeID, dbo.DriveTypes.DriveTypeName, dbo.VehicleDetails.Engine, dbo.VehicleDetails.Engine_CC, dbo.VehicleDetails.Engine_Cylinders, dbo.VehicleDetails.Engine_Liter_Display, 
             dbo.VehicleDetails.FuelTypeID, dbo.FuelTypes.FuelTypeName, dbo.VehicleDetails.NumDoors
FROM   dbo.FuelTypes INNER JOIN
             dbo.Bodies INNER JOIN
             dbo.Makes INNER JOIN
             dbo.MakeModels ON dbo.Makes.MakeID = dbo.MakeModels.MakeID INNER JOIN
             dbo.SubModels ON dbo.MakeModels.ModelID = dbo.SubModels.ModelID INNER JOIN
             dbo.VehicleDetails ON dbo.Makes.MakeID = dbo.VehicleDetails.MakeID AND dbo.MakeModels.ModelID = dbo.VehicleDetails.ModelID AND dbo.SubModels.SubModelID = dbo.VehicleDetails.SubModelID ON dbo.Bodies.BodyID = dbo.VehicleDetails.BodyID INNER JOIN
             dbo.DriveTypes ON dbo.VehicleDetails.DriveTypeID = dbo.DriveTypes.DriveTypeID ON dbo.FuelTypes.FuelTypeID = dbo.VehicleDetails.FuelTypeID

CREATE VIEW VehicleDetailsView AS (
SELECT 
	VehicleDetails.ID,
	Makes.Make,
	MakeModels.ModelName,
	SubModels.SubModelName,
	Bodies.BodyName,
	VehicleDetails.Vehicle_Display_Name,
	VehicleDetails.Year,
	DriveTypes.DriveTypeName,
	VehicleDetails.Engine,
	VehicleDetails.Engine_CC,
	VehicleDetails.Engine_Cylinders,
	VehicleDetails.Engine_Liter_Display,
	FuelTypes.FuelTypeName,
	VehicleDetails.NumDoors
FROM VehicleDetails
LEFT JOIN SubModels ON SubModels.SubModelID = VehicleDetails.SubModelID
LEFT JOIN MakeModels ON MakeModels.ModelID = SubModels.ModelID
LEFT JOIN Makes ON Makes.MakeID = MakeModels.MakeID
LEFT JOIN Bodies ON Bodies.BodyID = VehicleDetails.BodyID
LEFT JOIN DriveTypes ON DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID
LEFT JOIN FuelTypes ON FuelTypes.FuelTypeID = VehicleDetails.FuelTypeID
);  


select count(*) from MasterDetailsv 

select * from MasterDetailsv

create view MasterDetailsv   as
select   v.ID, v.MakeID, ma.Make,v.ModelID, m.ModelName, v.SubModelID, s.SubModelName, v.BodyID,b.BodyName,v.Vehicle_Display_Name,
v.Year, v.DriveTypeID,d.DriveTypeName,v.Engine, v.Engine_CC, v.Engine_Cylinders, v.Engine_Liter_Display, v.FuelTypeID, f.FuelTypeName,v.NumDoors

from VehicleDetails v
join SubModels s
on s.SubModelID = v.SubModelID

join MakeModels m
on s.ModelID = m.ModelID

join Makes ma
on m.MakeID = ma.MakeID

left join Bodies b
on v.BodyID = b.BodyID

left join DriveTypes d
on d.DriveTypeID = v.DriveTypeID

left join FuelTypes f
on f.FuelTypeID = v.FuelTypeID;