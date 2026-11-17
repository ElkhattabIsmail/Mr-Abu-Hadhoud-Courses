
use Shop_Database;

select * from Customers;
select * from Orders;


SELECT Customers.CustomerID, Customers.Name, Orders.amount
FROM Customers
JOIN Orders --or inner join is the same thing
ON Customers.CustomerID = Orders.CustomerID;

