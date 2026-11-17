

restore database HR_Database
from disk = 'c:\HR_Database.bak';

use HR_Database;

Select DepartmentID from Employees;

Select Distinct  DepartmentID from Employees;



Select FirstName from Employees;

Select Distinct  FirstName from Employees;


Select FirstName, DepartmentID from Employees;

EXEC sp_changedbowner 'sa';

Select * from Employees; -- all emp

Select Employees.* from Employees; --all

Select ID, FirstName, LastName,MonthlySalary From Employees;

Select ID, FirstName, DateOfBirth From Employees;

Select * from Departments;

Select * from Countries;

-- select statement
Select * from Employees
where Gendor='F';

Select * from Employees
where  MonthlySalary<=300;


Select * from Employees
where  MonthlySalary>500;

Select * from Employees
where Not MonthlySalary<=500;


Select * from Employees
where MonthlySalary<500 and Gendor='F';

select * from Employees
where CountryID=1;


select * from Employees
where Not CountryID=1;


select * from Employees
where  CountryID <> 1;


select * from Employees
where DepartmentID=1;

select * from Employees
where DepartmentID=1 and Gendor='M';


select * from Employees
where DepartmentID=1 Or DepartmentID=2;

select * from Employees
where DepartmentID=1 AND DepartmentID=2;


Select * from Employees
where ExitDate is Null;


Select * from Employees
where ExitDate  is Not Null;