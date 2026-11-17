use C21_DB1;

-- Case Statement in T-SQL Doesn't need a break , cuz when condition is true its go out .
DECLARE @StartTime DATETIME2(7), @EndTime DATETIME2(7);

-- Capture the start time
SET @StartTime = SYSDATETIME();

SELECT
    PerformanceCategory,
    COUNT(*) AS NumberOfEmployees,
    AVG(Salary) AS AverageSalary
FROM
    (SELECT
        Name,
        Salary,
        CASE
            WHEN PerformanceRating >= 80 THEN 'High'
            WHEN PerformanceRating >= 60 THEN 'Medium'
            ELSE 'Low'
        END AS PerformanceCategory
    FROM Employees2) AS PerformanceTable
GROUP BY PerformanceCategory;
-- Capture the end time
SET @EndTime = SYSDATETIME();

-- Output the execution time in milliseconds
SELECT DATEDIFF(MILLISECOND, @StartTime, @EndTime) AS ExecutionTimeMilliseconds;




select  
	COUNT(*) AS NumberOfEmployees,
    AVG(Salary) AS AverageSalary,
	classificat
from
(
select Name,
        Salary, 	
					Case 
					     when PerformanceRating >= 80 Then  'High'
						 when PerformanceRating >= 60  Then 'Medium'
					Else 'Low'
End as classificat		
from Employees2
) as ClassTable
GROUP BY classificat;
