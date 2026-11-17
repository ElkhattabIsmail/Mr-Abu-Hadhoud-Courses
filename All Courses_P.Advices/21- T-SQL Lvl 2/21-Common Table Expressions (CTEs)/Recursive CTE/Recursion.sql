

WITH Numbers AS (

	--Anchor Member (Initial State)
    SELECT 1 AS Number --  Start of Loop
    
	UNION ALL  
   
    SELECT Number + 1 FROM Numbers WHERE Number < 100 
	-- The statement terminated. The maximum recursion 100 has been exhausted before statement completion. 

)
SELECT * FROM Numbers;

WITH Factorial AS
(
    SELECT 4 AS Number, 1 AS Result -- Start with 1 as the initial result
    UNION ALL
    SELECT Number - 1, Result * (Number) -- Multiply the result by the current number
    FROM Factorial
    WHERE Number > 1 -- Stop when Number reaches 1
)
SELECT TOP 1 Result
FROM Factorial
ORDER BY Number;





WITH Factorial AS
(
    SELECT 4 AS Number, 1 AS Result
    UNION ALL
    SELECT Number - 1, Result * (Number)
    FROM Factorial
    WHERE Number > 1
)
select *from Factorial
SELECT TOP 1 Result
FROM Factorial
ORDER BY Number;