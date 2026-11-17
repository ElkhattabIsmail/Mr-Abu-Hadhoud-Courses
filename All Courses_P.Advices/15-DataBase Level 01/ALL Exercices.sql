
--#02
Select Count (*) AS NumberOfVehicles From VehicleDetails
where Year between '1950' and '2000';



 --#03
SELECT Makes.Make, COUNT(*) AS NumberOfVehicles
FROM   VehicleDetails 
INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE (VehicleDetails.Year BETWEEN 1954 AND 2000)
group by Makes.Make
order by NumberOfVehicles desc;



--#02
select Make ,count(*) as NumberOfVehicles from VehicleDetails
INNER JOIN  Makes ON VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950 and 2000
group by Make
order by NumberOfVehicles desc

select Make = (select Makes.Make from Makes 
Where VehicleDetails.MakeID = Makes.MakeID) , VehiclesNumber = Count(*) from VehicleDetails 
where VehicleDetails.Year between 1950 and 2000
group by VehicleDetails.MakeID
order by VehiclesNumber Desc


--04

SELECT top 3 Makes.Make, COUNT(*) AS NumberOfVehicles
FROM   VehicleDetails 
INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE (VehicleDetails.Year BETWEEN 1954 AND 2000)
group by Makes.Make
order by NumberOfVehicles desc;


-- without having
select * from
(
select Makes.Make ,Count(ID) as NumberOfVechicles 
from VehicleDetails join Makes 
on VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950  and 2000
group by Makes.Make
-- no "order by" here 
) 
 V_Count-- Name of the table
where V_Count.NumberOfVechicles > 12000
order by NumberOfVechicles desc


-- with having
SELECT Makes.Make , COUNT(*) AS NumberOfVehicles
FROM   VehicleDetails 
INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE (VehicleDetails.Year BETWEEN 1954 AND 2000)
group by Makes.Make
--HAVING NumberOfVehicles > 12000 ---errors name
HAVING COUNT(*) > 12000
order by NumberOfVehicles desc


--05

--all id
select TOTAL = (
SELECT TOP 1 ID FROM VehicleDetails
ORDER BY ID DESC
)


select Makes.Make , count(*) as NumberOfVehicles,

-- Query inside column <><><><
--TotalVehicles = (select count(*)from VehicleDetails) 

 Total = (select count(*) from VehicleDetails)
from VehicleDetails
INNER JOIN  Makes ON VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950 and 2000
group by Make
order by NumberOfVehicles desc

select Make ,count(*) as NumberOfVehicles , Total = (SELECT TOP 1 ID FROM VehicleDetails
ORDER BY ID DESC)
from VehicleDetails
INNER JOIN  Makes ON VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950 and 2000
group by Make
order by NumberOfVehicles desc


--06

select Make ,count(*) as NumberOfVehicles , Total = (SELECT TOP 1 ID FROM VehicleDetails
ORDER BY ID DESC) , (count(*))* 1.0 / (SELECT TOP 1 ID FROM VehicleDetails
ORDER BY ID DESC) as perc
from VehicleDetails
INNER JOIN  Makes ON VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950 and 2000
group by Make
order by NumberOfVehicles desc

------------------------------------------------------------------------------------------
--7 
-- Percentage

select * , CAST(NumberOfVehicles as float) / CAST(Total as float ) as perc
from
(
select Make ,count(*) as NumberOfVehicles , Total = (SELECT TOP 1 ID FROM VehicleDetails
ORDER BY ID DESC)
from VehicleDetails
INNER JOIN  Makes ON VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950 and 2000
group by Make
)R1
order by NumberOfVehicles desc

select * from FuelTypes
--08
SELECT Makes.Make, FuelTypes.FuelTypeName,
TotalVehicles = ( Count(*) )
FROM   VehicleDetails INNER JOIN
             FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID INNER JOIN
             Makes ON VehicleDetails.MakeID = Makes.MakeID
