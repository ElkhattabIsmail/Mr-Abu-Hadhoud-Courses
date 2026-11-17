WITH SalesTotals AS 
(
    SELECT 
        EmployeeID, 
        SUM(SaleAmount) AS TotalSales
    FROM SalesRecords
    GROUP BY EmployeeID
)
,  -- seperate with comma is neccessary.
RankedSales AS (
    SELECT
        EmployeeID,
        TotalSales,
        dense_RANK() OVER (ORDER BY TotalSales DESC) AS SalesRank
    FROM SalesTotals
)
SELECT EmployeeID, TotalSales, SalesRank
FROM RankedSales;
