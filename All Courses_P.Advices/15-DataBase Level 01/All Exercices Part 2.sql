Problem 49: Get the Lowest Manufacturers manufactured the lowest number of models
Get the Lowest Manufacturers manufactured the lowest number of models , remember that they could be more than one manufacturer have the same lowest number of models

select r1.*
from( select m.Make, count(*) numberofModels
	from makes m
	join MakeModels mk

on mk.MakeID = m.MakeID
group by m.Make) r1

where r1.numberofModels = (select min(r2.numberofModels)
							from(
							select m.Make, count(*) numberofModels
							from makes m
							join MakeModels mk

							on mk.MakeID = m.MakeID
							group by m.Make) r2);



use EmployeesDB
restore database EmployeesDB
from disk = 'C:\EmployeesDB.bak'

select * from Employees

--Problem 51: Get all employees that have manager along with Manager's name.
--Get all employees that have manager along with Manager's name.

select * from(
select Name,ManagerID,Salary,
case
     when ManagerID = 1 then 'Mohamed'
     when ManagerID = 2 then 'Ali'
	 when ManagerID = 4 then 'Fadi'
end as ManagerName
from Employees
)R1
where ManagerName is not null

select distinct Employees.name , Employees.ManagerID , Employees.Salary,R2.Name from Employees inner join
(select R1.ManagerID , Employees.Name from Employees inner join (select managerId from Employees where ManagerID is not null) R1 on EmployeeID = R1.ManagerID)R2
 on R2.ManagerID = Employees.ManagerID

select     Employees.Name , Employees.ManagerID,  Employees.Salary , Managers.Name from Employees 
inner join Employees as Managers on Employees.ManagerID = Managers.EmployeeID;


SELECT Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM    Employees INNER JOIN
            Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID



-- Get all employees that have manager along with Manager's name.
-- this will select all data from employees that are managed by someone along with their manager name, 
-- employees that have no manager will not be selected because we used inner join 
-- Note we used inner join on the same table with    diffrent alliace.

SELECT        Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM            Employees INNER JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID


-- Problem 52: Get all employees that have manager or does not have manager along with Manager's name, incase no manager name show null
--Get all employees that have manager or does not have manager along with Manager's name, incase no manager name show null


SELECT        Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM            Employees Left Outer JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID

-- Different Solution 
Select * , ManagerName = (select name from Employees As T2 Where T1.ManagerID = T2.EmployeeID) 
from Employees As T1

--Nice
select Name,ManagerID,Salary, (select Name from Employees where Employees.EmployeeID = R1.ManagerID)
as MangerName 
from ( select * from Employees ) R1

-- not allow null
SELECT   Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM    Employees LEFT OUTER JOIN
Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
WHERE   (Managers.Name IS not NULL)


  --Problem 53: Get all employees that have manager or does not have manager along with Manager's 
  --name, incase no manager name the same employee name as manager to himsel-- Get all employees that have manager or does not have manager along with Manager's name, incase no manager name the same employee name as manager to himself
-- this will select all data from employees regardless if they have manager or not, note here we used left outer join 
SELECT Employees.Name, Employees.ManagerID, Employees.Salary,  
  CASE
    WHEN Managers.Name is Null  THEN Employees.Name
    ELSE Managers.Name
END as ManagerName
FROM  Employees Left JOIN
      Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID

--Using isNull Method
SELECT Employees.EmployeeID, Employees.Name, Employees.ManagerID, Employees.Salary,
(ISNULL(Manager.Name, Employees.Name)) AS ManagerName
FROM      Employees left JOIN
          Employees AS Manager ON Employees.ManagerID = Manager.EmployeeID

------
select Employees.Name,
		Employees.ManagerID,
		Employees.Salary,
		Managers.Name
		from Employees left join Employees as Managers
		on Employees.ManagerID=Managers.EmployeeID or
		(Managers.ManagerID is null and Employees.Name=Managers.Name)


Select Name, ManagerID, Salary, ManagerName = 
case
	When ManagerID is null  then Employees.Name
	else 'Unknown'
End
from Employees
Where ManagerID is null
union
Select Employees.Name, Employees.ManagerID, Employees.Salary,
		Managers.Name as ManagerName from
		Employees Inner join Employees as Managers on
		Employees.ManagerID = Managers.EmployeeID
Order by ManagerID 


  --Problem 54: Get All Employees managed by 'Mohammed'

  -- Prof Solution
SELECT  Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM            Employees INNER JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
where Managers.Name='Mohammed'


  select * from (SELECT Employees.Name, Employees.ManagerID, Employees.Salary,  
  CASE
    WHEN Managers.Name is Null  THEN Employees.Name
    ELSE Managers.Name
END as ManagerName
FROM  Employees Left JOIN
      Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
)T1
where T1.ManagerName = 'Mohammed' and ManagerID is not null