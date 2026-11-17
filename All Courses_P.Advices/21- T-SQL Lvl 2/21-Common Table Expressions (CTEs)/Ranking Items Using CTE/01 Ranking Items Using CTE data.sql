select * from SalesRecords


select 
EmployeeID,
sum(SaleAmount) as TotalSales 
from SalesRecords
group by EmployeeID