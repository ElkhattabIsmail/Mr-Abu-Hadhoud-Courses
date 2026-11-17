--SELECT Makers.MakerName , CarsDetails.*
--FROM   CarsDetails INNER JOIN
--            Makers ON CarsDetails.MakeID = Makers.MakeID


-- into a makers table
-- we insert unique values from the main table into the side table
insert into Make_table
select distinct Make From CarsDet
order by Make asc;

SELECT Make_table.MakeName, CarsDet.*
FROM   CarsDet INNER JOIN
             Make_table ON CarsDet.MakeID = Make_table.MakeID


select * from CarsDet
select * from Make_table

-- now we update origine table car details after adding the colum (makeid) inside it
-- first we make column allows null 
-- Full The column 
--Like forloop
update CarsDet
set MakeID = (select MakeID from Make_table where Make_table.MakeName = CarsDet.Make);