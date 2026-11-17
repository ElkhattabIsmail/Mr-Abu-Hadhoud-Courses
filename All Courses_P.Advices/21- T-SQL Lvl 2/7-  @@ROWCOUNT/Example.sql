
select * from Employees
use C21_DB1;

UPDATE Employees SET DepartmentID = 3 WHERE DepartmentID = 4;

SELECT @@ROWCOUNT AS RowsAffected;


UPDATE Employees SET DepartmentID = @@IDentity WHERE DepartmentID = 4;

SELECT @@ROWCOUNT AS RowsAffected;
