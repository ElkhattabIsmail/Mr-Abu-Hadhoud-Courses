--Question:

--The cats must be ordered first by breed and second by name.
--They are about to enter an elevator one by one. When all the cats of the same breed have entered they leave.

--We would like to know what the running total weight of the cats is.

--Return: name, breed, running total weight
--Order by: breed, name


-- Step 3: Verify the data
use SQL_Challenges;
SELECT * FROM Cats;

-- Solution:
select 
name, breed ,Weight,
sum(weight) over (partition by breed order by name ) as running_total_weight
 from cats ;

 -- default when using order by :  ( rows between unbounding preceding and current row )
 --> that means aggregate from top 1 row to the last rows according the order by.

 select 
name, breed ,Weight,
sum(weight) over (partition by breed order by name rows between 1 preceding and current row) as running_total_weight
 from cats Order by weight;


 
select
 name ,Weight,
cast ( avg(weight) over (order by weight rows between 1 preceding AND 1 FOLLOWING ) as decimal(4,2) ) as avgWeight
 from cats ;