-- Mix between Make and fueltypename
GROUP BY Makes.Make, FuelTypes.FuelTypeName 
order by Makes.Make


--09
--All vehicles runs with gas

SELECT VehicleDetails.*,FullTypeName = FuelTypes.FuelTypeName
FROM   VehicleDetails INNER JOIN
             FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
WHERE (FuelTypes.FuelTypeName = N'GAS')
--N for invarchar

--10
--All vehicles runs with gas

SELECT distinct Makes.Make, FuelTypes.FuelTypeName
FROM   Makes INNER JOIN
             VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID INNER JOIN
             FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
WHERE (FuelTypes.FuelTypeName = N'GAS')
order by Make asc

--Solution ONE
select Makes.Make, R1.FuelTypeName
from
(
SELECT VehicleDetails.*, FuelTypes.FuelTypeName 
FROM VehicleDetails
inner join FuelTypes on VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
where FuelTypeName = N'GAS'
) R1
inner join Makes on R1.MakeID = Makes.MakeID
GROUP BY MAKES.Make, FuelTypeName
Order by Makes.Make


--Solution TWO
SELECT Makes.Make, FuelTypes.FuelTypeName 
FROM VehicleDetails
inner join FuelTypes on VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
inner join Makes on VehicleDetails.MakeID = Makes.MakeID
Group by Makes.Make, FuelTypes.FuelTypeName 
having FuelTypeName = N'GAS'
order by Make


--11
--Total vehicles runs with gas

select TotalMakesRunsONGas = count(*)
from
(
SELECT distinct Makes.Make, FuelTypes.FuelTypeName
FROM   Makes INNER JOIN
             VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID INNER JOIN
             FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
WHERE (FuelTypes.FuelTypeName = N'GAS')
)

--12
--Count Vehicles by make and order them by NumberOfVehicles from high to low.

SELECT distinct Makes.Make
FROM   Makes INNER JOIN
             VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID

select  * from VehicleDetails

SELECT  Makes.Make , totalvehicles = count(*)
FROM   Makes INNER JOIN
             VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID
group by make
order by totalvehicles desc


--Problem 13: 
--Get all Makes/Count Of Vehicles that manufactures more than 20K Vehicles
select  * from VehicleDetails

SELECT  Makes.Make , totalvehicles = count(*)
FROM   Makes INNER JOIN
             VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID
group by make
HAVING count(*) > 20000
order by totalvehicles desc

-- METHOD TWO
Select * from
(
SELECT distinct Makes.Make ,count(*) as NumberOfVehicles
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID
group by Makes.Make
)R1
Where R1.NumberOfVehicles>20000
order by NumberOfVehicles desc

--14
--Get all  Vehicles with make starts with 'B'
SELECT        Makes.Make 
FROM            Makes
where Makes.Make like 'B%';

--15 : Get all  Makes with make ends with 'W'
SELECT        Makes.Make from Makes
where Makes.Make like '%W';

 --Problem 16: Get all Makes that manufactures DriveTypeName = FWD
SELECT        distinct Makes.Make, DriveTypes.DriveTypeName
FROM            DriveTypes INNER JOIN
                         VehicleDetails ON DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID
Where DriveTypes.DriveTypeName ='FWD'



 --Problem 17: Get total Makes that Mantufactures DriveTypeName=FWD

 
--Get total Makes that Mantufactures DriveTypeName=FWD

select count(*) MakeWithFWD
from
(
	SELECT        distinct Makes.Make, DriveTypes.DriveTypeName
	FROM            DriveTypes INNER JOIN
							 VehicleDetails ON DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID INNER JOIN
							 Makes ON VehicleDetails.MakeID = Makes.MakeID
	Where DriveTypes.DriveTypeName ='FWD'
) R1


  --Problem 18: Get total vehicles per DriveTypeName Per Make and order them per make asc then per total Desc

  --Get total vehicles per DriveTypeName Per Make and order them per make asc then per total Desc

