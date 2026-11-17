
use Shop_Database;

SELECT Customers.CustomerID, Customers.Name, Orders.amount
FROM Customers
JOIN Orders --or inner join is the same thing
ON Customers.CustomerID = Orders.CustomerID;


SELECT Customers.CustomerID, Customers.Name, Orders.amount
FROM Customers
LEFT JOIN Orders
ON Customers.CustomerID = Orders.CustomerID;


-- Right Outer Join
SELECT Customers.CustomerID, Customers.Name, Orders.amount
FROM Customers
right JOIN Orders
ON Customers.CustomerID = Orders.CustomerID;

--Full Join
SELECT        Customers.CustomerID, Customers.Name, Orders.Amount
FROM            Customers FULL OUTER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID


-- ???
SELECT Customers.CustomerID , Orders.Amount
FROM   Customers RIGHT OUTER JOIN
             Orders ON Orders.CustomerID = Customers.CustomerID