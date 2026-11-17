select * from 
Employees2

select 
Name,
Department,
Salary,
PerformanceRating,
dbo.CalculateBonus(PerformanceRating,Salary) as bonus
from
Employees2


update Employees2 set Bonus = dbo.CalculateBonus(PerformanceRating,Salary)