SELECT         Makes.Make, DriveTypes.DriveTypeName, Count(*) AS Total
FROM            DriveTypes INNER JOIN
                         VehicleDetails ON DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID

Group By Makes.Make, DriveTypes.DriveTypeName
-- ORDER TWO THINGS
Order By Make ASC, Total Desc

--  Problem 19: Get total vehicles per DriveTypeName Per Make then filter only results with total > 10,000
--Get total vehicles per DriveTypeName Per Make then filter only results with total > 10,000
--Solution:
--mysql
--Get total vehicles per DriveTypeName Per Make then filter only results with total > 10,000

SELECT        distinct Makes.Make, DriveTypes.DriveTypeName, Count(*) AS Total
FROM            DriveTypes INNER JOIN
                         VehicleDetails ON DriveTypes.DriveTypeID = VehicleDetails.DriveTypeID INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID

Group By Makes.Make, DriveTypes.DriveTypeName
Having Count(*) > 10000

Order By Make ASC, Total Desc


--  Problem 20: Get all Vehicles that number of doors is not specified
--Get all Vehicles that number of doors is not specified
--Solution:
--mysql
--Get all Vehicles that number of doors is not specified
select * from VehicleDetails
where NumDoors is NuLl

SELECT COUNT (*) AS NUMBER_OF_VEHICLES_WITH_NULL_DOORS
FROM
(
select * from VehicleDetails
where NumDoors is NuLl
)R1

select count(*) as TotalWithNoSpecifiedDoors from VehicleDetails
where NumDoors is Null


--  Problem 22: Get percentage of vehicles that has no doors specified
--Get percentage of vehicles that has no doors specified
--Solution:
--mysql
----Get percentage of vehicles that has no doors specified

select 
	(
	
	
		CAST(	(select count(*) as TotalWithNoSpecifiedDoors from VehicleDetails
		where NumDoors is Null) as float)


		/
	
	
		Cast( (select count(*) from VehicleDetails as TotalVehicles) as float)
	
	
	) as PercOfNoSpecifiedDoors

	----------
Select PercOfNoSpecifiedDoors =  (Select Count (*) from VehicleDetails where NumDoors is null) * 1.0 / (Select Count (*) from VehicleDetails )
----------------





--  Problem 23: Get MakeID , Make, SubModelName for all vehicles that have SubModelName 'Elite'
--Get MakeID , Make, SubModelName for all vehicles that have SubModelName 'Elite'
--Solution:
--mysql

-- Get MakeID , Make, SubModelName for all vehicles that have SubModelName 'Elite'

SELECT    distinct    VehicleDetails.MakeID, Makes.Make, SubModelName
FROM      VehicleDetails INNER JOIN
          SubModels ON VehicleDetails.SubModelID = SubModels.SubModelID INNER JOIN
          Makes ON VehicleDetails.MakeID = Makes.MakeID
	
where SubModelName='Elite'


-- Problem 24: Get all vehicles that have Engines > 3 Liters and have only 2 doors
--Get all vehicles that have Engines > 3 Liters and have only 2 doors
--Solution:
--mysql

-- Get all vehicles that have Engines > 3 Liters and have only 2 doors

	select * from VehicleDetails
	where Engine_Liter_Display > 3 and NumDoors = 2
	-- TOTAL
	ORDER BY ID DESC

--	  Problem 25: Get make and vehicles that the engine contains 'OHV' and have Cylinders = 4
--Get make and vehicles that the engine contains 'OHV' and have Cylinders = 4
--Solution:
--mysql
---- Get  make and vehicles that the engine contains 'OHV' and have Cylinders = 4
SELECT * FROM MAKES
SELECT * FROM VehicleDetails

