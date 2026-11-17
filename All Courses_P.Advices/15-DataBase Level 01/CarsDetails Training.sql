SELECT Makers.MakerName , CarsDetails.*
FROM   CarsDetails INNER JOIN
            Makers ON CarsDetails.MakeID = Makers.MakeID


-- into a makers table
-- we insert unique values from the main table into the side table
insert into Makers
select distinct Make From CarsDetails
order by Make asc;

select * from Makers

-- now we update origine table car details after adding the colum (makeid) inside it
-- first we make column allows null 
-- Full The column 
update CarsDetails
set MakeID = (select MakeID from Makers where Makers.MakerName = CarsDetails.Make);