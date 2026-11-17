use c21_DB1;
--Sub Query
--select * from
--Sub Query
select * from 
(
  SELECT EmployeeId, Name, Sales
    FROM Employees6
    WHERE Department = 'Sales'
) SalesStaff ;



--CTE
WITH SalesStaff AS  -- MOre Readable.
(
    SELECT EmployeeId, Name, Sales
    FROM Employees6
    WHERE Department = 'Sales'
)
SELECT * FROM SalesStaff;

-- top salaries in each department.
with TopEmployees as
(
      Select *,
	  EmployeesSalaryRank=Row_Number()  
	  over (Partition by Employees2.Department order by Employees2.Salary)
	  from Employees2
)
select 
TopEmployees.Name,
TopEmployees.Salary,
TopEmployees.Department 
From TopEmployees  where TopEmployees.EmployeesSalaryRank = 1



declare @StartDate date = '2025-01-01';
declare @EndDate date = '2025-01-31';

with DateSeries as 
(
     select @StartDate as dateValue

	 union all

	 select DateAdd (day,1, dateValue) from DateSeries

	 where dateValue < @EndDate
)
select * from DateSeries;