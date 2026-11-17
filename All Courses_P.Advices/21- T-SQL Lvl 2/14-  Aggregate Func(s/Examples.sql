USE [C21_DB1]
Go

-- Aggregate Functions are Type of Window Functions

SELECT  Department,COUNT(Name) AS EmployeeCount
FROM Employees2
GROUP BY Department;

-- Description: Count the number of employees in each department
SELECT Department, COUNT(*) AS EmployeeCount
FROM Employees2
GROUP BY Department;

-- Description: Calculate the total salary for each department
SELECT Department, SUM(Salary) AS TotalSalary
FROM Employees2
GROUP BY Department;

-- Description: Calculate the average performance rating for each department
SELECT Department, AVG(PerformanceRating) AS AvgPerformanceRating
FROM Employees2
GROUP BY Department;

-- Description: Find the lowest salary in the company
SELECT MIN(Salary) AS LowestSalary
FROM Employees2;

-- Description: Find the lowest salary in the company for each Department.
SELECT Department , MIN(Salary) AS LowestSalary
FROM Employees2
GROUP BY Department;


-- Description: Find the highest salary in the company
SELECT Department , MAX(Salary) AS HighestSalary
FROM Employees2
GROUP BY Department;

-- Description: Find the highest salary in the company
SELECT MAX(Salary) AS HighestSalary
FROM Employees2;



-- Example 1
SELECT Name, Department, Salary AS HighestSalary
	from Employees2 as E
	where Salary = 
		(
			select
			Max(Salary) 
			FROM Employees2
			Where Department = E.Department
		)
	Order by Department ;


-- Example 2
SELECT emp2.Name, R1.Department, R1.[Max Salary] 
FROM
(
	SELECT Department, [Max Salary] = MAX(Salary) FROM Employees2 GROUP BY Department
) AS R1 

INNER JOIN Employees2 emp2 ON emp2.Salary = R1.[Max Salary] ORDER BY R1.Department;





SELECT e1.Name, e1.Department, T.MaxSalary
FROM 
(
    SELECT Department, MAX(Salary) AS MaxSalary
    FROM Employees2
    GROUP BY Department
) as T
INNER JOIN 
Employees2 e1 ON e1.Department = T.Department AND e1.Salary = T.MaxSalary
ORDER BY e1.Department;

-- استعلام بيعطي نتيجة أعلى راتب موظف في كل قسم
