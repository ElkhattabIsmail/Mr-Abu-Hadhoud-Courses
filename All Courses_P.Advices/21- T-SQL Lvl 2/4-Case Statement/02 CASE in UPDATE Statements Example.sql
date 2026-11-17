use C21_DB1;

select * from Employees2

UPDATE Employees2
SET Salary = 
    CASE 
        WHEN PerformanceRating > 90 THEN Salary * 1.15
        WHEN PerformanceRating BETWEEN 75 AND 90 THEN Salary * 1.10
		WHEN PerformanceRating BETWEEN 50 AND 74 THEN Salary * 1.05
        ELSE Salary
    END;


DECLARE @StartTime DATETIME2(7), @EndTime DATETIME2(7);

-- Capture the start time
SET @StartTime = SYSDATETIME();

-- Optimized query to update salaries
UPDATE Employees2
SET Salary = Salary * 
    CASE 
        WHEN PerformanceRating > 90 THEN 1.15
        WHEN PerformanceRating BETWEEN 75 AND 90 THEN 1.10
        WHEN PerformanceRating BETWEEN 50 AND 74 THEN 1.05
        ELSE Salary
    END
WHERE PerformanceRating IS NOT NULL;

-- Capture the end time
SET @EndTime = SYSDATETIME();

-- Output the execution time in milliseconds
SELECT DATEDIFF(MILLISECOND, @StartTime, @EndTime) AS ExecutionTimeMilliseconds;