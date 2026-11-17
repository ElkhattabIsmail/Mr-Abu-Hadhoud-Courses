


-- select aS

select a = 5*4 , b = 5*5;

select b = MOnthlySalary from  Employees;

select ID,FirstName, MonthlySalary , a = MonthlySalary + (MonthlySalary * 0.05) from Employees;

select ID , 'Mr. ' + FirstName + ' ' + LastName as FullName from Employees;

select ID , FullName = 'Mr. ' + FirstName + ' ' + LastName  from Employees; -- same expression

select ID,FullName = 'Mr. ' + FirstName + ' ' + LastName ,MonthlySalary  , YearlySalary = MonthlySalary*12  from Employees;

select ID,DateOfBirth ,FullName= FirstName + ' ' + LastName, Age = DATEDIFF(Year , DateOfBirth ,getDate()) from Employees;


Select A= 5 * 4 , B= 6/2 



Select A= 5 * 4 , B= 6/2 
from employees



Select ID, FirstName,  A = MonthlySalary/2
from employees


Select ID, FirstName + ' ' + LastName as FullName From Employees;


Select ID, FullName = FirstName + ' ' + LastName  From Employees;


select ID, FirstName , MonthlySalary , YealySalary = MonthlySalary * 12  from employees;


select ID, FirstName , MonthlySalary , YealySalary =MonthlySalary* 12 , BonusAmount= MonthlySalary * BonusPerc  from employees;


select Today = getDate()


select ID, FullName = FirstName + ' ' + LastName, Age = DATEDIFF(Year , DateOfBirth ,getDate()) from Employees;
