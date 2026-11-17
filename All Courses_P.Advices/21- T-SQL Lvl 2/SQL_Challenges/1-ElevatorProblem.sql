
	SELECT * FROM Pets;


 select 
 name, 
 sum(RunningTotalWeight) over (order by name) as running_total_weight
 from Pets 
 order by name

-- Key Points:
--Window Function (OVER): Allows calculations over a set of rows related to the current row.

--Running Total: The sum accumulates as the query processes each row in the specified order.

--Ordering: The ORDER BY Name ensures the running total is calculated in alphabetical order of the Name column.

SELECT 
    Name, 
    RunningTotalWeight,
    SUM(RunningTotalWeight) OVER (ORDER BY Name) AS RunningTotal
FROM Pets
ORDER BY Name;

-- S { Using Lag Aggregate Func} that wrong solution cuz every RunningTotalWeight added to the prev value and this case this is not 
-- the consider thing.
SELECT 
    Name, 
    RunningTotalWeight,
    coalesce( LAG(RunningTotalWeight, 1) OVER (ORDER BY Name) , 0) + d.RunningTotalWeight AS PreviousWeight
FROM Pets d
ORDER BY Name;