-- ALL FROM THE TWO TABLES
SELECT         Makes.Make, *
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE        (VehicleDetails.Engine LIKE '%OHV%') AND (VehicleDetails.Engine_Cylinders = 4)


SELECT         Makes.Make, VehicleDetails.*
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE        (VehicleDetails.Engine LIKE '%OHV%') AND (VehicleDetails.Engine_Cylinders = 4)


-- Problem 26: Get all vehicles that their body is 'Sport Utility' and Year > 2020
--Get all vehicles that their body is 'Sport Utility' and Year > 2020
--Solution:
--mysql
-- Get all vehicles that their body is 'Sport Utility' and Year > 2020

SELECT      BodyName,  VehicleDetails.*
FROM            VehicleDetails INNER JOIN
                         Bodies ON VehicleDetails.BodyID = Bodies.BodyID
Where BodyName='Sport Utility' and Year > 2020



--Problem 27: Get all vehicles that their Body is 'Coupe' or 'Hatchback' or 'Sedan'
--Get all vehicles that their Body is 'Coupe' or 'Hatchback' or 'Sedan'
--Solution:
--mysql
-- Get all vehicles that their Body is 'Coupe' or 'Hatchback' or 'Sedan'

SELECT       bodyName, VehicleDetails.*
FROM            VehicleDetails INNER JOIN
                         Bodies ON VehicleDetails.BodyID = Bodies.BodyID
Where BodyName in ('Coupe','Hatchback','Sedan')


--Problem 28: Get all vehicles that their body is 'Coupe' or 'Hatchback' or 'Sedan' and manufactured in year 2008 or 2020 or 2021
--Get all vehicles that their body is 'Coupe' or 'Hatchback' or 'Sedan' and manufactured in year 2008 or 2020 or 2021
--Solution:
--mysql
-- Get all vehicles that their body is 'Coupe' or 'Hatchback' or 'Sedan' and manufactured in year  2008 or 2020 or 2021

SELECT       bodyName, VehicleDetails.*
FROM            VehicleDetails INNER JOIN
                         Bodies ON VehicleDetails.BodyID = Bodies.BodyID
Where BodyName in ('Coupe','Hatchback','Sedan') and Year in ( 2008, 2020, 2021)


--Problem 29: Return found=1 if there is any vehicle made in year 1950
--Return found=1 if there is any vehicle made in year 1950
--Solution:
--mysql
-- Return found=1 if there is any vehicle made in year 1950

select found=1 
where 
exists (
        select top 1 * from VehicleDetails where Year = 1950
      )

--SELECT
--    CASE
--        WHEN year=1950 THEN '1'
--         ELSE year
--    END AS alias_name
--FROM VehicleDetails;

select found = 'YES'
where exists
(
-- FIRST RESULT STOP SEARCHING
	select top 1 * from VehicleDetails 	where Year like 1950
)

select top 1  found = 1  from VehicleDetails where VehicleDetails.Year = 1950;



--Problem 30: Get all Vehicle_Display_Name, NumDoors and add extra column to describe number of doors by words, and if door is null display 'Not Set'


SELECT * FROM VehicleDetails
WHERE NumDoors = 1


select Vehicle_Display_Name,NumDoors, DoorDescription =
Case
  WHEN  NumDoors=1 THEN 'Single door'
  WHEN  NumDoors=2 THEN 'two doors'
  WHEN  NumDoors=3 THEN 'Three doors'
  WHEN  NumDoors=4 THEN 'FOUR doors'
    WHEN  NumDoors=5 THEN 'FIVE doors'
  WHEN  NumDoors=6 THEN 'SEX doors'

  WHEN  NumDoors=7 THEN 'SEVEN doors'
  WHEN  NumDoors=8 THEN 'EIGHT doors'

   ELSE 'not set'
END
from VehicleDetails
ORDER BY NumDoors DESC




