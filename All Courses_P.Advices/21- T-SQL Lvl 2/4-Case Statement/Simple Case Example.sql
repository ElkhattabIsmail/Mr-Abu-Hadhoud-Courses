
use C21_DB1;

--Simple Case: Compares an expression to a set of specific values.



-- >> Using Inside of the Query Not Outside 

SELECT 
    EmployeeID,
    CASE DepartmentID
        WHEN 1 THEN ( select Departments.Name from Departments where Departments.DepartmentID = 1)
        WHEN 2 THEN ( select Departments.Name from Departments where Departments.DepartmentID = 2)
        WHEN 3 THEN ( select Departments.Name from Departments where Departments.DepartmentID = 3)
        WHEN 4 THEN ( select Departments.Name from Departments where Departments.DepartmentID = 4)
        ELSE 'Other'
    END AS DepartmentName
FROM Employees;