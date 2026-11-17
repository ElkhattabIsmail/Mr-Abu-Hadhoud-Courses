use HR_Database;



SELECT Employees.ID, Employees.FirstName, Employees.LastName, Countries.Name AS Country_Name, Departments.Name AS Dept_Name
FROM   Countries INNER JOIN
       Employees ON Countries.ID = Employees.CountryID INNER JOIN
       Departments ON Employees.DepartmentID = Departments.ID
where Countries.Name not in ('USA','UK');