select * from 
(
select Vehicle_Display_Name,NumDoors, DoorDescription =
Case
  WHEN  NumDoors=1 THEN 'Single doors'
  WHEN  NumDoors=2 THEN 'two doors'
  WHEN  NumDoors=3 THEN 'Three doors'
  WHEN  NumDoors=4 THEN 'four doors'
    WHEN  NumDoors=5 THEN 'fIVE doors'
  WHEN  NumDoors=6 THEN 'SEX doors'

  WHEN  NumDoors=7 THEN 'SEVEN doors'
  WHEN  NumDoors=8 THEN 'EIGHT doors'

   ELSE 'no seats'
END
from VehicleDetails


)r1
where r1.NumDoors = 8


--Problem 31: Get all Vehicle_Display_Name, year and add extra column to calculate the age of the car then sort the results by age desc.
--Get all Vehicle_Display_Name, year and add extra column to calcuate the age of the car then sort the results by age desc.
--Solution:
--mysql

-- Get all Vehicle_Display_Name, year and add extra column to calculate the age of the car then sort the results by age desc.


-- Note that YEAR in capital Letters is built in function in SQL Server that will give your the year of the given date :-) , 
-- and the year in small letters is the column name

Select VehicleDetails.Vehicle_Display_Name, Year, Age= YEAR(GetDate()) - VehicleDetails.year
from VehicleDetails
Order by Age

--  Problem 32: Get all Vehicle_Display_Name, year, Age for vehicles that their age between 15 and 25 years old
--Get all Vehicle_Display_Name, year, Age for vehicles that their age between 15 and 25 years old 
--Solution:


select * from
( 
	Select VehicleDetails.Vehicle_Display_Name, Year, Age= YEAR(GetDate()) - VehicleDetails.year
	from VehicleDetails
) R1

Where R1.Age between 15 and 25


-- Problem 33: Get Minimum Engine CC , Maximum Engine CC , and Average Engine CC of all Vehicles
--Get Minimum Engine CC , Maximum Engine CC , and Average Engine CC of all Vehicles
--Solution:
--mysql
-- Get Minimum Engine CC , Maximum Engine CC , and Average Engine CC of all Vehicles

select  Min(Engine_CC) as MinimimEngineCC,Max(Engine_CC) as MaximumEngineCC, AVG(Engine_CC)  as AverageEngineCC , count(Engine_CC) as TotalEngines
from VehicleDetails


--  Problem 34: Get all vehicles that have the minimum Engine_CC
--Get all vehicles that have the minimum Engine_CC
--Solution:
--mysql
-- Get all vehicles that have the minimum Engine_CC

Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select  Min(Engine_CC) as MinEngineCC  from VehicleDetails )

Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select  Max(Engine_CC) as MinEngineCC  from VehicleDetails )

Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select  avg(Engine_CC) as MinEngineCC  from VehicleDetails )

Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC > ( select  avg(Engine_CC) as MinEngineCC  from VehicleDetails )



--Problem 38: Get all unique Engin_CC and sort them Desc
--Get all unique Engin_CC and sort them Desc
--Solution:
--mysql


-- Get all unique  Engin_CC and sort them Desc

Select  distinct  Engine_CC from VehicleDetails
Order By Engine_CC

Select  distinct  Engine_CC from VehicleDetails
where Engine_CC is not null
Order By Engine_CC


select Engine_CC , C = count(*) from VehicleDetails
group by Engine_CC
having count(*) = 1

--Problem 39: Get the maximum 3 Engine CC
--Get the maximum 3 Engine CC
--Solution:
--mysql
---- Get the maximum 3 Engine CC

Select  distinct top 3 Engine_CC from VehicleDetails
	Order By Engine_CC Desc



	SELECT DISTINCT TOP 3 Engine_CC FROM VehicleDetails
WHERE  Engine_CC <= 
(SELECT MAX(Engine_CC) FROM VehicleDetails)
ORDER BY Engine_CC  DESC ;
--```
--طبعا اذكركم ان هذه الحلول فقط من اجل تذكر الافكار اللي خذناه فقط 
--```SQL

