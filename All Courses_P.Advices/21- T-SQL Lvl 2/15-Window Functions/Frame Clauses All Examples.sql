
CREATE TABLE Sales (
    id INT PRIMARY KEY,
    salesperson VARCHAR(50),
    sale_amount INT,
    sale_date DATE
);

-- Insert sample data
INSERT INTO Sales (id, salesperson, sale_amount, sale_date) VALUES
(1, 'Alice',    100, '2023-01-01'),
(2, 'Bob',      200, '2023-01-02'),
(3, 'Alice',    150, '2023-01-03'),
(4, 'Charlie',  300, '2023-01-04'),
(5, 'Alice',    250, '2023-01-05'),
(6, 'Bob',      100, '2023-01-06'),
(7, 'Charlie',  400, '2023-01-07'),
(8, 'Alice',    350, '2023-01-08'),
(9, 'Bob',      500, '2023-01-09'),
(10, 'Charlie', 600, '2023-01-10');

use SQL_Challenges;
select * from Sales;


-- ✅ Step 2: Examples for Each Frame Clause
-- We’ll show examples using SUM(sale_amount) to demonstrate the effect of different ROWS BETWEEN clauses (you can run these one at a time).

--🧮 1. ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
--Running total up to current row (cumulative sum):

SELECT 
    id, 
    sale_amount, 
    SUM(sale_amount) OVER (ORDER BY sale_date 
        ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS running_total -- the term UNBOUNDED refers to a limitless boundary
		-- on one side of a frame in a window function.
		-- SQL Server implicitly adds the following "Default" frame clause: ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW

FROM Sales;


--📈 2. ROWS BETWEEN CURRENT ROW AND UNBOUNDED FOLLOWING
--Future-looking total from current row onward:

SELECT 
    id, 
    sale_amount, 
    SUM(sale_amount) OVER (ORDER BY sale_date  
        ROWS BETWEEN CURRENT ROW  AND  UNBOUNDED FOLLOWING) AS forward_total -- غير محدود من الأسفل
FROM Sales;


--🔄 3. ROWS BETWEEN 1 PRECEDING AND 1 FOLLOWING
--Centered 3-row window (sliding sum):


SELECT 
    id, 
    sale_amount, 
    SUM(sale_amount) OVER (ORDER BY sale_date 
        ROWS BETWEEN 1 PRECEDING AND 1 FOLLOWING) AS moving_sum -- 1 - 1 or 2 - 2 or ...
FROM Sales;

-- where id % 2 = 0 -- for ex.


--📉 4. ROWS BETWEEN 2 PRECEDING AND CURRENT ROW
--Sum of current and previous 2 rows:


SELECT 
    id, 
    sale_amount, 
    SUM(sale_amount) OVER (ORDER BY sale_date 
        ROWS BETWEEN 2 PRECEDING AND CURRENT ROW) AS trailing_3_sum  -- the sum of the current row and two rows preceding.
FROM Sales;


--🔚 5. ROWS BETWEEN CURRENT ROW AND 2 FOLLOWING
--Current and next 2 rows (future-looking window):

SELECT 
    id, 
    sale_amount, 
    SUM(sale_amount) OVER (ORDER BY sale_date 
        ROWS BETWEEN CURRENT ROW AND 2 FOLLOWING) AS lead_3_sum -- the sum of the current row and two rows FOLLOWING.
FROM Sales;


--🌍 6. ROWS BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING
--Sum over the entire dataset:

SELECT 
    id, 
    sale_amount, 
    SUM(sale_amount) OVER (ORDER BY sale_date 
        ROWS BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING) AS total_sum -- the of entire entity set.
FROM Sales;


--🔁 Bonus: Partitioned Version
--You can also partition the data (e.g. by salesperson) for each of these:

SELECT 
    salesperson, 
    id,
    sale_amount, sale_date,
    SUM(sale_amount) OVER (
        PARTITION BY salesperson 
        ORDER BY sale_date 
        ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
    ) AS salesperson_running_total
FROM Sales;


select salesperson ,SUM(sale_amount) AS salesperson_running_total  from Sales
-- where sale_date != '2023-01-01' in case of exceptions
group by salesperson



--✅ Summary Table of Frame Clauses:
Frame														Clause Use Case
UNBOUNDED PRECEDING AND CURRENT ROW							Running total (default)
CURRENT ROW AND UNBOUNDED FOLLOWING							Forward-looking total
1 PRECEDING AND 1 FOLLOWING									Moving/sliding window (3 rows)
2 PRECEDING AND CURRENT ROW	    Trailing 3-row				sum	
CURRENT ROW AND 2 FOLLOWING	    Leading 3-row				sum	
UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING	Full partition	total

