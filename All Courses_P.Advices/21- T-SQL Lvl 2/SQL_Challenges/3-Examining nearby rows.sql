

------------------------Examining nearby rows-----------------------------------------------------------------------
--Question:
--The cats would like to see the average of the weight of them, the cat just after them and the cat just before them.
--The first and last cats are content to have an average weight of consisting of 2 cats not 3.
--Return: name, weight, average_weight
--Order by: weight

-- Solution :
select
 name ,Weight,
 avg(weight) over (order by weight rows between 1 preceding AND 1 FOLLOWING )   as avg_Weight
 from cats ;