select distinct top 3 Engine_CC from VehicleDetails 
group by Engine_CC 
having Engine_CC <= max(Engine_CC)
order by  Engine_CC desc ;



Select  distinct top 3 Engine_CC from VehicleDetails
	Order By Engine_CC Desc

--Problem 40: Get all vehicles that has one of the Max 3 Engine CC
--Get all vehicles that has one of the Max 3 Engine CC
--S1
select Vehicle_Display_Name from VehicleDetails
where (Engine_CC in (Select  distinct top 3 Engine_CC from VehicleDetails
	Order By Engine_CC Desc))
order by Vehicle_Display_Name

--S2
select Vehicle_Display_Name from VehicleDetails
where Engine_CC in(
18848,18013,15900)
ORDER BY Vehicle_Display_Name

-- prof S

Select Vehicle_Display_Name from VehicleDetails
where Engine_CC in 
(
	
	Select  distinct top 3 Engine_CC from VehicleDetails
	Order By Engine_CC Desc
)
----ملاحظة هذه الطريقة هي نفسها تستخدمها اذا كان لديك جدول فيه طلاب ومعدلاتهم وطلب منك ان تسترجع العشرة الاوائل
----العشرة الاوائل ممكن يكونو 15 لانه ممكن ان يكون هنالك علامات مكررة
----فيجب عليك ان تسترجع اعلى عشرة علامات وبعدها تسترجع الطلاب الذين حصلو على واحده من هذه العلامات


--Problem 41: Get all Makes that manufactures one of the Max 3 Engine CC
--Get all Makes that manufactures one of the Max 3 Engine CC

SELECT distinct Makes.Make
FROM   VehicleDetails INNER JOIN
          Makes ON VehicleDetails.MakeID = Makes.MakeID
where Engine_CC in 
(
	
	Select  distinct top 3 Engine_CC from VehicleDetails
	Order By Engine_CC Desc
)
order by make


--Problem 42: Get a table of unique Engine_CC and calculate tax per Engine CC
--Get a table of unique Engine_CC and calculate tax per Engine CC
-- Get a table of unique Engine_CC and calculate tax per Engine CC as follows:
	-- 0 to 1000    Tax = 100
	-- 1001 to 2000 Tax = 200
	-- 2001 to 4000 Tax = 300
	-- 4001 to 6000 Tax = 400
	-- 6001 to 8000 Tax = 500
	-- Above 8000   Tax = 600
	-- Otherwise    Tax = 0

SELECT DISTINCT Engine_CC , EngineTax = 
Case
	when Engine_CC between 0 and 1000 then  '100'
	when Engine_CC between 1001 and 2000 then  '200'
	when Engine_CC between 2001 and 4000 then  '300'
	when Engine_CC between 4001 and 6000 then  '400'
	when Engine_CC between 6001 and 8000 then  '500'
	when Engine_CC > 8000 then  '600'
	else
		'0'
	end
from VehicleDetails
order by Engine_CC

--PROF S
select Engine_CC,

	CASE
		WHEN Engine_CC between 0 and 1000 THEN 100
		 WHEN Engine_CC between 1001 and 2000 THEN 200
		 WHEN Engine_CC between 2001 and 4000 THEN 300
		 WHEN Engine_CC between 4001 and 6000 THEN 400
		 WHEN Engine_CC between 6001 and 8000 THEN 500
		 WHEN Engine_CC > 8000 THEN 600	
		ELSE 0

	END as Tax

from 
(
	select distinct Engine_CC from VehicleDetails
	
) R1
order by Engine_CC
-----------------------------------------------
select distinct Engine_CC , Tax=(select 0.1) ,
TaxValue=(0.1*Engine_CC),
PriceWithTax=(( Engine_CC )*0.1 + Engine_CC)
from VehicleDetails
order by Engine_CC ASC 

