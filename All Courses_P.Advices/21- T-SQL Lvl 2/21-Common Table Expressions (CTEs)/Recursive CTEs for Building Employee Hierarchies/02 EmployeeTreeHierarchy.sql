

SELECT * FROM Employees7;

--The EmployeeTreeHierarchy table changes in every iteration of the recursive CTE.
--It starts with the anchor member (initial row) and grows as new rows are added in each recursive iteration. 
WITH EmployeeTreeHierarchy AS (
    -- Anchor member: 
	-- This selects the root of the hierarchy (CEO in this case) and starts at Level 0
    SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL
	-- 1. Anchor Member (Initial State)

    UNION ALL

    -- Recursive member: This part of the CTE builds the hierarchy and increments the Level by 1
    SELECT empTable.EmployeeID, empTable.ManagerID, empTable.Name, 
	CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
	ETH.Level + 1 AS Level
    FROM Employees7 empTable
    INNER JOIN EmployeeTreeHierarchy ETH ON empTable.ManagerID = ETH.EmployeeID
	--The recursive member joins the Employees7 table with the current state
	--of EmployeeTreeHierarchy to find employees whose ManagerID matches
	--the EmployeeID of the current rows.
)
-- This SELECT statement retrieves the hierarchical data with Level
SELECT * FROM EmployeeTreeHierarchy
ORDER BY Hierarchy;





 -- First : Anchor Record/Member (Initial State)  Boss (Ceo)
(SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)


-- simulation of what happen in 1 iteration :  employee with 2 and 3 and 9 added

 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
    INNER JOIN 
	(SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL) ETH ON empTable.ManagerID = ETH.EmployeeID










-- simulation of what happen in 2 iteration :  employee with 4 and 5 and 6 added

 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
 join
( 
 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
    INNER JOIN 
	(SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL) ETH ON empTable.ManagerID = ETH.EmployeeID
) as ETH ON empTable.ManagerID = ETH.EmployeeID












-- simulation of what happen in 3 iteration :  employee with Id 7 and 8 added
 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable

 join

(
 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
 join
( 
 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
    INNER JOIN 
	(SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL) ETH ON empTable.ManagerID = ETH.EmployeeID
) as ETH ON empTable.ManagerID = ETH.EmployeeID
) 
as ETH ON empTable.ManagerID = ETH.EmployeeID









-- Final :

select * from 
(

 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable

 join

(
 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
 join
( 
 (SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL)

	union all  -- add Ceo to the table

SELECT 
empTable.EmployeeID,
empTable.ManagerID,
empTable.Name, 
CAST(ETH.Hierarchy + '  <-  ' + empTable.Name AS VARCHAR(MAX)), 
ETH.Level + 1 AS Level
    FROM Employees7 empTable
    INNER JOIN 
	(SELECT EmployeeID, 
	ManagerID, Name, 
	CAST(Name AS VARCHAR(MAX)) AS 'Hierarchy', 0 AS Level
    FROM Employees7
    WHERE ManagerID IS NULL) ETH ON empTable.ManagerID = ETH.EmployeeID
) as ETH ON empTable.ManagerID = ETH.EmployeeID
) 
as ETH ON empTable.ManagerID = ETH.EmployeeID

) F order by F.Hierarchy