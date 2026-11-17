
select Count(*) from CarModel
select * from CarModel
select * from CarsDet

insert into CarModel
select distinct Model from CarsDet

update CarsDet
set ModelID = (select ModelID from CarModel where CarModel.ModelName = CarsDet.Model);

SELECT CarModel.ModelName, CarsDet.*
FROM   CarsDet INNER JOIN
             CarModel ON CarsDet.ModelID = CarModel.ModelID

select ModelName From CarModel 
where CarModel.ModelID = 42;