select distinct Engine_CC , Tax= 0.1 ,
TaxValue = (0.1 * Engine_CC),
PriceWithTax=(( Engine_CC )*1.1 )
from VehicleDetails
order by Engine_CC ASC
-----------------------------------------------

-- Problem 43: Get Make and Total Number Of Doors Manufactured Per Make
--Get Make and Total Number Of Doors Manufactured Per Make
--Solution:
--mysql

-- Get Make and Total Number Of Doors Manufactured Per Make

SELECT        Makes.Make, SUM(VehicleDetails.NumDoors) AS TotalNumberOfDoors
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID

Group By Make
Order By TotalNumberOfDoors desc
------------------------------------------------------------------------------------------------------------------------------------------------------

select * from
(
	SELECT   distinct  Makes.Make , (select Sum(VehicleDetails.NumDoors) from VehicleDetails where VehicleDetails.MakeID = Makes.MakeID) as TotalDoors
	FROM            VehicleDetails INNER JOIN
	                         Makes ON VehicleDetails.MakeID = Makes.MakeID
)R1 
order by TotalDoors desc

--The COUNT() function returns the number of rows that matches a specified criterion.
--VS
--The SUM() function returns the total sum of a numeric column.
--Ziad Sraya
--Ziad Sraya6 months ago
--Reply
--Link
--i think the mechanism of  The COUNT() function that it Counting the rows with the table ID and return them as a Number


-- Problem 44: Get Total Number Of Doors Manufactured by 'Ford'
--Get Make and Total Number Of Doors Manufactured Per Make
--Solution:
-- Get Total Number Of Doors Manufactured by 'Ford'

SELECT        Makes.Make, Sum(VehicleDetails.NumDoors) AS TotalNumberOfDoors
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID

Group By Make
Having Make='Ford'
-------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------
select * from
(
	SELECT   distinct  Makes.Make , (select Sum(VehicleDetails.NumDoors) from VehicleDetails where VehicleDetails.MakeID = Makes.MakeID) as TotalDoors
	FROM            VehicleDetails INNER JOIN
	                         Makes ON VehicleDetails.MakeID = Makes.MakeID
)R1 
WHEre R1.Make = 'Ford'

--One Way
SELECT * FROM
(
		SELECT        Makes.Make, SUM(NumDoors) as TotalNumberOfDoorsPerMake
		FROM          Makes INNER JOIN VehicleDetails 
		ON			  Makes.MakeID = VehicleDetails.MakeID
		GROUP BY      Makes.Make
) R1
WHERE R1.Make= 'Ford';

--Second Way
SELECT        Makes.Make, SUM(NumDoors) as TotalNumberOfDoorsPerMake
		FROM          Makes INNER JOIN VehicleDetails 
		ON			  Makes.MakeID = VehicleDetails.MakeID
		GROUP BY      Makes.Make
		HAVING        Makes.Make = 'Ford';
--Third way 
SELECT top 1  Makes.Make, SUM(NumDoors) as TotalNumberOfDoorsPerMake
FROM          Makes INNER JOIN VehicleDetails 
ON			  Makes.MakeID = VehicleDetails.MakeID
GROUP BY      Makes.Make
ORDER BY	  TotalNumberOfDoorsPerMake DESC;

--Problem 45: Get Number of Models Per Make
--Get Number of Models Per Make
-- Get Number of Models Per Make

SELECT        Makes.Make, COUNT(*) AS NumberOfModels
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc


SELECT Makes.Make, NumberOfModels =  COUNT(*)
FROM   Makes INNER JOIN
          MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
Order By NumberOfModels desc


--  Problem 46: Get the highest 3 manufacturers that make the highest number of models
--Get the highest 3 manufacturers that make the highest number of models

select top 3 Makes.Make , count(*) as Totalmodels
FROM   Makes INNER JOIN
       MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
