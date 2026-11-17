
SELECT 
    weight, 
    SUM(weight) OVER (ORDER BY weight DESC) AS running_total
FROM 
    practiceTable
ORDER BY 
    weight DESC;
	select * from practiceTable
	-- When we use group by weight, any fields that have the same values ​​are grouped and summed together.
 -- default when using order by :  ( rows between unbounding preceding and current row )
 --> that means aggregate from top 1 row to the last rows according the order by.
SELECT 
    weight, 
    SUM(weight) OVER (ORDER BY weight DESC rows between unbounded preceding and current row) AS running_total
FROM 
    practiceTable
ORDER BY 
    weight DESC;