order by Totalmodels desc

select Make from Makes inner join
(
select distinct top 3 MakeID, Count(*) as Total from MakeModels
group by MakeID
order by Total desc
)R1 on Makes.MakeID = R1.MakeID;

-- Nice
Select Distinct Top 3 * From 
(
Select Makes.Make, Count(MakeModels.MakeID) as NumOfModels
From Makes Inner Join
MakeModels On Makes.MakeID = MakeModels.MakeID
Group By Makes.Make
)  R1
Order By NumOfModels Desc;


--Problem 47: Get the highest number of models manufactured
--Get the highest number of models manufactured

-- Get the highest number of models manufactured
-- prof
select  Max(NumberOfModels) as MaxNumberOfModels
from
(
		SELECT        Makes.Make, COUNT(*) AS NumberOfModels
		FROM            Makes INNER JOIN
								 MakeModels ON Makes.MakeID = MakeModels.MakeID
		GROUP BY Makes.Make
) R1

-- count the models from two tables + group the models by make + order numofmodels return the highest number + finaly we select top 1 of the list this is the highest number that we found
SELECT       top 1 Makes.Make,Count(*) as TopNumOFModels
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
						 Group by Makes.Make
						 Order By TopNumOfModels Desc

--I think this one faster 

select top 1 Makes.Make , count(*) as NumberOfModels from Makes
inner join MakeModels on MakeModels.MakeID = Makes.MakeID
group by Makes.Make
order by NumberOfModels desc


--Problem 48: Get the highest Manufacturers manufactured the highest number of models
--Get the highest Manufacturers manufactured the highest number of models ,
--remember that they could be more than one manufacturer have the same high number of models

-- Get the highest Manufacturers manufactured the highest number of models , 
-- remember that they could be more than one manufacturer have the same high number of models

-- Prof S
SELECT  Makes.Make, COUNT(*) AS NumberOfModels
FROM Makes INNER JOIN
	MakeModels
	ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
having COUNT(*) = (select Max(NumberOfModels) as MaxNumberOfModels
				from ( SELECT MakeID, COUNT(*) AS NumberOfModels FROM  MakeModels
				GROUP BY MakeID) R1
)


-- Another
SELECT    Makes.Make, count(*) as HighstManufactures 
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
group by Makes.Make
having count(*) in (select distinct top 1 count(*) from  Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
group by Makes.Make
order by count(*) desc
)


--Problem 49: Get the Lowest Manufacturers manufactured the lowest number of models
--Get the Lowest Manufacturers manufactured the lowest number of models ,
--remember that they could be more than one manufacturer have the same lowest number of models
-- Prof
SELECT  Makes.Make, COUNT(*) AS NumberOfModels
FROM Makes INNER JOIN
	MakeModels
	ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
having COUNT(*) = (select Min(NumberOfModels) as MinNumberOfModels
				from ( SELECT MakeID, COUNT(*) AS NumberOfModels FROM  MakeModels
				GROUP BY MakeID) R1
)

-- Nice
SELECT Makes.Make, count(*) as NumberOfMOdels
FROM   Makes INNER JOIN
       MakeModels ON Makes.MakeID = MakeModels.MakeID
group by Makes.Make
having count(*) = (
		select Min (R.NumOfModels) as LowestNumberOfModel from
        (      
		      select count(*) NumOfModels from
              MakeModels
              group by MakeID
        ) R
)

-- Problem 50: Get all Fuel Types , each time the result should be showed in random order
--Get all Fuel Types , each time the result should be showed in random order

select FuelTypes.FuelTypeName from FuelTypes
order by NewID()

SELECT  distinct FuelTypes.FuelTypeName , NewID() as RandomID
FROM    VehicleDetails INNER JOIN
            FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
group by FuelTypes.FuelTypeName
order by NewID()

select * from FuelTypes
order by  CRYPT_GEN_RANDOM(FuelTypeID);
